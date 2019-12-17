using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Models
{
    public class WeatherModel
    {
        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        public string City { get; set; }

        public static WeatherModel FromJson(string json) => JsonConvert.DeserializeObject<WeatherModel>(json, Converter.Settings);

        public override string ToString()
        {
            return $"\r\nCurrent weather in: {City}"
                 + $"\r\nTemperature:        {Main.Temp}°C"
                 + $"\r\nFeels like:         {Main.FeelsLike}°C"
                 + $"\r\nHumidity:           {Main.Humidity}%"
                 + $"\r\nVisibility:         {Visibility} meters"
                 + $"\r\nCurrent weather:    {Weather.FirstOrDefault().Description}";
        }
    }
}
