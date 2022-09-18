using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace BLL
{
    public class SendForecast
    {
        private BLL.SmtpBLL objSmtp;
        private BLL.WeatherBLL objWeather;

        public SendForecast()
        {
            objSmtp = new BLL.SmtpBLL();
            objWeather = new BLL.WeatherBLL();
        }
        public void Send()
        {
            string city = "Mongaguá";
            double temperature = objWeather.GetForecast(city);

            string message = $"Temperatura atual em {city}: {temperature}°C";

            objSmtp.SendEmail($"Temperatura em {city}", message);
        }
    }
}
