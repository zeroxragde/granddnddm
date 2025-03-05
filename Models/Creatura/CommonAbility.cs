using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GranDnDDM.Models.Creatura
{
    public class CommonAbility
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("realname")]
        public string RealName { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }
}
