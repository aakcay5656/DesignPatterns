using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Observer
{
    public class DataSource
    {
        private List<int> _values = new List<int>();
        private List<Object> _dependents = new List<Object>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values) {
            
            _values = values;

            foreach ( var depedent in _dependents)
            {
                if (depedent is Sheet2)
                {
                    (depedent as Sheet2).CalculateTotal(_values);
                }
                else if(depedent is BarChart) {
                    (depedent as BarChart).Render(_values);
                }
            }
        }

        public void AddDependent(Object dependent) {
            _dependents.Add(dependent);
        }
        public void RemoveDependent(Object dependent) { _dependents.Remove(dependent); }

    }
}
