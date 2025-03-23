using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Template.StrategyPattern
{
   public class BeverageMaker
    {
        private Beverage _beverage;

        public BeverageMaker(Beverage beverage) { 
            
            _beverage = beverage;
        }
        public void SetBeverage(Beverage beverage) { 
            
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            // Common operations
            BoilWater();
            PourIntoCup();

            // Unique operations
            _beverage.Prepare();

        }
        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        private void PourIntoCup()
        {
            Console.WriteLine("Pouring boiled water into cup");
        }
    }
}
