using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Template.TemplatePattern
{
    public class Camomile : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brew camomile for a 3 mins");
        }
    }
}
