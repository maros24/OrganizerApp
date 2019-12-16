﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Models
{
    public partial class MyWeather
    {
        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }

    public class Weather
    {
        [JsonProperty("description")]
        public string Description { get; set; }

    }
    public partial class MyWeather
    {
        public string City { get; set; }

        private const double Kelvin = 273.16;

        public static MyWeather FromJson(string json) => JsonConvert.DeserializeObject<MyWeather>(json, Converter.Settings);

        public override string ToString()
        {
            return $"\r\nCurrent weather in: {City}"
                 + $"\r\nTemperature:        {Math.Round(Main.Temp - Kelvin)}°C"
                 + $"\r\nFeels like:         {Math.Round(Main.FeelsLike - Kelvin)}°C"
                 + $"\r\nHumidity:           {Main.Humidity}%"
                 + $"\r\nVisibility:         {Visibility} meters"
                 + $"\r\nCurrent weather:    {Weather.FirstOrDefault().Description}";
        }
    }
}
