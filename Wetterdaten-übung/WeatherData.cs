using System;
using System.Collections.Generic;
using System.Text;

namespace Wetterdaten_übung
{
    public class WeatherData
    {
        public string CityName { get; set; }
        public double Temperature {  get; set; } //Celsius
        public string Description { get; set; } // leicht bewölkt etc
        public int Humidity { get; set; }   // luftfeuchtigkeit in proznet
    }
}
