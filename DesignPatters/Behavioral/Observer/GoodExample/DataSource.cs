using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Observer.GoodExample
{
    public class DataSource : Subject
    {
        private List<int> _values = new List<int>();
        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values) {
            
            _values = values;

            NotifyObserver();
        }


    }
}
