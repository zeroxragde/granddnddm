using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.Json.Serialization;

namespace GranDnDDM.Models
{
    public class MapItem
    {
        // Esta propiedad no se serializa; solo se usa en tiempo de ejecución
        [JsonIgnore]
        public Image Image { get; set; }

        // Nombre del archivo (o ruta relativa) que identifica la imagen en disco
        public string FileName { get; set; }

        public string Category { get; set; }
        public Point? GridLocation { get; set; }
        public Point Location { get; set; }
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
