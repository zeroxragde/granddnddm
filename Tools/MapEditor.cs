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
        // Tamaño de celda (por defecto 32x32)
        public int TileSize { get; set; } = 32;
        public int Columns { get; set; } = 20;
        public int Rows { get; set; } = 15;

        // Almacenamos los ítems colocados en la cuadrícula
        private Dictionary<Point, MapItem> gridTiles = new Dictionary<Point, MapItem>();
        // Almacenamos los ítems de colocación libre (que abarcan toda la grid)
        private List<MapItem> freeItems = new List<MapItem>();

        // Distancia umbral para disparar el evento de activación
        public int ActivationThreshold { get; set; } = 40;

        // Evento para notificar la activación de un objeto (por ejemplo, al detectar la cercanía de un personaje)
        public event Action<MapItem> ObjectActivated;

        public MapEditor()
        {
            this.DoubleBuffered = true;
            this.AllowDrop = true;
            this.DragEnter += MapEditor_DragEnter;
            this.DragDrop += MapEditor_DragDrop;
            this.MouseClick += MapEditor_MouseClick;
        }

        // En DragEnter verificamos que el objeto arrastrado incluya la información de nuestro ítem
        private void MapEditor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("DraggedMapItem") || e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // En DragDrop obtenemos la información del ítem (imagen y categoría) y lo colocamos en el mapa
        private void MapEditor_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("DraggedMapItem"))
            {
                var draggedItem = e.Data.GetData("DraggedMapItem") as DraggedMapItem;
                if (draggedItem != null)
                {
                    Image image = draggedItem.Image;
                    string category = draggedItem.Category;
                    Point dropPoint = this.PointToClient(new Point(e.X, e.Y));

                    // Creamos un nuevo MapItem con la información arrastrada
                    MapItem newItem = new MapItem
                    {
                        Image = (Image)image.Clone(),
                        Category = category,
                        // En free placement se utiliza la posición del drop; en grid se calculará la celda
                        Location = dropPoint
                    };

                    // Si se mantiene pulsada la tecla Control, se coloca libremente (ignora la cuadrícula)
                    if (ModifierKeys.HasFlag(Keys.Control))
                    {
                        freeItems.Add(newItem);
                    }
                    else
                    {
                        // Calculamos la celda de la cuadrícula donde se soltó la imagen
                        int col = dropPoint.X / TileSize;
                        int row = dropPoint.Y / TileSize;
                        Point gridPoint = new Point(col, row);
                        newItem.GridLocation = gridPoint;
                        gridTiles[gridPoint] = newItem;
                    }
                    this.Invalidate(); // Redibuja el control
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                // Si no se incluye la información de categoría, usamos un valor por defecto
                var bmp = e.Data.GetData(DataFormats.Bitmap) as Image;
                if (bmp != null)
                {
                    Point dropPoint = this.PointToClient(new Point(e.X, e.Y));
                    MapItem newItem = new MapItem
                    {
                        Image = (Image)bmp.Clone(),
                        Category = "desconocido",
                        Location = dropPoint
                    };
                    if (ModifierKeys.HasFlag(Keys.Control))
                    {
                        freeItems.Add(newItem);
                    }
                    else
                    {
                        int col = dropPoint.X / TileSize;
                        int row = dropPoint.Y / TileSize;
                        Point gridPoint = new Point(col, row);
                        newItem.GridLocation = gridPoint;
                        gridTiles[gridPoint] = newItem;
                    }
                    this.Invalidate();
                }
            }
        }

        // Ejemplo: con clic derecho se pueden eliminar ítems de colocación libre
        private void MapEditor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = freeItems.Count - 1; i >= 0; i--)
                {
                    var item = freeItems[i];
                    Rectangle rect = new Rectangle(item.Location, item.Image.Size);
                    if (rect.Contains(e.Location))
                    {
                        freeItems.RemoveAt(i);
                        this.Invalidate();
                        break;
                    }
                }
            }
        }

        // Método para pintar el mapa, la cuadrícula y los ítems
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

            // Dibuja los ítems colocados en la cuadrícula
            foreach (var kvp in gridTiles)
            {
                MapItem item = kvp.Value;
                Rectangle destRect = new Rectangle(item.GridLocation.Value.X * TileSize, item.GridLocation.Value.Y * TileSize, TileSize, TileSize);
                g.DrawImage(item.Image, destRect);
            }

            // Dibuja los ítems de colocación libre (que abarcan toda la grid)
            foreach (var item in freeItems)
            {
                g.DrawImage(item.Image, item.Location);
            }

            // Opcional: dibuja un borde rojo alrededor de los objetos para visualizarlos
            foreach (var item in GetAllItems().Where(mi => mi.Category.Equals("objetos", StringComparison.OrdinalIgnoreCase)))
            {
                Rectangle rect;
                if (item.GridLocation.HasValue)
                {
                    rect = new Rectangle(item.GridLocation.Value.X * TileSize, item.GridLocation.Value.Y * TileSize, TileSize, TileSize);
                }
                else
                {
                    rect = new Rectangle(item.Location, item.Image.Size);
                }
                g.DrawRectangle(Pens.Red, rect);
            }
        }

        // Método para obtener todos los ítems (tanto grid como free)
        public IEnumerable<MapItem> GetAllItems()
        {
            foreach (var item in gridTiles.Values)
                yield return item;
            foreach (var item in freeItems)
                yield return item;
        }

        // Método que se puede llamar (por ejemplo, en un Timer o tras un movimiento) para revisar interacciones
        // Si un objeto (categoría "objetos") está cerca de un personaje ("personajes"), se dispara el evento de activación.
        public void CheckInteractions()
        {
            var characters = GetAllItems().Where(mi => mi.Category.Equals("personajes", StringComparison.OrdinalIgnoreCase)).ToList();
            var objects = GetAllItems().Where(mi => mi.Category.Equals("objetos", StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var obj in objects)
            {
                // Calculamos la posición central del objeto
                Point objPos = obj.GridLocation.HasValue
                    ? new Point(obj.GridLocation.Value.X * TileSize + TileSize / 2, obj.GridLocation.Value.Y * TileSize + TileSize / 2)
                    : new Point(obj.Location.X + obj.Image.Width / 2, obj.Location.Y + obj.Image.Height / 2);

                foreach (var chr in characters)
                {
                    Point chrPos = chr.GridLocation.HasValue
                        ? new Point(chr.GridLocation.Value.X * TileSize + TileSize / 2, chr.GridLocation.Value.Y * TileSize + TileSize / 2)
                        : new Point(chr.Location.X + chr.Image.Width / 2, chr.Location.Y + chr.Image.Height / 2);

                    double distance = Math.Sqrt(Math.Pow(objPos.X - chrPos.X, 2) + Math.Pow(objPos.Y - chrPos.Y, 2));
                    if (distance <= ActivationThreshold)
                    {
                        // Dispara el evento de activación para este objeto
                        ObjectActivated?.Invoke(obj);
                    }
                }
            }
        }
    }

    // Clase auxiliar para el posicionamiento de imágenes libres
    public class ImagePlacement
    {
        public Image Image { get; set; }
        public Point Location { get; set; }
    }
}

