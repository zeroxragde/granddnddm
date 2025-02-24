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
        // Categoría del ítem ("personajes", "tiles", "objetos", etc.)
        public string Category { get; set; }
        // Para ítems colocados en la cuadrícula, almacenamos la celda (columna, fila)
        public Point? GridLocation { get; set; }
        // Para ítems de colocación libre
        public Point Location { get; set; }
    }
}
