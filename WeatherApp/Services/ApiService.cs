﻿using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format($"https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&appid=64aee2ea91256d864e47e4c4627e1478"));
            return JsonConvert.DeserializeObject<Root>(response);
        }

        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format($"https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&appid=64aee2ea91256d864e47e4c4627e1478"));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
