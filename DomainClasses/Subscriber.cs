﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class Subscriber
    {
        public void MethodToBeExecutedAfterThePublisherClassRaisesEvent(double a, double b)
        {
            Console.WriteLine(a + b);
        }
    }
}
