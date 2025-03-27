using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Observer.GoodExample
{
    public class Subject
    {
        private List<Observer> _observers = new List<Observer>();
        
        public void AddObserver(Observer observer) {  _observers.Add(observer); }

        public void RemovedObserver(Observer observer) { _observers.Remove(observer); }

        public void NotifyObserver()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();

            }
        }
    }
}
