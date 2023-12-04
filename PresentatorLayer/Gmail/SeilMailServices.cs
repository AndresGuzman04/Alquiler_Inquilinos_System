using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailDemo.MailServices
{
    public class SendMailService : MasterMailService
    {
        public SendMailService()
        {
            Host = "sandbox.smtp.mailtrap.io";
            Port = 2525;
            Username = "1386928657ccc0";
            Password = "4060ba80cdf1bd";
            Sender = "librarystar@gmail.com";
            Ssl = false;

            InitializeSmtpClient();
        }
    }
}