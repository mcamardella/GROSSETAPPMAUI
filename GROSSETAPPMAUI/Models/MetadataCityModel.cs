using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROSSETAPPMAUI.Models
{
    public class MetadataCityModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
