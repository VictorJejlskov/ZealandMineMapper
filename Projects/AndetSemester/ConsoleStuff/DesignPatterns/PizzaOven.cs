using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    class PizzaOven : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private Random rnd = new Random();
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void PreparePizza(AbstractPizza pi)
        {
            Task.Factory.StartNew(() =>
            {
                int prepareTime = rnd.Next(5, 15);
                System.Threading.Thread.Sleep(prepareTime * 500);
                NotifyObservers(pi);
            });
        }

        private void NotifyObservers(AbstractPizza pi)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(pi);
            }
        }
    }
}
