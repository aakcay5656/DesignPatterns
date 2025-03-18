using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.D
{
    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine Started");
        }

    }
}
