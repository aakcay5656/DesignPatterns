using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OopPrinciples.Polymorphism
{
    class Car : Vehicle
    {
        public int numberOfWheels { get; set; }
        public int numberOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine("Car is Starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is Stopping");
        }
    }
}
