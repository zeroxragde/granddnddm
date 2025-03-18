using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using GranDnDDM.Models;
using GranDnDDM.Enums;
using System.ComponentModel;

namespace GranDnDDM.Tools
{
    public class MapEditor : UserControl
    {
        private string imagesFolder = Path.Combine(Application.StartupPath, "imagenes");
        private string jsonDataFile = Path.Combine(Application.StartupPath, "data_img.json");
        public int TileSize { get; set; } = 32;
        public int Columns { get; set; } = 20;
        public int Rows { get; set; } = 15;

        // Lista de capas y la capa activa
        private List<MapLayer> layers = new List<MapLayer>();
        public int ActiveLayerIndex { get; set; } = 0;

        // Propiedades para la herramienta
        public ToolMode CurrentToolMode { get; set; } = ToolMode.None;
        public Image DrawingImage { get; set; }
        public DraggedMapItem DrawingItem { get; set; }

        // Selección y manipulación
        private MapItem selectedItem = null;
        private bool isDragging = false;
        private bool isResizing = false;
        private ResizeHandle currentHandle = ResizeHandle.None;

        private Point dragStartPos;
        private Rectangle originalBounds;

        private const int HANDLE_SIZE = 32;
        private string lastSelectedFilePath = string.Empty;
        // Evita que el control se active (no recibe el foco) al ser clickeado.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x08000000; // WS_EX_NOACTIVATE
                return cp;
            }
        }
        public MapEditor()
        {
            DoubleBuffered = true;
            AllowDrop = true;
            DragEnter += MapEditor_DragEnter;
            DragDrop += MapEditor_DragDrop;
            MouseDown += MapEditor_MouseDown;
            MouseMove += MapEditor_MouseMove;
            MouseUp += MapEditor_MouseUp;
            TabStop = false;
            // Crear capa base inicial
            layers.Add(new MapLayer("Capa Base"));
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (this.Parent != null)
            {
                this.Parent.Focus();
            }
        }
        #region Drag & Drop
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
            MapLayer activeLayer = layers[ActiveLayerIndex];
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
                        FileName = draggedItem.FileName,
                        Width = draggedItem.Image.Width,
                        Height = draggedItem.Image.Height
                    };

                    if (draggedItem.Category == "imagenes generales" || draggedItem.Category == "personajes")
                    {
                        activeLayer.FreeItems.Add(newItem);
                    }
                    else
                    {
                        int col = dropPoint.X / TileSize;
                        int row = dropPoint.Y / TileSize;
                        newItem.GridLocation = new Point(col, row);
                        activeLayer.GridItems[newItem.GridLocation.Value] = newItem;
                    }
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                var bmp = e.Data.GetData(DataFormats.Bitmap) as Image;
                if (bmp != null && draggedItem != null)
                {
                    var newItem = new MapItem
                    {
                        Image = (Image)draggedItem.Image.Clone(),
                        Category = draggedItem.Category,
                        Location = dropPoint,
                        Width = draggedItem.Image.Width,
                        FileName = draggedItem.FileName,
                        Height = draggedItem.Image.Height
                    };
                    if (draggedItem.Category == "imagenes generales" || draggedItem.Category == "personajes")
                        activeLayer.FreeItems.Add(newItem);
                    else
                    {
                        int col = dropPoint.X / TileSize;
                        int row = dropPoint.Y / TileSize;
                        newItem.GridLocation = new Point(col, row);
                        activeLayer.GridItems[newItem.GridLocation.Value] = newItem;
                    }
                }
            }
            Invalidate();
        }
        #endregion

        #region Mouse Handling (Selection, Drag, Resize)

        public Bitmap GetSnapshot()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            return bmp;
        }



        private void MapEditor_MouseDown(object sender, MouseEventArgs e)
        {

            // Si hay un elemento seleccionado, y se hace clic fuera de su área de selección (incluyendo los handles),
            // se borra la selección para que desaparezcan los HandleRect.
            if (selectedItem != null)
            {
                bool clickOnHandle = false;
                // Verifica si el clic cae dentro de alguno de los rectángulos de los handles.
                foreach (ResizeHandle handle in Enum.GetValues(typeof(ResizeHandle)))
                {
                    if (handle == ResizeHandle.None)
                        continue;
                    Rectangle hr = GetHandleRect(selectedItem.GetBounds(), handle);
                    if (hr.Contains(e.Location))
                    {
                        clickOnHandle = true;
                        break;
                    }
                }
                // Si el clic no está sobre los handles ni dentro del área del elemento seleccionado, se limpia la selección.
                if (!clickOnHandle && !selectedItem.GetBounds().Contains(e.Location))
                {
                    selectedItem = null;
                    Invalidate(); // Redibuja el control sin mostrar los handles.
                }
            }
            if (CurrentToolMode == ToolMode.Fill)
            {
                FillLayer();
                return;
            }
           // ActualizarContenidoConScrollPreservado();
            // Si la herramienta activa es 'Draw'
            if (CurrentToolMode == ToolMode.Draw)
            {
                if (DrawingImage == null)
                {
                    MessageBox.Show("No se ha seleccionado ninguna imagen para dibujar.");
                    return;
                }

                int col = e.X / TileSize;
                int row = e.Y / TileSize;
                Point gridPoint = new Point(col, row);

                MapLayer activeLayer = layers[ActiveLayerIndex];

                MapItem newItem = new MapItem
                {
                    Image = (Image)DrawingImage.Clone(),
                    Category = "tile", // O la categoría correspondiente
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

                // Borrar ítem de GridItems (ya lo tienes implementado)
                if (activeLayer.GridItems.ContainsKey(gridPoint))
                {
                    activeLayer.GridItems.Remove(gridPoint);
                    Invalidate();
                }

                // Borrar ítem de FreeItems
                // Recorremos la lista de FreeItems y buscamos el ítem que se debe borrar
                for (int i = activeLayer.FreeItems.Count - 1; i >= 0; i--)
                {
                    MapItem item = activeLayer.FreeItems[i];
                    if (item.GetBounds().Contains(e.Location)) // Comparar con la ubicación del mouse
                    {
                        activeLayer.FreeItems.RemoveAt(i); // Eliminar el ítem de FreeItems
                        Invalidate(); // Redibujar para actualizar el UI
                        break; // Salir del ciclo después de borrar el primer ítem encontrado
                    }
                }

                return;
            }
            else
            {
                // Lógica para seleccionar ítems (incluyendo imágenes generales)
                MapLayer activeLayer = layers[ActiveLayerIndex];
                MapItem clickedItem = null;

                // Revisamos si clicamos en un ítem "free"
                for (int i = activeLayer.FreeItems.Count - 1; i >= 0; i--)
                {
                    var item = activeLayer.FreeItems[i];
                    if (item.GetBounds().Contains(e.Location)) // Si hacemos clic sobre un ítem
                    {
                        clickedItem = item;
                        break;
                    }
                }

                // Si encontramos un ítem y su categoría es "imagenes generales", lo seleccionamos para moverlo o redimensionarlo
                if (clickedItem != null && (clickedItem.Category == "imagenes generales" || clickedItem.Category == "personajes"))
                {
                    selectedItem = clickedItem;
                    isDragging = true;
                    dragStartPos = e.Location;
                    originalBounds = selectedItem.GetBounds();

                    // Verificamos si clicamos sobre un handle de redimensionamiento
                    currentHandle = GetHandleAtPoint(selectedItem, e.Location);
                    if (currentHandle != ResizeHandle.None)
                    {
                        isResizing = true; // Empezamos el proceso de redimensionamiento
                        return;
                    }
                }
            }
        
        }
        private void MapEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedItem != null && !isResizing)
            {
                int dx = e.X - dragStartPos.X;
                int dy = e.Y - dragStartPos.Y;
                var bounds = originalBounds;
                bounds.X += dx;
                bounds.Y += dy;
                selectedItem.Location = new Point(bounds.X, bounds.Y);
                Invalidate(); // Redibujamos para actualizar la vista
            }
            else if (isResizing && selectedItem != null)
            {
                Rectangle newBounds = originalBounds;
                int dx = e.X - dragStartPos.X;
                int dy = e.Y - dragStartPos.Y;

                // Redimensionar el ítem, considerando el manejador seleccionado
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

                // Restringir el tamaño mínimo
                if (newBounds.Width < 1) newBounds.Width = 1;
                if (newBounds.Height < 1) newBounds.Height = 1;

                selectedItem.Location = new Point(newBounds.X, newBounds.Y);
                selectedItem.Width = newBounds.Width;
                selectedItem.Height = newBounds.Height;

                Invalidate(); // Redibujar el control
            }
        }
        private void MapEditor_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
            currentHandle = ResizeHandle.None;
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region Pintado
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Dibuja la cuadrícula
            for (int i = 0; i <= Columns; i++)
            {
                g.DrawLine(Pens.LightGray, i * TileSize, 0, i * TileSize, Rows * TileSize);
            }
            for (int j = 0; j <= Rows; j++)
            {
                g.DrawLine(Pens.LightGray, 0, j * TileSize, Columns * TileSize, j * TileSize);
            }

            if (layers == null || layers.Count == 0)
                return;

            foreach (var layer in layers)
            {
                if (!layer.Visible)
                    continue;

                foreach (var kvp in layer.GridItems)
                {
                    MapItem item = kvp.Value;
                    if (item.Image != null && item.GridLocation.HasValue)
                    {
                        Rectangle destRect = new Rectangle(
                            item.GridLocation.Value.X * TileSize,
                            item.GridLocation.Value.Y * TileSize,
                            TileSize,
                            TileSize);
                        g.DrawImage(item.Image, destRect);
                    }
                }

                foreach (var item in layer.FreeItems)
                {
                    if (item.Image != null)
                    {
                        var rect = item.GetBounds();
                        g.DrawImage(item.Image, rect);
                    }
                }
            }

            if (selectedItem != null && selectedItem.GridLocation == null)
            {
                DrawSelection(g, selectedItem);
            }
            //ActualizarContenidoConScrollPreservado();
        }

        private void DrawSelection(Graphics g, MapItem item)
        {
            Rectangle r = item.GetBounds();
            using (Pen pen = new Pen(Color.Red, 1))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, r);
            }
            foreach (var handle in Enum.GetValues(typeof(ResizeHandle)).Cast<ResizeHandle>())
            {
                if (handle == ResizeHandle.None) continue;
                Rectangle hr = GetHandleRect(r, handle);
                g.FillRectangle(Brushes.White, hr);
                g.DrawRectangle(Pens.Black, hr);
            }
        }

        private ResizeHandle GetHandleAtPoint(MapItem item, Point p)
        {
            Rectangle r = item.GetBounds();
            foreach (var handle in Enum.GetValues(typeof(ResizeHandle)).Cast<ResizeHandle>())
            {
                if (handle == ResizeHandle.None)
                    continue;
                Rectangle hr = GetHandleRect(r, handle);
                if (hr.Contains(p))
                    return handle;
            }
            return ResizeHandle.None;
        }

        private Rectangle GetHandleRect(Rectangle bounds, ResizeHandle handle)
        {
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
            return new Rectangle(x, y, HANDLE_SIZE, HANDLE_SIZE);  // Usa HANDLE_SIZE para el tamaño de los cuadros
        }

        #endregion

        #region Guardado y Carga de Mapa
        public void SaveMap(string name)
        {
            try
            {
                if(name=="" || name == null)
                {
                    return;
                }
                string mapJson = JsonSerializer.Serialize(layers, new JsonSerializerOptions { WriteIndented = true });
                string mapFile = "";
                if (GlobalTools.IsValidPath(name))
                {
                     mapFile = name;
                }
                else {
                    mapFile = Path.Combine(Application.StartupPath, "Mapas","mapa_" + name + ".json");
                }
                   
                File.WriteAllText(mapFile, mapJson);
                MessageBox.Show("Mapa guardado correctamente.", "Guardar Mapa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el mapa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para obtener el DataSource del ComboBox (en este caso, nombres de las capas)
        public BindingList<string> GetLayerDataSource()
        {
            var layerNames = new BindingList<string>();  // Usamos BindingList para que se pueda vincular al ComboBox

            foreach (var layer in layers)
            {
                layerNames.Add(layer.Name);  // Suponiendo que cada capa tiene una propiedad 'Name'
            }

            return layerNames; // Devolvemos la lista que puede ser usada como DataSource
        }

        public string LoadMap()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos JSON|*.json";
                ofd.Title = "Selecciona el archivo JSON del mapa";
                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("No se seleccionó ningún archivo JSON.", "Carga de Mapa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return "";
                }

                try
                {
                    string json = File.ReadAllText(ofd.FileName);
                    List<MapLayer> loadedLayers = JsonSerializer.Deserialize<List<MapLayer>>(json);
                    if (loadedLayers != null)
                    {
                        layers = loadedLayers; // Asigna las capas cargadas al mapa actual

                        if (string.IsNullOrEmpty(imagesFolder))
                        {
                            MessageBox.Show("La carpeta de imágenes no está definida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return "";
                        }

                        foreach (MapLayer layer in layers)
                        {//recorremos las capas

                            // Recorremos los tiles en la cuadrícula del mapa
                            foreach (var kvp in layer.GridItems)
                            {
                                MapItem item = kvp.Value;
                                if (!string.IsNullOrEmpty(item.FileName))
                                {
                                    string fullPath = Path.Combine(imagesFolder, item.FileName);
                                    if (File.Exists(fullPath))
                                    {
                                        item.Image = Image.FromFile(fullPath);
                                    }
                                    else
                                    {
                                        item.Image = SolicitarImagen($"No se encontró '{item.FileName}' para un tile de la cuadrícula.\nSelecciona la imagen correspondiente:");
                                        if (item.Image != null)
                                        {
                                            GuardarImagen(item);
                                        }
                                    }
                                }
                            }

                            // Recorremos los objetos libres en el mapa
                            foreach (MapItem item in layer.FreeItems)
                            {
                                if (!string.IsNullOrEmpty(item.FileName))
                                {
                                    string fullPath = Path.Combine(imagesFolder, item.FileName);
                                    if (File.Exists(fullPath))
                                    {
                                        item.Image = Image.FromFile(fullPath);
                                    }
                                    else
                                    {
                                        item.Image = SolicitarImagen($"No se encontró '{item.FileName}' para un ítem libre.\nSelecciona la imagen correspondiente:");
                                        if (item.Image != null)
                                        {
                                            GuardarImagen(item);
                                        }
                                    }
                                }
                            }
                        }
                        // Forzar actualización de la interfaz
                        Invalidate();
                        MessageBox.Show("Mapa cargado correctamente.", "Cargar Mapa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return ofd.FileName;

                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el mapa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
            }
            return "";
        }



        private void GuardarImagen(MapItem item)
        {
            string newFileName = Path.GetFileName(lastSelectedFilePath);
            item.FileName = newFileName;
            string destinationPath = Path.Combine(imagesFolder, newFileName);
            if (!File.Exists(destinationPath))
            {
                File.Copy(lastSelectedFilePath, destinationPath);
            }
        }
        private Image SolicitarImagen(string mensaje)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = mensaje;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lastSelectedFilePath = ofd.FileName;
                    return Image.FromFile(ofd.FileName);
                }
            }
            return null;
        }
        #endregion
        #region Métodos para Capas
        public void AddLayer(string name)
        {
            layers.Add(new MapLayer(name));
            this.Invalidate();
        }

        public List<MapLayer> GetLayers()
        {
            return layers;
        }
        #endregion

        public void ToggleHiddenLayer()
        {
            // Verifica si hay al menos una capa
            if (layers.Count > 0)
            {
                // Obtiene la capa activa
                MapLayer activeLayer = layers[ActiveLayerIndex];

                // Alterna la visibilidad de la capa activa
                activeLayer.Visible = !activeLayer.Visible;

                // Actualiza la interfaz
                Invalidate(); // Esto hará que se redibuje el mapa y se actualice la visibilidad
            }
        }
        public void FillLayer()
        {
            if (DrawingImage == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna imagen para rellenar el mapa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MapLayer activeLayer = layers[ActiveLayerIndex];

            for (int col = 0; col < Columns; col++)
            {
                for (int row = 0; row < Rows; row++)
                {
                    Point gridPoint = new Point(col, row);

                    MapItem newItem = new MapItem
                    {
                        Image = (Image)DrawingImage.Clone(),
                        Category = "tile",
                        GridLocation = gridPoint,
                        Location = new Point(gridPoint.X * TileSize, gridPoint.Y * TileSize),
                        Width = TileSize,
                        Height = TileSize,
                        FileName = DrawingItem.FileName
                    };

                    activeLayer.GridItems[gridPoint] = newItem;
                }
            }

            Invalidate(); // Refrescar la vista del mapa
        }

    }
}
