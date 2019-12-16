using Models;
using System;
using System.Net;
using System.Text;
namespace BusinessLogic
{
    public class WeatherData
	{
		private const string Url = "http://api.openweathermap.org/data/2.5/weather?q=";
		private const string APPId = "6f529c8327ba3ddaaa534da24ba75e12";
		public static void GetWeather()
		{
			Console.Write("Enter a city - ");
			string city = Console.ReadLine();
			try
			{
				StringBuilder webUrl = new StringBuilder(Url);
				webUrl.Append($"{city}&");
				webUrl.Append($"units=metric&");
				webUrl.Append($"APPID={APPId}");
				using (WebClient wc = new WebClient())
				{
					string json = wc.DownloadString(webUrl.ToString());
				}
				var currentWeather = MyWeather.FromJson(json);
                    		currentWeather.City = city;
				Console.WriteLine(currentWeather);
			}
			catch
			{
				Console.WriteLine("Oops, looks like you entered the incorrect city name! Try again."
                                + "\r\nTap any button to try again");
				Console.ReadKey();
				GetWeather();
			}
		}
	}
}