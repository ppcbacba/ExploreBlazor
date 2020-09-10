using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FinishedExampleProject.Data
{
    public class ContactService
    {
        public Task<bool> SendMessage(string name, string email, string messagebody)
        {
            try
            {
                var message = new MailMessage(email, "qlzcl@qq.com", "question by " + name, messagebody);
                message.IsBodyHtml = true;
                var client = new SmtpClient("emailclient", 465);
                client.EnableSsl = true;
                client.Timeout = 30;
                client.Credentials = new System.Net.NetworkCredential("qlzcl@qq.com", "aaaa");
                client.Send(message);
                return Task.FromResult(true);

            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }
    }
}
