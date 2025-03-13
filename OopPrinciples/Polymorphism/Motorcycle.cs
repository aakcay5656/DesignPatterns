using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OopPrinciples.Polymorphism
{
    class Motorcycle : Vehicle
    {
        public int numberOfWheels { get; set; }

        public override void Start()
        {
            Console.WriteLine("Motorcycle is Starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle is Stopping");
        }
    }
}
