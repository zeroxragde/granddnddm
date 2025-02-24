using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Models
{
    public class MapItem
    {
        public Image Image { get; set; }
        public string Category { get; set; }
        public Point? GridLocation { get; set; }

        // Solo se usan para ítems libres
        public Point Location { get; set; }

        // Dimensiones del ítem (para permitir redimensionar)
        public int Width { get; set; }
        public int Height { get; set; }

        public MapItem()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle GetBounds()
        {
            // Si Width o Height son 0, asumimos el tamaño nativo de la imagen
            int w = (Width == 0) ? (Image?.Width ?? 0) : Width;
            int h = (Height == 0) ? (Image?.Height ?? 0) : Height;
            return new Rectangle(Location, new Size(w, h));
        }
    }
}
