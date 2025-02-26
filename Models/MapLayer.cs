using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GranDnDDM.Models
{
    public class MapLayer
    {
        public string Name { get; set; }
        public bool Visible { get; set; } = true;

        // Ocultamos la propiedad original para que no cause error al serializar
        [JsonIgnore]
        public Dictionary<Point, MapItem> GridItems { get; set; } = new Dictionary<Point, MapItem>();

        // Esta propiedad "proxy" se serializa en lugar de GridItems
        [JsonPropertyName("GridItems")]
        public Dictionary<string, MapItem> GridItemsProxy
        {
            get
            {
                // Convertimos (Point -> string "x,y")
                var dict = new Dictionary<string, MapItem>();
                foreach (var kvp in GridItems)
                {
                    string key = $"{kvp.Key.X},{kvp.Key.Y}";
                    dict[key] = kvp.Value;
                }
                return dict;
            }
            set
            {
                // Reconstruimos (string "x,y" -> Point)
                GridItems.Clear();
                foreach (var kvp in value)
                {
                    var parts = kvp.Key.Split(',');
                    int x = int.Parse(parts[0]);
                    int y = int.Parse(parts[1]);
                    Point p = new Point(x, y);
                    GridItems[p] = kvp.Value;
                }
            }
        }

        // Ítems colocados libremente (imágenes generales, objetos, etc.)
        public List<MapItem> FreeItems { get; set; } = new List<MapItem>();

        public MapLayer(string name)
        {
            Name = name;
        }
    }
}
