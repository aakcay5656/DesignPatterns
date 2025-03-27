using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Observer.GoodExample
{
   public class Sheet2: Observer
    {
        private int _total;
        private DataSource _dataSource;

        public Sheet2(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

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

        public void Update()
        {
            _total = CalculateTotal(_dataSource.GetValues());
        }
    }
}
