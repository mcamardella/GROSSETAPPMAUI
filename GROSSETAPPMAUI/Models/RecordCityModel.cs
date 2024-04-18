using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROSSETAPPMAUI.Models
{
    public class RecordCityModel
    {
        [JsonProperty("Stato")]
        public string Stato { get; set; }

        [JsonProperty("Regione")]
        public string Regione { get; set; }

        [JsonProperty("Provincia")]
        public string Provincia { get; set; }

        [JsonProperty("Sindaco")]
        public string Sindaco { get; set; }

        [JsonProperty("Coordinate")]
        public CoordinateModel Coordinate { get; set; }

        [JsonProperty("Altitudine")]
        public int Altitudine { get; set; }

        [JsonProperty("Superficie")]
        public string Superficie { get; set; }

        [JsonProperty("Abitanti")]
        public string Abitanti { get; set; }

        [JsonProperty("Densità")]
        public string Densita { get; set; }

        [JsonProperty("Stemma")]
        public string Stemma { get; set; }
    }
}
