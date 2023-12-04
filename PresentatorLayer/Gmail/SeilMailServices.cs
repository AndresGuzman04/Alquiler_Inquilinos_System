using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace EmailDemo.MailServices
{
    public class SendMailService : MasterMailService
    {
        public SendMailService()
        {
            Host = "smtp.mailtrap.io";
            Port = 2525;
            Username = "8E987FD3A303C6";
            Password = "d957c5611f6e3e";
            Sender = "librarystar@gmail.com";
            Ssl = false;

            InitializeSmtpClient();
        }
    }
}