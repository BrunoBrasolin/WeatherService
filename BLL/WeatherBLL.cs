using System.Net.Mail;
using System.Net;
using System.Configuration;
using OpenWeatherAPI;
using System;
using System.Threading.Tasks;

namespace BLL
{
    public class WeatherBLL
    {
        [Obsolete]
        public double GetForecast(string city)
        {
            try
            {
                OpenWeatherApiClient api = new OpenWeatherAPI.OpenWeatherApiClient(ConfigurationManager.AppSettings["API_KEY"]);

                var results = api.Query(city);

                return Math.Round(results.Main.Temperature.CelsiusCurrent/1000, 2);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
