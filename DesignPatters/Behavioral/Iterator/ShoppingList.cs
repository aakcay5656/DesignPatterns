using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Iterator
{
    public class ShoppingList
    {
        private List<string> _list = new List<string>();

        public void Push(string item)
        {
            _list.Add(item);
        }

        public string Pop() 
        {
            var last = _list.Last();
            _list.Remove(last);

            return last;
        }
        public List<string> GetList() { return _list; }
    }
}
