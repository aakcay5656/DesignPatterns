using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.S
{
    class EmailSender
    {
        public void SendEmail(string email,string message)
        {
            Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}
