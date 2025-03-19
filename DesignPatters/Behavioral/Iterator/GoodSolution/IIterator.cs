using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Iterator.GoodSolution
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        T Current();


    }
}
