using System.Diagnostics;
using CSharpCodeExamples.Codility.Exercises;
using DomainClasses;
using SchoolDomain_Class_Library;
using ServiceLayer_Class_Library;

// Optional
using System.Threading;
using p00_Backend;

namespace Backend;

class Shared
{
    public static int SharedResource { get; set; }
    public static readonly object lockObject = new object();
}

//create a custom class to replace object? and pass more than one parameter/value
class MaxCount
{
    public int Count { get; set; }
}

class NumbersUpCounter
{
    public int Count { get; set; }
    public void CountUp()
    {
        try
        {
            Console.WriteLine("CountUp Started");
            for (int i = 1; i <= Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"i = {i},");
                //Thread.Sleep(3); 
            }
            Console.WriteLine("CountUp Completed");

        }
        catch (ThreadInterruptedException ex)
        {

            Console.WriteLine($"CountUp Thread Interrupted: {ex.Message}");
        }
    }

    public void CountUp(Action<long> callback)
    {
        long sum = 0;
        try
        {
            Console.WriteLine("CountUp Started");
            for (int i = 1; i <= Count; i++)
            {
                sum += i;
                
                //Monitor.Enter(Shared.lockObject);
                lock (Shared.lockObject)
                {
                    Shared.SharedResource++;
                    Console.WriteLine($"Shared Resource before increment: {Shared.SharedResource}");
                } 
                //Monitor.Exit(Shared.lockObject);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"i = {i},");
                //Thread.Sleep(3); 
            }
            Console.WriteLine("CountUp Completed");

        }
        catch (ThreadInterruptedException ex)
        {

            Console.WriteLine($"CountUp Thread Interrupted: {ex.Message}");
        }
        finally
        {
            callback(sum);
        }
    }

}

class NumbersDownCounter
{
    public int Count { get; set; }
    public void CountDown()
    {
        Console.WriteLine("CountDown Started");
        for (int? j = Count; j >= 1; j--)
        {
            

            //Monitor.Enter(Shared.lockObject);
            lock (Shared.lockObject)
            {
                Shared.SharedResource--;
                Console.WriteLine($"Shared Resource before decrement: {Shared.SharedResource}");
            }   
            //Monitor.Exit(Shared.lockObject);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"j = {j},");
            //Thread.Sleep(3);
        }
        Console.WriteLine("CountDown Completed");
    }
}

class NumbersCounter
{
    public void CountUp()
    {
        try
        {
            Console.WriteLine("CountUp Started");
            for (int i = 1; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"i = {i},");
                //Thread.Sleep(3); 
            }
            Console.WriteLine("CountUp Completed");

        }
        catch (ThreadInterruptedException ex)
        {

            Console.WriteLine($"CountUp Thread Interrupted: {ex.Message}");
        }  
    }
    public void CountUp(int count)
    {
        try
        {
            Console.WriteLine("CountUp Started");
            for (int i = 1; i <= count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"i = {i},");
                //Thread.Sleep(3); 
            }
            Console.WriteLine("CountUp Completed");

        }
        catch (ThreadInterruptedException ex)
        {

            Console.WriteLine($"CountUp Thread Interrupted: {ex.Message}");
        }  
    }
    public void CountUp(object? count)
    {
        try
        {
            Console.WriteLine("CountUp Started");
            int? countInt = (int?)count;
            for (int i = 1; i <= countInt; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"i = {i},");
                //Thread.Sleep(3); 
            }
            Console.WriteLine("CountUp Completed");

        }
        catch (ThreadInterruptedException ex)
        {

            Console.WriteLine($"CountUp Thread Interrupted: {ex.Message}");
        }  
    }


    public void CountDown()
    {
        Console.WriteLine("CountDown Started");
        for (int j = 100; j >= 1; j--)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"j = {j},");
            //Thread.Sleep(3);
        }
        Console.WriteLine("CountDown Completed");
    }
    public void CountDown(int count)
    {
        Console.WriteLine("CountDown Started");
        for (int j = count; j >= 1; j--)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"j = {j},");
            //Thread.Sleep(3);
        }
        Console.WriteLine("CountDown Completed");
    }
    public void CountDown(object? count)
    {
        Console.WriteLine("CountDown Started");
        int countInt = (int?)count ?? 0;
        for (int? j = countInt; j >= 1; j--)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"j = {j},");
            //Thread.Sleep(3);
        }
        Console.WriteLine("CountDown Completed");
    }
}

