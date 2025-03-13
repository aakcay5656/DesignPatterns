using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OopPrinciples.Coupling
{
    class EmailSender : INotificationServices
    {

        public void SendNotification(string message)
        {
            Console.WriteLine("Email sent: " + message);

        }
    }
}
