using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class Publisher
    {
        //private MyDelegateType myDelegate;

        public event MyDelegateType myEvent;
        /*
        {
            add
            {
                myDelegate += value;
            }
            remove
            {
                myDelegate -= value;
            }
            
        }
        */

        //public void RaiseEvent(double a, double b)
        //{
        //    if (this.myDelegate != null) //one or more methods have been subscribded to the event
        //    {
        //        this.myDelegate(a, b);
        //    }
        //}

        public void RaiseEvent(double a, double b)
        {
            if (this.myEvent != null) //one or more methods have been subscribded to the event
            {
                this.myEvent(a, b);
            }
        }
    }
}
