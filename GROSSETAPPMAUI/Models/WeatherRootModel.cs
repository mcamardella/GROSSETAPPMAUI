using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROSSETAPPMAUI.Models
{
    public class WeatherRootModel
    {
        [JsonProperty("record")]
        public RecordWeatherModel Record { get; set; }

        [JsonProperty("metadata")]
        public MetadataWeatherModel Metadata { get; set; }
    }

}
