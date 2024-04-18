using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROSSETAPPMAUI.Models
{
    public class MetadataWeatherModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}
