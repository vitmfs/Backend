using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.ObserverPatternExample
{
    public  class ObserverC : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"ObserverC received message: {message}");
        }
    }
}
