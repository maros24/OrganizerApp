using Newtonsoft.Json;

namespace Models
{
    public class Weather
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
