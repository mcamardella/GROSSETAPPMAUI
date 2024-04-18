using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROSSETAPPMAUI.Models
{
    public class RecordWeatherModel
    {
        [JsonProperty("timelines")]
        public TimelinesModel Timelines { get; set; }

        [JsonProperty("location")]
        public LocationModel Location { get; set; }
    }
}
