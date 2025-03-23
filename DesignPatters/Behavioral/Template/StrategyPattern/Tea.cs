using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Template.StrategyPattern
{
    public class Tea : Beverage
    {
        public void Prepare()
        {
           
            Brew();
            AddCondiments();
        }

      

        private void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes");
        }

        private void AddCondiments()
        {

            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding lemon to the tea");
            }
        }

        private bool CustomerWantsCondiments()
        {

            Console.WriteLine("Would you like lemon with your tea (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}
