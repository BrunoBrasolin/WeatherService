using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace BLL
{
    public class SmtpBLL
    {
        public void SendEmail(string subject, string body)
        {
            MailAddress mailAddress = new MailAddress(ConfigurationManager.AppSettings["FROM_ADDRESS"], ConfigurationManager.AppSettings["FROM_NAME"]);

            string fromPassword = ConfigurationManager.AppSettings["PASSWORD"];

            SmtpClient smtp = new SmtpClient
            {
                Host = ConfigurationManager.AppSettings["HOST"],
                Port = System.Convert.ToInt16(ConfigurationManager.AppSettings["PORT"]),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mailAddress.Address, fromPassword)
            };

            using (MailMessage message = new MailMessage(mailAddress, mailAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
