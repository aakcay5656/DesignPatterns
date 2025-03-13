using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OopPrinciples.Abstraction
{
    class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authentication();
            Console.WriteLine("Send Email .... ");
            Disconnect();
        }

        private void Connect()
        {
            Console.WriteLine("Connect .... ");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnect .... ");
        }

        private void Authentication()
        {
            Console.WriteLine("Authentication .... ");
        }

    }
}
