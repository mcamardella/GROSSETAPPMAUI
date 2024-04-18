using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROSSETAPPMAUI.Models
{
    internal class CityRootModel
    {
        [JsonProperty("record")]
        public RecordCityModel Record { get; set; }

        [JsonProperty("metadata")]
        public MetadataCityModel Metadata { get; set; }
    }
}
