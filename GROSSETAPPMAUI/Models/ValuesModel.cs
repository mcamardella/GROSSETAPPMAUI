using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GROSSETAPPMAUI.Models
{
    public class ValuesModel
    {
        [JsonProperty("cloudBaseAvg")]
        public double cloudBaseAvg { get; set; }

        [JsonProperty("cloudBaseMax")]
        public double cloudBaseMax { get; set; }

        [JsonProperty("cloudBaseMin")]
        public int cloudBaseMin { get; set; }

        [JsonProperty("cloudCeilingAvg")]
        public double cloudCeilingAvg { get; set; }

        [JsonProperty("cloudCeilingMax")]
        public double cloudCeilingMax { get; set; }

        [JsonProperty("cloudCeilingMin")]
        public int cloudCeilingMin { get; set; }

        [JsonProperty("cloudCoverAvg")]
        public double cloudCoverAvg { get; set; }

        [JsonProperty("cloudCoverMax")]
        public double cloudCoverMax { get; set; }

        [JsonProperty("cloudCoverMin")]
        public double cloudCoverMin { get; set; }

        [JsonProperty("dewPointAvg")]
        public double dewPointAvg { get; set; }

        [JsonProperty("dewPointMax")]
        public double dewPointMax { get; set; }

        [JsonProperty("dewPointMin")]
        public double dewPointMin { get; set; }

        [JsonProperty("evapotranspirationAvg")]
        public double evapotranspirationAvg { get; set; }

        [JsonProperty("evapotranspirationMax")]
        public double evapotranspirationMax { get; set; }

        [JsonProperty("evapotranspirationMin")]
        public double evapotranspirationMin { get; set; }

        [JsonProperty("evapotranspirationSum")]
        public double evapotranspirationSum { get; set; }

        [JsonProperty("freezingRainIntensityAvg")]
        public int freezingRainIntensityAvg { get; set; }

        [JsonProperty("freezingRainIntensityMax")]
        public int freezingRainIntensityMax { get; set; }

        [JsonProperty("freezingRainIntensityMin")]
        public int freezingRainIntensityMin { get; set; }

        [JsonProperty("humidityAvg")]
        public double humidityAvg { get; set; }

        [JsonProperty("humidityMax")]
        public double humidityMax { get; set; }

        [JsonProperty("humidityMin")]
        public double humidityMin { get; set; }

        [JsonProperty("iceAccumulationAvg")]
        public int iceAccumulationAvg { get; set; }

        [JsonProperty("iceAccumulationLweAvg")]
        public int iceAccumulationLweAvg { get; set; }

        [JsonProperty("iceAccumulationLweMax")]
        public int iceAccumulationLweMax { get; set; }

        [JsonProperty("iceAccumulationLweMin")]
        public int iceAccumulationLweMin { get; set; }

        [JsonProperty("iceAccumulationLweSum")]
        public int iceAccumulationLweSum { get; set; }

        [JsonProperty("iceAccumulationMax")]
        public int iceAccumulationMax { get; set; }

        [JsonProperty("iceAccumulationMin")]
        public int iceAccumulationMin { get; set; }

        [JsonProperty("iceAccumulationSum")]
        public int iceAccumulationSum { get; set; }

        [JsonProperty("moonriseTime")]
        public DateTime moonriseTime { get; set; }

        [JsonProperty("moonsetTime")]
        public DateTime moonsetTime { get; set; }

        [JsonProperty("precipitationProbabilityAvg")]
        public double precipitationProbabilityAvg { get; set; }

        [JsonProperty("precipitationProbabilityMax")]
        public int precipitationProbabilityMax { get; set; }

        [JsonProperty("precipitationProbabilityMin")]
        public int precipitationProbabilityMin { get; set; }

        [JsonProperty("pressureSurfaceLevelAvg")]
        public double pressureSurfaceLevelAvg { get; set; }

        [JsonProperty("pressureSurfaceLevelMax")]
        public double pressureSurfaceLevelMax { get; set; }

        [JsonProperty("pressureSurfaceLevelMin")]
        public double pressureSurfaceLevelMin { get; set; }

        [JsonProperty("rainAccumulationAvg")]
        public double rainAccumulationAvg { get; set; }

        [JsonProperty("rainAccumulationLweAvg")]
        public double rainAccumulationLweAvg { get; set; }

        [JsonProperty("rainAccumulationLweMax")]
        public double rainAccumulationLweMax { get; set; }

        [JsonProperty("rainAccumulationLweMin")]
        public int rainAccumulationLweMin { get; set; }

        [JsonProperty("rainAccumulationMax")]
        public double rainAccumulationMax { get; set; }

        [JsonProperty("rainAccumulationMin")]
        public int rainAccumulationMin { get; set; }

        [JsonProperty("rainAccumulationSum")]
        public double rainAccumulationSum { get; set; }

        [JsonProperty("rainIntensityAvg")]
        public double rainIntensityAvg { get; set; }

        [JsonProperty("rainIntensityMax")]
        public double rainIntensityMax { get; set; }

        [JsonProperty("rainIntensityMin")]
        public double rainIntensityMin { get; set; }

        [JsonProperty("sleetAccumulationAvg")]
        public int sleetAccumulationAvg { get; set; }

        [JsonProperty("sleetAccumulationLweAvg")]
        public int sleetAccumulationLweAvg { get; set; }

        [JsonProperty("sleetAccumulationLweMax")]
        public int sleetAccumulationLweMax { get; set; }

        [JsonProperty("sleetAccumulationLweMin")]
        public int sleetAccumulationLweMin { get; set; }

        [JsonProperty("sleetAccumulationLweSum")]
        public int sleetAccumulationLweSum { get; set; }

        [JsonProperty("sleetAccumulationMax")]
        public int sleetAccumulationMax { get; set; }

        [JsonProperty("sleetAccumulationMin")]
        public int sleetAccumulationMin { get; set; }

        [JsonProperty("sleetIntensityAvg")]
        public int sleetIntensityAvg { get; set; }

        [JsonProperty("sleetIntensityMax")]
        public int sleetIntensityMax { get; set; }

        [JsonProperty("sleetIntensityMin")]
        public int sleetIntensityMin { get; set; }

        [JsonProperty("snowAccumulationAvg")]
        public int snowAccumulationAvg { get; set; }

        [JsonProperty("snowAccumulationLweAvg")]
        public int snowAccumulationLweAvg { get; set; }

        [JsonProperty("snowAccumulationLweMax")]
        public int snowAccumulationLweMax { get; set; }

        [JsonProperty("snowAccumulationLweMin")]
        public int snowAccumulationLweMin { get; set; }

        [JsonProperty("snowAccumulationLweSum")]
        public int snowAccumulationLweSum { get; set; }

        [JsonProperty("snowAccumulationMax")]
        public int snowAccumulationMax { get; set; }

        [JsonProperty("snowAccumulationMin")]
        public int snowAccumulationMin { get; set; }

        [JsonProperty("snowAccumulationSum")]
        public int snowAccumulationSum { get; set; }

        [JsonProperty("snowIntensityAvg")]
        public int snowIntensityAvg { get; set; }

        [JsonProperty("snowIntensityMax")]
        public int snowIntensityMax { get; set; }

        [JsonProperty("snowIntensityMin")]
        public int snowIntensityMin { get; set; }

        [JsonProperty("sunriseTime")]
        public DateTime sunriseTime { get; set; }

        [JsonProperty("sunsetTime")]
        public DateTime sunsetTime { get; set; }

        [JsonProperty("temperatureApparentAvg")]
        public double temperatureApparentAvg { get; set; }

        [JsonProperty("temperatureApparentMax")]
        public double temperatureApparentMax { get; set; }

        [JsonProperty("temperatureApparentMin")]
        public double temperatureApparentMin { get; set; }

        [JsonProperty("temperatureAvg")]
        public double temperatureAvg { get; set; }

        [JsonProperty("temperatureMax")]
        public double temperatureMax { get; set; }

        [JsonProperty("temperatureMin")]
        public double temperatureMin { get; set; }

        [JsonProperty("uvHealthConcernAvg")]
        public int uvHealthConcernAvg { get; set; }

        [JsonProperty("uvHealthConcernMax")]
        public int uvHealthConcernMax { get; set; }

        [JsonProperty("uvHealthConcernMin")]
        public int uvHealthConcernMin { get; set; }

        [JsonProperty("uvIndexAvg")]
        public int uvIndexAvg { get; set; }

        [JsonProperty("uvIndexMax")]
        public int uvIndexMax { get; set; }

        [JsonProperty("uvIndexMin")]
        public int uvIndexMin { get; set; }

        [JsonProperty("visibilityAvg")]
        public double visibilityAvg { get; set; }

        [JsonProperty("visibilityMax")]
        public double visibilityMax { get; set; }

        [JsonProperty("visibilityMin")]
        public double visibilityMin { get; set; }

        [JsonProperty("weatherCodeMax")]
        public int weatherCodeMax { get; set; }

        [JsonProperty("weatherCodeMin")]
        public int weatherCodeMin { get; set; }

        [JsonProperty("windDirectionAvg")]
        public double windDirectionAvg { get; set; }

        [JsonProperty("windGustAvg")]
        public double windGustAvg { get; set; }

        [JsonProperty("windGustMax")]
        public double windGustMax { get; set; }

        [JsonProperty("windGustMin")]
        public double windGustMin { get; set; }

        [JsonProperty("windSpeedAvg")]
        public double windSpeedAvg { get; set; }

        [JsonProperty("windSpeedMax")]
        public double windSpeedMax { get; set; }

        [JsonProperty("windSpeedMin")]
        public double windSpeedMin { get; set; }
    }
}
