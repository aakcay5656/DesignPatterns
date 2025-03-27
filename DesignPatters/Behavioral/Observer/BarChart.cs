using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Observer
{
    public class BarChart
    {
        public void Render(List<int> values)
        {
            Console.WriteLine("Rendering bar chart with new values");
        }

    }
}
