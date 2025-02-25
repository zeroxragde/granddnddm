using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Models
{
    public class MapLayer
    {
        public string Name { get; set; }
        public bool Visible { get; set; } = true;
        // Ítems ubicados en la cuadrícula (tiles)
        public Dictionary<Point, MapItem> GridItems { get; set; } = new Dictionary<Point, MapItem>();
        // Ítems colocados libremente (imágenes generales, objetos, etc.)
        public List<MapItem> FreeItems { get; set; } = new List<MapItem>();

        public MapLayer(string name)
        {
            Name = name;
        }
    }
}