class Program
{
    static List<Guid> instructorIds;
    static int maxInstructors = 12;
    static List<Guid> courseIds;
    static int maxCourses = 50;
    static List<Guid> studentIds;
    static int maxStudents = 1000;

    //static async Task Main(string[] args)
    public static void Main(string[] args)
    {
        #region B4


        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main thread";
            Console.WriteLine(mainThread.Name);

            ThreadPriority threadPriority = mainThread.Priority;
            mainThread.Priority = ThreadPriority.Normal;
            Console.WriteLine(threadPriority.ToString());
            Console.WriteLine(mainThread.IsAlive);
            Console.WriteLine(mainThread.IsBackground); // if true, it will not block the process from terminating
            System.Threading.ThreadState threadState = mainThread.ThreadState;
            Console.WriteLine(threadState.ToString());

        }

        {
            // Single Threaded Execution: First CountUp, then CountDown
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main thread";
            Console.WriteLine(mainThread.Name);

            // Object of NumbersCounter
            NumbersCounter numbersCounter = new NumbersCounter();

            // Invoke CountUp
            numbersCounter.CountUp();

            // Invoke CountDown
            numbersCounter.CountDown();

            Console.WriteLine(mainThread.Name + " completed");
        }

        {
            // Single Threaded Execution: First CountUp, then CountDown
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main thread";
            Console.WriteLine(mainThread.Name);

            // Object of NumbersCounter
            NumbersCounter numbersCounter = new NumbersCounter();

            // Create Thread for CountUp
            ThreadStart countUpThreadStart = new ThreadStart(numbersCounter.CountUp);
            Thread countUpThread = new Thread(countUpThreadStart);
            countUpThread.Name = "CountUp thread";
            countUpThread.Priority = ThreadPriority.Highest;
            Console.WriteLine($"CountUp thread is {countUpThread.ThreadState.ToString()}"); // Unstarted

            // Invoke CountUp
            countUpThread.Start();
            Console.WriteLine($"{countUpThread.Name} ({countUpThread.ManagedThreadId}) thread is {countUpThread.ThreadState.ToString()}"); // Running

            // Create Thread for CountDown
            ThreadStart countDownThreadStart = new ThreadStart(numbersCounter.CountDown);
            Thread countDownThread = new Thread(countDownThreadStart)
            {
                Name = "CountDown thread",
                Priority = ThreadPriority.Lowest
            };
            Console.WriteLine($"CountDown thread is {countDownThread.ThreadState.ToString()}"); // Unstarted

            // Invoke CountDown
            countDownThread.Start();
            Console.WriteLine($"CountDown thread is {countDownThread.ThreadState.ToString()}"); // Running

            //countUpThread.Interrupt()

            // Wait for both threads to complete
            countUpThread.Join();
            countDownThread.Join();

            Console.WriteLine(mainThread.Name + " completed");
        }
        {
            // Single Threaded Execution: First CountUp, then CountDown
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main thread";
            Console.WriteLine(mainThread.Name);

            // Object of NumbersCounter
            NumbersCounter numbersCounter = new NumbersCounter();

            // Create Thread for CountUp
            ThreadStart countUpThreadStart = new ThreadStart(() => {
                numbersCounter.CountUp(100); // Invoke CountUp with parameter
            });
            // or but you have to give the parameter value to countUpThread.Start(100);
            ParameterizedThreadStart parameterizedCountUpThreadStart = new ParameterizedThreadStart(numbersCounter.CountUp);
            Thread countUpThread = new Thread(countUpThreadStart);
            countUpThread.Name = "CountUp thread";
            countUpThread.Priority = ThreadPriority.Highest;
            Console.WriteLine($"CountUp thread is {countUpThread.ThreadState.ToString()}"); // Unstarted

            // Invoke CountUp
            countUpThread.Start();
            Console.WriteLine($"{countUpThread.Name} ({countUpThread.ManagedThreadId}) thread is {countUpThread.ThreadState.ToString()}"); // Running

            // Create Thread for CountDown
            ThreadStart countDownThreadStart = new ThreadStart(() => {
                numbersCounter.CountDown(100); // Invoke CountDown with parameter
            });
            // or but you have to give the parameter value to countDownThread.Start(100);
            ParameterizedThreadStart parameterizedCountDownThreadStart = new ParameterizedThreadStart(numbersCounter.CountDown);

            Thread countDownThread = new Thread(countDownThreadStart)
            {
                Name = "CountDown thread",
                Priority = ThreadPriority.Lowest
            };
            Console.WriteLine($"CountDown thread is {countDownThread.ThreadState.ToString()}"); // Unstarted

            // Invoke CountDown
            countDownThread.Start();
            Console.WriteLine($"CountDown thread is {countDownThread.ThreadState.ToString()}"); // Running

            //countUpThread.Interrupt()

            // Wait for both threads to complete
            countUpThread.Join();
            countDownThread.Join();

            Console.WriteLine(mainThread.Name + " completed");
        }
        {
            // Single Threaded Execution: First CountUp, then CountDown
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main thread";
            Console.WriteLine(mainThread.Name);

            // Object of NumbersUpCounter
            NumbersUpCounter numbersUpCounter = new NumbersUpCounter()
            {
                Count = 100
            };

            // Create Thread for CountUp
            ThreadStart countUpThreadStart = new ThreadStart(numbersUpCounter.CountUp);
            Thread countUpThread = new Thread(countUpThreadStart);
            countUpThread.Name = "CountUp thread";
            countUpThread.Priority = ThreadPriority.Highest;
            Console.WriteLine($"CountUp thread is {countUpThread.ThreadState.ToString()}"); // Unstarted

            // Invoke CountUp
            countUpThread.Start();
            Console.WriteLine($"{countUpThread.Name} ({countUpThread.ManagedThreadId}) thread is {countUpThread.ThreadState.ToString()}"); // Running

            // Object of NumbersDownCounter
            NumbersDownCounter numbersDownCounter = new NumbersDownCounter()
            {
                Count = 100
            };

            // Create Thread for CountDown
            ThreadStart countDownThreadStart = new ThreadStart(numbersDownCounter.CountDown);


            Thread countDownThread = new Thread(countDownThreadStart)
            {
                Name = "CountDown thread",
                Priority = ThreadPriority.Lowest
            };
            Console.WriteLine($"CountDown thread is {countDownThread.ThreadState.ToString()}"); // Unstarted

            // Invoke CountDown
            countDownThread.Start();
            Console.WriteLine($"CountDown thread is {countDownThread.ThreadState.ToString()}"); // Running

            //countUpThread.Interrupt()

            // Wait for both threads to complete
            countUpThread.Join();
            countDownThread.Join();

            Console.WriteLine(mainThread.Name + " completed");
        }
        #endregion


