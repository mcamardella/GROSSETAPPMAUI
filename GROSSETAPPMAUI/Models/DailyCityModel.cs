using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROSSETAPPMAUI.Models
{
    public class DailyCityModel
    {
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("values")]
        public ValuesModel Values { get; set; }
    }
}
