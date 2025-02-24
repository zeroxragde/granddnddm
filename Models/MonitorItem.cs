using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Models
{
    public class MonitorItem
    {
        public Screen Screen { get; set; }
        public string NombreClave { get; set; }

        public override string ToString()
        {
            return NombreClave;
        }
    }
}
