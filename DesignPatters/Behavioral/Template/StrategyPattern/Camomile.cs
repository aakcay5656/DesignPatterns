using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Template.StrategyPattern
{
    class Camomile : Beverage
    {
        public void Prepare()
        {
            Brew();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing for 3 mins");
        }

    }
}
