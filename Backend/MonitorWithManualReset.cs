using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p00_Backend
{
    static class SharedResource2
    {
        public static object LockObject = new object();
        public static Queue<int> Buffer = new Queue<int>();
        public const int BufferCapacity = 5; //maximum capacity of the buffer (queue)

        public static ManualResetEvent ProducerEvent = new ManualResetEvent(true);
        public static ManualResetEvent ConsumerEvent = new ManualResetEvent(false);

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

    class Producer3
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
                        SharedResource2.ProducerEvent.Reset(); //Sets the state of producer event to "unsignaled"
                    }

                    
                }

                SharedResource2.ProducerEvent.WaitOne(); //Waits until the producer event is set to "signaled"

                lock (SharedResource2.LockObject)
                {
                    SharedResource2.Buffer.Enqueue(i);
                    Console.WriteLine($"Producer produced: {i}");

                    SharedResource2.Print();

                    SharedResource2.ConsumerEvent.Set(); //Sets the consumer event state as "signaled". It makes-up the consumer thread
                }

                

            }


            Console.WriteLine($"Production Completed");


            Console.WriteLine($"Production Completed");
        }
    }
    class Consumer3
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
                        SharedResource2.ConsumerEvent.Reset(); //Set the consumer event as "unsignaled"
                    }
                }

                SharedResource2.ConsumerEvent.WaitOne();
                Console.WriteLine("Consumer: Processing Data");
                Thread.Sleep(2500);

                lock (SharedResource.LockObject)
                {
                    int val = SharedResource.Buffer.Dequeue();
                    Console.WriteLine($"Consumer consumed: {val}");

                    //Signal the producer that there is a space in the buffer
                    SharedResource2.ProducerEvent.Set();
                }
            }







            Console.WriteLine($"Consumption Completed");
        }
    }
    internal class MonitorWithManualReset
    {
        public static void Execute()
        {
            //create objects of Producer and Consumer types
            Producer3 producer = new Producer3();
            Consumer3 consumer = new Consumer3();

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
