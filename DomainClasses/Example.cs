namespace DomainClasses
{ 

    public class Example: IDisposable
    {
        static void Work()
        {
            using Example s = new Example();
            s.DoSomething();


            MyDelegateType myDelegate;

            //myDelegate = new MyDelegateType(s.Add);
            myDelegate = s.Add;
            myDelegate += s.Multiply;

            myDelegate.Invoke(40, 10);


        }
        public Example()
        {
            //file and db connection logic here
            Console.WriteLine("Constructor has been called");
            
        }

        

        public void Dispose()
        {
            /*
            using (Example e = new Example())
            {
                e.DoSomething();
            }
             */
            //Close unmanaged resources here
            Console.WriteLine("Dispose has been called");
        }

        public void DoSomething()
        {
            Console.WriteLine("Do Something!");
        }

        public void Add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine(c);
        }

        public void Multiply(double a, double b)
        {
            double c = a * b;
            Console.WriteLine(c);
        }





        ~Example()
        {
            //file and db closing logic here
            Console.WriteLine("Destructor has been called");
        }

    }
}
