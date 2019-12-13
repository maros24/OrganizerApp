using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Models;

namespace BusinessLogic
{
    public class WeatherData
    {
        public static void GetWeather()
        {
            string city;
            Console.Write("Enter a city- ");
            city = Console.ReadLine();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&APPID=6f529c8327ba3ddaaa534da24ba75e12";
                    string json = wc.DownloadString(weburl);
                    var results = JsonConvert.DeserializeObject<MyWeather>(json, WeatherData.Converter.Settings);
                    double temp = Math.Round(results.Main.Temp - 273.16);
                    double feelsLike = Math.Round(results.Main.FeelsLike - 273.16);
                    int humidity = results.Main.Humidity;
                    int visibility = results.Visibility;
                    string current = results.Weather[0].Description;
                    ShowCurrentWeather(city, temp, feelsLike, humidity, visibility, current);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Oops, looks like you entered the incorrect city name! Try again.\n");
                Console.WriteLine("Tap any button to try again");
                Console.ReadKey();
                GetWeather();
            }
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }

        public static void ShowCurrentWeather(string city, double temp, double feelsLike, int humidity, int visibility, string current)
        {

            Console.WriteLine("\nCurrent weather in: " + city);
            Console.WriteLine("Temperature:        " + temp + "°C");
            Console.WriteLine("Feels like:         " + feelsLike + "°C");
            Console.WriteLine("Humidity:           " + humidity + "%");
            Console.WriteLine("Visibility:         " + visibility + " meters");
            Console.WriteLine("Current weather:    " + current + "\n");
        }
    }
}



