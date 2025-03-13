using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OopPrinciples.Polymorphism
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping");
        }

    }
}
