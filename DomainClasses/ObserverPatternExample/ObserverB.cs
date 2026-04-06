using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.ObserverPatternExample
{
    public  class ObserverB : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"ObserverB received message: {message}");
        }
    }
}
