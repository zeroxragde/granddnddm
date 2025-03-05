using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GranDnDDM.Models.Creatura
{
    public class StatBlockData
    {
        [JsonPropertyName("commonAbilities")]
        public List<CommonAbility> CommonAbilities { get; set; }
    }
}
