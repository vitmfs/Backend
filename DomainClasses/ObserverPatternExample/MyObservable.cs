using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.ObserverPatternExample
{
    public  class MyObservable : IObservable
    {
        private IList<IObserver> _observers = new List<IObserver>();
        private string _state;

        public string State
        {
            get => _state;
            set
            {
                if (_state != value)
                {
                    _state = value;
                    NotifyObservers();
                }
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                Console.WriteLine($"Observer registered: {observer.GetType().Name}");
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
                Console.WriteLine($"Observer removed: {observer.GetType().Name}");
            }
        }

        public void NotifyObservers()
        {
            Console.WriteLine($"Notifying observers of new sate {_state}");
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }



    }
}
