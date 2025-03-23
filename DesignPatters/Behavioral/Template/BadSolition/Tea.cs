using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Template.BadSolition
{
    public class Tea
    {

        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondiment();
        }
        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourWaterIntoCup()
        {
            Console.WriteLine("Pouring water into cup");
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes");
        }

        private void AddCondiment() {

            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding lemon to the tea");
            }
        }

        private bool CustomerWantsCondiments() {

            Console.WriteLine("Would you like lemon with your tea (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}
