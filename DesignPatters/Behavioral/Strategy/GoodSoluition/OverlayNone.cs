using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Strategy.GoodSoluition
{
    class OverlayNone : IOverlays
    {
        public void Apply()
        {
            Console.WriteLine("Applying blur none");
        }
    }
}
