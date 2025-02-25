using GranDnDDM.Enums;
using GranDnDDM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Tools
{
    public class MapEditor : UserControl
    {
        public int TileSize { get; set; } = 32;
        public int Columns { get; set; } = 20;
        public int Rows { get; set; } = 15;

        // Lista de capas y la capa activa
        private List<MapLayer> layers = new List<MapLayer>();
        public int ActiveLayerIndex { get; set; } = 0;
      
        // Propiedades para la herramienta
        public ToolMode CurrentToolMode { get; set; } = ToolMode.None;
        // La imagen que se usará para dibujar (debe ser asignada desde el formulario)
        public Image DrawingImage { get; set; }

        // Selección y manipulación
        private MapItem selectedItem = null;
        private bool isDragging = false;
        private bool isResizing = false;
        private ResizeHandle currentHandle = ResizeHandle.None;

        private Point dragStartPos;
        private Rectangle originalBounds; // Guardamos el tamaño/posición original al iniciar resize/move

        // Tamaño del "handler" de las esquinas
        private const int HANDLE_SIZE = 8;

        public MapEditor()
        {
            DoubleBuffered = true;
            AllowDrop = true;
            DragEnter += MapEditor_DragEnter;
            DragDrop += MapEditor_DragDrop;

            // Manejo de mouse para seleccionar/mover/redimensionar
            MouseDown += MapEditor_MouseDown;
            MouseMove += MapEditor_MouseMove;
            MouseUp += MapEditor_MouseUp;
            // Creamos la capa base inicial (grid inicial)
            layers.Add(new MapLayer("Capa Base"));
        }

        // ============ DRAG & DROP BÁSICO ============

        private void MapEditor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("DraggedMapItem") || e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MapEditor_DragDrop(object sender, DragEventArgs e)
        {
            Point dropPoint = this.PointToClient(new Point(e.X, e.Y));
            // Obtenemos la capa activa
            MapLayer activeLayer = layers[ActiveLayerIndex];
            // Si viene con categoría
            var draggedItem = e.Data.GetData("DraggedMapItem") as DraggedMapItem;
            if (e.Data.GetDataPresent("DraggedMapItem"))
            {
              
                if (draggedItem != null)
                {
                    var newItem = new MapItem
                    {
                        Image = (Image)draggedItem.Image.Clone(),
                        Category = draggedItem.Category,
                        Location = dropPoint,
                        Width = draggedItem.Image.Width,
                        Height = draggedItem.Image.Height
                    };

                    // Ajustamos el tamaño inicial al de la imagen
                  //  newItem.Width = newItem.Image.Width;
                  //  newItem.Height = newItem.Image.Height;

                    if (draggedItem.Category== "imagenes generales")
                    {
                        // freeItems.Add(newItem);
                        activeLayer.FreeItems.Add(newItem);
                    }
                    else
                    {
                        /*int col = dropPoint.X / TileSize;
                        int row = dropPoint.Y / TileSize;
                        newItem.GridLocation = new Point(col, row);
                        gridTiles[newItem.GridLocation.Value] = newItem;*/
                        int col = dropPoint.X / TileSize;
                        int row = dropPoint.Y / TileSize;
                        newItem.GridLocation = new Point(col, row);
                        activeLayer.GridItems[newItem.GridLocation.Value] = newItem;
                    }
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                // Caso sin categoría
                var bmp = e.Data.GetData(DataFormats.Bitmap) as Image;
                if (bmp != null && draggedItem != null)
                {
                    var newItem = new MapItem
                    {
                        Image = (Image)draggedItem.Image.Clone(),
                        Category = draggedItem.Category,
                        Location = dropPoint,
                        Width = draggedItem.Image.Width,
                        Height = draggedItem.Image.Height
                    };
                    if (draggedItem.Category == "imagenes generales")
                    {
                        // freeItems.Add(newItem);
                        activeLayer.FreeItems.Add(newItem);
                    }
                    else
                    {
                        /*int col = dropPoint.X / TileSize;
                        int row = dropPoint.Y / TileSize;
                        newItem.GridLocation = new Point(col, row);
                        gridTiles[newItem.GridLocation.Value] = newItem;*/
                        int col = dropPoint.X / TileSize;
                        int row = dropPoint.Y / TileSize;
                        newItem.GridLocation = new Point(col, row);
                        activeLayer.GridItems[newItem.GridLocation.Value] = newItem;
                    }
                }
            }
            this.Invalidate();
        }

        // ============ SELECCIÓN, MOVER Y REDIMENSIONAR ============

        private void MapEditor_MouseDown(object sender, MouseEventArgs e)
        {

            // Si la herramienta activa es Dibujar
            if (CurrentToolMode == ToolMode.Draw)
            {
                if (DrawingImage == null)
                {
                    MessageBox.Show("No se ha seleccionado ninguna imagen para dibujar.");
                    return;
                }

                // Se calcula la celda en la que se hizo click
                int col = e.X / TileSize;
                int row = e.Y / TileSize;
                Point gridPoint = new Point(col, row);

                // Obtenemos la capa activa
                MapLayer activeLayer = layers[ActiveLayerIndex];

                // Creamos un nuevo ítem usando la imagen seleccionada
                MapItem newItem = new MapItem
                {
                    Image = (Image)DrawingImage.Clone(),
                    Category = "tile", // O la categoría que manejes para tiles
                    GridLocation = gridPoint,
                    Location = new Point(gridPoint.X * TileSize, gridPoint.Y * TileSize),
                    Width = TileSize,
                    Height = TileSize
                };

                activeLayer.GridItems[gridPoint] = newItem;
                Invalidate();
                return;
            }
            else if (CurrentToolMode == ToolMode.Erase)
            {
                int col = e.X / TileSize;
                int row = e.Y / TileSize;
                Point gridPoint = new Point(col, row);

                MapLayer activeLayer = layers[ActiveLayerIndex];
                if (activeLayer.GridItems.ContainsKey(gridPoint))
                {
                    activeLayer.GridItems.Remove(gridPoint);
                    Invalidate();
                }
                return;
            }
            else
            {
                // Obtenemos la capa activa
                MapLayer activeLayer = layers[ActiveLayerIndex];
                // Primero, chequeamos si dimos clic en un handle de redimensionado del ítem seleccionado
                if (selectedItem != null && selectedItem.GridLocation == null)
                {
                    // Solo redimensionamos los items "free"
                    currentHandle = GetHandleAtPoint(selectedItem, e.Location);
                    if (currentHandle != ResizeHandle.None)
                    {
                        isResizing = true;
                        dragStartPos = e.Location;
                        originalBounds = selectedItem.GetBounds();
                        return;
                    }
                }

                // Si no se dio clic en un handle, revisamos si se clicó sobre algún ítem "free"
                MapItem clickedItem = null;
                for (int i = activeLayer.FreeItems.Count - 1; i >= 0; i--)
                {
                    var item = activeLayer.FreeItems[i];
                    if (item.GetBounds().Contains(e.Location))
                    {
                        clickedItem = item;
                        break;
                    }
                }

                // Seleccionamos el ítem clicado (o ninguno si se clicó en un área vacía)
                selectedItem = clickedItem;

                // Si clicamos en un ítem, iniciamos arrastre para moverlo
                if (selectedItem != null)
                {
                    isDragging = true;
                    dragStartPos = e.Location;
                    originalBounds = selectedItem.GetBounds();
                }

            }

        }

        private void MapEditor_MouseMove(object sender, MouseEventArgs e)
        {
            // Cambio de cursor si pasamos sobre un handle de redimensionado
            if (!isDragging && !isResizing && selectedItem != null && selectedItem.GridLocation == null)
            {
                var handle = GetHandleAtPoint(selectedItem, e.Location);
                switch (handle)
                {
                    case ResizeHandle.TopLeft:
                    case ResizeHandle.BottomRight:
                        this.Cursor = Cursors.SizeNWSE;
                        break;
                    case ResizeHandle.TopRight:
                    case ResizeHandle.BottomLeft:
                        this.Cursor = Cursors.SizeNESW;
                        break;
                    case ResizeHandle.TopCenter:
                    case ResizeHandle.BottomCenter:
                        this.Cursor = Cursors.SizeNS;
                        break;
                    case ResizeHandle.MiddleLeft:
                    case ResizeHandle.MiddleRight:
                        this.Cursor = Cursors.SizeWE;
                        break;
                    default:
                        this.Cursor = Cursors.Default;
                        break;
                }
            }
            else if (isResizing && selectedItem != null)
            {
                // Redimensionar según el handle
                Rectangle newBounds = originalBounds;
                int dx = e.X - dragStartPos.X;
                int dy = e.Y - dragStartPos.Y;

                switch (currentHandle)
                {
                    case ResizeHandle.TopLeft:
                        newBounds.X += dx;
                        newBounds.Width -= dx;
                        newBounds.Y += dy;
                        newBounds.Height -= dy;
                        break;
                    case ResizeHandle.TopCenter:
                        newBounds.Y += dy;
                        newBounds.Height -= dy;
                        break;
                    case ResizeHandle.TopRight:
                        newBounds.Y += dy;
                        newBounds.Height -= dy;
                        newBounds.Width += dx;
                        break;
                    case ResizeHandle.MiddleLeft:
                        newBounds.X += dx;
                        newBounds.Width -= dx;
                        break;
                    case ResizeHandle.MiddleRight:
                        newBounds.Width += dx;
                        break;
                    case ResizeHandle.BottomLeft:
                        newBounds.X += dx;
                        newBounds.Width -= dx;
                        newBounds.Height += dy;
                        break;
                    case ResizeHandle.BottomCenter:
                        newBounds.Height += dy;
                        break;
                    case ResizeHandle.BottomRight:
                        newBounds.Width += dx;
                        newBounds.Height += dy;
                        break;
                }

                // Aseguramos que el tamaño no sea negativo
                if (newBounds.Width < 1) newBounds.Width = 1;
                if (newBounds.Height < 1) newBounds.Height = 1;

                selectedItem.Location = new Point(newBounds.X, newBounds.Y);
                selectedItem.Width = newBounds.Width;
                selectedItem.Height = newBounds.Height;

                this.Invalidate();
            }
            else if (isDragging && selectedItem != null)
            {
                // Mover el ítem
                int dx = e.X - dragStartPos.X;
                int dy = e.Y - dragStartPos.Y;

                var bounds = originalBounds;
                bounds.X += dx;
                bounds.Y += dy;

                selectedItem.Location = new Point(bounds.X, bounds.Y);
                this.Invalidate();
            }
        }

        private void MapEditor_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
            currentHandle = ResizeHandle.None;
            this.Cursor = Cursors.Default;
        }

        // ============ PINTAR LA CUADRÍCULA E ÍTEMS ============

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Dibuja la cuadrícula (se dibuja una sola vez)
            for (int i = 0; i <= Columns; i++)
            {
                g.DrawLine(Pens.LightGray, i * TileSize, 0, i * TileSize, Rows * TileSize);
            }
            for (int j = 0; j <= Rows; j++)
            {
                g.DrawLine(Pens.LightGray, 0, j * TileSize, Columns * TileSize, j * TileSize);
            }

            // Recorre y dibuja todas las capas que estén visibles
            foreach (var layer in layers)
            {
                if (!layer.Visible)
                    continue;

                // Dibuja los ítems en la cuadrícula de la capa
                foreach (var kvp in layer.GridItems)
                {
                    MapItem item = kvp.Value;
                    Rectangle destRect = new Rectangle(
                        item.GridLocation.Value.X * TileSize,
                        item.GridLocation.Value.Y * TileSize,
                        TileSize,
                        TileSize
                    );
                    g.DrawImage(item.Image, destRect);
                }

                // Dibuja los ítems de colocación libre de la capa
                foreach (var item in layer.FreeItems)
                {
                    var rect = item.GetBounds();
                    g.DrawImage(item.Image, rect);
                }
            }

            // Dibuja el marco de selección y los handlers para el ítem seleccionado, si aplica
            if (selectedItem != null && selectedItem.GridLocation == null)
            {
                DrawSelection(g, selectedItem);
            }
        }
        // Método para agregar una nueva capa
        public void AddLayer(string name)
        {
            layers.Add(new MapLayer(name));
            this.Invalidate();
        } 

        // Método para obtener la lista de capas (para llenar el ComboBox en el formulario)
        public List<MapLayer> GetLayers() => layers;
        // Dibuja el rectángulo de selección y los manejadores (handles)
        private void DrawSelection(Graphics g, MapItem item)
        {
            Rectangle r = item.GetBounds();
            using (Pen pen = new Pen(Color.Red, 1))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, r);
            }

            // Dibujar 8 handles (esquinas y lados)
            foreach (var handle in Enum.GetValues(typeof(ResizeHandle)).Cast<ResizeHandle>())
            {
                if (handle == ResizeHandle.None) continue;
                Rectangle hr = GetHandleRect(r, handle);
                g.FillRectangle(Brushes.White, hr);
                g.DrawRectangle(Pens.Black, hr);
            }
        }

        // ============ CÁLCULO DE HANDLES ============

        private ResizeHandle GetHandleAtPoint(MapItem item, Point p)
        {
            Rectangle r = item.GetBounds();

            // Revisamos cada handle
            foreach (var handle in Enum.GetValues(typeof(ResizeHandle)).Cast<ResizeHandle>())
            {
                if (handle == ResizeHandle.None) continue;
                Rectangle hr = GetHandleRect(r, handle);
                if (hr.Contains(p))
                    return handle;
            }
            return ResizeHandle.None;
        }

    
        private Rectangle GetHandleRect(Rectangle bounds, ResizeHandle handle)
        {
            // Calcula las coordenadas del handle según la esquina/lado
            int x = 0, y = 0;
            switch (handle)
            {
                case ResizeHandle.TopLeft:
                    x = bounds.Left - HANDLE_SIZE / 2;
                    y = bounds.Top - HANDLE_SIZE / 2;
                    break;
                case ResizeHandle.TopCenter:
                    x = bounds.Left + (bounds.Width / 2) - HANDLE_SIZE / 2;
                    y = bounds.Top - HANDLE_SIZE / 2;
                    break;
                case ResizeHandle.TopRight:
                    x = bounds.Right - HANDLE_SIZE / 2;
                    y = bounds.Top - HANDLE_SIZE / 2;
                    break;
                case ResizeHandle.MiddleLeft:
                    x = bounds.Left - HANDLE_SIZE / 2;
                    y = bounds.Top + (bounds.Height / 2) - HANDLE_SIZE / 2;
                    break;
                case ResizeHandle.MiddleRight:
                    x = bounds.Right - HANDLE_SIZE / 2;
                    y = bounds.Top + (bounds.Height / 2) - HANDLE_SIZE / 2;
                    break;
                case ResizeHandle.BottomLeft:
                    x = bounds.Left - HANDLE_SIZE / 2;
                    y = bounds.Bottom - HANDLE_SIZE / 2;
                    break;
                case ResizeHandle.BottomCenter:
                    x = bounds.Left + (bounds.Width / 2) - HANDLE_SIZE / 2;
                    y = bounds.Bottom - HANDLE_SIZE / 2;
                    break;
                case ResizeHandle.BottomRight:
                    x = bounds.Right - HANDLE_SIZE / 2;
                    y = bounds.Bottom - HANDLE_SIZE / 2;
                    break;
            }
            return new Rectangle(x, y, HANDLE_SIZE, HANDLE_SIZE);
        }
    
    
    
    
    }

}

