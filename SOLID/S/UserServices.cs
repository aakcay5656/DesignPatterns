using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.S
{
    class UserServices
    {

        public void Register(User user)
        {
            // Register user logic

            // Send email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our platform");

        }
    }
}
