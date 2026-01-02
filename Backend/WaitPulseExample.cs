using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p00_Backend
{
    static class SharedResource
    {
        public static object LockObject = new object();
        public static Queue<int> Buffer = new Queue<int>();
        public const int BufferCapacity = 5; //maximum capacity of the buffer (queue)

        public static void Print()
        {
            //O/P: Buffer: 1, 2, 3, 4, 5
            Console.Write("Buffer: ");
            foreach (var item in Buffer)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

    }

    class Producer2
    {
        public void Produce()
        {
            Console.WriteLine($"Producer: Generating data");

            for (int i = 1; i <= 10; i++)
            {
                lock (SharedResource.LockObject)
                {
                    Console.WriteLine("Producer: Generating data");
                    Thread.Sleep(7);

                    if (SharedResource.Buffer.Count == SharedResource.BufferCapacity)
                    {
                        Console.WriteLine("Buffer is full, Wainting for signal from consumer");
                        Monitor.Wait(SharedResource.LockObject); //wait for signal from consumer thread
                    }
                    SharedResource.Buffer.Enqueue(i);
                    Console.WriteLine($"Producer produced: {i}");

                    SharedResource.Print();

                    Monitor.Pulse(SharedResource.LockObject); //signal the consumer that data is available
                }
                
            }

            
            Console.WriteLine($"Production Completed");


            Console.WriteLine($"Production Completed");
        }
    }
    class Consumer2
    {
        public void Consume()
        {
            Console.WriteLine($"Consumer: Consumer Started");

            for (int i = 0; i < SharedResource.BufferCapacity; i++)
            {
                lock (SharedResource.LockObject)
                {
                    if (SharedResource.Buffer.Count == 0)
                    {
                        Console.WriteLine($"Consumer: Buffer is empty, waiting for signal from producer");
                        Monitor.Wait(SharedResource.LockObject);
                    }
                }

                Thread.Sleep(2500);

                lock (SharedResource.LockObject)
                {
                    int val = SharedResource.Buffer.Dequeue();
                    Console.WriteLine($"Consumer consumed: {val}");

                    //Signal the producer that there is a space in the buffer
                    Monitor.Pulse(SharedResource.LockObject);
                }
            }

            

            
            


            Console.WriteLine($"Consumption Completed");
        }
    }

    internal class WaitPulseExample
    {
        public static void Execute()
        {
            //create objects of Producer and Consumer types
            Producer2 producer = new Producer2();
            Consumer2 consumer = new Consumer2();

            //Create objects of Thread class
            Thread producerThread = new Thread(producer.Produce)
            {
                Name = "Producer Thread"
            };
            Thread consumerThread = new Thread(consumer.Consume)
            {
                Name = "Consumer Thread"
            }; ;

            //Start threads
            producerThread.Start();
            consumerThread.Start();

            //Join
            producerThread.Join();
            consumerThread.Join();

            Console.ReadKey();
        }
    }
}
