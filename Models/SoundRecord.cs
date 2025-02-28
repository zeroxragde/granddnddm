using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Models
{
    public class SoundRecord
    {
        public string FileName { get; set; }  // Nombre único (GUID) del archivo en la carpeta "Sounds"
        public string RealName { get; set; }  // Nombre real (extraído del archivo)
    }
}
