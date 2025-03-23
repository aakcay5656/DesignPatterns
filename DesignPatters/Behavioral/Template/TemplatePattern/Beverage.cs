using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Template.TemplatePattern
{
   public abstract class Beverage
    {
        
        public void Prepare()
        {
            BoilWater();
            PourIntoCup();
            Brew();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        private void PourIntoCup()
        {
            Console.WriteLine("Pouring boiled water into cup");
        }

        protected abstract void Brew();

        protected virtual void AddCondiments() {}

    }


}
