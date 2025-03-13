using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OopPrinciples.Coupling
{
    class Order
    {
        private readonly INotificationServices notificationServices;

        public Order (INotificationServices notificationServices)
        {
            this.notificationServices = notificationServices;
        }


        public void PlaceOrder()
        {
            notificationServices.SendNotification("Order placed successfuly.");
        }
    }
}
