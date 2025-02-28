using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Models
{
    public class MusicRecord
    {
        public string FileName { get; set; }  // Nombre único (GUID) del archivo en la carpeta "Musica"
        public string RealName { get; set; }  // Nombre real del MP3 (extraído del archivo)
        public string Category { get; set; }  // Categoría seleccionada en cbCatSelect
    }
}
