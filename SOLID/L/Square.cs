using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.L
{
    class Square : Shape
    {
        
        public double sideLength { get; set; }

        public override double Area => sideLength * sideLength;
    }
}
