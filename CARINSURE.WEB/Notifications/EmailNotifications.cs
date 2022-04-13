using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace CARINSURE.WEB.Notifications
{
    public class EmailNotifications
    {
        public bool SendVerificationEmail(string userEmail, string emailSubject,
            string emailBody)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(ConfigKeys.FromEmail);
                message.To.Add(new MailAddress(userEmail));
                message.Subject = emailSubject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = emailBody;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(ConfigKeys.FromEmail,ConfigKeys.FromEmailPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}