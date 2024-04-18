using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROSSETAPPMAUI.Utilis
{
    public class Utilis
    {
        public string ConverteSytringToIcon(string StatusString)
        {
            string icon = "☀️";
            if (StatusString == "sunny")
            {
                icon = "☀️";
            }
            else if (StatusString == "cloudy")
            {
                icon = "☁️";
            }
            else if (StatusString == "thunderstorm")
            {
                icon = "⛈️";
            }
            else if (StatusString == "windy")
            {
                icon = "🌬️";
            }
            else if (StatusString == "rainy")
            {
                icon = "🌧️";
            }
            return icon;
        }
    }
}
