using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.D
{
    public class Car
    {

        private IEngine engine;

        public Car (IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started");
        }
    }
}