        {
            // Single Threaded Execution: First CountUp, then CountDown
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main thread";
            Console.WriteLine(mainThread.Name);

            // Object of NumbersUpCounter
            NumbersUpCounter numbersUpCounter = new NumbersUpCounter()
            {
                Count = 100
            };

            //Create callback method
            Action<long> callback = sum => {
                Console.WriteLine($"Return value from CountUp Thread is: {sum}");
            };


            // Create Thread for CountUp
            ThreadStart countUpThreadStart = new ThreadStart(() => {
                numbersUpCounter.CountUp(callback);
            });
            Thread countUpThread = new Thread(countUpThreadStart);
            countUpThread.Name = "CountUp thread";
            countUpThread.Priority = ThreadPriority.Highest;
            Console.WriteLine($"CountUp thread is {countUpThread.ThreadState.ToString()}"); // Unstarted

            
            

            // Invoke CountUp
            countUpThread.Start();
            Console.WriteLine($"{countUpThread.Name} ({countUpThread.ManagedThreadId}) thread is {countUpThread.ThreadState.ToString()}"); // Running

            // Object of NumbersDownCounter
            NumbersDownCounter numbersDownCounter = new NumbersDownCounter()
            {
                Count = 100
            };

            // Create Thread for CountDown
            ThreadStart countDownThreadStart = new ThreadStart(numbersDownCounter.CountDown);


            Thread countDownThread = new Thread(countDownThreadStart)
            {
                Name = "CountDown thread",
                Priority = ThreadPriority.Lowest
            };
            Console.WriteLine($"CountDown thread is {countDownThread.ThreadState.ToString()}"); // Unstarted

            // Invoke CountDown
            countDownThread.Start();
            Console.WriteLine($"CountDown thread is {countDownThread.ThreadState.ToString()}"); // Running

            //countUpThread.Interrupt()

            // Wait for both threads to complete
            countUpThread.Join();
            countDownThread.Join();

            Console.WriteLine($"Final value of Shared Resource is: {Shared.SharedResource}");

            Console.WriteLine(mainThread.Name + " completed");
        }

