using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.I
{
    class Sphere : IShape3D
    {
        public double Radius { get; set; }

        public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double Valume()
        {
            return (4.0D / 3.0D)* Math.PI* Math.Pow(Radius, 3);
        }


    }
}
