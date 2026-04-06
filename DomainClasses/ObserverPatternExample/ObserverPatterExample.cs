using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.ObserverPatternExample
{
    public  class ObserverPatterExample
    {
        public static void RunObserverPatternExample()
        {
            var observableSubject = new MyObservable();

            ObserverA observerA = new ObserverA();
            ObserverB observerB = new ObserverB();
            ObserverC observerC = new ObserverC();

            observableSubject.RegisterObserver(observerA);
            observableSubject.RegisterObserver(observerB);
            observableSubject.RegisterObserver(observerC);

            observableSubject.NotifyObservers();

            observableSubject.RegisterObserver(observerB);

            observableSubject.NotifyObservers();

        }
    }
}
