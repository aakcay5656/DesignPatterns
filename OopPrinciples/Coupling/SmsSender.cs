using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OopPrinciples.Coupling
{
    class SMSsender : INotificationServices
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS message: {message}");
        }
    }
}
