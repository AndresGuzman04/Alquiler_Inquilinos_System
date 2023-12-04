using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using MimeKit;

namespace EmailDemo.MailServices
{
    public abstract class MasterMailService
    {
        protected SmtpClient SmtpClient { get; set; }
        protected string Host { get; set; }

        protected string Sender { get; set; }

        protected string Username { get; set; }

        protected string Password { get; set; }

        protected int Port { get; set; }

        protected bool Ssl { get; set; }

        protected void InitializeSmtpClient()
        {
            SmtpClient = new SmtpClient();
            SmtpClient.Connect(Host, Port, Ssl);
            SmtpClient.Authenticate(Username, Password);
        }

        public void SendMail(string subject, string body, string destinationEmail, string Username)
        {
            var message = new MimeMessage();

            try
            {
                message.From.Add(new MailboxAddress("Programacion Eventos", Sender));
                message.To.Add(new MailboxAddress(Username, destinationEmail));
                message.Subject = subject;
                message.Body = new TextPart("plain")
                {
                    Text = body
                };

                SmtpClient.Send(message);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                SmtpClient.Disconnect(true);
                message.Dispose();
            }
        }
    }
}