        ThreadsDemo.RunDemo();





        List<int> intList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var evenNumbers = intList.Where(n => n % 2 == 0).ToList();

        Console.WriteLine(evenNumbers.ToString());

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        int option = -1;


        do
        {
            MainMenu();
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CodilityMenu();
                    Exercise1_2015Contest.LongestPassword();
                    break;

                /*
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
                */
            }

        }
        while (option != 0);



        Console.WriteLine("Thank you! Have a nice day!");

        //Demo();
    }

    public static void Method1()
    {
        Console.WriteLine("Method 1 called");
    }

    public static void MainMenu()
    {
        Console.WriteLine("Main Menu:");
    }

    public static void CodilityMenu()
    {
        Console.WriteLine("1. Run Codility Exercises");
    }

    public static void Demo()
    {
        //Console.OutputEncoding = System.Text.Encoding.ASCII;
        //System.Text.Encoding.ASCII.GetBytes("Something");

        char ch = 'A';
        byte by = (byte)ch;
        ch = (char)by;


        int dec1 = 13;
        string binary1 = Convert.ToString(dec1, 2);
        Console.WriteLine(binary1);

        int dec2 = Convert.ToInt32(binary1, 2);

        Console.WriteLine(0b1100100);

        string hex1 = Convert.ToString(dec1, 16);

        int dec3 = Convert.ToInt32(binary1, 16);

        int dec4 = 0x64;


        Task.Delay(1000).Wait();

        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main thread";
        mainThread.Priority = ThreadPriority.Normal;
        Console.WriteLine(mainThread.Name);
        Console.WriteLine(mainThread.IsAlive);
        Console.WriteLine(mainThread.IsBackground);
        Console.WriteLine(mainThread.ThreadState);

        Stopwatch sw = new Stopwatch();
        sw.Start();
        Thread.Sleep(15);
        sw.Stop();
        long timeTakenForTasks = sw.ElapsedMilliseconds;
        Console.WriteLine($"Time Taken: {timeTakenForTasks}");

        System.Console.ForegroundColor = ConsoleColor.Red;

        Random r = new Random();
        Thread.Sleep(100 * r.Next(2, 5));


        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();
        publisher.myEvent += subscriber.MethodToBeExecutedAfterThePublisherClassRaisesEvent;
        publisher.RaiseEvent(10, 20);

        List<int> numbers = [10, 20, 30];
        int[] quantities = [10, 20, 15];

        List<string> myFriends = new List<string>() { "Scott", "Allen", "Jones", "James" };
        var index = ^1;
        Console.WriteLine(myFriends[index]);
        Console.WriteLine(myFriends[1..3]);
        myFriends.Skip(1).Take(1);

        string jsonStr = """
            {
                "name": "John Doe",
                "age": 35
            }
            """;
        Console.WriteLine(jsonStr);

        int[] values = { 10, 20, 50 };

        bool b2 = values is [10, < 25, 50 or 100];

        bool bk = new List<int> { 10, 20, 50 } is [10, _, < 50 or 100];
        Console.WriteLine(new List<int> { 10, 15, 18, 20, 50 } is [10, .., < 25, 50 or 100]);

        Console.WriteLine(new List<int>() { 10, 20, 50 } is [10, var b, var c] && c > b);

        var v = "something";

        dynamic whatever = "something";
        whatever = 5;

        //using MyClassAlieas = Namspace1q.Namespace2.Class1;
        //using ProductInfo = (string Name, decimal Price, int Stock);
        //using NullableString = string?;
        //using StringList = System.Collections.Generic.List<string>;
        //locals but can be global on GlobalUsings

        /*
        if (File.Exists(args[0])) { }
        else
        { }
        */
        //Console.WriteLine(args.Length);
        Console.WriteLine("From Main");

        var getMessage = () => "Hello World";
        Func<int, object> getResult = object (int marks) =>
        {
            if (marks >= 35) return "Pass";
            else return 0;
        };

        var GetNumbers = IList<int> () => new int[] { 10, 20, 30 };
        var result = GetNumbers();

        /*
        var service = new SchoolService();
        service.Controller("CreateStudent", new string[] { "1", "Bob Smith", "0" });
        service.Controller("CreateInstructor", new string[] { "1", "Prof. Martin" });
        service.Controller("CreateCourse", new string[] { "1", "Algebra", "3" });
        service.Controller("AddStudentToCourse", new string[] { "1", "1" });
        service.Controller("AddInstructorToCourse", new string[] { "1", "1" });
        //Console.WriteLine(StudentCourse.StudentCourses.Count);
        service.Controller("AddStudentGrade", new string[] { "1", "1", "A" });

        Student student = (Student) service.Controller("GetStudent", new string[] { "1" });
        ShowStudentInfo(student);
        Student student2 = (Student)service.Controller("GetStudent", new string[] { "2" });
        ShowStudentInfo(student2);
        */
        var service = new SchoolService();

        CreateLotsofData();
        service.Controller("PersistData", new string[] { });
        service.Controller("addstudenttocourse", new string[] { studentIds[100].ToString(), courseIds[12].ToString() });

        service.Controller("LoadData", new string[] { });
    }

    static void ShowStudentInfo(Student student)
    {
        if (student == null) Console.WriteLine("Student not found");
        else
        {
            Console.WriteLine($"Student Id: {student.Id}");
            Console.WriteLine($"Student Name:  {student.Name}");
            Console.WriteLine($"Student GPA: {student.Name}");
        }

        try
        {
            Console.WriteLine($"Finished with {student.Name}");
        }
        catch (NullReferenceException nullRexEx) // when (condition)
        {

            Console.WriteLine($"No student found: {nullRexEx.Message}");
        }
        catch (Exception e)
        {

            Console.WriteLine($"Some exception was found: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Closing everything down");
        }
    }

    private static void CreateLotsofData()
    {
        instructorIds = new List<Guid>();
        courseIds = new List<Guid>();
        studentIds = new List<Guid>();

        var service = new SchoolService();

        for (int i = 0; i < maxInstructors; i++)
        {
            var id = (Guid) service.Controller("CreateInstructor", new string[] { $"Test Instructor {i}" });
            instructorIds.Add(id);
        }

        for (int i = 0; i < maxCourses; i++)
        {
            var id = (Guid) service.Controller("CreateCourse", new string[] { $"Test Course {i}", "3" });
            courseIds.Add(id);
        }

        for (int i = 0; i < maxStudents; i++)
        {
            var id = (Guid) service.Controller("CreateStudent", new string[] { $"Test Student{i}", "0" });
            studentIds.Add(id);
        }

    }
    
}