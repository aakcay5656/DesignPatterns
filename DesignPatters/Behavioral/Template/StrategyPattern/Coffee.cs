using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Template.StrategyPattern
{
    public class Coffee : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing coffee for 5 minutes");
        }

        private void AddCondiments()
        {

            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding creaam to the coffee");
            }
        }

        private bool CustomerWantsCondiments()
        {

            Console.WriteLine("Would you like cream with your coffee (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}
