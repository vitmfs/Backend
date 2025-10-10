using System.Diagnostics;
using DomainClasses;
using SchoolDomain_Class_Library;
using ServiceLayer_Class_Library;

namespace Backend;

class Program
{
    static List<Guid> instructorIds;
    static int maxInstructors = 12;
    static List<Guid> courseIds;
    static int maxCourses = 50;
    static List<Guid> studentIds;
    static int maxStudents = 1000;

    //static async Task Main(string[] args)
    static void Main(string[] args)
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
        Console.WriteLine(args.Length);
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