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
            Host = "sandbox.smtp.mailtrap.io";
            Port = 2525;
            Username = "980651363f240c";
            Password = "70335204d77786";
            Sender = "librarystar@gmail.com";
            Ssl = false;

            InitializeSmtpClient();
        }
    }
}