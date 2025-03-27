using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Observer
{
   public class Sheet2
    {
        private int _total;

        public int GetTotal() {  
            return _total; 
        }

        public int CalculateTotal(List<int> values) { 
            var sum = 0;
            foreach (var value in values) {
                sum += value;
            }

            Console.WriteLine($"Total: {sum}");
            return sum;
        }
    }
}
