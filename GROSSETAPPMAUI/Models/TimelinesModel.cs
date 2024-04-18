using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROSSETAPPMAUI.Models
{
    public class TimelinesModel
    {
        [JsonProperty("daily")]
        public List<DailyCityModel> Daily { get; set; }
    }
}
