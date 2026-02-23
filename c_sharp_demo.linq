<Query Kind="Program">
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

using System;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;
using System.Numerics;
using static System.Math;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using static System.Linq.Expressions.Expression;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
//using Excel = Microsoft.Office.Interop.Excel;
//using Word = Microsoft.Office.Interop.Word;
//using Excel = Microsoft.Office.Interop.Excel;
//using Word = Microsoft.Office.Interop.Word;
//namespace GlobalNamespace;
//using Newtonsoft.Json;

namespace ProgramNamespace
{ 
    
    public class Program { 
        
		//static void Main() { }
		//static int Main() { }
		//static void Main(string[] args) { }
		//static int Main(string[] args) { }
		//static async Task Main() { }
		//static async Task<int> Main() { }
		//static async Task Main(string[] args) { }
		//static async Task<int> Main(string[] args) { }
        static void Main(string[] args)
		{ 
            Console.WriteLine("PROGRAM STARTED!");
			Debug.WriteLine("PROGRAM STARTED!");
			 
			if (args != null)
			{
				Console.WriteLine(args.Length);
				
				if (args.Length > 0)
				{
				    foreach (var arg in args)
				    {
				        Console.WriteLine($"Argument={arg}");
				    }
				}
				else
				{
				    Console.WriteLine("No arguments");
				}
			}
			
			int a = 5;
			int b = a + 2; //OK
			
			bool test = true;
			
			// Declaration only:
			float temperature;
			string name;
			DotnetCSharpFundamentalsProgramStructureTopLevelStatements.MyNamespace.MyClass myClass;
			myClass = new();
			DotnetCSharpFundamentalsProgramStructureTopLevelStatements.MyNamespace.MyClass myClass2 = myClass;
			// Declare and assign using an existing value.
			//IMyInterface myInterface = myClass;
			
			// Or create and assign a value in a single statement.
			//IMyInterface myInterface2 = new MyClass();
			
			// Declaration with initializers (four examples):
			char firstLetter = 'C';
			var limit = 3;
			int[] source = [0, 1, 2, 3, 4, 5];
			var query = from item in source
			            where item <= limit
			            select item;
			
			
			
			// constant field on type byte.
			byte bm = byte.MaxValue;
			
			byte num = 0xA;
			int i = 5;
			char c = 'Z';
			
			// Declare and initialize an array of integers.
			int[] nums = [1, 2, 3, 4, 5];
			
			// Access an instance property of System.Array.
			int len = nums.Length;
			
			string s = "The answer is " + 5.ToString();
			// Outputs: "The answer is 5"
			Console.WriteLine(s);
			
			Type type = 12345.GetType();
			// Outputs: "System.Int32"
			Console.WriteLine(type);
			
			List<string> stringList = new List<string>();
			stringList.Add("String example");
			
			string message = "This is a string of characters";

			object anotherMessage = "This is another string of characters";
			IEnumerable<char> someCharacters = "abcdefghijklmnopqrstuvwxyz";
			
			System.Console.WriteLine("Hello World!");
			
			
			
			//DotnetCSharpFundamentalsProgramStructureMainCommandLine.MainClass.RunMainClass(["5"]);
			//DotnetCSharpFundamentalsProgramStructureTopLevelStatements.SBDemo.StringBuilderDemo(["something"]);
			//DotnetCSharpFundamentalsProgramStructureTopLevelStatements.MyNamespace.MyClass.MyMethod();
			//DotnetCSharpFundamentalsProgramStructureTopLevelStatements.SBDemo.AsyncMethod();
			//DotnetCSharpFundamentalsTypesGenerics.TestGenericList.RunTestGenericList();
			//DotnetCSharpFundamentalsTypesGenerics.GenericList2<int>.RunGenericList2();
			
			
			
			Debug.WriteLine("PROGRAM ENDED!");
			Console.WriteLine("PROGRAM ENDED!");
        }
		
		public static T MidPoint<T>(IEnumerable<T> sequence)
		{
		    if (sequence is IList<T> list)
		    {
		        return list[list.Count / 2];
		    }
		    else if (sequence is null)
		    {
		        throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
		    }
		    else
		    {
		        int halfLength = sequence.Count() / 2 - 1;
		        if (halfLength < 0) halfLength = 0;
		        return sequence.Skip(halfLength).First();
		    }
		}
    }
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
namespace DotnetCSharpProgrammingGuideClassesAndStructsObjectAndCollectionInitializers
{
	public class ClassesAndStructsObjectAndCollectionInitializers
	{
		public static void RunClassesAndStructsObjectAndCollectionInitializers()
		{
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/finalizers
namespace DotnetCSharpProgrammingGuideClassesAndStructsFinalizers
{
	public class ClassesAndStructsFinalizers
	{
		public static void RunClassesAndStructsFinalizers()
		{
			
		}
		
		
	}
	
	class Car
	{
	    ~Car()  // finalizer
	    {
	        // cleanup statements...
	    }
	}
	
	public class Destroyer
	{
	   public override string ToString() => GetType().Name;
	
	   ~Destroyer() => Console.WriteLine($"The {ToString()} finalizer is executing.");
	   
	   /*
	   protected override void Finalize()
		{
		    try
		    {
		        // Cleanup statements...
		    }
		    finally
		    {
		        base.Finalize();
		    }
		}
		*/
	   
	}
	
	class First
	{
	    ~First()
	    {
	        System.Diagnostics.Trace.WriteLine("First's finalizer is called.");
	    }
	}
	
	class Second : First
	{
	    ~Second()
	    {
	        System.Diagnostics.Trace.WriteLine("Second's finalizer is called.");
	    }
	}
	
	class Third : Second
	{
	    ~Third()
	    {
	        System.Diagnostics.Trace.WriteLine("Third's finalizer is called.");
	    }
	}
	
	/* 
	Test with code like the following:
	    Third t = new Third();
	    t = null;
	
	When objects are finalized, the output would be:
	Third's finalizer is called.
	Second's finalizer is called.
	First's finalizer is called.
	*/
	
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
namespace DotnetCSharpProgrammingGuideClassesAndStructsExtensionMethods
{
	public class ClassesAndStructsExtensionMethods
	{
		public static void RunClassesAndStructsExtensionMethods()
		{
			int[] numbers = [10, 45, 15, 39, 21, 26];
			IOrderedEnumerable<int> result = numbers.OrderBy(g => g);
			foreach (int i in result)
			{
			    Console.Write(i + " ");
			}
			//Output: 10 15 21 26 39 45
			
			//string s = "Hello Extension Methods";
			//int i = s.WordCount();
			
			//string s = "Hello Extension Methods";
			//int i = MyExtensions.WordCount(s);
			
			// Declare an instance of class A, class B, and class C.
			A a = new A();
			B b = new B();
			C c = new C();
			
			// For a, b, and c, call the following methods:
			//      -- MethodA with an int argument
			//      -- MethodA with a string argument
			//      -- MethodB with no argument.
			
			/*
			// A contains no MethodA, so each call to MethodA resolves to
			// the extension method that has a matching signature.
			a.MethodA(1);           // Extension.MethodA(IMyInterface, int)
			a.MethodA("hello");     // Extension.MethodA(IMyInterface, string)
			
			// A has a method that matches the signature of the following call
			// to MethodB.
			a.MethodB();            // A.MethodB()
			
			// B has methods that match the signatures of the following
			// method calls.
			b.MethodA(1);           // B.MethodA(int)
			b.MethodB();            // B.MethodB()
			
			// B has no matching method for the following call, but
			// class Extension does.
			b.MethodA("hello");     // Extension.MethodA(IMyInterface, string)
			
			// C contains an instance method that matches each of the following
			// method calls.
			c.MethodA(1);           // C.MethodA(object)
			c.MethodA("hello");     // C.MethodA(object)
			c.MethodB();            // C.MethodB()
			*/
			/* Output:
			    Extension.MethodA(this IMyInterface myInterface, int i)
			    Extension.MethodA(this IMyInterface myInterface, string s)
			    A.MethodB()
			    B.MethodA(int i)
			    B.MethodB()
			    Extension.MethodA(this IMyInterface myInterface, string s)
			    C.MethodA(object obj)
			    C.MethodA(object obj)
			    C.MethodB()
			 */
			 
			 int x = 1;

			// Takes x by value leading to the extension method
			// Increment modifying its own copy, leaving x unchanged
			x.Increment();
			Console.WriteLine($"x is now {x}"); // x is now 1
			
			// Takes x by reference leading to the extension method
			// RefIncrement changing the value of x directly
			x.RefIncrement();
			Console.WriteLine($"x is now {x}"); // x is now 2
			
			Account account = new()
			{
			    id = 1,
			    balance = 100f
			};
			
			Console.WriteLine($"I have ${account.balance}"); // I have $100
			
			account.Deposit(50f);
			Console.WriteLine($"I have ${account.balance}"); // I have $150
			
		}
	}

	public static class MyExtensions
	{
	    extension(string str)
	    {
	        public int WordCount() =>
	            str.Split([' ', '.', '?'], StringSplitOptions.RemoveEmptyEntries).Length;
	    }
	}
	
	public static class MyGenericExtensions
	{
	    extension<T>(IEnumerable<T> source)
	        where T : IEquatable<T>
	    {
	        public IEnumerable<T> ValuesEqualTo(T threshold)
	            => source.Where(x => x.Equals(threshold));
	    }
	}
	
	/*
	public static class MyExtensions2
	{
	    public static int WordCount(this string str) =>
	        str.Split([' ', '.', '?'], StringSplitOptions.RemoveEmptyEntries).Length;
	}
	*/
	
	public interface IMyInterface
	{
	    void MethodB();
	}
	
	// Define extension methods for IMyInterface.
	
	// The following extension methods can be accessed by instances of any
	// class that implements IMyInterface.
	public static class Extension
	{
	    public static void MethodA(this IMyInterface myInterface, int i) =>
	        Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, int i)");
	
	    public static void MethodA(this IMyInterface myInterface, string s) =>
	        Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, string s)");
	
	    // This method is never called in ExtensionMethodsDemo1, because each
	    // of the three classes A, B, and C implements a method named MethodB
	    // that has a matching signature.
	    public static void MethodB(this IMyInterface myInterface) =>
	        Console.WriteLine("Extension.MethodB(this IMyInterface myInterface)");
	}
	
	public static class Extension2
	{
	    extension(IMyInterface myInterface)
	    {
	        public void MethodA(int i) =>
	            Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, int i)");
	
	        public void MethodA(string s) =>
	            Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, string s)");
	
	        // This method is never called in ExtensionMethodsDemo1, because each
	        // of the three classes A, B, and C implements a method named MethodB
	        // that has a matching signature.
	        public void MethodB() =>
	            Console.WriteLine("Extension.MethodB(this IMyInterface myInterface)");
	    }

	}
	
	// Define three classes that implement IMyInterface, and then use them to test
	// the extension methods.
	class A : IMyInterface
	{
	    public void MethodB() { Console.WriteLine("A.MethodB()"); }
	}
	
	class B : IMyInterface
	{
	    public void MethodB() { Console.WriteLine("B.MethodB()"); }
	    public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
	}
	
	class C : IMyInterface
	{
	    public void MethodB() { Console.WriteLine("C.MethodB()"); }
	    public void MethodA(object obj)
	    {
	        Console.WriteLine("C.MethodA(object obj)");
	    }
	}
	
	public class DomainEntity
	{
	    public int Id { get; set; }
	    public required string FirstName { get; set; }
	    public required string LastName { get; set; }
	}
	
	static class DomainEntityExtensions
	{
	    static string FullName(this DomainEntity value)
	        => $"{value.FirstName} {value.LastName}";
	}
	
	static class DomainEntityExtensions2
	{
	    extension(DomainEntity value)
	    {
	        string FullName => $"{value.FirstName} {value.LastName}";
	    }
	}
	
	public static class IntExtensions
	{
	    public static void Increment(this int number)
	        => number++;
	
	    // Take note of the extra ref keyword here
	    public static void RefIncrement(this ref int number)
	        => number++;
	}
	
	/*
	public static class IntExtensions2
	{
	    extension(int number)
	    {
	        public void Increment()
	            => number++;
	    }
	
	    // Take note of the extra ref keyword here
	    extension(ref int number)
	    {
	        public void RefIncrement()
	            => number++;
	    }
	}
	*/
	
	public struct Account
	{
	    public uint id;
	    public float balance;
	
	    private int secret;
	}
	
	public static class AccountExtensions
	{
	    // ref keyword can also appear before the this keyword
	    public static void Deposit(ref this Account account, float amount)
	    {
	        account.balance += amount;
	
	        // The following line results in an error as an extension
	        // method is not allowed to access private members
	        // account.secret = 1; // CS0122
	    }
	}
	
	
	/*
	public static class AccountExtensions2
	{
	    extension(ref Account account)
	    {
	        // ref keyword can also appear before the this keyword
	        public void Deposit(float amount)
	        {
	            account.balance += amount;
	
	            // The following line results in an error as an extension
	            // method is not allowed to access private members
	            // account.secret = 1; // CS0122
	        }
	    }
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-write-a-copy-constructor
namespace DotnetCSharpProgrammingGuideClassesAndStructsHowToWriteACopyConstructor
{
	public class ClassesAndStructsHowToWriteACopyConstructor
	{
		public static void RunClassesAndStructsHowToWriteACopyConstructor()
		{
			
		}
	}
	
	public sealed class Person
	{
	    // Copy constructor.
	    public Person(Person previousPerson)
	    {
	        Name = previousPerson.Name;
	        Age = previousPerson.Age;
	    }
	
	    //// Alternate copy constructor calls the instance constructor.
	    //public Person(Person previousPerson)
	    //    : this(previousPerson.Name, previousPerson.Age)
	    //{
	    //}
	
	    // Instance constructor.
	    public Person(string name, int age)
	    {
	        Name = name;
	        Age = age;
	    }
	
	    public int Age { get; set; }
	
	    public string Name { get; set; }
	
	    public string Details()
	    {
	        return Name + " is " + Age.ToString();
	    }
	}
	
	class TestPerson
	{
	    static void RunMain()
	    {
	        // Create a Person object by using the instance constructor.
	        Person person1 = new Person("George", 40);
	
	        // Create another Person object, copying person1.
	        Person person2 = new Person(person1);
	
	        // Change each person's age.
	        person1.Age = 39;
	        person2.Age = 41;
	
	        // Change person2's name.
	        person2.Name = "Charles";
	
	        // Show details to verify that the name and age fields are distinct.
	        Console.WriteLine(person1.Details());
	        Console.WriteLine(person2.Details());
	
	        // Keep the console window open in debug mode.
	        Console.WriteLine("Press any key to exit.");
	        Console.ReadKey();
	    }
	}
	// Output:
	// George is 39
	// Charles is 41
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
namespace DotnetCSharpProgrammingGuideClassesAndStructsStaticConstructors
{
	public class ClassesAndStructsStaticConstructors
	{
		public static void RunClassesAndStructsStaticConstructors()
		{
			
		}
	}
	
	class SimpleClass
	{
	    // Static variable that must be initialized at run time.
	    static readonly long baseline;
	
	    // Static constructor is called at most one time, before any
	    // instance constructor is invoked or member is accessed.
	    static SimpleClass()
	    {
	        baseline = DateTime.Now.Ticks;
	    }
	}
	
	public class Singleton
	{
	    // Static field initializer calls instance constructor.
	    private static Singleton instance = new Singleton();
	
	    private Singleton()
	    { 
	        Console.WriteLine("Executes before static constructor.");
	    }
	
	    static Singleton()
	    { 
	        Console.WriteLine("Executes after instance constructor.");
	    }
	
	    public static Singleton Instance => instance;
	}
	
	public class Bus
	{
	    // Static variable used by all Bus instances.
	    // Represents the time the first bus of the day starts its route.
	    protected static readonly DateTime globalStartTime;
	
	    // Property for the number of each bus.
	    protected int RouteNumber { get; set; }
	
	    // Static constructor to initialize the static variable.
	    // It is invoked before the first instance constructor is run.
	    static Bus()
	    {
	        globalStartTime = DateTime.Now;
	
	        // The following statement produces the first line of output,
	        // and the line occurs only once.
	        Console.WriteLine($"Static constructor sets global start time to {globalStartTime.ToLongTimeString()}");
	    }
	
	    // Instance constructor.
	    public Bus(int routeNum)
	    {
	        RouteNumber = routeNum;
	        Console.WriteLine($"Bus #{RouteNumber} is created.");
	    }
	
	    // Instance method.
	    public void Drive()
	    {
	        TimeSpan elapsedTime = DateTime.Now - globalStartTime;
	
	        // For demonstration purposes we treat milliseconds as minutes to simulate
	        // actual bus times. Do not do this in your actual bus schedule program!
	        Console.WriteLine($"{this.RouteNumber} is starting its route {elapsedTime.Milliseconds:N2} minutes after global start time {globalStartTime.ToShortTimeString()}.");
	    }
	}
	
	class TestBus
	{
	    static void RunMain()
	    {
	        // The creation of this instance activates the static constructor.
	        Bus bus1 = new Bus(71);
	
	        // Create a second bus.
	        Bus bus2 = new Bus(72);
	
	        // Send bus1 on its way.
	        bus1.Drive();
	
	        // Wait for bus2 to warm up.
	        System.Threading.Thread.Sleep(25);
	
	        // Send bus2 on its way.
	        bus2.Drive();
	
	        // Keep the console window open in debug mode.
	        Console.WriteLine("Press any key to exit.");
	        Console.ReadKey();
	    }
	}
	/* Sample output:
	    Static constructor sets global start time to 3:57:08 PM.
	    Bus #71 is created.
	    Bus #72 is created.
	    71 is starting its route 6.00 minutes after global start time 3:57 PM.
	    72 is starting its route 31.00 minutes after global start time 3:57 PM.
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/private-constructors
namespace DotnetCSharpProgrammingGuideClassesAndStructsPrivateConstructors
{
	public class ClassesAndStructsPrivateConstructors
	{
		public static void RunClassesAndStructsPrivateConstructors()
		{
			
		}
	}
	
	class NLog
	{
	    // Private Constructor:
	    private NLog() { }
	
	    public static double e = Math.E;  //2.71828...
	}
	
	public class Counter
	{
	    private Counter() { }
	
	    public static int currentCount;
	
	    public static int IncrementCount()
	    {
	        return ++currentCount;
	    }
	}
	
	class TestCounter
	{
	    static void RunMain()
	    {
	        // If you uncomment the following statement, it will generate
	        // an error because the constructor is inaccessible:
	        // Counter aCounter = new Counter();   // Error
	
	        Counter.currentCount = 100;
	        Counter.IncrementCount();
	        Console.WriteLine($"New count: {Counter.currentCount}");
	
	        // Keep the console window open in debug mode.
	        Console.WriteLine("Press any key to exit.");
	        Console.ReadKey();
	    }
	}
	// Output: New count: 101
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors
namespace DotnetCSharpProgrammingGuideClassesAndStructsInstanceConstructors
{
	public class ClassesAndStructsInstanceConstructors
	{
		public static void RunClassesAndStructsInstanceConstructors()
		{
			
		}
	}
	
	class Coords
	{
	    public Coords()
	        : this(0, 0)
	    {  }
	
	    public Coords(int x, int y)
	    {
	        X = x;
	        Y = y;
	    }
	
	    public int X { get; set; }
	    public int Y { get; set; }
	
	    public override string ToString() => $"({X},{Y})";
	}
	
	class Example
	{
	    static void RunMain()
	    {
	        var p1 = new Coords();
	        Console.WriteLine($"Coords #1 at {p1}");
	        // Output: Coords #1 at (0,0)
	
	        var p2 = new Coords(5, 3);
	        Console.WriteLine($"Coords #2 at {p2}");
	        // Output: Coords #2 at (5,3)
	    }
	}
	
	abstract class Shape
	{
	    public const double pi = Math.PI;
	    protected double x, y;
	
	    public Shape(double x, double y)
	    {
	        this.x = x;
	        this.y = y;
	    }
	
	    public abstract double Area();
	}
	
	class Circle : Shape
	{
	    public Circle(double radius)
	        : base(radius, 0)
	    {  }
	
	    public override double Area() => pi * x * x;
	}
	
	class Cylinder : Circle
	{
	    public Cylinder(double radius, double height)
	        : base(radius)
	    {
	        y = height;
	    }
	
	    public override double Area() => (2 * base.Area()) + (2 * pi * x * y);
	}
	
	class Example2
	{
	    static void RunMain()
	    {
	        double radius = 2.5;
	        double height = 3.0;
	
	        var ring = new Circle(radius);
	        Console.WriteLine($"Area of the circle = {ring.Area():F2}");
	        // Output: Area of the circle = 19.63
	        
	        var tube = new Cylinder(radius, height);
	        Console.WriteLine($"Area of the cylinder = {tube.Area():F2}");
	        // Output: Area of the cylinder = 86.39
	    }
	}
	
	public class Person
	{
	    public int age;
	    public string name = "unknown";
	}
	
	class Example3
	{
	    static void RunMain()
	    {
	        var person = new Person();
	        Console.WriteLine($"Name: {person.name}, Age: {person.age}");
	        // Output:  Name: unknown, Age: 0
	    }
	}
	
	public class NamedItem(string name)
	{
	    public string Name => name;
	}
	
	// name isn't captured in Widget.
	// width, height, and depth are captured as private fields
	public class Widget(string name, int width, int height, int depth) : NamedItem(name)
	{
	    public Widget() : this("N/A", 1,1,1) {} // unnamed unit cube
	
	    public int WidthInCM => width;
	    public int HeightInCM => height;
	    public int DepthInCM => depth;
	
	    public int Volume => width * height * depth;
	}
	
	/*
	[method: MyAttribute]
	public class TaggedWidget(string name)
	{
	   // details elided
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-constructors
namespace DotnetCSharpProgrammingGuideClassesAndStructsUsingConstructors
{
	public class ClassesAndStructsUsingConstructors
	{
		public static void RunClassesAndStructsUsingConstructors()
		{
			int i = new int();
			Console.WriteLine(i);
			
			//int i;
			//Console.WriteLine(i);
			
			int a = 44;  // Initialize the value type...
			int b;
			b = 33;      // Or assign it before using it.
			Console.WriteLine("{0}, {1}", a, b);
			
			Employee e1 = new Employee(30000);
			Employee e2 = new Employee(500, 52);
			
		}
	}
	
	public class Taxi
	{
	    private string taxiTag;
	
	    public Taxi(string tag) => taxiTag = tag;
	
	    public override string ToString() => $"Taxi: {taxiTag}";
	}
	
	class TestTaxi
	{
	    static void RunMain()
	    {
	        Taxi t = new Taxi("Tag1345");
	        Console.WriteLine(t);
	    }
	}
	
	class NLog
	{
	    // Private Constructor:
	    private NLog() { }
	
	    public static double e = Math.E;  //2.71828...
	}
	
	public class Employee
	{
	    public int Salary;
	
	    public Employee() { }
	
	    public Employee(int annualSalary) => Salary = annualSalary;
	
	    public Employee(int weeklySalary, int numberOfWeeks) => Salary = weeklySalary * numberOfWeeks;
	}
	
	public class Manager : Employee
	{
	    public Manager(int annualSalary)
	        : base(annualSalary)
	    {
	        //Add further instructions here.
	    }
		
		/*
		public Manager(int initialData)
		{
		    //Add further instructions here.
		}
		
		public Manager(int initialData)
		    : base()
		{
		    //Add further instructions here.
		}
		
		public Employee(int weeklySalary, int numberOfWeeks)
		    : this(weeklySalary * numberOfWeeks)
		{
		}
		
		public Employee(int annualSalary) => Salary = annualSalary;
		*/
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
namespace DotnetCSharpProgrammingGuideClassesAndStructsConstructors
{
	public class ClassesAndStructsConstructors
	{
		public static void RunClassesAndStructsConstructors()
		{
			
		}
	}
	
	public class Person
	{
	   private string last;
	   private string first;
	
	   public Person(string lastName, string firstName)
	   {
	      last = lastName;
	      first = firstName;
	   }
	
	   // Remaining implementation of Person class.
	}
	
	public class Location
	{
	   private string locationName;
	
	   public Location(string name) => Name = name;
	
	   public string Name
	   {
	      get => locationName;
	      set => locationName = value;
	   }
	}
	
	public class LabelledContainer<T>(string label)
	{
	   public string Label { get; } = label;
	   public required T Contents 
	   { 
	      get;
	      init;
	   }
	}
	
	public class Adult : Person
	{
	   private static int minimumAge;
	
	   public Adult(string lastName, string firstName) : base(lastName, firstName)
	   { }
	
	   static Adult()
	   {
	       minimumAge = 18;
	   }
	
	   // Remaining implementation of Adult class.
	}
	
	public class Child : Person
	{
	   private static int maximumAge;
	
	   public Child(string lastName, string firstName) : base(lastName, firstName)
	   { }
	
	   static Child() => maximumAge = 18;
	
	   // Remaining implementation of Child class.
	}
	
	public class Example
	{
	    static Example()
	    {
	        Console.WriteLine("Static constructor called.");
	    }
	    
	    public Example()
	    {
	        Console.WriteLine("Instance constructor called.");
	    }
	
	    // Remaining implementation of Child class.
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
namespace DotnetCSharpProgrammingGuideClassesAndStructsNamedAndOptionalArguments
{
	public class ClassesAndStructsNamedAndOptionalArguments
	{
		public static void RunClassesAndStructsNamedAndOptionalArguments()
		{
			/*
			PrintOrderDetails("Gift Shop", 31, "Red Mug");
			
			PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
			PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);
			
			PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
			
			PrintOrderDetails(sellerName: "Gift Shop", 31, productName: "Red Mug");
			
			// This generates CS1738: Named argument specifications must appear after all fixed arguments have been specified.
			PrintOrderDetails(productName: "Red Mug", 31, "Gift Shop");
			
			// anExample.ExampleMethod(3, ,4);
			
			anExample.ExampleMethod(3, optionalint: 4);
			
			var excelApp = new Microsoft.Office.Interop.Excel.Application();
			excelApp.Workbooks.Add();
			excelApp.Visible = true;
			
			var myFormat =
			    Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting1;
			
			excelApp.Range["A1", "B4"].AutoFormat( Format: myFormat );
			*/
		}
		
		//public void ExampleMethod(int required, string optionalstr = "default string", int optionalint = 10)
	}
	
	class NamedExample
	{
	    static void RunMain(string[] args)
	    {
	        // The method can be called in the normal way, by using positional arguments.
	        PrintOrderDetails("Gift Shop", 31, "Red Mug");
	
	        // Named arguments can be supplied for the parameters in any order.
	        PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
	        PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);
	
	        // Named arguments mixed with positional arguments are valid
	        // as long as they are used in their correct position.
	        PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
	        PrintOrderDetails(sellerName: "Gift Shop", 31, productName: "Red Mug"); 
	        PrintOrderDetails("Gift Shop", orderNum: 31, "Red Mug");
	
	        // However, mixed arguments are invalid if used out-of-order.
	        // The following statements will cause a compiler error.
	        // PrintOrderDetails(productName: "Red Mug", 31, "Gift Shop");
	        // PrintOrderDetails(31, sellerName: "Gift Shop", "Red Mug");
	        // PrintOrderDetails(31, "Red Mug", sellerName: "Gift Shop");
	    }
	
	    static void PrintOrderDetails(string sellerName, int orderNum, string productName)
	    {
	        if (string.IsNullOrWhiteSpace(sellerName))
	        {
	            throw new ArgumentException(message: "Seller name cannot be null or empty.", paramName: nameof(sellerName));
	        }
	
	        Console.WriteLine($"Seller: {sellerName}, Order #: {orderNum}, Product: {productName}");
	    }
	}
	
	namespace OptionalNamespace
	{
	    class OptionalExample
	    {
	        static void RunMain(string[] args)
	        {
	            // Instance anExample does not send an argument for the constructor's
	            // optional parameter.
	            ExampleClass anExample = new ExampleClass();
	            anExample.ExampleMethod(1, "One", 1);
	            anExample.ExampleMethod(2, "Two");
	            anExample.ExampleMethod(3);
	
	            // Instance anotherExample sends an argument for the constructor's
	            // optional parameter.
	            ExampleClass anotherExample = new ExampleClass("Provided name");
	            anotherExample.ExampleMethod(1, "One", 1);
	            anotherExample.ExampleMethod(2, "Two");
	            anotherExample.ExampleMethod(3);
	
	            // The following statements produce compiler errors.
	
	            // An argument must be supplied for the first parameter, and it
	            // must be an integer.
	            //anExample.ExampleMethod("One", 1);
	            //anExample.ExampleMethod();
	
	            // You cannot leave a gap in the provided arguments.
	            //anExample.ExampleMethod(3, ,4);
	            //anExample.ExampleMethod(3, 4);
	
	            // You can use a named parameter to make the previous
	            // statement work.
	            anExample.ExampleMethod(3, optionalint: 4);
	        }
	    }
	
	    class ExampleClass
	    {
	        private string _name;
	
	        // Because the parameter for the constructor, name, has a default
	        // value assigned to it, it is optional.
	        public ExampleClass(string name = "Default name")
	        {
	            _name = name;
	        }
	
	        // The first parameter, required, has no default value assigned
	        // to it. Therefore, it is not optional. Both optionalstr and
	        // optionalint have default values assigned to them. They are optional.
	        public void ExampleMethod(int required, string optionalstr = "default string",
	            int optionalint = 10)
	        {
	            Console.WriteLine(
	                $"{_name}: {required}, {optionalstr}, and {optionalint}.");
	        }
	    }
	
	    // The output from this example is the following:
	    // Default name: 1, One, and 1.
	    // Default name: 2, Two, and 10.
	    // Default name: 3, default string, and 10.
	    // Provided name: 1, One, and 1.
	    // Provided name: 2, Two, and 10.
	    // Provided name: 3, default string, and 10.
	    // Default name: 3, default string, and 4.
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-create-a-new-method-for-an-enumeration
namespace DotnetCSharpProgrammingGuideClassesAndStructsHowToCreateANewMethodForAnEnumeration
{
	public class NewMethodForAnEnumeration
	{
		public static void RunNewMethodForAnEnumeration()
		{
			Grades g1 = Grades.D;
			Grades g2 = Grades.F;
			Console.WriteLine($"First {(g1.Passing() ? "is" : "is not")} a passing grade.");
			Console.WriteLine($"Second {(g2.Passing() ? "is" : "is not")} a passing grade.");
			
			Console.WriteLine("\r\nRaising the bar!\r\n");
			Console.WriteLine($"First {(g1.Passing(Grades.C) ? "is" : "is not")} a passing grade.");
			Console.WriteLine($"Second {(g2.Passing(Grades.C) ? "is" : "is not")} a passing grade.");

			/* Output:
			    First is a passing grade.
			    Second is not a passing grade.
			
			    Raising the bar!
			
			    First is not a passing grade.
			    Second is not a passing grade.
			*/
			
			/*
			Grades g1 = Grades.D;
			Grades g2 = Grades.F;
			Console.WriteLine($"First {(g1.Passing ? "is" : "is not")} a passing grade.");
			Console.WriteLine($"Second {(g2.Passing ? "is" : "is not")} a passing grade.");
			
			Grades.MinimumPassingGrade = Grades.C;
			Console.WriteLine($"\r\nRaising the bar. Passing grade is now {Grades.MinimumPassingGrade}!\r\n");
			Console.WriteLine($"First {(g1.Passing ? "is" : "is not")} a passing grade.");
			Console.WriteLine($"Second {(g2.Passing ? "is" : "is not")} a passing grade.");
			*/
			/* Output:
			    First is a passing grade.
			    Second is not a passing grade.
			
			    Raising the bar!
			
			    First is not a passing grade.
			    Second is not a passing grade.
			*/
			
		}
	}
	
	public enum Grades
	{
	    F = 0,
	    D = 1,
	    C = 2,
	    B = 3,
	    A = 4
	};
	
	// Define an extension method in a non-nested static class.
	public static class Extensions
	{
	    public static bool Passing(this Grades grade, Grades minPassing = Grades.D) =>
	        grade >= minPassing;
	}
	
	public static class EnumExtensions
	{
	    private static Grades minimumPassingGrade = Grades.D;
	
	    extension(Grades grade)
	    {
	        public static Grades MinimumPassingGrade
	        {
	            get => minimumPassingGrade;
	            set => minimumPassingGrade = value;
	        }
	
	        public bool Passing => grade >= minimumPassingGrade;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-implement-and-call-a-custom-extension-method
namespace DotnetCSharpProgrammingGuideClassesAndStructs
{
	public class ClassesAndStructs
	{
		public static void RunClassesAndStructs()
		{
			/*
			string s = "The quick brown fox jumped over the lazy dog.";
			// Call the method as if it were an
			// instance method on the type. Note that the first
			// parameter is not specified by the calling code.
			int i = s.WordCount();
			System.Console.WriteLine($"Word count of s is {i}");
			*/
			
		}
	}
	
	namespace CustomExtensions
	{
	    // Extension methods must be defined in a static class.
	    public static class StringExtension
	    {
	        extension(string str)
	        {
	            // This is the extension member.
	            // The `str` parameter is declared on the extension declaration.
	            public int WordCount()
	            {
	                return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
	            }
	        }
	    }
	}
	
	namespace CustomExtensions2
	{
	    // Extension methods must be defined in a static class.
	    public static class StringExtension
	    {
	        // This is the extension method.
	        // The first parameter takes the "this" modifier
	        // and specifies the type to be extended.
	        public static int WordCount(this string str)
	        {
	            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
	        }
	    }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-use-implicitly-typed-local-variables-and-arrays-in-a-query-expression
namespace DotnetCSharpProgrammingGuideClassesAndStructsHowToUseImplicitlyTypesLocalVariablesAndArraysInAQueryExpression
{
	public class ImplicitlyTypesLocalVariablesAndArraysInAQueryExpression
	{
		public static void RunImplicitlyTypesLocalVariablesAndArraysInAQueryExpression()
		{
			/*
			// Variable queryId could be declared by using
			// System.Collections.Generic.IEnumerable<string>
			// instead of var.
			var queryId =
			    from student in students
			    where student.Id > 111
			    select student.LastName;
			
			// Variable str could be declared by using var instead of string.
			foreach (string str in queryId)
			{
			    Console.WriteLine($"Last name: {str}");
			}
			*/
		}
		
		/*
		private static void QueryNames(char firstLetter)
		{
		    // Create the query. Use of var is required because
		    // the query produces a sequence of anonymous types:
		    // System.Collections.Generic.IEnumerable<????>.
		    var studentQuery =
		        from student in students
		        where student.FirstName[0] == firstLetter
		        select new { student.FirstName, student.LastName };
		
		    // Execute the query and display the results.
		    foreach (var anonType in studentQuery)
		    {
		        Console.WriteLine("First = {0}, Last = {1}", anonType.FirstName, anonType.LastName);
		    }
		}
		*/
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables
namespace DotnetCSharpProgrammingGuideClassesAndStructsImplicityTypedLocalVariables
{
	public class ClassesAndStructsImplicityTypedLocalVariables
	{
		public static void RunClassesAndStructsImplicityTypedLocalVariables()
		{
			// i is compiled as an int
			var i = 5;
			
			// s is compiled as a string
			var s = "Hello";
			
			// a is compiled as int[]
			var a = new[] { 0, 1, 2 };
			
			// expr is compiled as IEnumerable<Customer>
			// or perhaps IQueryable<Customer>
			/*
			var expr =
			    from c in customers
			    where c.City == "London"
			    select c;
			*/
			
			// anon is compiled as an anonymous type
			var anon = new { Name = "Terry", Age = 34 };
			
			// list is compiled as List<int>
			var list = new List<int>();
			
			for (var x = 1; x < 10; x++) {}
			
			foreach (var item in list) {}
			
			using (var file = new StreamReader("C:\\myfile.txt")) {}
			
			//private var bookTitles;
			
			//private var bookTitles = new List<string>();
			
			/*
			var studentQuery =
			    from student in students
			    group student by student.Last;
			*/
		}
	}
	
	class ImplicitlyTypedLocals2
	{
	    static void RunMain()
	    {
	        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
	
	        // If a query produces a sequence of anonymous types,
	        // then use var in the foreach statement to access the properties.
	        var upperLowerWords =
	             from w in words
	             select new { Upper = w.ToUpper(), Lower = w.ToLower() };
	
	        // Execute the query
	        foreach (var ul in upperLowerWords)
	        {
	            Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
	        }
	    }
	}
	/* Outputs:
	    Uppercase: APPLE, Lowercase: apple
	    Uppercase: BLUEBERRY, Lowercase: blueberry
	    Uppercase: CHERRY, Lowercase: cherry
	 */
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions
namespace DotnetProgrammingGuideClassesAndStructsLocalFunctions
{
	public class ClassesAndStructsLocalFunctions
	{
		public static void RunClassesAndStructsLocalFunctions()
		{
			
		}
		
		private static string GetText(string path, string filename)
		{
		     var reader = File.OpenText($"{AppendPathSeparator(path)}{filename}");
		     var text = reader.ReadToEnd();
		     return text;
		
		     string AppendPathSeparator(string filepath)
		     {
		        return filepath.EndsWith(@"\") ? filepath : filepath + @"\";
		     }
		}
		
		#nullable enable
		private static void Process(string?[] lines, string mark)
		{
		    foreach (var line in lines)
		    {
		        if (IsValid(line))
		        {
		            // Processing logic...
		        }
		    }
		
		    bool IsValid([NotNullWhen(true)] string? line)
		    {
		        return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
		    }
		}
		
		public static int LocalFunctionFactorial(int n)
		{
		    return nthFactorial(n);
		
		    int nthFactorial(int number) => number < 2 
		        ? 1 
		        : number * nthFactorial(number - 1);
		}
		
		public static int LambdaFactorial(int n)
		{
		    Func<int, int> nthFactorial = default(Func<int, int>);
		
		    nthFactorial = number => number < 2
		        ? 1
		        : number * nthFactorial(number - 1);
		
		    return nthFactorial(n);
		}
		
		/*
		int M()
		{
		    int y;
		    LocalFunction();
		    return y;
		
		    void LocalFunction() => y = 0;
		}
		*/
		
		/*
		public async Task<string> PerformLongRunningWorkLambda(string address, int index, string name)
		{
		    if (string.IsNullOrWhiteSpace(address))
		        throw new ArgumentException(message: "An address is required", paramName: nameof(address));
		    if (index < 0)
		        throw new ArgumentOutOfRangeException(paramName: nameof(index), message: "The index must be non-negative");
		    if (string.IsNullOrWhiteSpace(name))
		        throw new ArgumentException(message: "You must supply a name", paramName: nameof(name));
		
		    Func<Task<string>> longRunningWorkImplementation = async () =>
		    {
		        var interimResult = await FirstWork(address);
		        var secondResult = await SecondStep(index, name);
		        return $"The results are {interimResult} and {secondResult}. Enjoy.";
		    };
		
		    return await longRunningWorkImplementation();
		}
		*/
		
		/*
		public async Task<string> PerformLongRunningWork(string address, int index, string name)
		{
		    if (string.IsNullOrWhiteSpace(address))
		        throw new ArgumentException(message: "An address is required", paramName: nameof(address));
		    if (index < 0)
		        throw new ArgumentOutOfRangeException(paramName: nameof(index), message: "The index must be non-negative");
		    if (string.IsNullOrWhiteSpace(name))
		        throw new ArgumentException(message: "You must supply a name", paramName: nameof(name));
		
		    return await longRunningWorkImplementation();
		
		    async Task<string> longRunningWorkImplementation()
		    {
		        var interimResult = await FirstWork(address);
		        var secondResult = await SecondStep(index, name);
		        return $"The results are {interimResult} and {secondResult}. Enjoy.";
		    }
		}
		*/
		
		public IEnumerable<string> SequenceToLowercase(IEnumerable<string> input)
		{
		    if (!input.Any())
		    {
		        throw new ArgumentException("There are no items to convert to lowercase.");
		    }
		    
		    return LowercaseIterator();
		    
		    IEnumerable<string> LowercaseIterator()
		    {
		        foreach (var output in input.Select(item => item.ToLower()))
		        {
		            yield return output;
		        }
		    }
		}
	}
	
	public class IteratorWithoutLocalExample
	{
	   public static void RunMain()
	   {
	      IEnumerable<int> xs = OddSequence(50, 110);
	      Console.WriteLine("Retrieved enumerator...");
	
	      foreach (var x in xs)  // line 11
	      {
	         Console.Write($"{x} ");
	      }
	   }
	
	   public static IEnumerable<int> OddSequence(int start, int end)
	   {
	      if (start < 0 || start > 99)
	         throw new ArgumentOutOfRangeException(nameof(start), "start must be between 0 and 99.");
	      if (end > 100)
	         throw new ArgumentOutOfRangeException(nameof(end), "end must be less than or equal to 100.");
	      if (start >= end)
	         throw new ArgumentException("start must be less than end.");
	
	      for (int i = start; i <= end; i++)
	      {
	         if (i % 2 == 1)
	            yield return i;
	      }
	   }
	}
	// The example displays the output like this:
	//
	//    Retrieved enumerator...
	//    Unhandled exception. System.ArgumentOutOfRangeException: end must be less than or equal to 100. (Parameter 'end')
	//    at IteratorWithoutLocalExample.OddSequence(Int32 start, Int32 end)+MoveNext() in IteratorWithoutLocal.cs:line 22
	//    at IteratorWithoutLocalExample.Main() in IteratorWithoutLocal.cs:line 11
	
	public class IteratorWithLocalExample
	{
	   public static void RunMain()
	   {
	      IEnumerable<int> xs = OddSequence(50, 110);  // line 8
	      Console.WriteLine("Retrieved enumerator...");
	
	      foreach (var x in xs)
	      {
	         Console.Write($"{x} ");
	      }
	   }
	
	   public static IEnumerable<int> OddSequence(int start, int end)
	   {
	      if (start < 0 || start > 99)
	         throw new ArgumentOutOfRangeException(nameof(start), "start must be between 0 and 99.");
	      if (end > 100)
	         throw new ArgumentOutOfRangeException(nameof(end), "end must be less than or equal to 100.");
	      if (start >= end)
	         throw new ArgumentException("start must be less than end.");
	
	      return GetOddSequenceEnumerator();
	
	      IEnumerable<int> GetOddSequenceEnumerator()
	      {
	         for (int i = start; i <= end; i++)
	         {
	            if (i % 2 == 1)
	               yield return i;
	         }
	      }
	   }
	}
	// The example displays the output like this:
	//
	//    Unhandled exception. System.ArgumentOutOfRangeException: end must be less than or equal to 100. (Parameter 'end')
	//    at IteratorWithLocalExample.OddSequence(Int32 start, Int32 end) in IteratorWithLocal.cs:line 22
	//    at IteratorWithLocalExample.Main() in IteratorWithLocal.cs:line 8
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
namespace DotnetCSharpProgrammingGuideClassesAndStructsMethods
{
	public class ClassesAndStructsMethods
	{
		public static void RunClassesAndStructsMethods()
		{
			/*
			int result = obj.AddTwoNumbers(1, 2);
			result = obj.SquareANumber(result);
			// The result is 9.
			Console.WriteLine(result);
			
			result = obj.SquareANumber(obj.AddTwoNumbers(1, 2));
			// The result is 9.
			Console.WriteLine(result);
			
			ref double distance = ref Planet.GetEstimatedDistance();
			*/
			
		}
		
		public void Caller()
		{
		    int numA = 4;
		    // Call with an int variable.
		    int productA = Square(numA);
		
		    int numB = 32;
		    // Call with another int variable.
		    int productB = Square(numB);
		
		    // Call with an integer literal.
		    int productC = Square(12);
		
		    // Call with an expression that evaluates to int.
		    productC = Square(productA * 3);
		}
		
		int Square(int i)
		{
		    // Store input argument in a local variable.
		    int input = i;
		    return input * input;
		}
		
		public static void TestRefType()
		{
		    SampleRefType rt = new SampleRefType();
		    rt.value = 44;
		    ModifyObject(rt);
		    Console.WriteLine(rt.value);
		}
		
		static void ModifyObject(SampleRefType obj)
		{
		    obj.value = 33;
		}
		
		/*
		public ref double GetEstimatedDistance()
		{
		    return ref estDistance;
		}
		*/
		
		static void RunMain(string[] args)
		{
		    int[,] matrix = new int[2, 2];
		    FillMatrix(matrix);
		    // matrix is now full of -1
		}
		
		public static void FillMatrix(int[,] matrix)
		{
		    for (int i = 0; i < matrix.GetLength(0); i++)
		    {
		        for (int j = 0; j < matrix.GetLength(1); j++)
		        {
		            matrix[i, j] = -1;
		        }
		    }
		}
		
		/*
		public Point Move(int dx, int dy) => new Point(x + dx, y + dy);
		public void Print() => Console.WriteLine(First + " " + Last);
		// Works with operators, properties, and indexers too.
		public static Complex operator +(Complex a, Complex b) => a.Add(b);
		public string Name => First + " " + Last;
		public Customer this[long id] => store.LookupCustomer(id);
		*/
	}
	
	abstract class Motorcycle
	{
	    // Anyone can call this.
	    public void StartEngine() {/* Method statements here */ }
	
	    // Only derived classes can call this.
	    protected void AddGas(int gallons) { /* Method statements here */ }
	
	    // Derived classes can override the base class implementation.
	    public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }
	
	    // Derived classes must implement this.
	    public abstract double GetTopSpeed();
	}
	
	class TestMotorcycle : Motorcycle
	{
	    public override double GetTopSpeed()
	    {
	        return 108.4;
	    }
	
	    static void RunMain()
	    {
	        TestMotorcycle moto = new TestMotorcycle();
	
	        moto.StartEngine();
	        moto.AddGas(15);
	        moto.Drive(5, 20);
	        double speed = moto.GetTopSpeed();
	        Console.WriteLine($"My top speed is {speed}");
	    }
	}
	
	public class SampleRefType
	{
	    public int value;
	}
	
	class SimpleMath
	{
	    public int AddTwoNumbers(int number1, int number2)
	    {
	        return number1 + number2;
	    }
	
	    public int SquareANumber(int number)
	    {
	        return number * number;
	    }
	}
	
	class Program
	{
	    static Task RunMain() => DoSomethingAsync();
	
	    static async Task DoSomethingAsync()
	    {
	        Task<int> delayTask = DelayAsync();
	        int result = await delayTask;
	
	        // The previous two statements may be combined into
	        // the following statement.
	        //int result = await DelayAsync();
	
	        Console.WriteLine($"Result: {result}");
	    }
	
	    static async Task<int> DelayAsync()
	    {
	        await Task.Delay(100);
	        return 5;
	    }
	}
	// Example output:
	//   Result: 5
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-implement-a-lightweight-class-with-auto-implemented-properties
namespace DotnetCSharpProgrammingGuideClassesAndStructsHowToImplementALightweightClassWithAutoImplementedProperties
{
	public class AutoImplementedProperties
	{
		public static void RunAutoImplementedProperties()
		{
			
		}
	}
	
	// This class is immutable. After an object is created,
	// it cannot be modified from outside the class. It uses a
	// constructor to initialize its properties.
	class Contact
	{
		// Read-only property.
	    public string Name { get; }
		
		// Read-write property with a private set accessor.
	    public string Address { get; private set; }
	
		// Public constructor.
	    public Contact(string contactName, string contactAddress)
	    {
	        // Both properties are accessible in the constructor.
	        Name = contactName;
	        Address = contactAddress;
	    }
	
	    // Name isn't assignable here. This will generate a compile error.
	    //public void ChangeName(string newName) => Name = newName;
	
	    // Address is assignable here.
	    public void ChangeAddress(string newAddress) => Address = newAddress;
	}
	
	// This class is immutable. After an object is created,
	// it cannot be modified from outside the class. It uses a
	// static method and private constructor to initialize its properties.
	public class Contact2
	{
	    // Read-write property with a private set accessor.
	    public string Name { get; private set; }
	
	    // Read-only property.
	    public string Address { get; }
	
	    // Private constructor.
	    private Contact2(string contactName, string contactAddress)
	    {
	        Name = contactName;
	        Address = contactAddress;
	    }
	
	    // Public factory method.
	    public static Contact2 CreateContact(string name, string address)
	    {
	        return new Contact2(name, address);
	    }
	}
	
	public class Program
	{
	    static void RunMain()
	    {
	        // Some simple data sources.
	        string[] names = ["Terry Adams","Fadi Fakhouri", "Hanying Feng",
	                            "Cesar Garcia", "Debra Garcia"];
	        string[] addresses = ["123 Main St.", "345 Cypress Ave.", "678 1st Ave",
	                                "12 108th St.", "89 E. 42nd St."];
	
	        // Simple query to demonstrate object creation in select clause.
	        // Create Contact objects by using a constructor.
	        var query1 = from i in Enumerable.Range(0, 5)
	                    select new Contact(names[i], addresses[i]);
	
	        // List elements cannot be modified by client code.
	        var list = query1.ToList();
	        foreach (var contact in list)
	        {
	            Console.WriteLine("{0}, {1}", contact.Name, contact.Address);
	        }
	
	        // Create Contact2 objects by using a static factory method.
	        var query2 = from i in Enumerable.Range(0, 5)
	                        select Contact2.CreateContact(names[i], addresses[i]);
	
	        // Console output is identical to query1.
	        var list2 = query2.ToList();
	
	        // List elements cannot be modified by client code.
	        // CS0272:
	        // list2[0].Name = "Eugene Zabokritski";
	    }
	}
	
	/* Output:
	    Terry Adams, 123 Main St.
	    Fadi Fakhouri, 345 Cypress Ave.
	    Hanying Feng, 678 1st Ave
	    Cesar Garcia, 12 108th St.
	    Debra Garcia, 89 E. 42nd St.
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
namespace DotnetCSharpProgrammingGuideClassesAndStructsAutoImplementedProperties
{
	public class ClassesAndStructsAutoImplementedProperties
	{
		
	}
	
	// This class is mutable. Its data can be modified from
	// outside the class.
	public class Customer
	{
	    // Auto-implemented properties for trivial get and set
	    public double TotalPurchases { get; set; }
	    public string Name { get; set; }
	    public int CustomerId { get; set; }
		
		//public string FirstName { get; set; } = "Jane";
		
		public string FirstName 
		{ 
		    get; 
		    set 
		    { 
		        field = (string.IsNullOrWhiteSpace(value) is false
		            ? value
		            : throw new ArgumentException(nameof(value), "First name can't be whitespace or null"));
		    }
		} = "Jane";
	
	    // Constructor
	    public Customer(double purchases, string name, int id)
	    {
	        TotalPurchases = purchases;
	        Name = name;
	        CustomerId = id;
	    }
	
	    // Methods
	    public string GetContactInfo() { return "ContactInfo"; }
	    public string GetTransactionHistory() { return "History"; }
	
	    // .. Additional methods, events, etc.
	}
	
	class Program
	{
	    static void RunMain()
	    {
	        // Initialize a new object.
	        Customer cust1 = new Customer(4987.63, "Northwind", 90108);
	
	        // Modify a property.
	        cust1.TotalPurchases += 499.99;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-declare-and-use-read-write-properties
namespace DotnetCSharpProgrammingGuideClassesAndStructsHowToDeclareAndUseReadWriteProperties
{
	public class DeclareAndUseReadWriteProperties
	{
		public static void RunDeclareAndUseReadWriteProperties()
		{
			//person.Name = "Joe";
			//person.Age = 99;
			
			//_name = value;
			
			//person.Age += 1;
			
			//person.SetAge(person.GetAge() + 1);
			
		}
	}
	
	class Person
	{
	    private string _name = "N/A";
	    private int _age = 0;
	
	    // Declare a Name property of type string:
	    public string Name
	    {
	        get
	        {
	            return _name;
	        }
	        set
	        {
	            _name = value;
	        }
			
			/*
			public string Name
			{
			    get
			    {
			        return _name;
			    }
			    private set
			    {
			        _name = value;
			    }
			}
			*/
	    }
	
	    // Declare an Age property of type int:
	    public int Age
	    {
	        get
	        {
	            return _age;
	        }
	
	        set
	        {
	            _age = value;
	        }
	    }
	
	    public override string ToString()
	    {
	        return "Name = " + Name + ", Age = " + Age;
	    }
	}
	
	public class Wrapper
	{
	    private string _name = "N/A";
	    public string Name
	    {
	        get
	        {
	            return _name;
	        }
	        private set
	        {
	            _name = value;
	        }
	    }
	
	}
	
	class TestPerson
	{
	    static void RunMain()
	    {
	        // Create a new Person object:
	        Person person = new Person();
	
	        // Print out the name and the age associated with the person:
	        Console.WriteLine($"Person details - {person}");
	
	        // Set some values on the person object:
	        person.Name = "Joe";
	        person.Age = 99;
	        Console.WriteLine($"Person details - {person}");
	
	        // Increment the Age property:
	        person.Age += 1;
	        Console.WriteLine($"Person details - {person}");
	
	        // Keep the console window open in debug mode.
	        Console.WriteLine("Press any key to exit.");
	        Console.ReadKey();
	    }
	}
	/* Output:
	    Person details - Name = N/A, Age = 0
	    Person details - Name = Joe, Age = 99
	    Person details - Name = Joe, Age = 100
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/restricting-accessor-accessibility
namespace DotnetCSharpProgrammingGuideClassesAndStructsRestrictingAccessorAccessibility
{
	public class ClassesAndStructsRestrictingAccessorAccessibility
	{
		public static void RunClassesAndStructsRestrictingAccessorAccessibility()
		{
			
		}
		
		private string _name = "Hello";

		public string Name
		{
		    get
		    {
		        return _name;
		    }
		    protected set
		    {
		        _name = value;
		    }
		}
	}
	
	public class Parent
	{
	    public virtual int TestProperty
	    {
	        // Notice the accessor accessibility level.
	        protected set { }
	
	        // No access modifier is used here.
	        get { return 0; }
	    }
	}
	public class Kid : Parent
	{
	    public override int TestProperty
	    {
	        // Use the same accessibility level as in the overridden accessor.
	        protected set { }
	
	        // Cannot use access modifier here.
	        get { return 0; }
	    }
	}
	
	public interface ISomeInterface
	{
	    int TestProperty
	    {
	        // No access modifier allowed here
	        // because this is an interface.
	        get;
	    }
	}
	
	public class TestClass : ISomeInterface
	{
	    public int TestProperty
	    {
	        // Cannot use access modifier here because
	        // this is an interface implementation.
	        get { return 10; }
	
	        // Interface property does not have set accessor,
	        // so access modifier is allowed.
	        protected set { }
	    }
	}
	
	public class BaseClass
	{
	    private string _name = "Name-BaseClass";
	    private string _id = "ID-BaseClass";
	
	    public string Name
	    {
	        get { return _name; }
	        set { }
	    }
	
	    public string Id
	    {
	        get { return _id; }
	        set { }
	    }
	}
	
	public class DerivedClass : BaseClass
	{
	    private string _name = "Name-DerivedClass";
	    private string _id = "ID-DerivedClass";
	
	    new public string Name
	    {
	        get
	        {
	            return _name;
	        }
	
	        // Using "protected" would make the set accessor not accessible.
	        set
	        {
	            _name = value;
	        }
	    }
	
	    // Using private on the following property hides it in the Main Class.
	    // Any assignment to the property will use Id in BaseClass.
	    new private string Id
	    {
	        get
	        {
	            return _id;
	        }
	        set
	        {
	            _id = value;
	        }
	    }
	}
	
	class MainClass
	{
	    static void RunMain()
	    {
	        BaseClass b1 = new BaseClass();
	        DerivedClass d1 = new DerivedClass();
	
	        b1.Name = "Mary";
	        d1.Name = "John";
	
	        b1.Id = "Mary123";
	        d1.Id = "John123";  // The BaseClass.Id property is called.
	
	        System.Console.WriteLine("Base: {0}, {1}", b1.Name, b1.Id);
	        System.Console.WriteLine("Derived: {0}, {1}", d1.Name, d1.Id);
	
	        // Keep the console window open in debug mode.
	        System.Console.WriteLine("Press any key to exit.");
	        System.Console.ReadKey();
	    }
	}
	/* Output:
	    Base: Name-BaseClass, ID-BaseClass
	    Derived: John, ID-BaseClass
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/interface-properties
namespace DotnetCSharpProgrammingGuideClassesAndStructsInterfaceProperties
{
	public class ClassesAndStructsInterfaceProperties
	{
		public static void RunClassesAndStructsInterfaceProperties()
		{
			System.Console.Write("Enter number of employees: ");
			Employee.numberOfEmployees = int.Parse(System.Console.ReadLine());
			
			Employee e1 = new Employee();
			System.Console.Write("Enter the name of the new employee: ");
			e1.Name = System.Console.ReadLine();
			
			System.Console.WriteLine("The employee information:");
			System.Console.WriteLine($"Employee number: {e1.Counter}");
			System.Console.WriteLine($"Employee name: {e1.Name}");
		}
	}
	
	public interface ISampleInterface
	{
	    // Property declaration:
	    string Name
	    {
	        get;
	        set;
	    }
		
		/*
		string IEmployee.Name
		{
		    get { return "Employee Name"; }
		    set { }
		}
		
		string IEmployee.Name
		{
		    get { return "Employee Name"; }
		    set { }
		}
		
		string ICitizen.Name
		{
		    get { return "Citizen Name"; }
		    set { }
		}
		*/
	}
	
	interface IEmployee
	{
	    string Name
	    {
	        get;
	        set;
	    }
	
	    int Counter
	    {
	        get;
	    }
	}
	
	public class Employee : IEmployee
	{
	    public static int numberOfEmployees;
	
	    private string _name;
	    public string Name  // read-write instance property
	    {
	        get => _name;
	        set => _name = value;
	    }
	
	    private int _counter;
	    public int Counter  // read-only instance property
	    {
	        get => _counter;
	    }
	
	    // constructor
	    public Employee() => _counter = ++numberOfEmployees;
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties
namespace DotnetCSharpProgrammingGuideClassesAndStructsUsingProperties
{
	public class ClassesAndStructsUsingProperties
	{
		public static void RunClassesAndStructsUsingProperties()
		{
			var employee = new Employee();
			//...
			
			System.Console.Write(employee.Name); // the get accessor is invoked here
			
			var student = new Student();
			student.Name = "Joe"; // the set accessor is invoked here
			
			System.Console.Write(student.Name); // the get accessor is invoked here
			
			//((Employee)m1).Name = "Mary";
			
		}
	}
	
	public class Date
	{
	    private int _month = 7;  // Backing store
	
	    public int Month
	    {
	        get => _month;
	        set
	        {
	            if ((value > 0) && (value < 13))
	            {
	                _month = value;
	            }
	        }
	    }
	}
	
	public class DateExample
	{
	    public int Month
	    {
	        get;
	        set
	        {
	            if ((value > 0) && (value < 13))
	            {
	                field = value;
	            }
	        }
	    }
	}
	
	/*
	class Employee
	{
	    private string _name;           // the name field
	    public string Name => _name;    // the Name property
	}
	*/
	
	/*
	class Manager
	{
	    private string _name;
	    public string Name => _name != null ? _name : "NA";
	}
	*/
	
	class Student
	{
	    private string _name;      // the name field
	    public string Name         // the Name property
	    {
	        get => _name;
	        set => _name = value;
	    }
	}
	
	/*
	public class Employee
	{
	    public static int NumberOfEmployees;
	    private static int _counter;
	    private string _name;
	
	    // A read-write instance property:
	    public string Name
	    {
	        get => _name;
	        set => _name = value;
	    }
	
	    // A read-only static property:
	    public static int Counter => _counter;
	
	    // A Constructor:
	    public Employee() => _counter = ++NumberOfEmployees; // Calculate the employee's number:
	}
	*/
	
	/*
	public class Employee
	{
	    private string _name;
	    public string Name
	    {
	        get => _name;
	        set => _name = value;
	    }
	}
	
	public class Manager : Employee
	{
	    private string _name;
	
	    // Notice the use of the new modifier:
	    public new string Name
	    {
	        get => _name;
	        set => _name = value + ", Manager";
	    }
	}
	
	class TestHiding
	{
	    public static void Test()
	    {
	        Manager m1 = new Manager();
	
	        // Derived class property.
	        m1.Name = "John";
	
	        // Base class property.
	        ((Employee)m1).Name = "Mary";
	
	        System.Console.WriteLine($"Name in the derived class is: {m1.Name}");
	        System.Console.WriteLine($"Name in the base class is: {((Employee)m1).Name}");
	    }
	}
	*/
	/* Output:
	    Name in the derived class is: John, Manager
	    Name in the base class is: Mary
	*/
	
	public class Employee
	{
	    private string _name;
	    public string Name
	    {
	        get => _name;
	        set => _name = value;
	    }
	}
	
	public class Manager : Employee
	{
	    private string _name;
	
	    // Notice the use of the new modifier:
	    public new string Name
	    {
	        get => _name;
	        set => _name = value + ", Manager";
	    }
	}
	
	class TestHiding
	{
	    public static void Test()
	    {
	        Manager m1 = new Manager();
	
	        // Derived class property.
	        m1.Name = "John";
	
	        // Base class property.
	        ((Employee)m1).Name = "Mary";
	
	        System.Console.WriteLine($"Name in the derived class is: {m1.Name}");
	        System.Console.WriteLine($"Name in the base class is: {((Employee)m1).Name}");
	    }
	}
	/* Output:
	    Name in the derived class is: John, Manager
	    Name in the base class is: Mary
	*/
	
	abstract class Shape
	{
	    public abstract double Area
	    {
	        get;
	        set;
	    }
	}
	
	class Square : Shape
	{
	    public double side;
	
	    //constructor
	    public Square(double s) => side = s;
	
	    public override double Area
	    {
	        get => side * side;
	        set => side = System.Math.Sqrt(value);
	    }
	}
	
	class Cube : Shape
	{
	    public double side;
	
	    //constructor
	    public Cube(double s) => side = s;
	
	    public override double Area
	    {
	        get => 6 * side * side;
	        set => side = System.Math.Sqrt(value / 6);
	    }
	}
	
	class TestShapes
	{
	    static void RunMain()
	    {
	        // Input the side:
	        System.Console.Write("Enter the side: ");
	        double side = double.Parse(System.Console.ReadLine());
	
	        // Compute the areas:
	        Square s = new Square(side);
	        Cube c = new Cube(side);
	
	        // Display the results:
	        System.Console.WriteLine($"Area of the square = {s.Area:F2}");
	        System.Console.WriteLine($"Area of the cube = {c.Area:F2}");
	        System.Console.WriteLine();
	
	        // Input the area:
	        System.Console.Write("Enter the area: ");
	        double area = double.Parse(System.Console.ReadLine());
	
	        // Compute the sides:
	        s.Area = area;
	        c.Area = area;
	
	        // Display the results:
	        System.Console.WriteLine($"Side of the square = {s.side:F2}");
	        System.Console.WriteLine($"Side of the cube = {c.side:F2}");
	    }
	}
	/* Example Output:
	    Enter the side: 4
	    Area of the square = 16.00
	    Area of the cube = 96.00
	
	    Enter the area: 24
	    Side of the square = 4.90
	    Side of the cube = 2.00
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
namespace DotnetCSharpProgrammingGuideClassesAndStructsProperties
{
	public class ClassesAndStructsProperties
	{
		public static void RunClassesAndStructsProperties()
		{
			//var aPerson = new Person("John");
			//aPerson = new Person { FirstName = "John"};
			// Error CS9035: Required member `Person.FirstName` must be set:
			//aPerson2 = new Person();
		}
	}
	
	public class Person
	{
	    //public string? FirstName;
	
	    // Omitted for brevity.
		
		//public string? FirstName { get; set; }

    	// Omitted for brevity.
		
		//public string FirstName { get; set; } = string.Empty;
		
		/*
		public string? FirstName 
	    { 
	        get;
	        set => field = value.Trim(); 
	    }
		*/
		
		//public Person() { }

	    //[SetsRequiredMembers]
	    //public Person(string firstName) => FirstName = firstName;
	
	    //public required string FirstName { get; init; }
		
		/*
		public Person() { }

	    [SetsRequiredMembers]
	    public Person(string firstName, string lastName)
	    {
	        FirstName = firstName;
	        LastName = lastName;
	    }
	
	    public required string FirstName { get; init; }
	    public required string LastName { get; init; }
	
	    public string Name => $"{FirstName} {LastName}";
		*/
	
	    // Omitted for brevity.
		
		//public string? FirstName { get; private set; }
		
		//public Person(string firstName) => FirstName = firstName;

	    //public string FirstName { get; }
	
	    // Omitted for brevity.
		
		//public Person() { }
	    //public Person(string firstName) => FirstName = firstName;
	
	    //public string? FirstName { get; init; }
	
	    // Omitted for brevity.
		
		/*
		public Person() { }

	    [SetsRequiredMembers]
	    public Person(string firstName, string lastName)
	    {
	        FirstName = firstName;
	        LastName = lastName;
	    }
	
	    public required string FirstName { get; init; }
	    public required string LastName { get; init; }
	
	    private string? _fullName;
	    public string FullName
	    {
	        get
	        {
	            if (_fullName is null)
	                _fullName = $"{FirstName} {LastName}";
	            return _fullName;
	        }
	    }
		*/
		
		private string? _firstName;
	    public string? FirstName
	    {
	        get => _firstName;
	        set
	        {
	            _firstName = value;
	            _fullName = null;
	        }
	    }
	
	    private string? _lastName;
	    public string? LastName
	    {
	        get => _lastName;
	        set
	        {
	            _lastName = value;
	            _fullName = null;
	        }
	    }
	
	    private string? _fullName;
	    public string FullName
	    {
	        get
	        {
	            if (_fullName is null)
	                _fullName = $"{FirstName} {LastName}";
	            return _fullName;
	        }
	    }

		
		
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-define-constants
namespace DotnetCSharpProgrammingGuideClassesAndStructsHowToDefineConstants
{
	
	static class Constants
	{
	    public const double Pi = 3.14159;
	    public const int SpeedOfLight = 300000; // km per sec.
	}
	
	class Program
	{
	    static void RunMain()
	    {
	        double radius = 5.3;
	        double area = Constants.Pi * (radius * radius);
	        int secsFromSun = 149476000 / Constants.SpeedOfLight; // in km
	        Console.WriteLine(secsFromSun);
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-define-abstract-properties
namespace DotnetCSharpProgrammingGuideClassesAndStructsHowToDefineAbstractProperties
{
	public class DefineAbstractProperties
	{
		
	}
	
	// compile with: csc -target:library abstractshape.cs
	public abstract class Shape
	{
	    public Shape(string s)
	    {
	        // calling the set accessor of the Id property.
	        Id = s;
	    }
	
	    public string Id { get; set; }
	
	    // Area is a read-only property - only a get accessor is needed:
	    public abstract double Area
	    {
	        get;
	    }
	
	    public override string ToString()
	    {
	        return $"{Id} Area = {Area:F2}";
	    }
	}
	
	// compile with: csc -target:library -reference:abstractshape.dll shapes.cs
public class Square : Shape
{
    private int _side;

    public Square(int side, string id)
        : base(id)
    {
        _side = side;
    }

    public override double Area
    {
        get
        {
            // Given the side, return the area of a square:
            return _side * _side;
        }
    }
}

public class Circle : Shape
{
    private int _radius;

    public Circle(int radius, string id)
        : base(id)
    {
        _radius = radius;
    }

    public override double Area
    {
        get
        {
            // Given the radius, return the area of a circle:
            return _radius * _radius * Math.PI;
        }
    }
}

	public class Rectangle : Shape
	{
	    private int _width;
	    private int _height;
	
	    public Rectangle(int width, int height, string id)
	        : base(id)
	    {
	        _width = width;
	        _height = height;
	    }
	
	    public override double Area
	    {
	        get
	        {
	            // Given the width and height, return the area of a rectangle:
	            return _width * _height;
	        }
	    }
	}
	
	// compile with: csc -reference:abstractshape.dll;shapes.dll shapetest.cs
	class TestClass
	{
	    static void RunMain()
	    {
	        Shape[] shapes =
	        [
	            new Square(5, "Square #1"),
	            new Circle(3, "Circle #1"),
	            new Rectangle( 4, 5, "Rectangle #1")
	        ];
	
	        Console.WriteLine("Shapes Collection");
	        foreach (Shape s in shapes)
	        {
	            Console.WriteLine(s);
	        }
	    }
	}
	/* Output:
	    Shapes Collection
	    Square #1 Area = 25.00
	    Circle #1 Area = 28.27
	    Rectangle #1 Area = 20.00
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants
namespace DotnetCSharpProgrammingGuideClassesAndStructsConstants
{
	public class ClassesAndStructsConstants
	{
		
	}
	
	class Calendar1
	{
	    public const int Months = 12;
	}
	
	class Calendar2
	{
	    public const int Months = 12, Weeks = 52, Days = 365;
	}
	
	class Calendar3
	{
	    public const int Months = 12;
	    public const int Weeks = 52;
	    public const int Days = 365;
	
	    public const double DaysPerWeek = (double) Days / (double) Weeks;
	    public const double DaysPerMonth = (double) Days / (double) Months;
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields
namespace DotnetCSharpProgrammingGuideClassesAndStructsFields
{
	public class ClassesAndStructsFields
	{
		public static void RunClassesAndStructsFields()
		{
			CalendarEntry birthday = new CalendarEntry();
			birthday.Day = "Saturday";
		}
	}
	
	public class CalendarEntry
	{
	
	    // private field (Located near wrapping "Date" property).
	    private DateTime _date;
	
	    // Public property exposes _date field safely.
	    public DateTime Date
	    {
	        get
	        {
	            return _date;
	        }
	        set
	        {
	            // Set some reasonable boundaries for likely birth dates.
	            if (value.Year > 1900 && value.Year <= DateTime.Today.Year)
	            {
	                _date = value;
	            }
	            else
	            {
	                throw new ArgumentOutOfRangeException("Date");
	            }
	        }
	    }
	
	    // public field (Generally not recommended).
	    public string? Day;
	
	    // Public method also exposes _date field safely.
	    // Example call: birthday.SetDate("1975, 6, 30");
	    public void SetDate(string dateString)
	    {
	        DateTime dt = DateTime.Now; //Convert.ToDateTime(dateString);
	
	        // Set some reasonable boundaries for likely birth dates.
	        if (dt.Year > 1900 && dt.Year <= DateTime.Today.Year)
	        {
	            _date = dt;
	        }
	        else
	        {
	            throw new ArgumentOutOfRangeException("dateString");
	        }
	    }
	
	    public TimeSpan GetTimeSpan(string dateString)
	    {
	        DateTime dt = DateTime.Now; //Convert.ToDateTime(dateString);
	
	        if (dt.Ticks < _date.Ticks)
	        {
	            return _date - dt;
	        }
	        else
	        {
	            throw new ArgumentOutOfRangeException("dateString");
	        }
	    }
	}
	
	public class CalendarDateWithInitialization
	{
	    public string Day = "Monday";
	    //...
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
namespace DotnetCSharpProgrammingGuideClassesAndStructsAccessModifiers
{
	public class ClassesAndStructsAccessModifiers
	{
		public static void RunClassesAndStructsAccessModifiers()
		{
			
		}
	}
	
	// public class:
	public class Tricycle
	{
	    // protected method:
	    protected void Pedal() { }
	
	    // private field:
	    private int _wheels = 3;
	
	    // protected internal property:
	    protected internal int Wheels => _wheels;
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
namespace DotnetCSharpProgrammingGuideClassesAndStructsStaticClassesAndStaticClassMembers
{
	public class StaticClassesAndStaticClassMembers
	{
		public static void RunStaticClassesAndStaticClassMembers()
		{
			double dub = -3.14;
			Console.WriteLine(Math.Abs(dub));
			Console.WriteLine(Math.Floor(dub));
			Console.WriteLine(Math.Round(Math.Abs(dub)));
			
			// Output:
			// 3.14
			// -4
			// 3
		}
	}
	
	public static class TemperatureConverter
	{
	    public static double CelsiusToFahrenheit(string temperatureCelsius) =>
	        double.Parse(temperatureCelsius) * 9 / 5 + 32;
	
	    public static double FahrenheitToCelsius(string temperatureFahrenheit) =>
	        (double.Parse(temperatureFahrenheit) - 32) * 5 / 9;
	}
	
	class TestTemperatureConverter
	{
	    static void RunMain()
	    {
	        Console.WriteLine("Please select the convertor direction");
	        Console.WriteLine("1. From Celsius to Fahrenheit.");
	        Console.WriteLine("2. From Fahrenheit to Celsius.");
	        Console.Write(":");
	
	        string? selection = Console.ReadLine();
	
	        switch (selection)
	        {
	            case "1":
	                Console.Write("Please enter the Celsius temperature: ");
	                var f = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine() ?? "0");
	                Console.WriteLine($"Temperature in Fahrenheit: {f:F2}");
	                break;
	
	            case "2":
	                Console.Write("Please enter the Fahrenheit temperature: ");
	                var c = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine() ?? "0");
	                Console.WriteLine($"Temperature in Celsius: {c:F2}");
	                break;
	
	            default:
	                Console.WriteLine("Please select a convertor.");
	                break;
	        }
	
	        // Keep the console window open in debug mode.
	        Console.WriteLine("Press any key to exit.");
	        Console.ReadKey();
			
			Automobile.Drive();
			var i = Automobile.NumberOfWheels;
	    }
	}
	/* Example Output:
	    Please select the convertor direction
	    1. From Celsius to Fahrenheit.
	    2. From Fahrenheit to Celsius.
	    :2
	    Please enter the Fahrenheit temperature: 20
	    Temperature in Celsius: -6.67
	    Press any key to exit.
	 */
	 
	 public class Automobile
	{
	    public static int NumberOfWheels = 4;
	
	    public static int SizeOfGasTank => 15;
	
	    public static void Drive() { }
	
	    //public static event EventType? RunOutOfGas;
	
	    // Other non-static fields and properties...
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members
namespace DotnetCSharpProgrammingGuideClassesAndStructsAbstractAndSealedClassesAndClassMembers
{
	public class ClassesAndStructsAbstractAndSealedClassesAndClassMembers
	{
		public static void RunClassesAndStructsAbstractAndSealedClassesAndClassMembers()
		{
			
		}
	}
	
	public abstract class A
	{
	    public abstract void DoWork(int i);
	}
	
	// compile with: -target:library
	public class D
	{
	    public virtual void DoWork(int i)
	    {
	        // Original implementation.
	    }
	}
	
	public abstract class E : D
	{
	    public abstract override void DoWork(int i);
	}
	
	public class F : E
	{
	    public override void DoWork(int i)
	    {
	        // New implementation.
	    }
	}
	
	/*
	public sealed class D
	{
	    // Class members here.
	}
	
	public class D : C
	{
	    public sealed override void DoWork() { }
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method
namespace DotnetCSharpProgrammingGuideClassesAndStructsHowToOverrideTheToStringMethod
{
	public class OverrideTheToStringMethod
	{
		public static void RunOverrideTheToStringMethod()
		{
			int x = 42;
			string strx = x.ToString();
			Console.WriteLine(strx);
			// Output:
			// 42
			
			Person person = new() { Name = "John", Age = 12 };
			Console.WriteLine(person);
			// Output:
			// Person: John 12
		}
	}
	
	class Person
	{
	    public string Name { get; set; }
	    public int Age { get; set; }
	
	    public override string ToString()
	    {
	        return "Person: " + Name + " " + Age;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
namespace DotnetCSharpProgrammingGuideClassesAndStructsKnowingWhenToUseOverrideAndNewKeywords
{
	public class OverrideAndNewKeywords
	{
		public static void RunOverrideAndNewKeywords()
		{
			
		}
	}
	
	class BaseClass  
	{  
	    public void Method1()  
	    {  
	        Console.WriteLine("Base - Method1");  
	    }  
		
		
		/*
		public virtual void Method1()  
		{  
		    Console.WriteLine("Base - Method1");  
		}
		*/
	}  
	  
	class DerivedClass : BaseClass  
	{  
	    public void Method2()  
	    {  
	        Console.WriteLine("Derived - Method2");  
	    }  
		
		/*
		public new void Method2()  
		{  
		    Console.WriteLine("Derived - Method2");  
		}
		*/
		
		/*
		public override void Method1()  
		{  
		    Console.WriteLine("Derived - Method1");  
		}
		*/
		
		
	}
	
	class Program  
	{  
	    static void RunMain(string[] args)  
	    {  
	        BaseClass bc = new BaseClass();  
	        DerivedClass dc = new DerivedClass();  
	        BaseClass bcdc = new DerivedClass();  
	  
	        bc.Method1();  
	        dc.Method1();  
	        dc.Method2();  
	        bcdc.Method1();  
	    }  
	    // Output:  
	    // Base - Method1  
	    // Base - Method1  
	    // Derived - Method2  
	    // Base - Method1  
		
		public static void TestCars1()  
		{  
		    System.Console.WriteLine("\nTestCars1");  
		    System.Console.WriteLine("----------");  
		  
		    Car car1 = new Car();  
		    car1.DescribeCar();  
		    System.Console.WriteLine("----------");  
		  
		    // Notice the output from this test case. The new modifier is  
		    // used in the definition of ShowDetails in the ConvertibleCar  
		    // class.
		  
		    Car car2 = new ConvertibleCar();  
		    car2.DescribeCar();  
		    System.Console.WriteLine("----------");  
		  
		    Minivan car3 = new Minivan();  
		    car3.DescribeCar();  
		    System.Console.WriteLine("----------");  
		}
		
		public static void TestCars2()  
		{  
		    System.Console.WriteLine("\nTestCars2");  
		    System.Console.WriteLine("----------");  
		  
		    var cars = new List<Car> { new Car(), new ConvertibleCar(),
		        new Minivan() };  
		  
		    foreach (var car in cars)  
		    {  
		        car.DescribeCar();  
		        System.Console.WriteLine("----------");  
		    }  
		}
		
		public static void TestCars3()  
		{  
		    System.Console.WriteLine("\nTestCars3");  
		    System.Console.WriteLine("----------");  
		    ConvertibleCar car2 = new ConvertibleCar();  
		    Minivan car3 = new Minivan();  
		    car2.ShowDetails();  
		    car3.ShowDetails();  
		}  
		  
		public static void TestCars4()  
		{  
		    System.Console.WriteLine("\nTestCars4");  
		    System.Console.WriteLine("----------");  
		    Car car2 = new ConvertibleCar();  
		    Car car3 = new Minivan();  
		    car2.ShowDetails();  
		    car3.ShowDetails();  
		}
	}
	
	namespace OverrideAndNew  
	{  
	    class Program  
	    {  
	        static void RunMain(string[] args)  
	        {  
	            BaseClass bc = new BaseClass();  
	            DerivedClass dc = new DerivedClass();  
	            BaseClass bcdc = new DerivedClass();  
	  
	            // The following two calls do what you would expect. They call  
	            // the methods that are defined in BaseClass.  
	            bc.Method1();  
	            bc.Method2();  
	            // Output:  
	            // Base - Method1  
	            // Base - Method2  
	  
	            // The following two calls do what you would expect. They call  
	            // the methods that are defined in DerivedClass.  
	            dc.Method1();  
	            dc.Method2();  
	            // Output:  
	            // Derived - Method1  
	            // Derived - Method2  
	  
	            // The following two calls produce different results, depending
	            // on whether override (Method1) or new (Method2) is used.  
	            bcdc.Method1();  
	            bcdc.Method2();  
	            // Output:  
	            // Derived - Method1  
	            // Base - Method2  
	        }  
	    }  
	  
	    class BaseClass  
	    {  
	        public virtual void Method1()  
	        {  
	            Console.WriteLine("Base - Method1");  
	        }  
	  
	        public virtual void Method2()  
	        {  
	            Console.WriteLine("Base - Method2");  
	        }  
	    }  
	  
	    class DerivedClass : BaseClass  
	    {  
	        public override void Method1()  
	        {  
	            Console.WriteLine("Derived - Method1");  
	        }  
	  
	        public new void Method2()  
	        {  
	            Console.WriteLine("Derived - Method2");  
	        }  
	    }  
	} 
	
	// Define the base class, Car. The class defines two methods,  
	// DescribeCar and ShowDetails. DescribeCar calls ShowDetails, and each derived  
	// class also defines a ShowDetails method. The example tests which version of  
	// ShowDetails is selected, the base class method or the derived class method.  
	class Car  
	{  
	    public void DescribeCar()  
	    {  
	        System.Console.WriteLine("Four wheels and an engine.");  
	        ShowDetails();  
	    }  
	  
	    public virtual void ShowDetails()  
	    {  
	        System.Console.WriteLine("Standard transportation.");  
	    }  
	}  
	  
	// Define the derived classes.  
	  
	// Class ConvertibleCar uses the new modifier to acknowledge that ShowDetails  
	// hides the base class method.  
	class ConvertibleCar : Car  
	{  
	    public new void ShowDetails()  
	    {  
	        System.Console.WriteLine("A roof that opens up.");  
	    }  
	}  
	  
	// Class Minivan uses the override modifier to specify that ShowDetails  
	// extends the base class method.  
	class Minivan : Car  
	{  
	    public override void ShowDetails()  
	    {  
	        System.Console.WriteLine("Carries seven people.");  
	    }  
	} 
	
	namespace OverrideAndNew2  
	{  
	    class Program  
	    {  
	        static void RunMain(string[] args)  
	        {  
	            // Declare objects of the derived classes and test which version  
	            // of ShowDetails is run, base or derived.  
	            TestCars1();  
	  
	            // Declare objects of the base class, instantiated with the  
	            // derived classes, and repeat the tests.  
	            TestCars2();  
	  
	            // Declare objects of the derived classes and call ShowDetails  
	            // directly.  
	            TestCars3();  
	  
	            // Declare objects of the base class, instantiated with the  
	            // derived classes, and repeat the tests.  
	            TestCars4();  
	        }  
	  
	        public static void TestCars1()  
	        {  
	            System.Console.WriteLine("\nTestCars1");  
	            System.Console.WriteLine("----------");  
	  
	            Car car1 = new Car();  
	            car1.DescribeCar();  
	            System.Console.WriteLine("----------");  
	  
	            // Notice the output from this test case. The new modifier is  
	            // used in the definition of ShowDetails in the ConvertibleCar  
	            // class.
	            ConvertibleCar car2 = new ConvertibleCar();  
	            car2.DescribeCar();  
	            System.Console.WriteLine("----------");  
	  
	            Minivan car3 = new Minivan();  
	            car3.DescribeCar();  
	            System.Console.WriteLine("----------");  
	        }  
	        // Output:  
	        // TestCars1  
	        // ----------  
	        // Four wheels and an engine.  
	        // Standard transportation.  
	        // ----------  
	        // Four wheels and an engine.  
	        // Standard transportation.  
	        // ----------  
	        // Four wheels and an engine.  
	        // Carries seven people.  
	        // ----------  
	  
	        public static void TestCars2()  
	        {  
	            System.Console.WriteLine("\nTestCars2");  
	            System.Console.WriteLine("----------");  
	  
	            var cars = new List<Car> { new Car(), new ConvertibleCar(),
	                new Minivan() };  
	  
	            foreach (var car in cars)  
	            {  
	                car.DescribeCar();  
	                System.Console.WriteLine("----------");  
	            }  
	        }  
	        // Output:  
	        // TestCars2  
	        // ----------  
	        // Four wheels and an engine.  
	        // Standard transportation.  
	        // ----------  
	        // Four wheels and an engine.  
	        // Standard transportation.  
	        // ----------  
	        // Four wheels and an engine.  
	        // Carries seven people.  
	        // ----------  
	  
	        public static void TestCars3()  
	        {  
	            System.Console.WriteLine("\nTestCars3");  
	            System.Console.WriteLine("----------");  
	            ConvertibleCar car2 = new ConvertibleCar();  
	            Minivan car3 = new Minivan();  
	            car2.ShowDetails();  
	            car3.ShowDetails();  
	        }  
	        // Output:  
	        // TestCars3  
	        // ----------  
	        // A roof that opens up.  
	        // Carries seven people.  
	  
	        public static void TestCars4()  
	        {  
	            System.Console.WriteLine("\nTestCars4");  
	            System.Console.WriteLine("----------");  
	            Car car2 = new ConvertibleCar();  
	            Car car3 = new Minivan();  
	            car2.ShowDetails();  
	            car3.ShowDetails();  
	        }  
	        // Output:  
	        // TestCars4  
	        // ----------  
	        // Standard transportation.  
	        // Carries seven people.  
	    }  
	  
	    // Define the base class, Car. The class defines two virtual methods,  
	    // DescribeCar and ShowDetails. DescribeCar calls ShowDetails, and each derived  
	    // class also defines a ShowDetails method. The example tests which version of  
	    // ShowDetails is used, the base class method or the derived class method.  
	    class Car  
	    {  
	        public virtual void DescribeCar()  
	        {  
	            System.Console.WriteLine("Four wheels and an engine.");  
	            ShowDetails();  
	        }  
	  
	        public virtual void ShowDetails()  
	        {  
	            System.Console.WriteLine("Standard transportation.");  
	        }  
	    }  
	  
	    // Define the derived classes.  
	  
	    // Class ConvertibleCar uses the new modifier to acknowledge that ShowDetails  
	    // hides the base class method.  
	    class ConvertibleCar : Car  
	    {  
	        public new void ShowDetails()  
	        {  
	            System.Console.WriteLine("A roof that opens up.");  
	        }  
	    }  
	  
	    // Class Minivan uses the override modifier to specify that ShowDetails  
	    // extends the base class method.  
	    class Minivan : Car  
	    {  
	        public override void ShowDetails()  
	        {  
	            System.Console.WriteLine("Carries seven people.");  
	        }  
	    }  
	  
	} 
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/versioning-with-the-override-and-new-keywords
namespace DotnetCSharpProgrammingGuideClassesAndStructsVersioningWithTheOverrideAndNewKeywords
{
	public class TheOverrideAndNewKeywords
	{
		public static void RunTheOverrideAndNewKeywords()
		{
			/*
			int val = 5;
			Derived d = new();
			d.DoWork(val);  // Calls DoWork(double).
			*/
			
			//((Base)d).DoWork(val);  // Calls DoWork(int) on Derived.
		}
	}
	
	class GraphicsClass
	{
	    public virtual void DrawLine() { }
	    public virtual void DrawPoint() { }
	    public virtual void DrawRectangle() { }
	}
	
	class YourDerivedGraphicsClass : GraphicsClass
	{
	    public override void DrawRectangle() { }
	}
	
	class YourDerivedGraphicsClass2 : GraphicsClass
	{
	    public new void DrawRectangle() { }
	}
	
	/*
	public class Derived : Base
	{
	    public override void DoWork(int param) { }
	    public void DoWork(double param) { }
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-between-hexadecimal-strings-and-numeric-types
namespace DotnetCSharpProgrammingGuideTypesHowToConvertBetweenHexadecimalStringsAndNumericTypes
{
	public class HexadecimalStringsAndNumericTypes
	{
		public static void RunHexadecimalStringsAndNumericTypes()
		{
			string input = "Hello World!";
			char[] values = input.ToCharArray();
			foreach (char letter in values)
			{
			    // Get the integral value of the character.
			    int value = 5; //Convert.ToInt32(letter);
			    // Convert the integer value to a hexadecimal value in string form.
			    Console.WriteLine($"Hexadecimal value of {letter} is {value:X}");
			}
			/* Output:
			    Hexadecimal value of H is 48
			    Hexadecimal value of e is 65
			    Hexadecimal value of l is 6C
			    Hexadecimal value of l is 6C
			    Hexadecimal value of o is 6F
			    Hexadecimal value of   is 20
			    Hexadecimal value of W is 57
			    Hexadecimal value of o is 6F
			    Hexadecimal value of r is 72
			    Hexadecimal value of l is 6C
			    Hexadecimal value of d is 64
			    Hexadecimal value of ! is 21
			 */
			 
			 string hexValues = "48 65 6C 6C 6F 20 57 6F 72 6C 64 21";
			string[] hexValuesSplit = hexValues.Split(' ');
			foreach (string hex in hexValuesSplit)
			{
			    // Convert the number expressed in base-16 to an integer.
			    int value = 5; //Convert.ToInt32(hex, 16);
			    // Get the character corresponding to the integral value.
			    string stringValue = char.ConvertFromUtf32(value);
			    char charValue = (char)value;
			    Console.WriteLine("hexadecimal value = {0}, int value = {1}, char value = {2} or {3}",
			                        hex, value, stringValue, charValue);
			}
			/* Output:
			    hexadecimal value = 48, int value = 72, char value = H or H
			    hexadecimal value = 65, int value = 101, char value = e or e
			    hexadecimal value = 6C, int value = 108, char value = l or l
			    hexadecimal value = 6C, int value = 108, char value = l or l
			    hexadecimal value = 6F, int value = 111, char value = o or o
			    hexadecimal value = 20, int value = 32, char value =   or
			    hexadecimal value = 57, int value = 87, char value = W or W
			    hexadecimal value = 6F, int value = 111, char value = o or o
			    hexadecimal value = 72, int value = 114, char value = r or r
			    hexadecimal value = 6C, int value = 108, char value = l or l
			    hexadecimal value = 64, int value = 100, char value = d or d
			    hexadecimal value = 21, int value = 33, char value = ! or !
			*/
			
			string hexString = "8E2";
			int num = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
			Console.WriteLine(num);
			//Output: 2274
			
			string hexString2 = "43480170";
			uint num2 = uint.Parse(hexString2, System.Globalization.NumberStyles.AllowHexSpecifier);
			
			byte[] floatVals = BitConverter.GetBytes(num2);
			float f = BitConverter.ToSingle(floatVals, 0);
			Console.WriteLine($"float convert = {f}");
			
			byte[] vals = [0x01, 0xAA, 0xB1, 0xDC, 0x10, 0xDD];

			string str = BitConverter.ToString(vals);
			Console.WriteLine(str);
			
			str = BitConverter.ToString(vals).Replace("-", "");
			Console.WriteLine(str);
			
			/*Output:
			  01-AA-B1-DC-10-DD
			  01AAB1DC10DD
			 */
			
			// Output: 200.0056
			
			byte[] array = [0x64, 0x6f, 0x74, 0x63, 0x65, 0x74];

			//string hexValue = Convert.ToHexString(array);
			//Console.WriteLine(hexValue);
			
			/*Output:
			  646F74636574
			 */
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
namespace DotnetCSharpProgrammingGuideTypesHowToConvertAStringToANumber
{
	public class ConvertAStringToANumber
	{
		public class RunConvertAStringToANumber()
		{
			
		}
		
		public static class StringConversion
		{
		    public static void RunMain()
		    {
		        string input = String.Empty;
		        try
		        {
		            int result = Int32.Parse(input);
		            Console.WriteLine(result);
		        }
		        catch (FormatException)
		        {
		            Console.WriteLine($"Unable to parse '{input}'");
		        }
		        // Output: Unable to parse ''
		
		        try
		        {
		            int numVal = Int32.Parse("-105");
		            Console.WriteLine(numVal);
		        }
		        catch (FormatException e)
		        {
		            Console.WriteLine(e.Message);
		        }
		        // Output: -105
		
		        if (Int32.TryParse("-105", out int j))
		        {
		            Console.WriteLine(j);
		        }
		        else
		        {
		            Console.WriteLine("String could not be parsed.");
		        }
		        // Output: -105
		
		        try
		        {
		            int m = Int32.Parse("abc");
		        }
		        catch (FormatException e)
		        {
		            Console.WriteLine(e.Message);
		        }
		        // Output: Input string was not in a correct format.
		
		        const string inputString = "abc";
		        if (Int32.TryParse(inputString, out int numValue))
		        {
		            Console.WriteLine(numValue);
		        }
		        else
		        {
		            Console.WriteLine($"Int32.TryParse could not parse '{inputString}' to an int.");
		        }
		        // Output: Int32.TryParse could not parse 'abc' to an int.
		    }
			
			public static void RunMain2()
		    {
		        var str = "  10FFxxx";
		        string numericString = string.Empty;
		        foreach (var c in str)
		        {
		            // Check for numeric characters (hex in this case) or leading or trailing spaces.
		            if ((c >= '0' && c <= '9') || (char.ToUpperInvariant(c) >= 'A' && char.ToUpperInvariant(c) <= 'F') || c == ' ')
		            {
		                numericString = string.Concat(numericString, c.ToString());
		            }
		            else
		            {
		                break;
		            }
		        }
		
		        if (int.TryParse(numericString, System.Globalization.NumberStyles.HexNumber, null, out int i))
		        {
		            Console.WriteLine($"'{str}' --> '{numericString}' --> {i}");
		        }
		        // Output: '  10FFxxx' --> '  10FF' --> 4351
		
		        str = "   -10FFXXX";
		        numericString = "";
		        foreach (char c in str)
		        {
		            // Check for numeric characters (0-9), a negative sign, or leading or trailing spaces.
		            if ((c >= '0' && c <= '9') || c == ' ' || c == '-')
		            {
		                numericString = string.Concat(numericString, c);
		            }
		            else
		            {
		                break;
		            }
		        }
		
		        if (int.TryParse(numericString, out int j))
		        {
		            Console.WriteLine($"'{str}' --> '{numericString}' --> {j}");
		        }
		        // Output: '   -10FFXXX' --> '   -10' --> -10
		    }
		}
	}
	
	public class ConvertStringExample1
	{
	    static void RunMain(string[] args)
	    {
	        int numVal = -1;
	        bool repeat = true;
	
	        while (repeat)
	        {
	            Console.Write("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive): ");
	
	            string? input = Console.ReadLine();
	
	            // ToInt32 can throw FormatException or OverflowException.
	            try
	            {
	                numVal = 5; //Convert.ToInt32(input);
	                if (numVal < Int32.MaxValue)
	                {
	                    Console.WriteLine($"The new value is {++numVal}");
	                }
	                else
	                {
	                    Console.WriteLine("numVal cannot be incremented beyond its current value");
	                }
	           }
	            catch (FormatException)
	            {
	                Console.WriteLine("Input string is not a sequence of digits.");
	            }
	            catch (OverflowException)
	            {
	                Console.WriteLine("The number cannot fit in an Int32.");
	            }
	
	            Console.Write("Go again? Y/N: ");
	            string? go = Console.ReadLine();
	            if (go?.ToUpper() != "Y")
	            {
	                repeat = false;
	            }
	        }
	    }
	}
	// Sample Output:
	//   Enter a number between -2,147,483,648 and +2,147,483,647 (inclusive): 473
	//   The new value is 474
	//   Go again? Y/N: y
	//   Enter a number between -2,147,483,648 and +2,147,483,647 (inclusive): 2147483647
	//   numVal cannot be incremented beyond its current value
	//   Go again? Y/N: y
	//   Enter a number between -2,147,483,648 and +2,147,483,647 (inclusive): -1000
	//   The new value is -999
	//   Go again? Y/N: n
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-byte-array-to-an-int
namespace DotnetCSharpProgrammingGuideTypesHowToConvertAByteArrayToAnInt
{
	public class ByteArrayToAnInt
	{
		public static void RunByteArrayToAnInt()
		{
			byte[] bytes = [0, 0, 0, 25];

			// If the system architecture is little-endian (that is, little end first),
			// reverse the byte array.
			if (BitConverter.IsLittleEndian)
			    Array.Reverse(bytes);
			
			int i = BitConverter.ToInt32(bytes, 0);
			Console.WriteLine($"int: {i}");
			// Output: int: 25
			
			byte[] bytes2 = BitConverter.GetBytes(201805978);
			Console.WriteLine($"byte array: {BitConverter.ToString(bytes2)}");
			// Output: byte array: 9A-50-07-0C
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
namespace DotnetCSharpProgrammingGuideTypesCastingAndTypeConversions
{
	public class CastingAndTypeConversions
	{
		public static void RunCastingAndTypeConversions()
		{
			int i;

			// error CS0029: can't implicitly convert type 'string' to 'int'
			//i = "Hello";
			
			// Implicit conversion. A long can
			// hold any value an int can hold, and more!
			int num = 2147483647;
			long bigNum = num;
			
			/*
			Derived d = new Derived();

			// Always OK.
			Base b = d;
			*/
			
			double x = 1234.7;
			int a;
			// Cast double to int.
			a = (int)x;
			Console.WriteLine(a);
			// Output: 1234
			
			/*
			Animal a = new Mammal();
			Reptile r = (Reptile)a; // InvalidCastException at run time
			*/
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
namespace DotnetCShapProgrammingGuideTypesBoxingAndUnboxing
{
	public class BoxingAndUnboxing
	{
		public static void RunBoxingAndUnboxing()
		{
			int i = 123;
			// The following line boxes i.
			object o = i;
			
			o = 123;
			i = (int)o;  // unboxing
			
			// String.Concat example.
			// String.Concat has many versions. Rest the mouse pointer on
			// Concat in the following statement to verify that the version
			// that is used here takes three object arguments. Both 42 and
			// true must be boxed.
			Console.WriteLine(String.Concat("Answer", 42, true));
			
			// List example.
			// Create a list of objects to hold a heterogeneous collection
			// of elements.
			List<object> mixedList = [];
			
			// Add a string element to the list.
			mixedList.Add("First Group:");
			
			// Add some integers to the list.
			for (int j = 1; j < 5; j++)
			{
			    // Rest the mouse pointer over j to verify that you are adding
			    // an int to a list of objects. Each element j is boxed when
			    // you add j to mixedList.
			    mixedList.Add(j);
			}
			
			// Add another string and more integers.
			mixedList.Add("Second Group:");
			for (int j = 5; j < 10; j++)
			{
			    mixedList.Add(j);
			}
			
			// Display the elements in the list. Declare the loop variable by
			// using var, so that the compiler assigns its type.
			foreach (var item in mixedList)
			{
			    // Rest the mouse pointer over item to verify that the elements
			    // of mixedList are objects.
			    Console.WriteLine(item);
			}
			
			// The following loop sums the squares of the first group of boxed
			// integers in mixedList. The list elements are objects, and cannot
			// be multiplied or added to the sum until they are unboxed. The
			// unboxing must be done explicitly.
			var sum = 0;
			for (var j = 1; j < 5; j++)
			{
			    // The following statement causes a compiler error: Operator
			    // '*' cannot be applied to operands of type 'object' and
			    // 'object'.
			    //sum += mixedList[j] * mixedList[j];
			
			    // After the list elements are unboxed, the computation does
			    // not cause a compiler error.
			    sum += (int)mixedList[j] * (int)mixedList[j];
			}
			
			Console.WriteLine($"Sum: {sum}");
			
			// Output:
			// Answer42True
			// First Group:
			// 1
			// 2
			// 3
			// 4
			// Second Group:
			// 5
			// 6
			// 7
			// 8
			// 9
			// Sum: 30
			
			int i2 = 123;
			
			// Boxing copies the value of i into object o.
			object o2 = i2;
			
			int i3 = 123;
			object o3 = (object)i3;  // explicit boxing
			
			// Create an int variable
	        int i4 = 123;
	        
	        // Box the value type into an object reference
	        object o4 = i4;  // boxing
	        
	        // Display the initial values
	        Console.WriteLine($"Value of i: {i4}");
	        Console.WriteLine($"Value of boxed object o: {o4}");
	        
	        // Modify the original value type
	        i4 = 456;
	        
	        // Display the values after modification
	        Console.WriteLine("\nAfter changing i to 456:");
	        Console.WriteLine($"Value of i: {i4}");
	        Console.WriteLine($"Value of boxed object o: {o}");
	        
	        // Output:
	        // Value of i: 123
	        // Value of boxed object o: 123
	
	        // After changing i to 456:
	        // Value of i: 456
	        // Value of boxed object o: 123
			
			
			int i5 = 123;      // a value type
			object o5 = i5;     // boxing
			int j5 = (int)o5;   // unboxing
			
		}
	}
	
	class TestUnboxing
	{
	    static void RunMain()
	    {
	        int i = 123;
	        object o = i;  // implicit boxing
	
	        try
	        {
	            int j = (short)o;  // attempt to unbox
	
	            Console.WriteLine("Unboxing OK.");
	        }
	        catch (InvalidCastException e)
	        {
	            Console.WriteLine($"{e.Message} Error: Incorrect unboxing.");
	        }
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/how-to-test-for-reference-equality-identity
namespace DotnetCSharpProgrammingGuideStatementsExpressionsOperatorsHowToTestForReferenceEqualityIdentity
{
	namespace TestReferenceEquality
	{
	    struct TestStruct
	    {
	        public int Num { get; private set; }
	        public string Name { get; private set; }
	
	        public TestStruct(int i, string s) : this()
	        {
	            Num = i;
	            Name = s;
	        }
	    }
	
	    class TestClass
	    {
	        public int Num { get; set; }
	        public string? Name { get; set; }
	    }
	
	    class Program
	    {
	        static void RunMain()
	        {
	            // Demonstrate reference equality with reference types.
	            #region ReferenceTypes
	
	            // Create two reference type instances that have identical values.
	            TestClass tcA = new TestClass() { Num = 1, Name = "New TestClass" };
	            TestClass tcB = new TestClass() { Num = 1, Name = "New TestClass" };
	
	            Console.WriteLine($"ReferenceEquals(tcA, tcB) = {Object.ReferenceEquals(tcA, tcB)}"); // false
	
	            // After assignment, tcB and tcA refer to the same object.
	            // They now have reference equality.
	            tcB = tcA;
	            Console.WriteLine($"After assignment: ReferenceEquals(tcA, tcB) = {Object.ReferenceEquals(tcA, tcB)}"); // true
	
	            // Changes made to tcA are reflected in tcB. Therefore, objects
	            // that have reference equality also have value equality.
	            tcA.Num = 42;
	            tcA.Name = "TestClass 42";
	            Console.WriteLine($"tcB.Name = {tcB.Name} tcB.Num: {tcB.Num}");
	            #endregion
	
	            // Demonstrate that two value type instances never have reference equality.
	            #region ValueTypes
	
	            TestStruct tsC = new TestStruct( 1, "TestStruct 1");
	
	            // Value types are boxed into separate objects when passed to ReferenceEquals.
	            // Even if the same variable is used twice, boxing ensures they are different instances.
	            TestStruct tsD = tsC;
	            Console.WriteLine($"After assignment: ReferenceEquals(tsC, tsD) = {Object.ReferenceEquals(tsC, tsD)}"); // false
	            #endregion
	
	            #region stringRefEquality
	            // Constant strings within the same assembly are always interned by the runtime.
	            // This means they are stored in the same location in memory. Therefore,
	            // the two strings have reference equality although no assignment takes place.
	            string strA = "Hello world!";
	            string strB = "Hello world!";
	            Console.WriteLine($"ReferenceEquals(strA, strB) = {Object.ReferenceEquals(strA, strB)}"); // true
	
	            // After a new string is assigned to strA, strA and strB
	            // are no longer interned and no longer have reference equality.
	            strA = "Goodbye world!";
	            Console.WriteLine($"strA = '{strA}' strB = '{strB}'");
	
	            Console.WriteLine("After strA changes, ReferenceEquals(strA, strB) = {0}",
	                            Object.ReferenceEquals(strA, strB)); // false
	
	            // A string that is created at runtime cannot be interned.
	            StringBuilder sb = new StringBuilder("Hello world!");
	            string stringC = sb.ToString();
	            // False:
	            Console.WriteLine($"ReferenceEquals(stringC, strB) = {Object.ReferenceEquals(stringC, strB)}");
	
	            // The string class overloads the == operator to perform an equality comparison.
	            Console.WriteLine($"stringC == strB = {stringC == strB}"); // true
	
	            #endregion
	
	            // Keep the console open in debug mode.
	            Console.WriteLine("Press any key to exit.");
	            Console.ReadKey();
	        }
	    }
	}
	
	/* Output:
	    ReferenceEquals(tcA, tcB) = False
	    After assignment: ReferenceEquals(tcA, tcB) = True
	    tcB.Name = TestClass 42 tcB.Num: 42
	    After assignment: ReferenceEquals(tsC, tsD) = False
	    ReferenceEquals(strA, strB) = True
	    strA = "Goodbye world!" strB = "Hello world!"
	    After strA changes, ReferenceEquals(strA, strB) = False
	    ReferenceEquals(stringC, strB) = False
	    stringC == strB = True
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/how-to-define-value-equality-for-a-type
namespace DotnetCSharpProgrammingGuideStatementsExpressionsOperatorsHowToDefineValueEqualityForAType
{
	public class HowToDefineValueEqualityForAType
	{
		
	}
	
	//public record TwoDPoint(int X, int Y);

	//public record ThreeDPoint(int X, int Y, int Z) : TwoDPoint(X, Y);
	
	class Program
	{
	    static void RunMain(string[] args)
	    {
	        // Create some points
	        TwoDPoint pointA = new TwoDPoint(3, 4);
	        TwoDPoint pointB = new TwoDPoint(3, 4);
	        TwoDPoint pointC = new TwoDPoint(5, 6);
	        
	        ThreeDPoint point3D_A = new ThreeDPoint(3, 4, 5);
	        ThreeDPoint point3D_B = new ThreeDPoint(3, 4, 5);
	        ThreeDPoint point3D_C = new ThreeDPoint(3, 4, 7);
	
	        Console.WriteLine("=== Value Equality with Records ===");
	        
	        // Value equality works automatically
	        Console.WriteLine($"pointA.Equals(pointB) = {pointA.Equals(pointB)}"); // True
	        Console.WriteLine($"pointA == pointB = {pointA == pointB}"); // True
	        Console.WriteLine($"pointA.Equals(pointC) = {pointA.Equals(pointC)}"); // False
	        Console.WriteLine($"pointA == pointC = {pointA == pointC}"); // False
	
	        Console.WriteLine("\n=== Hash Codes ===");
	        
	        // Equal objects have equal hash codes automatically
	        Console.WriteLine($"pointA.GetHashCode() = {pointA.GetHashCode()}");
	        Console.WriteLine($"pointB.GetHashCode() = {pointB.GetHashCode()}");
	        Console.WriteLine($"pointC.GetHashCode() = {pointC.GetHashCode()}");
	        
	        Console.WriteLine("\n=== Inheritance with Records ===");
	        
	        // Inheritance works correctly with value equality
	        Console.WriteLine($"point3D_A.Equals(point3D_B) = {point3D_A.Equals(point3D_B)}"); // True
	        Console.WriteLine($"point3D_A == point3D_B = {point3D_A == point3D_B}"); // True
	        Console.WriteLine($"point3D_A.Equals(point3D_C) = {point3D_A.Equals(point3D_C)}"); // False
	        
	        // Different types are not equal (unlike problematic class example)
	        Console.WriteLine($"pointA.Equals(point3D_A) = {pointA.Equals(point3D_A)}"); // False
	        
	        Console.WriteLine("\n=== Collections ===");
	        
	        // Works seamlessly with collections
	        var pointSet = new HashSet<TwoDPoint> { pointA, pointB, pointC };
	        Console.WriteLine($"Set contains {pointSet.Count} unique points"); // 2 unique points
	        
	        var pointDict = new Dictionary<TwoDPoint, string>
	        {
	            { pointA, "First point" },
	            { pointC, "Different point" }
	        };
	        
	        // Demonstrate that equivalent points work as the same key
	        var duplicatePoint = new TwoDPoint(3, 4);
	        Console.WriteLine($"Dictionary contains key for {duplicatePoint}: {pointDict.ContainsKey(duplicatePoint)}"); // True
	        Console.WriteLine($"Dictionary contains {pointDict.Count} entries"); // 2 entries
	        
	        Console.WriteLine("\n=== String Representation ===");
	        
	        // Automatic ToString implementation
	        Console.WriteLine($"pointA.ToString() = {pointA}");
	        Console.WriteLine($"point3D_A.ToString() = {point3D_A}");
	
	        Console.WriteLine("Press any key to exit.");
	        Console.ReadKey();
			
			var person1 = new PersonWithHobbies("Alice", new List<string> { "Reading", "Swimming" });
			var person2 = new PersonWithHobbies("Alice", new List<string> { "Reading", "Swimming" });
			
			Console.WriteLine(person1.Equals(person2)); // False - different List instances!
			
			Console.WriteLine($"person1: {person1}");
			Console.WriteLine($"person2: {person2}");
			Console.WriteLine($"person1.Equals(person2): {person1.Equals(person2)}"); // False! Different List instances
			Console.WriteLine($"Lists have same content: {person1.Hobbies.SequenceEqual(person2.Hobbies)}"); // True
			Console.WriteLine();
			
			Console.WriteLine("=== Solution 1: Custom IEquatable Implementation ===");

			var personFixed1 = new PersonWithHobbiesFixed("Bob", [ "Cooking", "Hiking" ]);
			var personFixed2 = new PersonWithHobbiesFixed("Bob", [ "Cooking", "Hiking" ]);
			
			Console.WriteLine($"personFixed1: {personFixed1}");
			Console.WriteLine($"personFixed2: {personFixed2}");
			Console.WriteLine($"personFixed1.Equals(personFixed2): {personFixed1.Equals(personFixed2)}"); // True! Custom equality
			Console.WriteLine();
			
			Console.WriteLine("=== Arrays Also Use Reference Equality ===");

			var personArray1 = new PersonWithHobbiesArray("Charlie", ["Gaming", "Music" ]);
			var personArray2 = new PersonWithHobbiesArray("Charlie", ["Gaming", "Music" ]);
			
			Console.WriteLine($"personArray1: {personArray1}");
			Console.WriteLine($"personArray2: {personArray2}");
			Console.WriteLine($"personArray1.Equals(personArray2): {personArray1.Equals(personArray2)}"); // False! Arrays use reference equality too
			Console.WriteLine($"Arrays have same content: {personArray1.Hobbies.SequenceEqual(personArray2.Hobbies)}"); // True
			Console.WriteLine();
			
			Console.WriteLine("=== Same Issue with IReadOnlyList ===");

			var personImmutable1 = new PersonWithHobbiesImmutable("Diana", [ "Art", "Travel" ]);
			var personImmutable2 = new PersonWithHobbiesImmutable("Diana", [ "Art", "Travel" ]);
			
			Console.WriteLine($"personImmutable1: {personImmutable1}");
			Console.WriteLine($"personImmutable2: {personImmutable2}");
			Console.WriteLine($"personImmutable1.Equals(personImmutable2): {personImmutable1.Equals(personImmutable2)}"); // False! Reference equality
			Console.WriteLine($"Content is the same: {personImmutable1.Hobbies.SequenceEqual(personImmutable2.Hobbies)}"); // True
			Console.WriteLine();
			
			/*
			TwoDPoint p1 = new ThreeDPoint(1, 2, 3);
			TwoDPoint p2 = new ThreeDPoint(1, 2, 4);
			Console.WriteLine(p1.Equals(p2)); // output: True
			*/
			
			TwoDPoint p1 = new ThreeDPoint(1, 2, 3);  // Declared as TwoDPoint
			TwoDPoint p2 = new ThreeDPoint(1, 2, 4);  // Declared as TwoDPoint
			Console.WriteLine(p1.Equals(p2)); // True - but should be False!
			
	    }
	}
	
	/* Expected Output:
	=== Value Equality with Records ===
	pointA.Equals(pointB) = True
	pointA == pointB = True
	pointA.Equals(pointC) = False
	pointA == pointC = False
	
	=== Hash Codes ===
	pointA.GetHashCode() = -1400834708
	pointB.GetHashCode() = -1400834708
	pointC.GetHashCode() = -148136000
	
	=== Inheritance with Records ===
	point3D_A.Equals(point3D_B) = True
	point3D_A == point3D_B = True
	point3D_A.Equals(point3D_C) = False
	pointA.Equals(point3D_A) = False
	
	=== Collections ===
	Set contains 2 unique points
	Dictionary contains key for TwoDPoint { X = 3, Y = 4 }: True
	Dictionary contains 2 entries
	
	=== String Representation ===
	pointA.ToString() = TwoDPoint { X = 3, Y = 4 }
	point3D_A.ToString() = ThreeDPoint { X = 3, Y = 4, Z = 5 }
	*/
	
	public record PersonWithHobbies(string Name, List<string> Hobbies);
	
	// A potential solution using IEquatable<T> with custom equality
	public record PersonWithHobbiesFixed(string Name, List<string> Hobbies) : IEquatable<PersonWithHobbiesFixed>
	{
	    public virtual bool Equals(PersonWithHobbiesFixed? other)
	    {
	        if (ReferenceEquals(null, other)) return false;
	        if (ReferenceEquals(this, other)) return true;
	        
	        // Use SequenceEqual for List comparison
	        return Name == other.Name && Hobbies.SequenceEqual(other.Hobbies);
	    }
	
	    public override int GetHashCode()
	    {
	        // Create hash based on content, not reference
	        var hashCode = new HashCode();
	        hashCode.Add(Name);
	        foreach (var hobby in Hobbies)
	        {
	            hashCode.Add(hobby);
	        }
	        return hashCode.ToHashCode();
	    }
	}
	
	// These also use reference equality - the issue persists
	public record PersonWithHobbiesArray(string Name, string[] Hobbies);
	
	public record PersonWithHobbiesImmutable(string Name, IReadOnlyList<string> Hobbies);
	
	/*
	class TwoDPoint : IEquatable<TwoDPoint>
	{
	    public int X { get; private set; }
	    public int Y { get; private set; }
	
	    public TwoDPoint(int x, int y)
	    {
	        if (x is (< 1 or > 2000) || y is (< 1 or > 2000))
	        {
	            throw new ArgumentException("Point must be in range 1 - 2000");
	        }
	        this.X = x;
	        this.Y = y;
	    }
	
	    public override bool Equals(object obj) => this.Equals(obj as TwoDPoint);
	
	    public bool Equals(TwoDPoint p)
	    {
	        if (p is null)
	        {
	            return false;
	        }
	
	        // Optimization for a common success case.
	        if (Object.ReferenceEquals(this, p))
	        {
	            return true;
	        }
	
	        // If run-time types are not exactly the same, return false.
	        if (this.GetType() != p.GetType())
	        {
	            return false;
	        }
	
	        // Return true if the fields match.
	        // Note that the base class is not invoked because it is
	        // System.Object, which defines Equals as reference equality.
	        return (X == p.X) && (Y == p.Y);
	    }
	
	    public override int GetHashCode() => (X, Y).GetHashCode();
	
	    public static bool operator ==(TwoDPoint lhs, TwoDPoint rhs)
	    {
	        if (lhs is null)
	        {
	            if (rhs is null)
	            {
	                return true;
	            }
	
	            // Only the left side is null.
	            return false;
	        }
	        // Equals handles case of null on right side.
	        return lhs.Equals(rhs);
	    }
	
	    public static bool operator !=(TwoDPoint lhs, TwoDPoint rhs) => !(lhs == rhs);
	}
	
	// For the sake of simplicity, assume a ThreeDPoint IS a TwoDPoint.
	class ThreeDPoint : TwoDPoint, IEquatable<ThreeDPoint>
	{
	    public int Z { get; private set; }
	
	    public ThreeDPoint(int x, int y, int z)
	        : base(x, y)
	    {
	        if ((z < 1) || (z > 2000))
	        {
	            throw new ArgumentException("Point must be in range 1 - 2000");
	        }
	        this.Z = z;
	    }
	
	    public override bool Equals(object obj) => this.Equals(obj as ThreeDPoint);
	
	    public bool Equals(ThreeDPoint p)
	    {
	        if (p is null)
	        {
	            return false;
	        }
	
	        // Optimization for a common success case.
	        if (Object.ReferenceEquals(this, p))
	        {
	            return true;
	        }
	
	        // Check properties that this class declares.
	        if (Z == p.Z)
	        {
	            // Let base class check its own fields
	            // and do the run-time type comparison.
	            return base.Equals((TwoDPoint)p);
	        }
	        else
	        {
	            return false;
	        }
	    }
	
	    public override int GetHashCode() => (X, Y, Z).GetHashCode();
	
	    public static bool operator ==(ThreeDPoint lhs, ThreeDPoint rhs)
	    {
	        if (lhs is null)
	        {
	            if (rhs is null)
	            {
	                // null == null = true.
	                return true;
	            }
	
	            // Only the left side is null.
	            return false;
	        }
	        // Equals handles the case of null on right side.
	        return lhs.Equals(rhs);
	    }
	
	    public static bool operator !=(ThreeDPoint lhs, ThreeDPoint rhs) => !(lhs == rhs);
	}
	*/
	
	class Program2
	{
	    static void RunMain(string[] args)
	    {
	        ThreeDPoint pointA = new ThreeDPoint(3, 4, 5);
	        ThreeDPoint pointB = new ThreeDPoint(3, 4, 5);
	        ThreeDPoint pointC = null;
	        int i = 5;
	
	        Console.WriteLine($"pointA.Equals(pointB) = {pointA.Equals(pointB)}");
	        Console.WriteLine($"pointA == pointB = {pointA == pointB}");
	        Console.WriteLine($"null comparison = {pointA.Equals(pointC)}");
	        Console.WriteLine($"Compare to some other type = {pointA.Equals(i)}");
	
	        TwoDPoint pointD = null;
	        TwoDPoint pointE = null;
	
	        Console.WriteLine($"Two null TwoDPoints are equal: {pointD == pointE}");
	
	        pointE = new TwoDPoint(3, 4);
	        Console.WriteLine($"(pointE == pointA) = {pointE == pointA}");
	        Console.WriteLine($"(pointA == pointE) = {pointA == pointE}");
	        Console.WriteLine($"(pointA != pointE) = {pointA != pointE}");
	
	        System.Collections.ArrayList list = new System.Collections.ArrayList();
	        list.Add(new ThreeDPoint(3, 4, 5));
	        Console.WriteLine($"pointE.Equals(list[0]): {pointE.Equals(list[0])}");
	
	        // Keep the console window open in debug mode.
	        Console.WriteLine("Press any key to exit.");
	        Console.ReadKey();
			
			Console.WriteLine("=== Safe Polymorphic Equality ===");

			// Test polymorphic scenarios that were problematic before
			TwoDPoint p1 = new ThreeDPoint(1, 2, 3);
			TwoDPoint p2 = new ThreeDPoint(1, 2, 4);
			TwoDPoint p3 = new ThreeDPoint(1, 2, 3);
			TwoDPoint p4 = new TwoDPoint(1, 2);
			
			Console.WriteLine("Testing polymorphic equality (declared as TwoDPoint):");
			Console.WriteLine($"p1 = ThreeDPoint(1, 2, 3) as TwoDPoint");
			Console.WriteLine($"p2 = ThreeDPoint(1, 2, 4) as TwoDPoint");
			Console.WriteLine($"p3 = ThreeDPoint(1, 2, 3) as TwoDPoint");
			Console.WriteLine($"p4 = TwoDPoint(1, 2)");
			Console.WriteLine();
			
			Console.WriteLine($"p1.Equals(p2) = {p1.Equals(p2)}"); // False - different Z values
			Console.WriteLine($"p1.Equals(p3) = {p1.Equals(p3)}"); // True - same values
			Console.WriteLine($"p1.Equals(p4) = {p1.Equals(p4)}"); // False - different types
			Console.WriteLine($"p4.Equals(p1) = {p4.Equals(p1)}"); // False - different types
			Console.WriteLine();
			
			// Test direct type comparisons
			var point3D_A = new ThreeDPoint(3, 4, 5);
			var point3D_B = new ThreeDPoint(3, 4, 5);
			var point3D_C = new ThreeDPoint(3, 4, 7);
			var point2D_A = new TwoDPoint(3, 4);
			
			Console.WriteLine("Testing direct type comparisons:");
			Console.WriteLine($"point3D_A.Equals(point3D_B) = {point3D_A.Equals(point3D_B)}"); // True
			Console.WriteLine($"point3D_A.Equals(point3D_C) = {point3D_A.Equals(point3D_C)}"); // False
			Console.WriteLine($"point3D_A.Equals(point2D_A) = {point3D_A.Equals(point2D_A)}"); // False
			Console.WriteLine($"point2D_A.Equals(point3D_A) = {point2D_A.Equals(point3D_A)}"); // False
			Console.WriteLine();
			
			// Test with collections
			Console.WriteLine("Testing with collections:");
			var hashSet = new HashSet<TwoDPoint> { p1, p2, p3, p4 };
			Console.WriteLine($"HashSet contains {hashSet.Count} unique points"); // Should be 3: one ThreeDPoint(1,2,3), one ThreeDPoint(1,2,4), one TwoDPoint(1,2)
			
			var dictionary = new Dictionary<TwoDPoint, string>
			{
			    { p1, "First 3D point" },
			    { p2, "Second 3D point" },
			    { p4, "2D point" }
			};
			
			Console.WriteLine($"Dictionary contains {dictionary.Count} entries");
			Console.WriteLine($"Dictionary lookup for equivalent point: {dictionary.ContainsKey(new ThreeDPoint(1, 2, 3))}"); // True
	    }
	}
	
	/* Output:
	    pointA.Equals(pointB) = True
	    pointA == pointB = True
	    null comparison = False
	    Compare to some other type = False
	    Two null TwoDPoints are equal: True
	    (pointE == pointA) = False
	    (pointA == pointE) = False
	    (pointA != pointE) = True
	    pointE.Equals(list[0]): False
	*/
	
	// Safe polymorphic equality implementation using explicit interface implementation
	class TwoDPoint : IEquatable<TwoDPoint>
	{
	    public int X { get; private set; }
	    public int Y { get; private set; }
	
	    public TwoDPoint(int x, int y)
	    {
	        if (x is (< 1 or > 2000) || y is (< 1 or > 2000))
	        {
	            throw new ArgumentException("Point must be in range 1 - 2000");
	        }
	        this.X = x;
	        this.Y = y;
	    }
	
	    public override bool Equals(object? obj) => Equals(obj as TwoDPoint);
	
	    // Explicit interface implementation prevents compile-time type issues
	    bool IEquatable<TwoDPoint>.Equals(TwoDPoint? p) => Equals((object?)p);
	
	    protected virtual bool Equals(TwoDPoint? p)
	    {
	        if (p is null)
	        {
	            return false;
	        }
	
	        // Optimization for a common success case.
	        if (Object.ReferenceEquals(this, p))
	        {
	            return true;
	        }
	
	        // If run-time types are not exactly the same, return false.
	        if (this.GetType() != p.GetType())
	        {
	            return false;
	        }
	
	        // Return true if the fields match.
	        // Note that the base class is not invoked because it is
	        // System.Object, which defines Equals as reference equality.
	        return (X == p.X) && (Y == p.Y);
	    }
	
	    public override int GetHashCode() => (X, Y).GetHashCode();
	
	    public static bool operator ==(TwoDPoint? lhs, TwoDPoint? rhs)
	    {
	        if (lhs is null)
	        {
	            if (rhs is null)
	            {
	                return true;
	            }
	
	            // Only the left side is null.
	            return false;
	        }
	        // Equals handles case of null on right side.
	        return lhs.Equals(rhs);
	    }
	
	    public static bool operator !=(TwoDPoint? lhs, TwoDPoint? rhs) => !(lhs == rhs);
	}
	
	// For the sake of simplicity, assume a ThreeDPoint IS a TwoDPoint.
	class ThreeDPoint : TwoDPoint, IEquatable<ThreeDPoint>
	{
	    public int Z { get; private set; }
	
	    public ThreeDPoint(int x, int y, int z)
	        : base(x, y)
	    {
	        if ((z < 1) || (z > 2000))
	        {
	            throw new ArgumentException("Point must be in range 1 - 2000");
	        }
	        this.Z = z;
	    }
	
	    public override bool Equals(object? obj) => Equals(obj as ThreeDPoint);
	
	    // Explicit interface implementation prevents compile-time type issues
	    bool IEquatable<ThreeDPoint>.Equals(ThreeDPoint? p) => Equals((object?)p);
	
	    protected override bool Equals(TwoDPoint? p)
	    {
	        if (p is null)
	        {
	            return false;
	        }
	
	        // Optimization for a common success case.
	        if (Object.ReferenceEquals(this, p))
	        {
	            return true;
	        }
	
	        // Runtime type check happens in the base method
	        if (p is ThreeDPoint threeD)
	        {
	            // Check properties that this class declares.
	            if (Z != threeD.Z)
	            {
	                return false;
	            }
	
	            return base.Equals(p);
	        }
	
	        return false;
	    }
	
	    public override int GetHashCode() => (X, Y, Z).GetHashCode();
	
	    public static bool operator ==(ThreeDPoint? lhs, ThreeDPoint? rhs)
	    {
	        if (lhs is null)
	        {
	            if (rhs is null)
	            {
	                // null == null = true.
	                return true;
	            }
	
	            // Only the left side is null.
	            return false;
	        }
	        // Equals handles the case of null on right side.
	        return lhs.Equals(rhs);
	    }
	
	    public static bool operator !=(ThreeDPoint? lhs, ThreeDPoint? rhs) => !(lhs == rhs);
	}
	
	namespace ValueEqualityStruct
	{
	    struct TwoDPoint : IEquatable<TwoDPoint>
	    {
	        public int X { get; private set; }
	        public int Y { get; private set; }
	
	        public TwoDPoint(int x, int y)
	            : this()
	        {
	            if (x is (< 1 or > 2000) || y is (< 1 or > 2000))
	            {
	                throw new ArgumentException("Point must be in range 1 - 2000");
	            }
	            X = x;
	            Y = y;
	        }
	
	        public override bool Equals(object? obj) => obj is TwoDPoint other && this.Equals(other);
	
	        public bool Equals(TwoDPoint p) => X == p.X && Y == p.Y;
	
	        public override int GetHashCode() => (X, Y).GetHashCode();
	
	        public static bool operator ==(TwoDPoint lhs, TwoDPoint rhs) => lhs.Equals(rhs);
	
	        public static bool operator !=(TwoDPoint lhs, TwoDPoint rhs) => !(lhs == rhs);
	    }
	
	    class Program
	    {
	        static void RunMain(string[] args)
	        {
	            TwoDPoint pointA = new TwoDPoint(3, 4);
	            TwoDPoint pointB = new TwoDPoint(3, 4);
	            int i = 5;
	
	            // True:
	            Console.WriteLine($"pointA.Equals(pointB) = {pointA.Equals(pointB)}");
	            // True:
	            Console.WriteLine($"pointA == pointB = {pointA == pointB}");
	            // True:
	            Console.WriteLine($"object.Equals(pointA, pointB) = {object.Equals(pointA, pointB)}");
	            // False:
	            Console.WriteLine($"pointA.Equals(null) = {pointA.Equals(null)}");
	            // False:
	            Console.WriteLine($"(pointA == null) = {pointA == null}");
	            // True:
	            Console.WriteLine($"(pointA != null) = {pointA != null}");
	            // False:
	            Console.WriteLine($"pointA.Equals(i) = {pointA.Equals(i)}");
	            // CS0019:
	            // Console.WriteLine($"pointA == i = {pointA == i}");
	
	            // Compare unboxed to boxed.
	            System.Collections.ArrayList list = new System.Collections.ArrayList();
	            list.Add(new TwoDPoint(3, 4));
	            // True:
	            Console.WriteLine($"pointA.Equals(list[0]): {pointA.Equals(list[0])}");
	
	            // Compare nullable to nullable and to non-nullable.
	            TwoDPoint? pointC = null;
	            TwoDPoint? pointD = null;
	            // False:
	            Console.WriteLine($"pointA == (pointC = null) = {pointA == pointC}");
	            // True:
	            Console.WriteLine($"pointC == pointD = {pointC == pointD}");
	
	            TwoDPoint temp = new TwoDPoint(3, 4);
	            pointC = temp;
	            // True:
	            Console.WriteLine($"pointA == (pointC = 3,4) = {pointA == pointC}");
	
	            pointD = temp;
	            // True:
	            Console.WriteLine($"pointD == (pointC = 3,4) = {pointD == pointC}");
	
	            Console.WriteLine("Press any key to exit.");
	            Console.ReadKey();
	        }
	    }
	
	    /* Output:
	        pointA.Equals(pointB) = True
	        pointA == pointB = True
	        Object.Equals(pointA, pointB) = True
	        pointA.Equals(null) = False
	        (pointA == null) = False
	        (pointA != null) = True
	        pointA.Equals(i) = False
	        pointE.Equals(list[0]): True
	        pointA == (pointC = null) = False
	        pointC == pointD = True
	        pointA == (pointC = 3,4) = True
	        pointD == (pointC = 3,4) = True
	    */
	}

}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons
namespace DotnetCSharpProgrammingGuideStatementsExpressionsOperatorsEqualityComparisons
{
	class Test
	{
	    public int Num { get; set; }
	    public string Str { get; set; }
	
	    public static void RunMain()
	    {
	        Test a = new Test() { Num = 1, Str = "Hi" };
	        Test b = new Test() { Num = 1, Str = "Hi" };
	
	        bool areEqual = System.Object.ReferenceEquals(a, b);
	        // False:
	        System.Console.WriteLine($"ReferenceEquals(a, b) = {areEqual}");
	
	        // Assign b to a.
	        b = a;
	
	        // Repeat calls with different results.
	        areEqual = System.Object.ReferenceEquals(a, b);
	        // True:
	        System.Console.WriteLine($"ReferenceEquals(a, b) = {areEqual}");
			
			/*
			int a = GetOriginalValue();  
			int b = GetCurrentValue();  
			  
			// Test for value equality.
			if (b == a)
			{  
			    // The two integers are equal.  
			}
			*/
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
namespace DotnetCSharpProgrammingGuideStatementsExpressionsOperatorsExpressionBodiedMembers
{
	public class ExpressionBodiedMembers
	{
		
	}
	
	public class Person
	{
	   public Person(string firstName, string lastName)
	   {
	      fname = firstName;
	      lname = lastName;
	   }
	
	   private string fname;
	   private string lname;
	
	   public override string ToString() => $"{fname} {lname}".Trim();
	   public void DisplayName() => Console.WriteLine(ToString());
	   
	   // Expression-bodied methods with parameters
	   public string GetFullName(string title) => $"{title} {fname} {lname}";
	   public int CalculateAge(int birthYear) => DateTime.Now.Year - birthYear;
	   public bool IsOlderThan(int age) => CalculateAge(1990) > age;
	   public string FormatName(string format) => format.Replace("{first}", fname).Replace("{last}", lname);
	}
	
	class Example
	{
	   public static void RunMain()
	   {
	      Person p = new Person("Mandy", "Dejesus");
	      Console.WriteLine(p);
	      p.DisplayName();
	      
	      // Examples with parameters
	      Console.WriteLine(p.GetFullName("Dr."));
	      Console.WriteLine($"Age: {p.CalculateAge(1990)}");
	      Console.WriteLine($"Is older than 25: {p.IsOlderThan(25)}");
	      Console.WriteLine(p.FormatName("Last: {last}, First: {first}"));
	   }
	}
	
	/*
	public class Location
	{
	   private string locationName;
	
	   public Location(string name)
	   {
	      locationName = name;
	   }
	
	   public string Name => locationName;
	}
	*/
	
	/*
	public class Location
	{
	   private string locationName;
	
	   public Location(string name) => Name = name;
	
	   public string Name
	   {
	      get => locationName;
	      set => locationName = value;
	   }
	}
	
	// Example with multiple parameters
	public class Point
	{
	   public double X { get; }
	   public double Y { get; }
	   
	   // Constructor with multiple parameters
	   public Point(double x, double y) => (X, Y) = (x, y);
	   
	   // Constructor with single parameter (creates point at origin on axis)
	   public Point(double coordinate) => (X, Y) = (coordinate, 0);
	}
	*/
	
	public class ChangedEventArgs : EventArgs
	{
	   public required int NewValue { get; init; }
	}
	
	public class ObservableNum(int _value)
	{
	   public event EventHandler<ChangedEventArgs> ChangedGeneric = default!;
	
	   public event EventHandler Changed
	   {
	      // Note that, while this is syntactically valid, it won't work as expected because it's creating a new delegate object with each call.
	      add => ChangedGeneric += (sender, args) => value(sender, args);
	      remove => ChangedGeneric -= (sender, args) => value(sender, args);
	   }
	
	   public int Value
	   {
	      get => _value;
	      set => ChangedGeneric?.Invoke(this, new() { NewValue = (_value = value) });
	   }
	}
	
	public class Location
	{
	   private string locationName;
	
	   public Location(string name) => Name = name;
	
	   public string Name
	   {
	      get => locationName;
	      set => locationName = value;
	   }
	}
	
	// Example with multiple parameters
	public class Point
	{
	   public double X { get; }
	   public double Y { get; }
	   
	   // Constructor with multiple parameters
	   public Point(double x, double y) => (X, Y) = (x, y);
	   
	   // Constructor with single parameter (creates point at origin on axis)
	   public Point(double coordinate) => (X, Y) = (coordinate, 0);
	}
	
	public class Destroyer
	{
	   public override string ToString() => GetType().Name;
	
	   ~Destroyer() => Console.WriteLine($"The {ToString()} finalizer is executing.");
	}
	
	public class Sports
	{
	   private string[] types = [ "Baseball", "Basketball", "Football",
	                              "Hockey", "Soccer", "Tennis",
	                              "Volleyball" ];
	
	   public string this[int i]
	   {
	      get => types[i];
	      set => types[i] = value;
	   }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/statements
namespace DotnetCSharpProgrammingGuideStatementsExpressionsOperatorsStatements
{
	public class ExpressionsOperatorsStatements
	{
		public static void RunMain()
	    {
	        // Declaration statement.
	        int counter;
	
	        // Assignment statement.
	        counter = 1;
	
	        // Error! This is an expression, not an expression statement.
	        // counter + 1;
	
	        // Declaration statements with initializers are functionally
	        // equivalent to  declaration statement followed by assignment statement:
	        int[] radii = [15, 32, 108, 74, 9]; // Declare and initialize an array.
	        const double pi = 3.14159; // Declare and initialize  constant.
	
	        // foreach statement block that contains multiple statements.
	        foreach (int radius in radii)
	        {
	            // Declaration statement with initializer.
	            double circumference = pi * (2 * radius);
	
	            // Expression statement (method invocation). A single-line
	            // statement can span multiple text lines because line breaks
	            // are treated as white space, which is ignored by the compiler.
	            System.Console.WriteLine($"Radius of circle #{counter} is {radius}. Circumference = {circumference:N2}");
	
	            // Expression statement (postfix increment).
	            counter++;
	        } // End of foreach statement block
			
			/*
			// Variable declaration statements.
			double area;
			double radius = 2;
			
			// Constant declaration statement.
			const double pi = 3.14159;
			
			// Expression statement (assignment).
			area = 3.14 * (radius * radius);
			
			// Expression statement (result discarded).
			int x = 0;
			x++;
			
			// Expression statement (method invocation).
			System.Console.WriteLine();
			
			// Expression statement (new object creation).
			System.Collections.Generic.List<string> strings =
			    new System.Collections.Generic.List<string>();
			*/
			
			// Recommended style. Embedded statement in  block.
			foreach (string s in System.IO.Directory.GetDirectories(
			                        System.Environment.CurrentDirectory))
			{
			    System.Console.WriteLine(s);
			}
			
			// Not recommended.
			foreach (string s in System.IO.Directory.GetDirectories(
			                        System.Environment.CurrentDirectory))
			    System.Console.WriteLine(s);
			
			/*
			if(pointB == true)
			    //Error CS1023:
			    int radius = 5;
				
			if (b == true)
			{
			    // OK:
			    System.DateTime d = System.DateTime.Now;
			    System.Console.WriteLine(d.ToLongDateString());
			}
			*/
			
			foreach (string s in System.IO.Directory.GetDirectories(
			    System.Environment.CurrentDirectory))
			{
			    if (s.StartsWith("CSharp"))
			    {
			        if (s.EndsWith("TempFolder"))
			        {
			            //return s;
			        }
			    }
			}
			//return "Not found.";
			
			// An over-simplified example of unreachable code.
			const int val = 5;
			if (val < 4)
			{
			    System.Console.WriteLine("I'll never write anything."); //CS0162
			}
			
			
			
			
	    } // End of Main method body.
		/*
		   Output:
		    Radius of circle #1 = 15. Circumference = 94.25
		    Radius of circle #2 = 32. Circumference = 201.06
		    Radius of circle #3 = 108. Circumference = 678.58
		    Radius of circle #4 = 74. Circumference = 464.96
		    Radius of circle #5 = 9. Circumference = 56.55
		*/
		
		/*
		void ProcessMessages()
		{
		    while (ProcessMessage())
		        ; // Statement needed here.
		}
		
		void F()
		{
		    //...
		    if (done) goto exit;
		//...
		exit:
		    ; // Statement needed here.
		}
		*/
		
		
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators
namespace DotnetCSharpProgrammingGuideConceptsIterators
{
	public class Iterators
	{
		static void RunMain()
		{
		    foreach (int number in SomeNumbers())
		    {
		        Console.Write(number.ToString() + " ");
		    }
		    // Output: 3 5 8
		    Console.ReadKey();
			
			foreach (int number in EvenSequence(5, 18))
		    {
		        Console.Write(number.ToString() + " ");
		    }
		    // Output: 6 8 10 12 14 16 18
		    Console.ReadKey();
			
			DaysOfTheWeek days = new DaysOfTheWeek();

		    foreach (string day in days)
		    {
		        Console.Write(day + " ");
		    }
		    // Output: Sun Mon Tue Wed Thu Fri Sat
		    Console.ReadKey();
			
			Zoo theZoo = new Zoo();

		    theZoo.AddMammal("Whale");
		    theZoo.AddMammal("Rhinoceros");
		    theZoo.AddBird("Penguin");
		    theZoo.AddBird("Warbler");
		
		    foreach (string name in theZoo)
		    {
		        Console.Write(name + " ");
		    }
		    Console.WriteLine();
		    // Output: Whale Rhinoceros Penguin Warbler
		
		    foreach (string name in theZoo.Birds)
		    {
		        Console.Write(name + " ");
		    }
		    Console.WriteLine();
		    // Output: Penguin Warbler
		
		    foreach (string name in theZoo.Mammals)
		    {
		        Console.Write(name + " ");
		    }
		    Console.WriteLine();
		    // Output: Whale Rhinoceros
		
		    Console.ReadKey();
			
			Stack<int> theStack = new Stack<int>();

		    //  Add items to the stack.
		    for (int number = 0; number <= 9; number++)
		    {
		        theStack.Push(number);
		    }
		
		    // Retrieve items from the stack.
		    // foreach is allowed because theStack implements IEnumerable<int>.
		    foreach (int number in theStack)
		    {
		        Console.Write("{0} ", number);
		    }
		    Console.WriteLine();
		    // Output: 9 8 7 6 5 4 3 2 1 0
		
		    // foreach is allowed, because theStack.TopToBottom returns IEnumerable(Of Integer).
		    foreach (int number in theStack.TopToBottom)
		    {
		        Console.Write("{0} ", number);
		    }
		    Console.WriteLine();
		    // Output: 9 8 7 6 5 4 3 2 1 0
		
		    foreach (int number in theStack.BottomToTop)
		    {
		        Console.Write("{0} ", number);
		    }
		    Console.WriteLine();
		    // Output: 0 1 2 3 4 5 6 7 8 9
		
		    foreach (int number in theStack.TopN(7))
		    {
		        Console.Write("{0} ", number);
		    }
		    Console.WriteLine();
		    // Output: 9 8 7 6 5 4 3
		
		    Console.ReadKey();
		}
		
		public static System.Collections.IEnumerable SomeNumbers()
		{
		    yield return 3;
		    yield return 5;
		    yield return 8;
		}
		
		public static System.Collections.Generic.IEnumerable<int>
		    EvenSequence(int firstNumber, int lastNumber)
		{
		    // Yield even numbers in the range.
		    for (int number = firstNumber; number <= lastNumber; number++)
		    {
		        if (number % 2 == 0)
		        {
		            yield return number;
		        }
		    }
		}
		
		public class Zoo : IEnumerable
		{
		    // Private members.
		    private List<Animal> animals = new List<Animal>();
		
		    // Public methods.
		    public void AddMammal(string name)
		    {
		        animals.Add(new Animal { Name = name, Type = Animal.TypeEnum.Mammal });
		    }
		
		    public void AddBird(string name)
		    {
		        animals.Add(new Animal { Name = name, Type = Animal.TypeEnum.Bird });
		    }
		
		    public IEnumerator GetEnumerator()
		    {
		        foreach (Animal theAnimal in animals)
		        {
		            yield return theAnimal.Name;
		        }
		    }
		
		    // Public members.
		    public IEnumerable Mammals
		    {
		        get { return AnimalsForType(Animal.TypeEnum.Mammal); }
		    }
		
		    public IEnumerable Birds
		    {
		        get { return AnimalsForType(Animal.TypeEnum.Bird); }
		    }
		
		    // Private methods.
		    private IEnumerable AnimalsForType(Animal.TypeEnum type)
		    {
		        foreach (Animal theAnimal in animals)
		        {
		            if (theAnimal.Type == type)
		            {
		                yield return theAnimal.Name;
		            }
		        }
		    }
		
		    // Private class.
		    private class Animal
		    {
		        public enum TypeEnum { Bird, Mammal }
		
		        public string Name { get; set; }
		        public TypeEnum Type { get; set; }
		    }
		}
		
		public class Stack<T> : IEnumerable<T>
		{
		    private T[] values = new T[100];
		    private int top = 0;
		
		    public void Push(T t)
		    {
		        values[top] = t;
		        top++;
		    }
		    public T Pop()
		    {
		        top--;
		        return values[top];
		    }
		
		    // This method implements the GetEnumerator method. It allows
		    // an instance of the class to be used in a foreach statement.
		    public IEnumerator<T> GetEnumerator()
		    {
		        for (int index = top - 1; index >= 0; index--)
		        {
		            yield return values[index];
		        }
		    }
		
		    IEnumerator IEnumerable.GetEnumerator()
		    {
		        return GetEnumerator();
		    }
		
		    public IEnumerable<T> TopToBottom
		    {
		        get { return this; }
		    }
		
		    public IEnumerable<T> BottomToTop
		    {
		        get
		        {
		            for (int index = 0; index <= top - 1; index++)
		            {
		                yield return values[index];
		            }
		        }
		    }
		
		    public IEnumerable<T> TopN(int itemsFromTop)
		    {
		        // Return less than itemsFromTop if necessary.
		        int startIndex = itemsFromTop >= top ? 0 : top - itemsFromTop;
		
		        for (int index = top - 1; index >= startIndex; index--)
		        {
		            yield return values[index];
		        }
		    }
		
		}
	}
	
	public class DaysOfTheWeek : IEnumerable
	{
	    private string[] days = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
	
	    public IEnumerator GetEnumerator()
	    {
	        for (int index = 0; index < days.Length; index++)
	        {
	            // Yield each day of the week.
	            yield return days[index];
	        }
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/using-variance-for-func-and-action-generic-delegates
namespace DotnetCSharpProgrammingGuideConceptsCovarianceContravarianceUsingVarianceForFuncAndActionGenericDelegates
{
	/*
	// Simple hierarchy of classes.  
	public class Person { }  
	public class Employee : Person { }  
	class Program  
	{  
	    static Employee FindByTitle(String title)  
	    {  
	        // This is a stub for a method that returns  
	        // an employee that has the specified title.  
	        return new Employee();  
	    }  
	  
	    static void Test()  
	    {  
	        // Create an instance of the delegate without using variance.  
	        Func<String, Employee> findEmployee = FindByTitle;  
	  
	        // The delegate expects a method to return Person,  
	        // but you can assign it a method that returns Employee.  
	        Func<String, Person> findPerson = FindByTitle;  
	  
	        // You can also assign a delegate
	        // that returns a more derived type
	        // to a delegate that returns a less derived type.  
	        findPerson = findEmployee;  
	  
	    }  
	}
	*/
	
	/*
	public class Person { }  
	public class Employee : Person { }  
	class Program  
	{  
	    static void AddToContacts(Person person)  
	    {  
	        // This method adds a Person object  
	        // to a contact list.  
	    }  
	  
	    static void Test()  
	    {  
	        // Create an instance of the delegate without using variance.  
	        Action<Person> addPersonToContacts = AddToContacts;  
	  
	        // The Action delegate expects
	        // a method that has an Employee parameter,  
	        // but you can assign it a method that has a Person parameter  
	        // because Employee derives from Person.  
	        Action<Employee> addEmployeeToContacts = AddToContacts;  
	  
	        // You can also assign a delegate
	        // that accepts a less derived parameter to a delegate
	        // that accepts a more derived parameter.  
	        addEmployeeToContacts = addPersonToContacts;  
	    }  
	}
	*/
	
	public class Person
	{
	    public virtual void ReadContact() { /*...*/ }
	}
	
	public class Employee : Person
	{
	    public override void ReadContact() { /*...*/ }
	}
	
	class Program
	{
	    private static void RunMain()
	    {
	        var personReadContact = (Person p) => p.ReadContact();
	
	        // This works - contravariance allows assignment.
	        //Action<Employee> employeeReadContact = personReadContact;
	
	        // This causes a compile error: CS1661.
	        // Action<Employee> employeeReadContact2 = (Person p) => p.ReadContact();
			
			// Explicit cast to the desired delegate type.
			Action<Employee> employeeReadContact = (Action<Person>)((Person p) => p.ReadContact());
			
			// Or specify the lambda parameter type that matches the target delegate.
			Action<Employee> employeeReadContact2 = (Employee e) => e.ReadContact();
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/using-variance-in-delegates
namespace DotnetCSharpProgrammingGuideConceptsCovarianceContravarianceUsingVarianceInDelegates
{
	public class CovarianceContravarianceUsingVarianceInDelegates
	{
		public static void RunCovarianceContravarianceUsingVarianceInDelegates()
		{
			
		}
	}
	
	class Mammals {}  
	class Dogs : Mammals {}  
	  
	class Program  
	{  
	    // Define the delegate.  
	    public delegate Mammals HandlerMethod();  
	  
	    public static Mammals MammalsHandler()  
	    {  
	        return null;  
	    }  
	  
	    public static Dogs DogsHandler()  
	    {  
	        return null;  
	    }  
	  
	    static void Test()  
	    {  
	        HandlerMethod handlerMammals = MammalsHandler;  
	  
	        // Covariance enables this assignment.  
	        HandlerMethod handlerDogs = DogsHandler;  
	    }
		
		public delegate void KeyEventHandler(object sender, KeyEventArgs e);
		
		public delegate void MouseEventHandler(object sender, MouseEventArgs e);
		
		// Custom EventArgs classes to demonstrate the hierarchy
		public class KeyEventArgs(string keyCode) : EventArgs
		{
		    public string KeyCode { get; set; } = keyCode;
		}
		
		public class MouseEventArgs(int x, int y) : EventArgs  
		{
		    public int X { get; set; } = x;
		    public int Y { get; set; } = y;
		}
		
		/*
		// Define delegate types that match the Windows Forms pattern
		public delegate void KeyEventHandler(object sender, KeyEventArgs e);
		public delegate void MouseEventHandler(object sender, MouseEventArgs e);
		
		// A simple class that demonstrates contravariance with events
		public class Button
		{
		    // Events that expect specific EventArgs-derived types
		    public event KeyEventHandler? KeyDown;
		    public event MouseEventHandler? MouseClick;
		
		    // Method to simulate key press
		    public void SimulateKeyPress(string key)
		    {
		        Console.WriteLine($"Simulating key press: {key}");
		        KeyDown?.Invoke(this, new KeyEventArgs(key));
		    }
		
		    // Method to simulate mouse click  
		    public void SimulateMouseClick(int x, int y)
		    {
		        Console.WriteLine($"Simulating mouse click at ({x}, {y})");
		        MouseClick?.Invoke(this, new MouseEventArgs(x, y));
		    }
		}
		
		public class Form1
		{
		    private Button button1;
		
		    public Form1()
		    {
		        button1 = new Button();
		        
		        // Event handler that accepts a parameter of the base EventArgs type.
		        // This method can handle events that expect more specific EventArgs-derived types
		        // due to contravariance in delegate parameters.
		        
		        // You can use a method that has an EventArgs parameter,
		        // although the KeyDown event expects the KeyEventArgs parameter.
		        button1.KeyDown += MultiHandler;
		
		        // You can use the same method for an event that expects 
		        // the MouseEventArgs parameter.
		        button1.MouseClick += MultiHandler;
		    }
		
		    // Event handler that accepts a parameter of the base EventArgs type.
		    // This works for both KeyDown and MouseClick events because:
		    // - KeyDown expects KeyEventHandler(object sender, KeyEventArgs e)
		    // - MouseClick expects MouseEventHandler(object sender, MouseEventArgs e)  
		    // - Both KeyEventArgs and MouseEventArgs derive from EventArgs
		    // - Contravariance allows a method with a base type parameter (EventArgs)
		    //   to be used where a derived type parameter is expected
		    private void MultiHandler(object sender, EventArgs e)
		    {
		        Console.WriteLine($"MultiHandler called at: {DateTime.Now:HH:mm:ss.fff}");
		        
		        // You can check the actual type of the event args if needed
		        switch (e)
		        {
		            case KeyEventArgs keyArgs:
		                Console.WriteLine($"  - Key event: {keyArgs.KeyCode}");
		                break;
		            case MouseEventArgs mouseArgs:
		                Console.WriteLine($"  - Mouse event: ({mouseArgs.X}, {mouseArgs.Y})");
		                break;
		            default:
		                Console.WriteLine($"  - Generic event: {e.GetType().Name}");
		                break;
		        }
		    }
		
		    public void DemonstrateEvents()
		    {
		        Console.WriteLine("Demonstrating contravariance in event handlers:");
		        Console.WriteLine("Same MultiHandler method handles both events!\n");
		        
		        button1.SimulateKeyPress("Enter");
		        button1.SimulateMouseClick(100, 200);
		        button1.SimulateKeyPress("Escape");
		        button1.SimulateMouseClick(50, 75);
		    }
		}
		*/
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/variance-in-delegates
namespace DotnetCSharpProgrammingGuideConceptsCovarianceContravarianceVarianceInDelegates
{
	public class CovarianceContravarianceVarianceInDelegates
	{
		public static void RunCovarianceContravarianceVarianceInDelegates()
		{
			// Assigning a method with a matching signature
			// to a non-generic delegate. No conversion is necessary.  
			SampleDelegate dNonGeneric = ASecondRFirst;  
			// Assigning a method with a more derived return type
			// and less derived argument type to a non-generic delegate.  
			// The implicit conversion is used.  
			SampleDelegate dNonGenericConversion = AFirstRSecond;  
			  
			// Assigning a method with a matching signature to a generic delegate.  
			// No conversion is necessary.  
			SampleGenericDelegate<Second, First> dGeneric = ASecondRFirst;  
			// Assigning a method with a more derived return type
			// and less derived argument type to a generic delegate.  
			// The implicit conversion is used.  
			SampleGenericDelegate<Second, First> dGenericConversion = AFirstRSecond;
			
			DVariant<String, String> dvariant = (String str) => str + " ";  
			dvariant("test");
			
			Action<object> actObj = x => Console.WriteLine("object: {0}", x);  
			Action<string> actStr = x => Console.WriteLine("string: {0}", x);  
			// All of the following statements throw exceptions at run time.  
			// Action<string> actCombine = actStr + actObj;  
			// actStr += actObj;  
			// Delegate.Combine(actStr, actObj);
			
		}
		
		// Matching signature.  
		public static First ASecondRFirst(Second second)  
		{ return new First(); }  
		  
		// The return type is more derived.  
		public static Second ASecondRSecond(Second second)  
		{ return new Second(); }  
		  
		// The argument type is less derived.  
		public static First AFirstRFirst(First first)  
		{ return new First(); }  
		  
		// The return type is more derived
		// and the argument type is less derived.  
		public static Second AFirstRSecond(First first)  
		{ return new Second(); }
		
		/*
		// Type T is declared covariant by using the out keyword.  
		public delegate T SampleGenericDelegate <out T>();  
		  
		public static void Test()  
		{  
		    SampleGenericDelegate <String> dString = () => " ";  
		  
		    // You can assign delegates to each other,  
		    // because the type T is declared covariant.  
		    SampleGenericDelegate <Object> dObject = dString;
		}
		*/
		
		public delegate T SampleGenericDelegate<T>();  
  
		public static void Test()  
		{  
		    SampleGenericDelegate<String> dString = () => " ";  
		  
		    // You can assign the dObject delegate  
		    // to the same lambda expression as dString delegate  
		    // because of the variance support for
		    // matching method signatures with delegate types.  
		    SampleGenericDelegate<Object> dObject = () => " ";  
		  
		    // The following statement generates a compiler error  
		    // because the generic type T is not marked as covariant.  
		    // SampleGenericDelegate <Object> dObject = dString;  
		  
		}
		
		public delegate R DCovariant<out R>();
		
		public delegate void DContravariant<in A>(A a);
		
		public delegate R DVariant<in A, out R>(A a);
		
		// The type T is covariant.  
		public delegate T DVariant<out T>();  
		  
		// The type T is invariant.  
		public delegate T DInvariant<T>();  
		  
		public static void Test2()  
		{  
		    int i = 0;  
		    DInvariant<int> dInt = () => i;  
		    DVariant<int> dVariantInt = () => i;  
		  
		    // All of the following statements generate a compiler error  
		    // because type variance in generic parameters is not supported  
		    // for value types, even if generic type parameters are declared variant.  
		    // DInvariant<Object> dObject = dInt;  
		    // DInvariant<long> dLong = dInt;  
		    // DVariant<Object> dVariantObject = dVariantInt;  
		    // DVariant<long> dVariantLong = dVariantInt;
		}
	
	
		
	}
	
	public class First { }  
	public class Second : First { }  
	public delegate First SampleDelegate(Second a);  
	public delegate R SampleGenericDelegate<A, R>(A a);
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/using-variance-in-interfaces-for-generic-collections
namespace DotnetCSharpProgrammingGuideConceptsCovarianceContravarianceUsingVarianceInInterfacesForGenericCollections
{
	public class VarianceInInterfacesForGenericCollections
	{
		public static void RunVarianceInInterfacesForGenericCollections()
		{
			
		}
	}
	
	/*
	// Simple hierarchy of classes.  
	public class Person  
	{  
	    public string FirstName { get; set; }  
	    public string LastName { get; set; }  
	}  
	  
	public class Employee : Person { }  
	  
	class Program  
	{  
	    // The method has a parameter of the IEnumerable<Person> type.  
	    public static void PrintFullName(IEnumerable<Person> persons)  
	    {  
	        foreach (Person person in persons)  
	        {  
	            Console.WriteLine("Name: {0} {1}",  
	            person.FirstName, person.LastName);  
	        }  
	    }  
	  
	    public static void Test()  
	    {  
	        IEnumerable<Employee> employees = new List<Employee>();  
	  
	        // You can pass IEnumerable<Employee>,
	        // although the method expects IEnumerable<Person>.  
	  
	        PrintFullName(employees);  
	  
	    }  
	}
	*/
	
	// Simple hierarchy of classes.  
	public class Person  
	{  
	    public string FirstName { get; set; }  
	    public string LastName { get; set; }  
	}  
	  
	public class Employee : Person { }  
	  
	// The custom comparer for the Person type  
	// with standard implementations of Equals()  
	// and GetHashCode() methods.  
	class PersonComparer : IEqualityComparer<Person>  
	{  
	    public bool Equals(Person x, Person y)  
	    {
	        if (Object.ReferenceEquals(x, y)) return true;  
	        if (Object.ReferenceEquals(x, null) ||  
	            Object.ReferenceEquals(y, null))  
	            return false;
	        return x.FirstName == y.FirstName && x.LastName == y.LastName;  
	    }  
	    public int GetHashCode(Person person)  
	    {  
	        if (Object.ReferenceEquals(person, null)) return 0;  
	        int hashFirstName = person.FirstName == null  
	            ? 0 : person.FirstName.GetHashCode();  
	        int hashLastName = person.LastName.GetHashCode();  
	        return hashFirstName ^ hashLastName;  
	    }  
	}  
	  
	class Program  
	{  
	  
	    public static void Test()  
	    {  
	        List<Employee> employees = new List<Employee> {  
	               new Employee() {FirstName = "Michael", LastName = "Alexander"},  
	               new Employee() {FirstName = "Jeff", LastName = "Price"}  
	            };  
	  
	        // You can pass PersonComparer,
	        // which implements IEqualityComparer<Person>,  
	        // although the method expects IEqualityComparer<Employee>.  
	  
	        IEnumerable<Employee> noduplicates =  
	            employees.Distinct<Employee>(new PersonComparer());  
	  
	        foreach (var employee in noduplicates)  
	            Console.WriteLine(employee.FirstName + " " + employee.LastName);  
	    }  
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/creating-variant-generic-interfaces
namespace DotnetCSharpProgrammingGuideConceptsCovarianceContravarianceCreatingVariantGenericInterfaces
{
	public class CovarianceContravarianceCreatingVariantGenericInterfaces
	{
		public static void RunCovarianceContravarianceCreatingVariantGenericInterfaces()
		{
			/*
			// The interface is covariant.
			ICovariant<Button> ibutton = new SampleImplementation<Button>();
			ICovariant<Object> iobj = ibutton;
			
			// The class is invariant.
			SampleImplementation<Button> button = new SampleImplementation<Button>();
			// The following statement generates a compiler error
			// because classes are invariant.
			// SampleImplementation<Object> obj = button;
			*/
			
		}
	}
	
	/*
	interface ICovariant<out R>
	{
	    R GetSomething();
	    // The following statement generates a compiler error.
	    // void SetSomething(R sampleArg);
	
	}
	*/
	
	/*
	interface ICovariant<out R>
	{
	    void DoSomething(Action<R> callback);
	}
	*/
	
	/*
	interface ICovariant<out R>
	{
	    // The following statement generates a compiler error
	    // because you can use only contravariant or invariant types
	    // in generic constraints.
	    // void DoSomething<T>() where T : R;
	}
	*/
	
	interface IContravariant<in A>
	{
	    void SetSomething(A sampleArg);
	    void DoSomething<T>() where T : A;
	    // The following statement generates a compiler error.
	    // A GetSomething();
	}
	
	interface IVariant<out R, in A>
	{
	    R GetSomething();
	    void SetSomething(A sampleArg);
	    R GetSetSomethings(A sampleArg);
	}
	
	interface ICovariant<out R>
	{
	    R GetSomething();
	}
	class SampleImplementation<R> : ICovariant<R>
	{
	    public R GetSomething()
	    {
	        // Some code.
	        return default(R);
	    }
	}
	
	/*
	interface ICovariant<out T> { }
	interface IInvariant<T> : ICovariant<T> { }
	interface IExtCovariant<out T> : ICovariant<T> { }
	
	interface ICovariant<out T> { }
	interface IContravariant<in T> { }
	interface IInvariant<T> : ICovariant<T>, IContravariant<T> { }
	*/
	
	// Simple class hierarchy.
	class Animal { }
	class Cat : Animal { }
	class Dog : Animal { }
	
	// This class introduces ambiguity
	// because IEnumerable<out T> is covariant.
	class Pets : IEnumerable<Cat>, IEnumerable<Dog>
	{
	    IEnumerator<Cat> IEnumerable<Cat>.GetEnumerator()
	    {
	        Console.WriteLine("Cat");
	        // Some code.
	        return null;
	    }
	
	    IEnumerator IEnumerable.GetEnumerator()
	    {
	        // Some code.
	        return null;
	    }
	
	    IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
	    {
	        Console.WriteLine("Dog");
	        // Some code.
	        return null;
	    }
	}
	class Program
	{
	    public static void Test()
	    {
	        IEnumerable<Animal> pets = new Pets();
	        pets.GetEnumerator();
	    }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/variance-in-generic-interfaces
namespace DotnetCSharpProgrammingGuideConceptsCovarianceContravarianceVarianceInGenericInterfaces
{
	public class CovarianceContravarianceVarianceInGenericInterfaces
	{
		public static void RunCovarianceContravarianceVarianceInGenericInterfaces()
		{
			IEnumerable<String> strings = new List<String>();
			IEnumerable<Object> objects = strings;
			
			IEnumerable<int> integers = new List<int>();
			// The following statement generates a compiler error,
			// because int is a value type.
			// IEnumerable<Object> objects = integers;
			
			// The following line generates a compiler error
			// because classes are invariant.
			// List<Object> list = new List<String>();
			
			// You can use the interface object instead.
			IEnumerable<Object> listObjects = new List<String>();
		}
	}
	
	// Simple hierarchy of classes.
	class BaseClass { }
	class DerivedClass : BaseClass { }
	
	// Comparer class.
	class BaseComparer : IEqualityComparer<BaseClass>
	{
	    public int GetHashCode(BaseClass baseInstance)
	    {
	        return baseInstance.GetHashCode();
	    }
	    public bool Equals(BaseClass x, BaseClass y)
	    {
	        return x == y;
	    }
	}
	class Program
	{
	    static void Test()
	    {
	        IEqualityComparer<BaseClass> baseComparer = new BaseComparer();
	
	        // Implicit conversion of IEqualityComparer<BaseClass> to
	        // IEqualityComparer<DerivedClass>.
	        IEqualityComparer<DerivedClass> childComparer = baseComparer;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/
namespace DotnetCSharpProgrammingGuideConceptsCovarianceContravariance
{
	public class CovarianceContravariance
	{
		public static void RunCovarianceContravariance()
		{
			// Assignment compatibility.
			string str = "test";  
			// An object of a more derived type is assigned to an object of a less derived type.
			object obj = str;  
			  
			// Covariance.
			IEnumerable<string> strings = new List<string>();  
			// An object that is instantiated with a more derived type argument
			// is assigned to an object instantiated with a less derived type argument.
			// Assignment compatibility is preserved.
			IEnumerable<object> objects = strings;  
			  
			// Contravariance.
			// Assume that the following method is in the class:
			static void SetObject(object o) { }
			Action<object> actObject = SetObject;  
			// An object that is instantiated with a less derived type argument
			// is assigned to an object instantiated with a more derived type argument.
			// Assignment compatibility is reversed.
			Action<string> actString = actObject;
			
			object[] array = new String[10];  
			// The following statement produces a run-time exception.  
			// array[0] = 10;
			
			//IEnumerable<String> strings = new List<String>();  
			//IEnumerable<Object> objects = strings;
		}
		
		static object GetObject() { return null; }  
		static void SetObject(object obj) { }  
		  
		static string GetString() { return ""; }  
		static void SetString(string str) { }  
		  
		static void Test()  
		{  
		    // Covariance. A delegate specifies a return type as object,  
		    // but you can assign a method that returns a string.  
		    Func<object> del = GetString;  
		  
		    // Contravariance. A delegate specifies a parameter type as string,  
		    // but you can assign a method that takes an object.  
		    Action<string> del2 = SetObject;  
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/tutorials/how-to-write-csharp-analyzer-code-fix
namespace DotnetCSharpRoslynSdkTutorialsHowToWriteCSharpAnalyzerCodeFix
{
	public class CSharpAnalyzerCodeFix
	{
		public static void RunCSharpAnalyzerCodeFix()
		{
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-transformation
namespace DotnetCSharpRoslynSdkGetStartedSyntaxTransformation
{
	public class SyntaxTransformation
	{
		public static void RunSyntaxTransformation()
		{
			/*
			NameSyntax name = IdentifierName("System");
			WriteLine($"\tCreated the identifier {name}");
			
			name = QualifiedName(name, IdentifierName("Collections"));
			WriteLine(name.ToString());
			
			private const string sampleCode =
			@"using System;
			using System.Collections;
			using System.Linq;
			using System.Text;
			
			namespace HelloWorld
			{
			    class Program
			    {
			        static void Main(string[] args)
			        {
			            Console.WriteLine(""Hello, World!"");
			        }
			    }
			}";
			
			SyntaxTree tree = CSharpSyntaxTree.ParseText(sampleCode);
			var root = (CompilationUnitSyntax)tree.GetRoot();
			
			var oldUsing = root.Usings[1];
			var newUsing = oldUsing.WithName(name);
			WriteLine(root.ToString());
			
			root = root.ReplaceNode(oldUsing, newUsing);
			WriteLine(root.ToString());
			
			Type variable = expression;
			
			// Multiple variables in a single declaration.
			Type variable1 = expression1,
			     variable2 = expression2;
			// No initializer.
			Type variable;
			
			if (node.Declaration.Variables.Count > 1)
			{
			    return node;
			}
			if (node.Declaration.Variables[0].Initializer == null)
			{
			    return node;
			}
			
			var declarator = node.Declaration.Variables.First();
			var variableTypeName = node.Declaration.Type;
			
			var variableType = (ITypeSymbol)SemanticModel
			    .GetSymbolInfo(variableTypeName)
			    .Symbol;
				
			var initializerInfo = SemanticModel.GetTypeInfo(declarator.Initializer.Value);
			
			if (SymbolEqualityComparer.Default.Equals(variableType, initializerInfo.Type))
			{
			    TypeSyntax varTypeName = SyntaxFactory.IdentifierName("var")
			        .WithLeadingTrivia(variableTypeName.GetLeadingTrivia())
			        .WithTrailingTrivia(variableTypeName.GetTrailingTrivia());
			
			    return node.ReplaceNode(variableTypeName, varTypeName);
			}
			else
			{
			    return node;
			}
			
			Compilation test = CreateTestCompilation();
			
			foreach (SyntaxTree sourceTree in test.SyntaxTrees)
			{
			    SemanticModel model = test.GetSemanticModel(sourceTree);
			
			    TypeInferenceRewriter rewriter = new TypeInferenceRewriter(model);
			
			    SyntaxNode newSource = rewriter.Visit(sourceTree.GetRoot());
			
			    if (newSource != sourceTree.GetRoot())
			    {
			        File.WriteAllText(sourceTree.FilePath, newSource.ToFullString());
			    }
			}
			
			SyntaxNode newSource = rewriter.Visit(sourceTree.GetRoot());

			if (newSource != sourceTree.GetRoot())
			{
			    File.WriteAllText(sourceTree.FilePath, newSource.ToFullString());
			}
			
			String programPath = @"..\..\..\Program.cs";
			String programText = File.ReadAllText(programPath);
			SyntaxTree programTree =
			               CSharpSyntaxTree.ParseText(programText)
			                               .WithFilePath(programPath);
			
			String rewriterPath = @"..\..\..\TypeInferenceRewriter.cs";
			String rewriterText = File.ReadAllText(rewriterPath);
			SyntaxTree rewriterTree =
			               CSharpSyntaxTree.ParseText(rewriterText)
			                               .WithFilePath(rewriterPath);
			
			SyntaxTree[] sourceTrees = { programTree, rewriterTree };
			
			MetadataReference mscorlib =
			        MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
			MetadataReference codeAnalysis =
			        MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location);
			MetadataReference csharpCodeAnalysis =
			        MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location);
			
			MetadataReference[] references = { mscorlib, codeAnalysis, csharpCodeAnalysis };
			
			return CSharpCompilation.Create("TransformationCS",
			    sourceTrees,
			    references,
			    new CSharpCompilationOptions(OutputKind.ConsoleApplication));
			*/
			
			
			
		}
		
		/*
		private readonly SemanticModel SemanticModel;

		public TypeInferenceRewriter(SemanticModel semanticModel) => SemanticModel = semanticModel;
		
		public override SyntaxNode VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
		{
		
		}
		*/
	}
	
	//public class TypeInferenceRewriter : CSharpSyntaxRewriter
}

//https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/semantic-analysis
namespace DotnetCSharpRoslynSdkGetStartedSemanticAnalysis
{
	public class SemanticAnalysis
	{
		public static void RunSemanticAnalysis()
		{
			const string programText =
				@"using System;
				using System.Collections.Generic;
				using System.Text;
				
				namespace HelloWorld
				{
				    class Program
				    {
				        static void Main(string[] args)
				        {
				            Console.WriteLine(""Hello, World!"");
				        }
				    }
				}";
			
			/*	
			SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);

			CompilationUnitSyntax root = tree.GetCompilationUnitRoot();
			
			var compilation = CSharpCompilation.Create("HelloWorld")
			    .AddReferences(MetadataReference.CreateFromFile(
			        typeof(string).Assembly.Location))
			    .AddSyntaxTrees(tree);
			
			SemanticModel model = compilation.GetSemanticModel(tree);
			
			// Use the syntax tree to find "using System;"
			UsingDirectiveSyntax usingSystem = root.Usings[0];
			NameSyntax systemName = usingSystem.Name;
			
			// Use the semantic model for symbol information:
			SymbolInfo nameInfo = model.GetSymbolInfo(systemName);
			
			var systemSymbol = (INamespaceSymbol?)nameInfo.Symbol;
			if (systemSymbol?.GetNamespaceMembers() is not null)
			{
			    foreach (INamespaceSymbol ns in systemSymbol?.GetNamespaceMembers()!)
			    {
			        Console.WriteLine(ns);
			    }
			}
			
			// Use the syntax model to find the literal string:
			LiteralExpressionSyntax helloWorldString = root.DescendantNodes()
			.OfType<LiteralExpressionSyntax>()
			.Single();
			
			// Use the semantic model for type information:
			TypeInfo literalInfo = model.GetTypeInfo(helloWorldString);
			
			var stringTypeSymbol = (INamedTypeSymbol?)literalInfo.Type;
			
			var allMembers = stringTypeSymbol?.GetMembers();
			
			var methods = allMembers?.OfType<IMethodSymbol>();
			
			var publicStringReturningMethods = methods?
			    .Where(m => SymbolEqualityComparer.Default.Equals(m.ReturnType, stringTypeSymbol) &&
			    m.DeclaredAccessibility == Accessibility.Public);
				
			var distinctMethods = publicStringReturningMethods?.Select(m => m.Name).Distinct();
			
			foreach (string name in (from method in stringTypeSymbol?
			                         .GetMembers().OfType<IMethodSymbol>()
			                         where SymbolEqualityComparer.Default.Equals(method.ReturnType, stringTypeSymbol) &&
			                         method.DeclaredAccessibility == Accessibility.Public
			                         select method.Name).Distinct())
			{
			    Console.WriteLine(name);
			}
			*/
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-analysis
namespace DotnetCSharpRoslynSdkGetStartedSyntaxAnalysis
{
	public class GetStartedSyntaxAnalysis
	{
		public static void RunGetStartedSyntaxAnalysis()
		{
			/*
			SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
			CompilationUnitSyntax root = tree.GetCompilationUnitRoot();
			
			WriteLine($"The tree is a {root.Kind()} node.");
			WriteLine($"The tree has {root.Members.Count} elements in it.");
			WriteLine($"The tree has {root.Usings.Count} using directives. They are:");
			foreach (UsingDirectiveSyntax element in root.Usings)
			    WriteLine($"\t{element.Name}");
				
			MemberDeclarationSyntax firstMember = root.Members[0];
			WriteLine($"The first member is a {firstMember.Kind()}.");
			var helloWorldDeclaration = (NamespaceDeclarationSyntax)firstMember;
			
			WriteLine($"There are {helloWorldDeclaration.Members.Count} members declared in this namespace.");
			WriteLine($"The first member is a {helloWorldDeclaration.Members[0].Kind()}.");
			
			var programDeclaration = (ClassDeclarationSyntax)helloWorldDeclaration.Members[0];
			WriteLine($"There are {programDeclaration.Members.Count} members declared in the {programDeclaration.Identifier} class.");
			WriteLine($"The first member is a {programDeclaration.Members[0].Kind()}.");
			var mainDeclaration = (MethodDeclarationSyntax)programDeclaration.Members[0];
			
			WriteLine($"The return type of the {mainDeclaration.Identifier} method is {mainDeclaration.ReturnType}.");
			WriteLine($"The method has {mainDeclaration.ParameterList.Parameters.Count} parameters.");
			foreach (ParameterSyntax item in mainDeclaration.ParameterList.Parameters)
			    WriteLine($"The type of the {item.Identifier} parameter is {item.Type}.");
			WriteLine($"The body text of the {mainDeclaration.Identifier} method follows:");
			WriteLine(mainDeclaration.Body?.ToFullString());
			
			var argsParameter = mainDeclaration.ParameterList.Parameters[0];
			
			var firstParameters = from methodDeclaration in root.DescendantNodes()
                                        .OfType<MethodDeclarationSyntax>()
                      where methodDeclaration.Identifier.ValueText == "Main"
                      select methodDeclaration.ParameterList.Parameters.First();

			var argsParameter2 = firstParameters.Single();
			
			WriteLine(argsParameter == argsParameter2);
			
						const string programText =
			@"using System;
			using System.Collections.Generic;
			using System.Linq;
			using System.Text;
			using Microsoft.CodeAnalysis;
			using Microsoft.CodeAnalysis.CSharp;
			
			namespace TopLevel
			{
			    using Microsoft;
			    using System.ComponentModel;
			
			    namespace Child1
			    {
			        using Microsoft.Win32;
			        using System.Runtime.InteropServices;
			
			        class Foo { }
			    }
			
			    namespace Child2
			    {
			        using System.CodeDom;
			        using Microsoft.CSharp;
			
			        class Bar { }
			    }
			}";
			
			SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
			CompilationUnitSyntax root = tree.GetCompilationUnitRoot();
			
			class UsingCollector : CSharpSyntaxWalker
			
			public ICollection<UsingDirectiveSyntax> Usings { get; } = new List<UsingDirectiveSyntax>();
			
			var collector = new UsingCollector();
			collector.Visit(root);
			foreach (var directive in collector.Usings)
			{
			    WriteLine(directive.Name);
			}
			*/
		}
		
		/*
		public override void VisitUsingDirective(UsingDirectiveSyntax node)
		{
		    WriteLine($"\tVisitUsingDirective called with {node.Name}.");
		    if (node.Name.ToString() != "System" &&
		        !node.Name.ToString().StartsWith("System."))
		    {
		        WriteLine($"\t\tSuccess. Adding {node.Name}.");
		        this.Usings.Add(node);
		    }
		}
		*/
	}
	
	namespace HelloWorld
	{
	    class Program
	    {
	        static void RunMain(string[] args)
	        {
	            Console.WriteLine("Hello World!");
	        }
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/performance/interpolated-string-handler
namespace DotnetCSharpAdvancedTopicsPerformanceInterpolatedStringHandler
{
	public class InterpolatedStringHandler
	{
		private readonly bool enabled;
		
		public static void RunInterpolatedStringHandler()
		{
			var logger = new Logger() { EnabledLevel = LogLevel.Warning };
			var time = DateTime.Now;
			
			logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time}. This is an error. It will be printed.");
			logger.LogMessage(LogLevel.Trace, $"Trace Level. CurrentTime: {time}. This won't be printed.");
			logger.LogMessage(LogLevel.Warning, "Warning Level. This warning is a string, not an interpolated string expression.");
			
			//var time = DateTime.Now;

			logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time}. The time doesn't use formatting.");
			logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time:t}. This is an error. It will be printed.");
			logger.LogMessage(LogLevel.Trace, $"Trace Level. CurrentTime: {time:t}. This won't be printed.");
			
			int index = 0;
			int numberOfIncrements = 0;
			for (var level = LogLevel.Critical; level <= LogLevel.Trace; level++)
			{
			    Console.WriteLine(level);
			    logger.LogMessage(level, $"{level}: Increment index {index++}");
			    numberOfIncrements++;
			}
			Console.WriteLine($"Value of index {index}, value of numberOfIncrements: {numberOfIncrements}");
		}
		
		/*
		public void AppendLiteral(string s)
		{
		    Console.WriteLine($"\tAppendLiteral called: {{{s}}}");
		    if (!enabled) return;
		
		    builder.Append(s);
		    Console.WriteLine($"\tAppended the literal string");
		}
		
		public void AppendFormatted<T>(T t)
		{
		    Console.WriteLine($"\tAppendFormatted called: {{{t}}} is of type {typeof(T)}");
		    if (!enabled) return;
		
		    builder.Append(t?.ToString());
		    Console.WriteLine($"\tAppended the formatted object");
		}
		
		public void LogMessage(LogLevel level, [InterpolatedStringHandlerArgument("", "level")] LogInterpolatedStringHandler builder)
		{
		    if (EnabledLevel < level) return;
		    Console.WriteLine(builder.ToString());
		}
		
		public void AppendFormatted<T>(T t, string format) where T : IFormattable
		{
		    Console.WriteLine($"\tAppendFormatted (IFormattable version) called: {t} with format {{{format}}} is of type {typeof(T)},");
		
		    builder.Append(t?.ToString(format, null));
		    Console.WriteLine($"\tAppended the formatted object");
		}
		
		public void AppendFormatted<T>(T t, int alignment, string format) where T : IFormattable
		{
		    Console.WriteLine($"\tAppendFormatted (IFormattable version) called: {t} with alignment {alignment} and format {{{format}}} is of type {typeof(T)},");
		    var formatString =$"{alignment}:{format}";
		    builder.Append(string.Format($"{{0,{formatString}}}", t));
		    Console.WriteLine($"\tAppended the formatted object");
		}
		
		public LogInterpolatedStringHandler(int literalLength, int formattedCount, Logger logger, LogLevel level, out bool isEnabled)
		{
		    isEnabled = logger.EnabledLevel >= level;
		    Console.WriteLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
		    builder = isEnabled ? new StringBuilder(literalLength) : default!;
		}
		*/
		
		
		
		
	}
	
	public enum LogLevel
	{
	    Off,
	    Critical,
	    Error,
	    Warning,
	    Information,
	    Trace
	}
	
	public class Logger
	{
	    public LogLevel EnabledLevel { get; init; } = LogLevel.Error;
	
	    public void LogMessage(LogLevel level, string msg)
	    {
	        if (EnabledLevel < level) return;
	        Console.WriteLine(msg);
	    }
		
		/*
		public void LogMessage(LogLevel level, LogInterpolatedStringHandler builder)
		{
		    if (EnabledLevel < level) return;
		    Console.WriteLine(builder.ToString());
		}
		
		public LogInterpolatedStringHandler(int literalLength, int formattedCount, Logger logger, LogLevel logLevel)
		{
		    enabled = logger.EnabledLevel >= logLevel;
		    builder = new StringBuilder(literalLength);
		    Console.WriteLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
		}
		*/
	}
	
	/*
	[InterpolatedStringHandler]
	public struct LogInterpolatedStringHandler
	{
	    // Storage for the built-up string
	    StringBuilder builder;
	
	    public LogInterpolatedStringHandler(int literalLength, int formattedCount)
	    {
	        builder = new StringBuilder(literalLength);
	        Console.WriteLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
	    }
	
	    public void AppendLiteral(string s)
	    {
	        Console.WriteLine($"\tAppendLiteral called: {{{s}}}");
	        
	        builder.Append(s);
	        Console.WriteLine($"\tAppended the literal string");
	    }
	
	    public void AppendFormatted<T>(T t)
	    {
	        Console.WriteLine($"\tAppendFormatted called: {{{t}}} is of type {typeof(T)}");
	
	        builder.Append(t?.ToString());
	        Console.WriteLine($"\tAppended the formatted object");
	    }
	
	    public override string ToString() => builder.ToString();
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/performance/ref-tutorial
namespace DotnetCSharpAdvancedTopicsPerformanceRefTutorial
{
	public class PerformanceRefTutorial
	{
		public static void RunPerformanceRefTutorial()
		{
			/*
			Console.WriteLine("Press <return> to start simulation");
			Console.ReadLine();
			var room = new Room("gallery");
			var r = new Random();
			
			int counter = 0;
			
			room.TakeMeasurements(
			    m =>
			    {
			        Console.WriteLine(room.Debounce);
			        Console.WriteLine(room.Average);
			        Console.WriteLine();
			        counter++;
			        return counter < 20000;
			    });
				
			counter = 0;
			room.TakeMeasurements(
			    m =>
			    {
			        Console.WriteLine(room.Debounce);
			        Console.WriteLine(room.Average);
			        room.Intruders += (room.Intruders, r.Next(5)) switch
			        {
			            ( > 0, 0) => -1,
			            ( < 3, 1) => 1,
			            _ => 0
			        };
			
			        Console.WriteLine($"Current intruders: {room.Intruders}");
			        Console.WriteLine($"Calculated intruder risk: {room.RiskStatus}");
			        Console.WriteLine();
			        counter++;
			        return counter < 200000;
			    });
				
			if (recentMeasurements[i].Room is not null)
			*/
			
			
				
			
		}
		
		
		
		
	}
	
	public class SensorMeasurement
	{
	    private static readonly Random generator = new Random();
	
		/*
	    public static SensorMeasurement TakeMeasurement(string room, int intruders)
	    {
	        return new SensorMeasurement
	        {
	            CO2 = (CO2Concentration + intruders * 10) + (20 * generator.NextDouble() - 10.0),
	            O2 = (O2Concentration - intruders * 0.01) + (0.005 * generator.NextDouble() - 0.0025),
	            Temperature = (TemperatureSetting + intruders * 0.05) + (0.5 * generator.NextDouble() - 0.25),
	            Humidity = (HumiditySetting + intruders * 0.005) + (0.20 * generator.NextDouble() - 0.10),
	            Room = room,
	            TimeRecorded = DateTime.Now
	        };
	    }
		*/
		
		/*
		public static SensorMeasurement TakeMeasurement(string room, int intruders)
		{
		    return new SensorMeasurement
		    {
		        CO2 = (CO2Concentration + intruders * 10) + (20 * generator.NextDouble() - 10.0),
		        O2 = (O2Concentration - intruders * 0.01) + (0.005 * generator.NextDouble() - 0.0025),
		        Temperature = (TemperatureSetting + intruders * 0.05) + (0.5 * generator.NextDouble() - 0.25),
		        Humidity = (HumiditySetting + intruders * 0.005) + (0.20 * generator.NextDouble() - 0.10),
		        Room = room,
		        TimeRecorded = DateTime.Now
		    };
		}
		
		public void TakeMeasurements(Func<SensorMeasurement, bool> MeasurementHandler)
		{
		    SensorMeasurement? measure = default;
		    do {
		        measure = SensorMeasurement.TakeMeasurement(Name, Intruders);
		        Average.AddMeasurement(measure);
		        Debounce.AddMeasurement(measure);
		    } while (MeasurementHandler(measure));
		}
		
		
		public static SensorMeasurement TakeMeasurement(string room, int intruders)
		{
		    return new SensorMeasurement
		    {
		        CO2 = (CO2Concentration + intruders * 10) + (20 * generator.NextDouble() - 10.0),
		        O2 = (O2Concentration - intruders * 0.01) + (0.005 * generator.NextDouble() - 0.0025),
		        Temperature = (TemperatureSetting + intruders * 0.05) + (0.5 * generator.NextDouble() - 0.25),
		        Humidity = (HumiditySetting + intruders * 0.005) + (0.20 * generator.NextDouble() - 0.10),
		        Room = room,
		        TimeRecorded = DateTime.Now
		    };
		}
		*/
		
		public static SensorMeasurement TakeMeasurement(string room, int intruders)
		{
		    return new SensorMeasurement
		    {
		        CO2 = (CO2Concentration + intruders * 10) + (20 * generator.NextDouble() - 10.0),
		        O2 = (O2Concentration - intruders * 0.01) + (0.005 * generator.NextDouble() - 0.0025),
		        Temperature = (TemperatureSetting + intruders * 0.05) + (0.5 * generator.NextDouble() - 0.25),
		        Humidity = (HumiditySetting + intruders * 0.005) + (0.20 * generator.NextDouble() - 0.10),
		        Room = room,
		        TimeRecorded = DateTime.Now
		    };
		}
		
		/*
		public void AddMeasurement(in SensorMeasurement datum)
		{
		    int index = totalMeasurements % debounceSize;
		    recentMeasurements[index] = datum;
		    totalMeasurements++;
		    double sumCO2 = 0;
		    double sumO2 = 0;
		    double sumTemp = 0;
		    double sumHumidity = 0;
		    for (int i = 0; i < debounceSize; i++)
		    {
		        if (recentMeasurements[i].Room is not null)
		        {
		            sumCO2 += recentMeasurements[i].CO2;
		            sumO2+= recentMeasurements[i].O2;
		            sumTemp+= recentMeasurements[i].Temperature;
		            sumHumidity += recentMeasurements[i].Humidity;
		        }
		    }
		    O2 = sumO2 / ((totalMeasurements > debounceSize) ? debounceSize : totalMeasurements);
		    CO2 = sumCO2 / ((totalMeasurements > debounceSize) ? debounceSize : totalMeasurements);
		    Temperature = sumTemp / ((totalMeasurements > debounceSize) ? debounceSize : totalMeasurements);
		    Humidity = sumHumidity / ((totalMeasurements > debounceSize) ? debounceSize : totalMeasurements);
		}
		*/
	
	    private const double CO2Concentration = 409.8; // increases with people.
	    private const double O2Concentration = 0.2100; // decreases
	    private const double TemperatureSetting = 67.5; // increases
	    private const double HumiditySetting = 0.4500; // increases
	
	    public required double CO2 { get; init; }
	    public required double O2 { get; init; }
	    public required double Temperature { get; init; }
	    public required double Humidity { get; init; }
	    public required string Room { get; init; }
	    public required DateTime TimeRecorded { get; init; }
	
	    public override string ToString() => $"""
	            Room: {Room} at {TimeRecorded}:
	                Temp:      {Temperature:F3}
	                Humidity:  {Humidity:P3}
	                Oxygen:    {O2:P3}
	                CO2 (ppm): {CO2:F3}
	            """;
	
	
	}
	
	/*
	public class Room
	{
	    public AverageMeasurement Average { get; } = new ();
	    public DebounceMeasurement Debounce { get; } = new ();
	    public string Name { get; }
	
	    public IntruderRisk RiskStatus
	    {
	        get
	        {
	            var CO2Variance = (Debounce.CO2 - Average.CO2) > 10.0 / 4;
	            var O2Variance = (Average.O2 - Debounce.O2) > 0.005 / 4.0;
	            var TempVariance = (Debounce.Temperature - Average.Temperature) > 0.05 / 4.0;
	            var HumidityVariance = (Debounce.Humidity - Average.Humidity) > 0.20 / 4;
	            IntruderRisk risk = IntruderRisk.None;
	            if (CO2Variance) { risk++; }
	            if (O2Variance) { risk++; }
	            if (TempVariance) { risk++; }
	            if (HumidityVariance) { risk++; }
	            return risk;
	        }
	    }
	
	    public int Intruders { get; set; }
	
	    
	    public Room(string name)
	    {
	        Name = name;
	    }
	
	    public void TakeMeasurements(Func<SensorMeasurement, bool> MeasurementHandler)
	    {
	        SensorMeasurement? measure = default;
	        do {
	            measure = SensorMeasurement.TakeMeasurement(Name, Intruders);
	            Average.AddMeasurement(measure);
	            Debounce.AddMeasurement(measure);
	        } while (MeasurementHandler(measure));
	    }
	}
	*/
	
	//public DebounceMeasurement() { }
	
	//private DebounceMeasurement debounce = new();
	//public ref readonly DebounceMeasurement Debounce { get { return ref debounce; } }
	
	public struct AverageMeasurement
	{
	    private double sumCO2 = 0;
	    private double sumO2 = 0;
	    private double sumTemperature = 0;
	    private double sumHumidity = 0;
	    private int totalMeasurements = 0;
	
	    public AverageMeasurement() { }
	
	    public readonly double CO2 => sumCO2 / totalMeasurements;
	    public readonly double O2 => sumO2 / totalMeasurements;
	    public readonly double Temperature => sumTemperature / totalMeasurements;
	    public readonly double Humidity => sumHumidity / totalMeasurements;
	
	    public void AddMeasurement(in SensorMeasurement datum)
	    {
	        totalMeasurements++;
	        sumCO2 += datum.CO2;
	        sumO2 += datum.O2;
	        sumTemperature += datum.Temperature;
	        sumHumidity+= datum.Humidity;
	    }
	
	    public readonly override string ToString() => $"""
	        Average measurements:
	            Temp:      {Temperature:F3}
	            Humidity:  {Humidity:P3}
	            Oxygen:    {O2:P3}
	            CO2 (ppm): {CO2:F3}
	        """;
	}
	
	//private AverageMeasurement average = new();
	//public  ref readonly AverageMeasurement Average { get { return ref average; } }
	
	//Console.WriteLine($"Current intruders: {room.Intruders}");
	//Console.WriteLine($"Calculated intruder risk: {room.RiskStatus}");
	
	/*
	public override string ToString() =>
	    $"Calculated intruder risk: {RiskStatus switch
	    {
	        IntruderRisk.None => "None",
	        IntruderRisk.Low => "Low",
	        IntruderRisk.Medium => "Medium",
	        IntruderRisk.High => "High",
	        IntruderRisk.Extreme => "Extreme",
	        _ => "Error!"
	    }}, Current intruders: {Intruders.ToString()}";
	*/
	
	

}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/performance/
namespace DotnetCSharpAdvancedTopicsPerformance
{
	public class AdvancedTopicsPerformance
	{
		private int anIndex;
		
		private string longMessage = "This is a long message";
		
		public static void RunAdvancedTopicsPerformance()
		{
			int anInteger = 42; // assignment.
			ref int location = ref anInteger; // ref assignment.
			ref int sameLocation = ref location; // ref assignment
			
			Console.WriteLine(location); // output: 42
			
			sameLocation = 19; // assignment
			
			Console.WriteLine(anInteger); // output: 19
		}
		
		/*
		public ref int CantEscape()
		{
		    int index = 42;
		    return ref index; // Error: index's ref safe context is the body of CantEscape
		}
		*/
		
		public ref int RetrieveIndexRef()
		{
		    return ref anIndex;
		}
		
		public ref int RefMin(ref int left, ref int right)
		{
		    if (left < right)
		        return ref left;
		    else
		        return ref right;
		}
		
		public ReadOnlySpan<char> Safe()
		{
		    var span = longMessage.AsSpan();
		    return span;
		}
		
		/*
		public Span<int> M()
		{
		    int length = 3;
		    Span<int> numbers = stackalloc int[length];
		    for (var i = 0; i < length; i++)
		    {
		        numbers[i] = i;
		    }
		    return numbers; // Error! numbers can't escape this method.
		}
		*/
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/walkthrough-creating-and-using-dynamic-objects
namespace DotnetCSharopAdvancedTopicsInteropWalkthroughCreatingAndUsingDynamicObjects
{
	public class CreatingAndUsingDynamicObjects
	{
		// Store the path to the file and the initial line count value.
			private string p_filePath;
			
		public static void RunCreatingAndUsingDynamicObjects()
		{
			/*
			dynamic rFile = new ReadOnlyFile(@"..\..\..\TextFile1.txt");
			foreach (string line in rFile.Customer)
			{
			    Console.WriteLine(line);
			}
			Console.WriteLine("----------------------------");
			foreach (string line in rFile.Customer(StringSearchOption.Contains, true))
			{
			    Console.WriteLine(line);
			}
			
			
			// Set the current directory to the IronPython libraries.
			System.IO.Directory.SetCurrentDirectory(
			   Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) +
			   @"\IronPython 2.7\Lib");
			
			// Create an instance of the random.py IronPython library.
			Console.WriteLine("Loading random.py");
			ScriptRuntime py = Python.CreateRuntime();
			dynamic random = py.UseFile("random.py");
			Console.WriteLine("random.py loaded.");
			
			// Initialize an enumerable set of integers.
			int[] items = Enumerable.Range(1, 7).ToArray();
			
			// Randomly shuffle the array of integers by using IronPython.
			for (int i = 0; i < 5; i++)
			{
			    random.shuffle(items);
			    foreach (int item in items)
			    {
			        Console.WriteLine(item);
			    }
			    Console.WriteLine("-------------------");
			}
			*/
			
			
		}
		
		public List<string> GetPropertyValue(string propertyName,
                                     StringSearchOption StringSearchOption = StringSearchOption.StartsWith,
                                     bool trimSpaces = true)
		{
		    StreamReader sr = null;
		    List<string> results = new List<string>();
		    string line = "";
		    string testLine = "";
		
		    try
		    {
		        sr = new StreamReader(p_filePath);
		
		        while (!sr.EndOfStream)
		        {
		            line = sr.ReadLine();
		
		            // Perform a case-insensitive search by using the specified search options.
		            testLine = line.ToUpper();
		            if (trimSpaces) { testLine = testLine.Trim(); }
		
		            switch (StringSearchOption)
		            {
		                case StringSearchOption.StartsWith:
		                    if (testLine.StartsWith(propertyName.ToUpper())) { results.Add(line); }
		                    break;
		                case StringSearchOption.Contains:
		                    if (testLine.Contains(propertyName.ToUpper())) { results.Add(line); }
		                    break;
		                case StringSearchOption.EndsWith:
		                    if (testLine.EndsWith(propertyName.ToUpper())) { results.Add(line); }
		                    break;
		            }
		        }
		    }
		    catch
		    {
		        // Trap any exception that occurs in reading the file and return null.
		        results = null;
		    }
		    finally
		    {
		        if (sr != null) {sr.Close();}
		    }
		
		    return results;
		}
		
		/*
		// Implement the TryGetMember method of the DynamicObject class for dynamic member calls.
		public override bool TryGetMember(GetMemberBinder binder,
		                                  out object result)
		{
		    result = GetPropertyValue(binder.Name);
		    return result == null ? false : true;
		}
		
		// Implement the TryInvokeMember method of the DynamicObject class for
		// dynamic member calls that have arguments.
		public override bool TryInvokeMember(InvokeMemberBinder binder,
		                                     object[] args,
		                                     out object result)
		{
		    StringSearchOption StringSearchOption = StringSearchOption.StartsWith;
		    bool trimSpaces = true;
		
		    try
		    {
		        if (args.Length > 0) { StringSearchOption = (StringSearchOption)args[0]; }
		    }
		    catch
		    {
		        throw new ArgumentException("StringSearchOption argument must be a StringSearchOption enum value.");
		    }
		
		    try
		    {
		        if (args.Length > 1) { trimSpaces = (bool)args[1]; }
		    }
		    catch
		    {
		        throw new ArgumentException("trimSpaces argument must be a Boolean value.");
		    }
		
		    result = GetPropertyValue(binder.Name, StringSearchOption, trimSpaces);
		
		    return result == null ? false : true;
		}
		*/
	}
	
	public enum StringSearchOption
	{
	    StartsWith,
	    Contains,
	    EndsWith
	}
	
	/*
	class ReadOnlyFile : DynamicObject
	{
		// Public constructor. Verify that file exists and store the path in
		// the private variable.
		public ReadOnlyFile(string filePath)
		{
		    if (!File.Exists(filePath))
		    {
		        throw new Exception("File path does not exist.");
		    }
		
		    p_filePath = filePath;
		}
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/using-type-dynamic
namespace DotnetCSharpAdvancedTopicsInteropUsingTypeDynamic
{
	public class UsingTypeDynamic
	{
		static void RunMain(string[] args)
		{
		    ExampleClass ec = new ExampleClass();
		    // The following call to exampleMethod1 causes a compiler error
		    // if exampleMethod1 has only one parameter. Uncomment the line
		    // to see the error.
		    // ec.exampleMethod1(10, 4);
		
		    dynamic dynamic_ec = new ExampleClass();
		    // The following line is not identified as an error by the
		    // compiler, but it causes a run-time exception.
		    dynamic_ec.exampleMethod1(10, 4);
		
		    // The following calls also do not cause compiler errors, whether
		    // appropriate methods exist or not.
		    dynamic_ec.someMethod("some argument", 7, null);
		    dynamic_ec.nonexistentMethod();
			
			dynamic d = 1;
			var testSum = d + 3;
			// Rest the mouse pointer over testSum in the following statement.
			System.Console.WriteLine(testSum);
			
			var testInstance = new ExampleClass(d);
			
			dynamic d1 = 7;
			dynamic d2 = "a string";
			dynamic d3 = System.DateTime.Today;
			dynamic d4 = System.Diagnostics.Process.GetProcesses();
			
			int i = d1;
			string str = d2;
			DateTime dt = d3;
			System.Diagnostics.Process[] procs = d4;
			
			// Valid.
			ec.exampleMethod2("a string");
			
			// The following statement does not cause a compiler error, even though ec is not
			// dynamic. A run-time exception is raised because the run-time type of d1 is int.
			ec.exampleMethod2(d1);
			
			// The following statement does cause a compiler error.
			// Uncomment the line to see the error.
			// ec.exampleMethod2(7);
		}
		
	}
	
	class ExampleClass
	{
	    public ExampleClass() { }
	    public ExampleClass(int v) { }
	
	    public void exampleMethod1(int i) { }
	
	    public void exampleMethod2(string str) { }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/how-to-use-named-and-optional-arguments-in-office-programming
namespace DotnetCSharpAdvancedTopicsInteropHowToUseNamedAndOptionalArgumentsInOfficeProgramming
{
	public class OptionalArgumentsInOfficeProgramming
	{
		public static void RunOptionalArgumentsInOfficeProgramming()
		{
			
		}
		
		static void DisplayInWord()
		{
			/*
		    var wordApp = new Word.Application();
		    // Keep Word invisible during operations to avoid COM threading issues
		    wordApp.Visible = false;
		    // docs is a collection of all the Document objects currently
		    // open in Word.
		    Word.Documents docs = wordApp.Documents;
		
		    // Add a document to the collection and name it doc.
		    Word.Document doc = docs.Add();
		    
		    // Make Word visible after operations are complete
		    wordApp.Visible = true;
			
			// Define a range, a contiguous area in the document, by specifying
			// a starting and ending character position. Currently, the document
			// is empty.
			Word.Range range = doc.Range(0, 0);
			
			// Use the InsertAfter method to insert a string at the end of the
			// current range.
			range.InsertAfter("Testing, testing, testing. . .");
			
			// Convert to a simple table. The table will have a single row with
			// three columns.
			range.ConvertToTable(Separator: ",");
			
			range.ConvertToTable(Separator: ",", AutoFit: true, NumColumns: 1);
			
			range.ConvertToTable(Separator: ",", AutoFit: true, NumColumns: 1,
    			Format: Word.WdTableFormat.wdTableFormatElegant);
			*/
		}
	}
	
	/*
	namespace OfficeHowTo
	{
	    class WordProgram
	    {
	        static void Main(string[] args)
	        {
	            DisplayInWord();
	        }
	
	        static void DisplayInWord()
	        {
	            var wordApp = new Word.Application();
	            // Keep Word invisible during operations to avoid COM threading issues
	            wordApp.Visible = false;
	            // docs is a collection of all the Document objects currently
	            // open in Word.
	            Word.Documents docs = wordApp.Documents;
	
	            // Add a document to the collection and name it doc.
	            Word.Document doc = docs.Add();
	
	            // Define a range, a contiguous area in the document, by specifying
	            // a starting and ending character position. Currently, the document
	            // is empty.
	            Word.Range range = doc.Range(0, 0);
	
	            // Use the InsertAfter method to insert a string at the end of the
	            // current range.
	            range.InsertAfter("Testing, testing, testing. . .");
	
	            // You can comment out any or all of the following statements to
	            // see the effect of each one in the Word document.
	
	            // Next, use the ConvertToTable method to put the text into a table.
	            // The method has 16 optional parameters. You only have to specify
	            // values for those you want to change.
	
	            // Convert to a simple table. The table will have a single row with
	            // three columns.
	            range.ConvertToTable(Separator: ",");
	
	            // Change to a single column with three rows..
	            range.ConvertToTable(Separator: ",", AutoFit: true, NumColumns: 1);
	
	            // Format the table.
	            range.ConvertToTable(Separator: ",", AutoFit: true, NumColumns: 1,
	                Format: Word.WdTableFormat.wdTableFormatElegant);
	
	            // Make Word visible after all operations are complete
	            wordApp.Visible = true;
	        }
	    }
	}
	*/
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/how-to-access-office-interop-objects
namespace DotnetCSharpAdvancedTopicsInteropHowToAccessOfficeInteropObjects
{
	public class OfficeInteropObjects
	{
		public static void RunOfficeInteropObjects()
		{
			// Create a list of accounts.
			var bankAccounts = new List<Account> {
			    new Account {
			                  ID = 345678,
			                  Balance = 541.27
			                },
			    new Account {
			                  ID = 1230221,
			                  Balance = -127.44
			                }
			};
			
			/*
			// Establish column headings in cells A1 and B1.
			workSheet.Cells[1, "A"] = "ID Number";
			workSheet.Cells[1, "B"] = "Current Balance";
			
			var row = 1;
			foreach (var acct in accounts)
			{
			    row++;
			    workSheet.Cells[row, "A"] = acct.ID;
			    workSheet.Cells[row, "B"] = acct.Balance;
			}
			
			workSheet.Columns[1].AutoFit();
			workSheet.Columns[2].AutoFit();
			
			((Excel.Range)workSheet.Columns[1]).AutoFit();
			((Excel.Range)workSheet.Columns[2]).AutoFit();
			
			// Display the list in an Excel spreadsheet.
			DisplayInExcel(bankAccounts);
			
			// Create a Word document that contains an icon that links to
			// the spreadsheet.
			CreateIconInWordDoc();
			
			// Put the spreadsheet contents on the clipboard. The Copy method has one
			// optional parameter for specifying a destination. Because no argument
			// is sent, the destination is the Clipboard.
			workSheet.Range["A1:B3"].Copy();
			
			((Excel.Range)workSheet.Columns[1]).AutoFit();
			((Excel.Range)workSheet.Columns[2]).AutoFit();
			
			// Call to AutoFormat in Visual C# 2010.
			workSheet.Range["A1", "B3"].AutoFormat(
			    Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
				
			// Call to AutoFormat in Visual C# 2010.
			workSheet.Range["A1", "B3"].AutoFormat(Format:
			    Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
				
			*/
			
		}
		
		/*
		static void DisplayInExcel(IEnumerable<Account> accounts)
		{
		    var excelApp = new Excel.Application();
		    // Make the object visible.
		    excelApp.Visible = true;
		
		    // Create a new, empty workbook and add it to the collection returned
		    // by property Workbooks. The new workbook becomes the active workbook.
		    // Add has an optional parameter for specifying a particular template.
		    // Because no argument is sent in this example, Add creates a new workbook.
		    excelApp.Workbooks.Add();
		
		    // This example uses a single workSheet. The explicit type casting is
		    // removed in a later procedure.
		    Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
		}
		*/
		
		/*
		static void CreateIconInWordDoc()
		{
		    var wordApp = new Word.Application();
		    wordApp.Visible = true;
		
		    // The Add method has four reference parameters, all of which are
		    // optional. Visual C# allows you to omit arguments for them if
		    // the default values are what you want.
		    wordApp.Documents.Add();
		
		    // PasteSpecial has seven reference parameters, all of which are
		    // optional. This example uses named arguments to specify values
		    // for two of the parameters. Although these are reference
		    // parameters, you do not need to use the ref keyword, or to create
		    // variables to send in as arguments. You can send the values directly.
		    wordApp.Selection.PasteSpecial( Link: true, DisplayAsIcon: true);
		}
		*/
	}
	
	public class Account
	{
	    public int ID { get; set; }
	    public double Balance { get; set; }
	}
	
	/*
	namespace OfficeProgrammingWalkthruComplete
	{
	    class Walkthrough
	    {
	        static void Main(string[] args)
	        {
	            // Create a list of accounts.
	            var bankAccounts = new List<Account>
	            {
	                new Account {
	                              ID = 345678,
	                              Balance = 541.27
	                            },
	                new Account {
	                              ID = 1230221,
	                              Balance = -127.44
	                            }
	            };
	
	            // Display the list in an Excel spreadsheet.
	            DisplayInExcel(bankAccounts);
	
	            // Create a Word document that contains an icon that links to
	            // the spreadsheet.
	            CreateIconInWordDoc();
	        }
	
	        static void DisplayInExcel(IEnumerable<Account> accounts)
	        {
	            var excelApp = new Excel.Application();
	            // Make the object visible.
	            excelApp.Visible = true;
	
	            // Create a new, empty workbook and add it to the collection returned
	            // by property Workbooks. The new workbook becomes the active workbook.
	            // Add has an optional parameter for specifying a particular template.
	            // Because no argument is sent in this example, Add creates a new workbook.
	            excelApp.Workbooks.Add();
	
	            // This example uses a single workSheet.
	            Excel._Worksheet workSheet = excelApp.ActiveSheet;
	
	            // Earlier versions of C# require explicit casting.
	            //Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
	
	            // Establish column headings in cells A1 and B1.
	            workSheet.Cells[1, "A"] = "ID Number";
	            workSheet.Cells[1, "B"] = "Current Balance";
	
	            var row = 1;
	            foreach (var acct in accounts)
	            {
	                row++;
	                workSheet.Cells[row, "A"] = acct.ID;
	                workSheet.Cells[row, "B"] = acct.Balance;
	            }
	
	            workSheet.Columns[1].AutoFit();
	            workSheet.Columns[2].AutoFit();
	
	            // Call to AutoFormat in Visual C#. This statement replaces the
	            // two calls to AutoFit.
	            workSheet.Range["A1", "B3"].AutoFormat(
	                Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
	
	            // Put the spreadsheet contents on the clipboard. The Copy method has one
	            // optional parameter for specifying a destination. Because no argument
	            // is sent, the destination is the Clipboard.
	            workSheet.Range["A1:B3"].Copy();
	        }
	
	        static void CreateIconInWordDoc()
	        {
	            var wordApp = new Word.Application();
	            wordApp.Visible = true;
	
	            // The Add method has four reference parameters, all of which are
	            // optional. Visual C# allows you to omit arguments for them if
	            // the default values are what you want.
	            wordApp.Documents.Add();
	
	            // PasteSpecial has seven reference parameters, all of which are
	            // optional. This example uses named arguments to specify values
	            // for two of the parameters. Although these are reference
	            // parameters, you do not need to use the ref keyword, or to create
	            // variables to send in as arguments. You can send the values directly.
	            wordApp.Selection.PasteSpecial(Link: true, DisplayAsIcon: true);
	        }
	    }
	
	    public class Account
	    {
	        public int ID { get; set; }
	        public double Balance { get; set; }
	    }
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/how-to-use-indexed-properties-in-com-interop-programming
namespace DotnetCSharpAdvancedTopicsInteropHowToUseIndexedPropertiesInComInteropProgramming
{
	public class IndexedPropertiesInComInteropProgramming
	{
		public static void RunIndexedPropertiesInComInteropProgramming()
		{
			/*
			// Visual C# 2008 and earlier.
			var excelApp = new Excel.Application();
			// . . .
			Excel.Range targetRange = excelApp.get_Range("A1", Type.Missing);
			
			// Visual C# 2010.
			var excelApp = new Excel.Application();
			// . . .
			Excel.Range targetRange = excelApp.Range["A1"];
			
			// Visual C# 2010.
			targetRange.Value = "Name";
			
			// You must add a reference to Microsoft.Office.Interop.Excel to run
			// this example.
			using System;
			using Excel = Microsoft.Office.Interop.Excel;
			*/
		}
	}
	
	/*
	namespace IndexedProperties
	{
	    class Program
	    {
	        static void RunMain(string[] args)
	        {
	            CSharp2010();
	        }
	
	        static void CSharp2010()
	        {
	            var excelApp = new Excel.Application();
	            excelApp.Workbooks.Add();
	            excelApp.Visible = true;
	
	            Excel.Range targetRange = excelApp.Range["A1"];
	            targetRange.Value = "Name";
	        }
	
	        static void CSharp2008()
	        {
	            var excelApp = new Excel.Application();
	            excelApp.Workbooks.Add(Type.Missing);
	            excelApp.Visible = true;
	
	            Excel.Range targetRange = excelApp.get_Range("A1", Type.Missing);
	            targetRange.set_Value(Type.Missing, "Name");
	            // Or
	            //targetRange.Value2 = "Name";
	        }
	    }
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/how-to-use-platform-invoke-to-play-a-wave-file
namespace DotnetCSharpAdvancedTopicsInteropHowToUsePlatformInvokeToPlayAWaveFile
{
	public class PlatformInvokeToPlayAWaveFile
	{
		public static void RunPlatformInvokeToPlayAWaveFile()
		{
			/*
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			//
			// button1
			//
			this.button1.Location = new System.Drawing.Point(192, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Browse";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			//
			// textBox1
			//
			this.textBox1.Location = new System.Drawing.Point(8, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(168, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "File path";
			//
			// Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Platform Invoke WinSound C#";
			this.ResumeLayout(false);
			this.PerformLayout();
			*/
			
		}
	}
	
	/*
	public partial class Form1 : Form
	{
	    private TextBox textBox1;
	    private Button button1;
	
	    public Form1()  // Constructor.
	    {
	        InitializeComponent();
	    }
	
	    [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
	    private static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);
	
	    [System.Flags]
	    public enum PlaySoundFlags : int
	    {
	        SND_SYNC = 0x0000,
	        SND_ASYNC = 0x0001,
	        SND_NODEFAULT = 0x0002,
	        SND_LOOP = 0x0008,
	        SND_NOSTOP = 0x0010,
	        SND_NOWAIT = 0x00002000,
	        SND_FILENAME = 0x00020000,
	        SND_RESOURCE = 0x00040004
	    }
	
	    private void button1_Click(object sender, System.EventArgs e)
	    {
	        var dialog1 = new OpenFileDialog();
	
	        dialog1.Title = "Browse to find sound file to play";
	        dialog1.InitialDirectory = @"c:\";
	        //<Snippet5>
	        dialog1.Filter = "Wav Files (*.wav)|*.wav";
	        //</Snippet5>
	        dialog1.FilterIndex = 2;
	        dialog1.RestoreDirectory = true;
	
	        if (dialog1.ShowDialog() == DialogResult.OK)
	        {
	            textBox1.Text = dialog1.FileName;
	            PlaySound(dialog1.FileName, new System.IntPtr(), PlaySoundFlags.SND_SYNC);
	        }
	    }
	
	    private void Form1_Load(object sender, EventArgs e)
	    {
	        // Including this empty method in the sample because in the IDE,
	        // when users click on the form, generates code that looks for a default method
	        // with this name. We add it here to prevent confusion for those using the samples.
	    }
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/walkthrough-office-programming
namespace DotnetCSharpAdvancedTopicsInteropWalkthroughOfficeProgramming
{
	public class InteropWalkthroughOfficeProgramming
	{
		public static void RunInteropWalkthroughOfficeProgramming()
		{
			var bankAccounts = new List<Account>
			{
			    new Account
			    {
			        ID = 345,
			        Balance = 541.27
			    },
			    new Account
			    {
			        ID = 123,
			        Balance = -127.44
			    }
			};
			
			// Visual C# 2010 provides indexed properties for COM programming.
			//excelApp.Range["A1"].Value = "ID";
			//excelApp.ActiveCell.Offset[1, 0].Select();
			
			//excelApp.Columns[1].AutoFit();
			//excelApp.Columns[2].AutoFit();
			
			/*
			DisplayInExcel(bankAccounts, (account, cell) =>
			// This multiline lambda expression sets custom processing rules
			// for the bankAccounts.
			{
			    cell.Value = account.ID;
			    cell.Offset[0, 1].Value = account.Balance;
			    if (account.Balance < 0)
			    {
			        cell.Interior.Color = 255;
			        cell.Offset[0, 1].Interior.Color = 255;
			    }
			});
			*/
			
			/*
			var wordApp = new Word.Application();
			wordApp.Visible = true;
			wordApp.Documents.Add();
			wordApp.Selection.PasteSpecial(Link: true, DisplayAsIcon: true);
			*/
			
		}
		
		/*
		void DisplayInExcel(IEnumerable<Account> accounts,
		           Action<Account, Excel.Range> DisplayFunc)
		{
		    var excelApp = this.Application;
		    // Add a new Excel workbook.
		    excelApp.Workbooks.Add();
		    excelApp.Visible = true;
		    excelApp.Range["A1"].Value = "ID";
		    excelApp.Range["B1"].Value = "Balance";
		    excelApp.Range["A2"].Select();
		
		    foreach (var ac in accounts)
		    {
		        DisplayFunc(ac, excelApp.ActiveCell);
		        excelApp.ActiveCell.Offset[1, 0].Select();
		    }
		    // Copy the results to the Clipboard.
		    excelApp.Range["A1:B3"].Copy();
		}
		*/
		
		/*
		void DisplayInExcel(IEnumerable<Account> accounts,
		           Action<Account, Excel.Range> DisplayFunc)
		{
		    var excelApp = this.Application;
		    // Add a new Excel workbook.
		    excelApp.Workbooks.Add();
		    excelApp.Visible = true;
		    excelApp.Range["A1"].Value = "ID";
		    excelApp.Range["B1"].Value = "Balance";
		    excelApp.Range["A2"].Select();
		
		    foreach (var ac in accounts)
		    {
		        DisplayFunc(ac, excelApp.ActiveCell);
		        excelApp.ActiveCell.Offset[1, 0].Select();
		    }
		    // Copy the results to the Clipboard.
		    excelApp.Range["A1:B3"].Copy();
		}
		*/
	}
	
	class Account
	{
	    public int ID { get; set; }
	    public double Balance { get; set; }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/example-com-class
namespace DotnetCSharpAdvancedTopicsInteropExampleComClass
{
	public class InteropExampleComClass
	{
		public static void RunInteropExampleComClass()
		{
			
		}
	}
	
	namespace project_name
	{
	    [Guid("EAA4976A-45C3-4BC5-BC0B-E474F4C3C83F")]
	    public interface ComClass1Interface
	    {
	    }
	
	    [Guid("7BD20046-DF8C-44A6-8F6B-687FAA26FA71"),
	        InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	    public interface ComClass1Events
	    {
	    }
	
	    [Guid("0D53A3E8-E51A-49C7-944E-E72A2064F938"),
	        ClassInterface(ClassInterfaceType.None),
	        ComSourceInterfaces(typeof(ComClass1Events))]
	    public class ComClass1 : ComClass1Interface
	    {
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/
namespace DotnetCSharpAdvancedTopicsInterop
{
	public class AdvancedTopicsInterop
	{
		public static void RunAdvancedTopicsInterop()
		{
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-linq-expressions-binaryexpression
namespace DotnetFundamentalsRuntimeLibrariesSystemLinqExpressionsBinaryExpression
{
	public class LinqExpressionsBinaryExpression
	{
		public static void RunLinqExpressionsBinaryExpression()
		{
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-linq-expressions-expression-add
namespace DotnetFundamentalsRuntimeLibrariesSystemLinqExpressionsExpressionAdd
{
	public class LinqExpressionsExpressionAdd
	{
		public static void RunLinqExpressionsExpressionAdd()
		{
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/debugview-syntax
namespace DotnetCSharpAdvancedTopicsExpressionTreesDebugviewSyntax
{
	public class ExpressionTreesDebugviewSyntax
	{
		public static void RunExpressionTreesDebugviewSyntax()
		{
			//ParameterExpression numParam =  Expression.Parameter(typeof(int), "num");
			/*
			    $num
			*/
			
			ParameterExpression numParam =  Expression.Parameter(typeof(int));
			/*
			    $var1
			*/
			
			//int num = 10;
			//ConstantExpression expr = Expression.Constant(num);
			/*
			    10
			*/
			
			double num = 10;
			ConstantExpression expr = Expression.Constant(num);
			/*
			    10D
			*/
			
			//BlockExpression block = Expression.Block(Expression.Constant("test"));
			/*
			    .Block() {
			        "test"
			    }
			*/
			
			//BlockExpression block =  Expression.Block(typeof(Object), Expression.Constant("test"));
			/*
			    .Block<System.Object>() {
			        "test"
			    }
			*/
			
			//LambdaExpression lambda =  Expression.Lambda<Func<int>>(Expression.Constant(1));
			/*
			    .Lambda #Lambda1<System.Func'1[System.Int32]>() {
			        1
			    }
			*/
			
			LambdaExpression lambda =  Expression.Lambda<Func<int>>(Expression.Constant(1), "SampleLambda", null);
			/*
			    .Lambda #SampleLambda<System.Func'1[System.Int32]>() {
			        1
			    }
			*/
			
			/*
			LabelTarget target = Expression.Label(typeof(int), "SampleLabel");
			BlockExpression block = Expression.Block(
			    Expression.Goto(target, Expression.Constant(0)),
			    Expression.Label(target, Expression.Constant(-1))
			);
			*/
			/*
			    .Block() {
			        .Goto SampleLabel { 0 };
			        .Label
			            -1
			        .LabelTarget SampleLabel:
			    }
			*/
			
			LabelTarget target = Expression.Label();
			BlockExpression block = Expression.Block(
			    Expression.Goto(target),
			    Expression.Label(target)
			);
			/*
			    .Block() {
			        .Goto #Label1 { };
			        .Label
			        .LabelTarget #Label1:
			    }
			*/
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/debugging-expression-trees-in-visual-studio
namespace DotnetCSharpAdvancedTopicsExpressionTreesDebuggingExpressionTreesInVisualStudio
{
	public class DebuggingExpressionTreesInVisualStudio
	{
		public static void RunDebuggingExpressionTreesInVisualStudio()
		{
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/expression-trees-translating
namespace DotnetCSharpAdvancedTopicsExpressionTreesExpressionTreesTranslating
{
	public class ExpressionTreesTranslating
	{
		public static void RunExpressionTreesTranslating()
		{
			/*
			var one = Expression.Constant(1, typeof(int));
			var two = Expression.Constant(2, typeof(int));
			var addition = Expression.Add(one, two);
			var sum = ReplaceNodes(addition);
			var executableFunc = Expression.Lambda(sum);
			
			var func = (Func<int>)executableFunc.Compile();
			var answer = func();
			Console.WriteLine(answer);
			*/
			
			var one = Expression.Constant(1, typeof(int));
			var two = Expression.Constant(2, typeof(int));
			var three = Expression.Constant(3, typeof(int));
			var four = Expression.Constant(4, typeof(int));
			var addition = Expression.Add(one, two);
			var add2 = Expression.Add(three, four);
			var sum = Expression.Add(addition, add2);
			
			// Declare the delegate, so you can call it
			// from itself recursively:
			Func<Expression, int> aggregate = null!;
			// Aggregate, return constants, or the sum of the left and right operand.
			// Major simplification: Assume every binary expression is an addition.
			aggregate = (exp) =>
			    exp.NodeType == ExpressionType.Constant ?
			    (int)((ConstantExpression)exp).Value :
			    aggregate(((BinaryExpression)exp).Left) + aggregate(((BinaryExpression)exp).Right);
			
			var theSum = aggregate(sum);
			Console.WriteLine(theSum);
			
			Expression<Func<int>> sum1 = () => 1 + (2 + (3 + 4));
			
			Expression<Func<string, bool>> expr = name => name.Length > 10 && name.StartsWith("G");
			Console.WriteLine(expr);
			
			AndAlsoModifier treeModifier = new AndAlsoModifier();
			Expression modifiedExpr = treeModifier.Modify((Expression)expr);
			
			Console.WriteLine(modifiedExpr);
			
			/*  This code produces the following output:
			
			    name => ((name.Length > 10) && name.StartsWith("G"))
			    name => ((name.Length > 10) || name.StartsWith("G"))
			*/
			
		}
		
		private static Expression ReplaceNodes(Expression original)
		{
		    if (original.NodeType == ExpressionType.Constant)
		    {
		        return Expression.Multiply(original, Expression.Constant(10));
		    }
		    else if (original.NodeType == ExpressionType.Add)
		    {
		        var binaryExpression = (BinaryExpression)original;
		        return Expression.Add(
		            ReplaceNodes(binaryExpression.Left),
		            ReplaceNodes(binaryExpression.Right));
		    }
		    return original;
		}
		
		private static int Aggregate(Expression exp)
		{
		    if (exp.NodeType == ExpressionType.Constant)
		    {
		        var constantExp = (ConstantExpression)exp;
		        Console.Error.WriteLine($"Found Constant: {constantExp.Value}");
		        if (constantExp.Value is int value)
		        {
		            return value;
		        }
		        else
		        {
		            return 0;
		        }
		    }
		    else if (exp.NodeType == ExpressionType.Add)
		    {
		        var addExp = (BinaryExpression)exp;
		        Console.Error.WriteLine("Found Addition Expression");
		        Console.Error.WriteLine("Computing Left node");
		        var leftOperand = Aggregate(addExp.Left);
		        Console.Error.WriteLine($"Left is: {leftOperand}");
		        Console.Error.WriteLine("Computing Right node");
		        var rightOperand = Aggregate(addExp.Right);
		        Console.Error.WriteLine($"Right is: {rightOperand}");
		        var sum = leftOperand + rightOperand;
		        Console.Error.WriteLine($"Computed sum: {sum}");
		        return sum;
		    }
		    else throw new NotSupportedException("Haven't written this yet");
		}
	}
	
	public class AndAlsoModifier : ExpressionVisitor
	{
	    public Expression Modify(Expression expression)
	    {
	        return Visit(expression);
	    }
	
	    protected override Expression VisitBinary(BinaryExpression b)
	    {
	        if (b.NodeType == ExpressionType.AndAlso)
	        {
	            Expression left = this.Visit(b.Left);
	            Expression right = this.Visit(b.Right);
	
	            // Make this binary expression an OrElse operation instead of an AndAlso operation.
	            return Expression.MakeBinary(ExpressionType.OrElse, left, right, b.IsLiftedToNull, b.Method);
	        }
	
	        return base.VisitBinary(b);
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/expression-trees-building
namespace DotnetCSharpAdvancedTopicsExpressionTreesExpressionTreesBuilding
{
	public class ExpressionTreesBuilding
	{
		public static void RunExpressionTreesBuilding()
		{
			Expression<Func<int>> sum = () => 1 + 2;
			
			var one = Expression.Constant(1, typeof(int));
			var two = Expression.Constant(2, typeof(int));
			
			var addition = Expression.Add(one, two);
			
			var lambda = Expression.Lambda(addition);
			
			var lambda2 = Expression.Lambda(
			    Expression.Add(
			        Expression.Constant(1, typeof(int)),
			        Expression.Constant(2, typeof(int))
			    )
			);
			
			Expression<Func<double, double, double>> distanceCalc =
    			(x, y) => Math.Sqrt(x * x + y * y);
				
			var xParameter = Expression.Parameter(typeof(double), "x");
			var yParameter = Expression.Parameter(typeof(double), "y");
			
			var xSquared = Expression.Multiply(xParameter, xParameter);
			var ySquared = Expression.Multiply(yParameter, yParameter);
			var sum2 = Expression.Add(xSquared, ySquared);
			
			var sqrtMethod = typeof(Math).GetMethod("Sqrt", new[] { typeof(double) }) ?? throw new InvalidOperationException("Math.Sqrt not found!");
			var distance = Expression.Call(sqrtMethod, sum2);
			
			var distanceLambda = Expression.Lambda(
			    distance,
			    xParameter,
			    yParameter);
				
			Func<int, int> factorialFunc = (n) =>
			{
			    var res = 1;
			    while (n > 1)
			    {
			        res = res * n;
			        n--;
			    }
			    return res;
			};
			
			var nArgument = Expression.Parameter(typeof(int), "n");
			var result = Expression.Variable(typeof(int), "result");
			
			// Creating a label that represents the return value
			LabelTarget label = Expression.Label(typeof(int));
			
			var initializeResult = Expression.Assign(result, Expression.Constant(1));
			
			// This is the inner block that performs the multiplication,
			// and decrements the value of 'n'
			var block = Expression.Block(
			    Expression.Assign(result,
			        Expression.Multiply(result, nArgument)),
			    Expression.PostDecrementAssign(nArgument)
			);
			
			// Creating a method body.
			BlockExpression body = Expression.Block(
			    new[] { result },
			    initializeResult,
			    Expression.Loop(
			        Expression.IfThenElse(
			            Expression.GreaterThan(nArgument, Expression.Constant(1)),
			            block,
			            Expression.Break(label, result)
			        ),
			        label
			    )
			);
			
			// Manually build the expression tree for
			// the lambda expression num => num < 5.
			ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
			ConstantExpression five = Expression.Constant(5, typeof(int));
			BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);
			Expression<Func<int, bool>> lambda1 =
			    Expression.Lambda<Func<int, bool>>(
			        numLessThanFive,
			        new ParameterExpression[] { numParam });
					
			// Creating a parameter expression.
			ParameterExpression value = Expression.Parameter(typeof(int), "value");
			
			// Creating an expression to hold a local variable.
			ParameterExpression result2 = Expression.Parameter(typeof(int), "result");
			
			// Creating a label to jump to from a loop.
			LabelTarget label2 = Expression.Label(typeof(int));
			
			// Creating a method body.
			BlockExpression block2 = Expression.Block(
			    // Adding a local variable.
			    new[] { result },
			    // Assigning a constant to a local variable: result = 1
			    Expression.Assign(result2, Expression.Constant(1)),
			        // Adding a loop.
			        Expression.Loop(
			           // Adding a conditional block into the loop.
			           Expression.IfThenElse(
			               // Condition: value > 1
			               Expression.GreaterThan(value, Expression.Constant(1)),
			               // If true: result *= value --
			               Expression.MultiplyAssign(result2,
			                   Expression.PostDecrementAssign(value)),
			               // If false, exit the loop and go to the label.
			               Expression.Break(label2, result2)
			           ),
			       // Label to jump to.
			       label2
			    )
			);
			
			// Compile and execute an expression tree.
			int factorial = Expression.Lambda<Func<int, int>>(block2, value).Compile()(5);
			
			Console.WriteLine(factorial);
			// Prints 120.
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/expression-trees-interpreting
namespace DotnetCSharpAdvancedTopicsExpressionTreesExpressionTreesInterpreting
{
	public class ExpressionTreesInterpreting
	{
		public static void RunExpressionTreesInterpreting()
		{
			// Add the following using directive to your code file:
			// using System.Linq.Expressions;
			
			// Create an expression tree.
			Expression<Func<int, bool>> exprTree = num => num < 5;
			
			// Decompose the expression tree.
			ParameterExpression param = (ParameterExpression)exprTree.Parameters[0];
			BinaryExpression operation = (BinaryExpression)exprTree.Body;
			ParameterExpression left = (ParameterExpression)operation.Left;
			ConstantExpression right = (ConstantExpression)operation.Right;
			
			Console.WriteLine($"Decomposed expression: {param.Name} => {left.Name} {operation.NodeType} {right.Value}");
			
			// This code produces the following output:
			
			// Decomposed expression: num => num LessThan 5
			
			var constant = Expression.Constant(24, typeof(int));

			Console.WriteLine($"This is a/an {constant.NodeType} expression type");
			Console.WriteLine($"The type of the constant value is {constant.Type}");
			Console.WriteLine($"The value of the constant value is {constant.Value}");
			
			Expression<Func<int>> sum = () => 1 + 2;
			
			Expression<Func<int, int, int>> addition = (a, b) => a + b;

			Console.WriteLine($"This expression is a {addition.NodeType} expression type");
			Console.WriteLine($"The name of the lambda is {((addition.Name == null) ? "<null>" : addition.Name)}");
			Console.WriteLine($"The return type is {addition.ReturnType.ToString()}");
			Console.WriteLine($"The expression has {addition.Parameters.Count} arguments. They are:");
			foreach (var argumentExpression in addition.Parameters)
			{
			    Console.WriteLine($"\tParameter Type: {argumentExpression.Type.ToString()}, Name: {argumentExpression.Name}");
			}
			
			var additionBody = (BinaryExpression)addition.Body;
			Console.WriteLine($"The body is a {additionBody.NodeType} expression");
			Console.WriteLine($"The left side is a {additionBody.Left.NodeType} expression");
			var left2 = (ParameterExpression)additionBody.Left;
			Console.WriteLine($"\tParameter Type: {left.Type.ToString()}, Name: {left2.Name}");
			Console.WriteLine($"The right side is a {additionBody.Right.NodeType} expression");
			var right2 = (ParameterExpression)additionBody.Right;
			Console.WriteLine($"\tParameter Type: {right2.Type.ToString()}, Name: {right2.Name}");
			
			Expression<Func<int>> sum6 = () => 1 + 2 + 3 + 4;
			
			Expression<Func<int>> sum1 = () => 1 + (2 + (3 + 4));
			Expression<Func<int>> sum2 = () => ((1 + 2) + 3) + 4;
			
			Expression<Func<int>> sum3 = () => (1 + 2) + (3 + 4);
			Expression<Func<int>> sum4 = () => 1 + ((2 + 3) + 4);
			Expression<Func<int>> sum5 = () => (1 + (2 + 3)) + 4;
			
			Expression<Func<int, int>> sum7 = (a) => 1 + a + 3 + 4;
			
			Expression<Func<int, int, int>> sum8 = (a, b) => (1 + a) + (3 + b);
			
			Expression<Func<int, int>> factorial = (n) =>
			    n == 0 ?
			    1 :
			    Enumerable.Range(1, n).Aggregate((product, factor) => product * factor);
				
			
			
		}
		
		public static Visitor CreateFromExpression(Expression node) =>
		    node.NodeType switch
		    {
		        ExpressionType.Constant    => new ConstantVisitor((ConstantExpression)node),
		        ExpressionType.Lambda      => new LambdaVisitor((LambdaExpression)node),
		        ExpressionType.Parameter   => new ParameterVisitor((ParameterExpression)node),
		        ExpressionType.Add         => new BinaryVisitor((BinaryExpression)node),
		        ExpressionType.Equal       => new BinaryVisitor((BinaryExpression)node),
		        ExpressionType.Multiply    => new BinaryVisitor((BinaryExpression)node),
		        ExpressionType.Conditional => new ConditionalVisitor((ConditionalExpression)node),
		        ExpressionType.Call        => new MethodCallVisitor((MethodCallExpression)node),
		        _ => throw new NotImplementedException($"Node not processed yet: {node.NodeType}"),
		    };
			
	}
	
	// Base Visitor class:
	public abstract class Visitor
	{
	    private readonly Expression node;
	
	    protected Visitor(Expression node) => this.node = node;
	
	    public abstract void Visit(string prefix);
	
	    public ExpressionType NodeType => node.NodeType;
	    public static Visitor CreateFromExpression(Expression node) =>
	        node.NodeType switch
	        {
	            ExpressionType.Constant => new ConstantVisitor((ConstantExpression)node),
	            ExpressionType.Lambda => new LambdaVisitor((LambdaExpression)node),
	            ExpressionType.Parameter => new ParameterVisitor((ParameterExpression)node),
	            ExpressionType.Add => new BinaryVisitor((BinaryExpression)node),
	            _ => throw new NotImplementedException($"Node not processed yet: {node.NodeType}"),
	        };
	}
	
	// Lambda Visitor
	public class LambdaVisitor : Visitor
	{
	    private readonly LambdaExpression node;
	    public LambdaVisitor(LambdaExpression node) : base(node) => this.node = node;
	
	    public override void Visit(string prefix)
	    {
	        Console.WriteLine($"{prefix}This expression is a {NodeType} expression type");
	        Console.WriteLine($"{prefix}The name of the lambda is {((node.Name == null) ? "<null>" : node.Name)}");
	        Console.WriteLine($"{prefix}The return type is {node.ReturnType}");
	        Console.WriteLine($"{prefix}The expression has {node.Parameters.Count} argument(s). They are:");
	        // Visit each parameter:
	        foreach (var argumentExpression in node.Parameters)
	        {
	            var argumentVisitor = CreateFromExpression(argumentExpression);
	            argumentVisitor.Visit(prefix + "\t");
	        }
	        Console.WriteLine($"{prefix}The expression body is:");
	        // Visit the body:
	        var bodyVisitor = CreateFromExpression(node.Body);
	        bodyVisitor.Visit(prefix + "\t");
	    }
	}
	
	// Binary Expression Visitor:
	public class BinaryVisitor : Visitor
	{
	    private readonly BinaryExpression node;
	    public BinaryVisitor(BinaryExpression node) : base(node) => this.node = node;
	
	    public override void Visit(string prefix)
	    {
	        Console.WriteLine($"{prefix}This binary expression is a {NodeType} expression");
	        var left = CreateFromExpression(node.Left);
	        Console.WriteLine($"{prefix}The Left argument is:");
	        left.Visit(prefix + "\t");
	        var right = CreateFromExpression(node.Right);
	        Console.WriteLine($"{prefix}The Right argument is:");
	        right.Visit(prefix + "\t");
	    }
	}
	
	// Parameter visitor:
	public class ParameterVisitor : Visitor
	{
	    private readonly ParameterExpression node;
	    public ParameterVisitor(ParameterExpression node) : base(node)
	    {
	        this.node = node;
	    }
	
	    public override void Visit(string prefix)
	    {
	        Console.WriteLine($"{prefix}This is an {NodeType} expression type");
	        Console.WriteLine($"{prefix}Type: {node.Type}, Name: {node.Name}, ByRef: {node.IsByRef}");
	    }
	}
	
	// Constant visitor:
	public class ConstantVisitor : Visitor
	{
	    private readonly ConstantExpression node;
	    public ConstantVisitor(ConstantExpression node) : base(node) => this.node = node;
	
	    public override void Visit(string prefix)
	    {
	        Console.WriteLine($"{prefix}This is an {NodeType} expression type");
	        Console.WriteLine($"{prefix}The type of the constant value is {node.Type}");
	        Console.WriteLine($"{prefix}The value of the constant value is {node.Value}");
	    }
	}
	
	public class ConditionalVisitor : Visitor
	{
	    private readonly ConditionalExpression node;
	    public ConditionalVisitor(ConditionalExpression node) : base(node)
	    {
	        this.node = node;
	    }
	
	    public override void Visit(string prefix)
	    {
	        Console.WriteLine($"{prefix}This expression is a {NodeType} expression");
	        var testVisitor = Visitor.CreateFromExpression(node.Test);
	        Console.WriteLine($"{prefix}The Test for this expression is:");
	        testVisitor.Visit(prefix + "\t");
	        var trueVisitor = Visitor.CreateFromExpression(node.IfTrue);
	        Console.WriteLine($"{prefix}The True clause for this expression is:");
	        trueVisitor.Visit(prefix + "\t");
	        var falseVisitor = Visitor.CreateFromExpression(node.IfFalse);
	        Console.WriteLine($"{prefix}The False clause for this expression is:");
	        falseVisitor.Visit(prefix + "\t");
	    }
	}
	
	public class MethodCallVisitor : Visitor
	{
	    private readonly MethodCallExpression node;
	    public MethodCallVisitor(MethodCallExpression node) : base(node)
	    {
	        this.node = node;
	    }
	
	    public override void Visit(string prefix)
	    {
	        Console.WriteLine($"{prefix}This expression is a {NodeType} expression");
	        if (node.Object == null)
	            Console.WriteLine($"{prefix}This is a static method call");
	        else
	        {
	            Console.WriteLine($"{prefix}The receiver (this) is:");
	            var receiverVisitor = Visitor.CreateFromExpression(node.Object);
	            receiverVisitor.Visit(prefix + "\t");
	        }
	
	        var methodInfo = node.Method;
	        Console.WriteLine($"{prefix}The method name is {methodInfo.DeclaringType}.{methodInfo.Name}");
	        // There is more here, like generic arguments, and so on.
	        Console.WriteLine($"{prefix}The Arguments are:");
	        foreach (var arg in node.Arguments)
	        {
	            var argVisitor = Visitor.CreateFromExpression(arg);
	            argVisitor.Visit(prefix + "\t");
	        }
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/expression-trees-execution
namespace DotnetCSharpAdvancedTopicsExpressionTreesExpressionTreesExecution
{
	public class ExpressionTreesExecution
	{
		public static void RunExpressionTreesExecution()
		{
			Expression<Func<int>> add = () => 1 + 2;
			var func = add.Compile(); // Create Delegate
			var answer = func(); // Invoke Delegate
			Console.WriteLine(answer);
			
			Expression<Func<int, bool>> expr = num => num < 5;

			// Compiling the expression tree into a delegate.
			Func<int, bool> result = expr.Compile();
			
			// Invoking the delegate and writing the result to the console.
			Console.WriteLine(result(4));
			
			// Prints True.
			
			// You can also use simplified syntax
			// to compile and run an expression tree.
			// The following line can replace two previous statements.
			Console.WriteLine(expr.Compile()(4));
			
			// Also prints True.
			
			// The expression tree to execute.
			BinaryExpression be = Expression.Power(Expression.Constant(2d), Expression.Constant(3d));
			
			// Create a lambda expression.
			Expression<Func<double>> le = Expression.Lambda<Func<double>>(be);
			
			// Compile the lambda expression.
			Func<double> compiledExpression = le.Compile();
			
			// Execute the lambda expression.
			double result2 = compiledExpression();
			
			// Display the result.
			Console.WriteLine(result2);
			
			// This code produces the following output:
			// 8
		}
		
		private static Func<int, int> CreateBoundFunc()
		{
		    var constant = 5; // constant is captured by the expression tree
		    Expression<Func<int, int>> expression = (b) => constant + b;
		    var rVal = expression.Compile();
		    return rVal;
		}
		
		private static Func<int, int> CreateBoundResource()
		{
		    using (var constant = new Resource()) // constant is captured by the expression tree
		    {
		        Expression<Func<int, int>> expression = (b) => constant.Argument + b;
		        var rVal = expression.Compile();
		        return rVal;
		    }
		}
	}
	
	public class Resource : IDisposable
	{
	    private bool _isDisposed = false;
	    public int Argument
	    {
	        get
	        {
	            if (!_isDisposed)
	                return 5;
	            else throw new ObjectDisposedException("Resource");
	        }
	    }
	
	    public void Dispose()
	    {
	        _isDisposed = true;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/expression-classes
namespace DotnetCSharpAdvancedTopicsExpressionTreesExpressionClasses
{
	public class ExpressionTreesExpressionClasses
	{
		public static void RunExpressionTreesExpressionClasses()
		{
			Expression<Func<int, int>> addFive = (num) => num + 5;

			if (addFive is LambdaExpression lambdaExp)
			{
			    var parameter = lambdaExp.Parameters[0];  // -- first
			
			    Console.WriteLine(parameter.Name);
			    Console.WriteLine(parameter.Type);
			}
			
			// Addition is an add expression for "1 + 2"
			var one = Expression.Constant(1, typeof(int));
			var two = Expression.Constant(2, typeof(int));
			var addition = Expression.Add(one, two);
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/expression-trees-explained
namespace DotnetCSharpAdvancedTopicsExpressionTreesExpressionTreesExplained
{
	public class ExpressionTreesExpressionTreesExplained
	{
		public static void RunExpressionTreesExpressionTreesExplained()
		{
			var sum = 1 + 2;
			
			/*
			var finalAnswer = this.SecretSauceFunction(
			    currentState.createInterimResult(), currentState.createSecondValue(1, 2),
			    decisionServer.considerFinalOptions("hello")) +
			    MoreSecretSauce('A', DateTime.Now, true);
			*/
			
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/expression-trees/
namespace DotnetCSharpAdvancedTopicsExpressionTrees
{
	public class AdvancedTopicsExpressionTrees
	{
		public static void RunAdvancedTopicsExpressionTrees()
		{
			Expression<Func<int, bool>> lambda = num => num < 5;
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interface-implementation/static-virtual-interface-members
namespace DotnetCSharpAdvancedTopicsInterfaceImplementationStaticVirtualInterfaceMembers
{
	public class VirtualInterfaceMembers
	{
		public static void RunVirtualInterfaceMembers()
		{
			var str = new RepeatSequence();

			for (int i = 0; i < 10; i++)
			    Console.WriteLine(str++);
			
			/*
			var pt = new Point<int>(3, 4);

			var translate = new Translation<int>(5, 10);
			
			var final = pt + translate;
			
			Console.WriteLine(pt);
			Console.WriteLine(translate);
			Console.WriteLine(final);
			*/
			
		}
		
		public static double MidPoint(double left, double right) =>
    		(left + right) / (2.0);
			
		public static T MidPoint<T>(T left, T right)
    		where T : INumber<T> => (left + right) / T.CreateChecked(2);  // note: the addition of left and right may overflow here; it's just for demonstration purposes
			
		/*
		public static Translation<T> AdditiveIdentity =>
    		new Translation<T>(XOffset: 0, YOffset: 0);
			
		public static Translation<T> AdditiveIdentity =>
    		new Translation<T>(XOffset: T.AdditiveIdentity, YOffset: T.AdditiveIdentity);
		*/
	}
	
	public interface IGetNext<T> where T : IGetNext<T>
	{
	    static abstract T operator ++(T other);
	}
	
	public struct RepeatSequence : IGetNext<RepeatSequence>
	{
	    private const char Ch = 'A';
	    public string Text = new string(Ch, 1);
	
	    public RepeatSequence() {}
	
	    public static RepeatSequence operator ++(RepeatSequence other)
	        => other with { Text = other.Text + Ch };
	
	    public override string ToString() => Text;
	}
	
	/*
	// Note: Not complete. This won't compile yet.
	//public record Translation<T>(T XOffset, T YOffset);

	public record Point<T>(T X, T Y)
	{
	    public static Point<T> operator +(Point<T> left, Translation<T> right);
		
		public static Point<T> operator +(Point<T> left, Translation<T> right) =>
			left with { X = left.X + right.XOffset, Y = left.Y + right.YOffset };
	}

	public record Point<T>(T X, T Y) where T : IAdditionOperators<T, T, T>;
	
	public record Translation<T>(T XOffset, T YOffset) where T : IAdditionOperators<T, T, T>;
	
	
	public record Point<T>(T X, T Y) : IAdditionOperators<Point<T>, Translation<T>, Point<T>>
		where T : IAdditionOperators<T, T, T>
		
	public record Translation<T>(T XOffset, T YOffset) : IAdditiveIdentity<Translation<T>, Translation<T>>
	    where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T>
	{
	    public static Translation<T> AdditiveIdentity =>
	        new Translation<T>(XOffset: T.AdditiveIdentity, YOffset: T.AdditiveIdentity);
	}
	
	public record Translation<T>(T XOffset, T YOffset) : IAdditiveIdentity<Translation<T>, Translation<T>>
	
	public record Point<T>(T X, T Y) : IAdditionOperators<Point<T>, Translation<T>, Point<T>>
    where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T>
	{
	    public static Point<T> operator +(Point<T> left, Translation<T> right) =>
	        left with { X = left.X + right.XOffset, Y = left.Y + right.YOffset };
	}
	*/

}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interface-implementation/mixins-with-default-interface-methods
namespace DotnetCSharpAdvancedTopicsInterfaceImplementationMixinsWithDefaultInterfaceMethods
{
	public class MixinsWithDefaultInterfaceMethods
	{
		public static void RunMixinsWithDefaultInterfaceMethods()
		{
			
		}
		
		public static async Task RunMain(string[] args)
		{
		    Console.WriteLine("Testing the overhead light");
		    var overhead = new OverheadLight();
		    await TestLightCapabilities(overhead);
		    Console.WriteLine();
		
		    Console.WriteLine("Testing the halogen light");
		    var halogen = new HalogenLight();
		    await TestLightCapabilities(halogen);
		    Console.WriteLine();
		
		    Console.WriteLine("Testing the LED light");
		    var led = new LEDLight();
		    await TestLightCapabilities(led);
		    Console.WriteLine();
		
		    Console.WriteLine("Testing the fancy light");
		    var fancy = new ExtraFancyLight();
		    await TestLightCapabilities(fancy);
		    Console.WriteLine();
		}
		
		private static async Task TestLightCapabilities(ILight light)
		{
		    // Perform basic tests:
		    light.SwitchOn();
		    Console.WriteLine($"\tAfter switching on, the light is {(light.IsOn() ? "on" : "off")}");
		    light.SwitchOff();
		    Console.WriteLine($"\tAfter switching off, the light is {(light.IsOn() ? "on" : "off")}");
		
		    if (light is ITimerLight timer)
		    {
		        Console.WriteLine("\tTesting timer function");
		        await timer.TurnOnFor(1000);
		        Console.WriteLine("\tTimer function completed");
		    }
		    else
		    {
		        Console.WriteLine("\tTimer function not supported.");
		    }
		
		    if (light is IBlinkingLight blinker)
		    {
		        Console.WriteLine("\tTesting blinking function");
		        await blinker.Blink(500, 5);
		        Console.WriteLine("\tBlink function completed");
		    }
		    else
		    {
		        Console.WriteLine("\tBlink function not supported.");
		    }
		}
	}
	
	/*
	public interface ILight
	{
	    void SwitchOn();
	    void SwitchOff();
	    bool IsOn();
	}
	*/
	
	/*
	public class OverheadLight : ILight
	{
	    private bool isOn;
	    public bool IsOn() => isOn;
	    public void SwitchOff() => isOn = false;
	    public void SwitchOn() => isOn = true;
	
	    public override string ToString() => $"The light is {(isOn ? "on" : "off")}";
	}
	*/
	
	/*
	public interface ITimerLight : ILight
	{
	    Task TurnOnFor(int duration);
	}
	*/
	
	public interface ITimerLight : ILight
	{
	    public async Task TurnOnFor(int duration)
	    {
	        Console.WriteLine("Using the default interface method for the ITimerLight.TurnOnFor.");
	        SwitchOn();
	        await Task.Delay(duration);
	        SwitchOff();
	        Console.WriteLine("Completed ITimerLight.TurnOnFor sequence.");
	    }
	}
	
	//public class OverheadLight : ITimerLight { }
	
	public class HalogenLight : ITimerLight
	{
	    private enum HalogenLightState
	    {
	        Off,
	        On,
	        TimerModeOn
	    }
	
	    private HalogenLightState state;
	    public void SwitchOn() => state = HalogenLightState.On;
	    public void SwitchOff() => state = HalogenLightState.Off;
	    public bool IsOn() => state != HalogenLightState.Off;
	    public async Task TurnOnFor(int duration)
	    {
	        Console.WriteLine("Halogen light starting timer function.");
	        state = HalogenLightState.TimerModeOn;
	        await Task.Delay(duration);
	        state = HalogenLightState.Off;
	        Console.WriteLine("Halogen light finished custom timer function");
	    }
	
	    public override string ToString() => $"The light is {state}";
	}
	
	public interface IBlinkingLight : ILight
	{
	    public async Task Blink(int duration, int repeatCount)
	    {
	        Console.WriteLine("Using the default interface method for IBlinkingLight.Blink.");
	        for (int count = 0; count < repeatCount; count++)
	        {
	            SwitchOn();
	            await Task.Delay(duration);
	            SwitchOff();
	            await Task.Delay(duration);
	        }
	        Console.WriteLine("Done with the default interface method for IBlinkingLight.Blink.");
	    }
	}
	
	public class OverheadLight : ILight, ITimerLight, IBlinkingLight
	{
	    private bool isOn;
	    public bool IsOn() => isOn;
	    public void SwitchOff() => isOn = false;
	    public void SwitchOn() => isOn = true;
	
	    public override string ToString() => $"The light is {(isOn ? "on" : "off")}";
	}
	
	public class LEDLight : IBlinkingLight, ITimerLight, ILight
	{
	    private bool isOn;
	    public void SwitchOn() => isOn = true;
	    public void SwitchOff() => isOn = false;
	    public bool IsOn() => isOn;
	    public async Task Blink(int duration, int repeatCount)
	    {
	        Console.WriteLine("LED Light starting the Blink function.");
	        await Task.Delay(duration * repeatCount);
	        Console.WriteLine("LED Light has finished the Blink function.");
	    }
	
	    public override string ToString() => $"The light is {(isOn ? "on" : "off")}";
	}
	
	public class ExtraFancyLight : IBlinkingLight, ITimerLight, ILight
	{
	    private bool isOn;
	    public void SwitchOn() => isOn = true;
	    public void SwitchOff() => isOn = false;
	    public bool IsOn() => isOn;
	    public async Task Blink(int duration, int repeatCount)
	    {
	        Console.WriteLine("Extra Fancy Light starting the Blink function.");
	        await Task.Delay(duration * repeatCount);
	        Console.WriteLine("Extra Fancy Light has finished the Blink function.");
	    }
	    public async Task TurnOnFor(int duration)
	    {
	        Console.WriteLine("Extra Fancy light starting timer function.");
	        await Task.Delay(duration);
	        Console.WriteLine("Extra Fancy light finished custom timer function");
	    }
	
	    public override string ToString() => $"The light is {(isOn ? "on" : "off")}";
	}
	
	public enum PowerStatus
	{
	    NoPower,
	    ACPower,
	    FullBattery,
	    MidBattery,
	    LowBattery
	}
	
	public interface ILight
	{
	    void SwitchOn();
	    void SwitchOff();
	    bool IsOn();
	    public PowerStatus Power() => PowerStatus.NoPower;
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interface-implementation/default-interface-methods-versions
namespace DotnetCSharpAdvancedTopicsInterfaceImplementationDefaultInterfaceMethodsVersions
{
	public class DefaultInterfaceMethodsVersions
	{
		public static void RunDefaultInterfaceMethodsVersions()
		{
			/*
			SampleCustomer c = new SampleCustomer("customer one", new DateTime(2010, 5, 31))
			{
			    Reminders =
			    {
			        { new DateTime(2010, 08, 12), "childs's birthday" },
			        { new DateTime(2012, 11, 15), "anniversary" }
			    }
			};
			
			SampleOrder o = new SampleOrder(new DateTime(2012, 6, 1), 5m);
			c.AddOrder(o);
			
			o = new SampleOrder(new DateTime(2013, 7, 4), 25m);
			c.AddOrder(o);
			
			// Check the discount:
			ICustomer theCustomer = c;
			Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");
			*/
			
			/*
			ICustomer.SetLoyaltyThresholds(new TimeSpan(30, 0, 0, 0), 1, 0.25m);
			Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");
			*/
			
		}
	}
	
	public interface ICustomer
	{
	    IEnumerable<IOrder> PreviousOrders { get; }
	
	    DateTime DateJoined { get; }
	    DateTime? LastOrder { get; }
	    string Name { get; }
	    IDictionary<DateTime, string> Reminders { get; }
		
		// This method belongs in the ICustomer interface (ICustomer.cs).
		// Version 1:
		public decimal ComputeLoyaltyDiscount()
		{
		    DateTime TwoYearsAgo = DateTime.Now.AddYears(-2);
		    if ((DateJoined < TwoYearsAgo) && (PreviousOrders.Count() > 10))
		    {
		        return 0.10m;
		    }
		    return 0;
		}
		
		// These methods belong in the ICustomer interface (ICustomer.cs).
		// Version 2:
		public static void SetLoyaltyThresholds(
		    TimeSpan ago,
		    int minimumOrders = 10,
		    decimal percentageDiscount = 0.10m)
		{
		    length = ago;
		    orderCount = minimumOrders;
		    discountPercent = percentageDiscount;
		}
		private static TimeSpan length = new TimeSpan(365 * 2, 0,0,0); // two years
		private static int orderCount = 10;
		private static decimal discountPercent = 0.10m;
		
		public decimal ComputeLoyaltyDiscount2()
		{
		    DateTime start = DateTime.Now - length;
		
		    if ((DateJoined < start) && (PreviousOrders.Count() > orderCount))
		    {
		        return discountPercent;
		    }
		    return 0;
		}
		
		// These methods belong in the ICustomer interface (ICustomer.cs).
		public decimal ComputeLoyaltyDiscount3() => DefaultLoyaltyDiscount(this);
		protected static decimal DefaultLoyaltyDiscount(ICustomer c)
		{
		    DateTime start = DateTime.Now - length;
		
		    if ((c.DateJoined < start) && (c.PreviousOrders.Count() > orderCount))
		    {
		        return discountPercent;
		    }
		    return 0;
		}
	}
	
	public interface IOrder
	{
	    DateTime Purchased { get; }
	    decimal Cost { get; }
	}
	
	/*
	// This method belongs in the SampleCustomer class (SampleCustomer.cs) that implements ICustomer.
	public decimal ComputeLoyaltyDiscount()
	{
	   if (PreviousOrders.Any() == false)
	        return 0.50m;
	    else
	        return ICustomer.DefaultLoyaltyDiscount(this);
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/attribute-tutorial
namespace DotnetCSharpAdvancedTopicsReflectionAndAttributesAttributeTutorial
{
	public class ReflectionAndAttributesAttributeTutorial
	{
		public static void RunReflectionAndAttributesAttributeTutorial()
		{
			TypeInfo typeInfo = typeof(MyClass).GetTypeInfo();
			Console.WriteLine("The assembly qualified name of MyClass is " + typeInfo.AssemblyQualifiedName);
			
			var attrs = typeInfo.GetCustomAttributes();
			foreach(var attr in attrs)
			    Console.WriteLine("Attribute on MyClass: " + attr.GetType().Name);
			
		}
	}
	
	[Obsolete]
	public class MyClass
	{
	}
	
	[Obsolete("ThisClass is obsolete. Use ThisClass2 instead.")]
	public class ThisClass
	{
	}
	
	public class MySpecialAttribute : Attribute
	{
	}
	
	[MySpecial]
	public class SomeOtherClass
	{
	}
	
	public class GotchaAttribute : Attribute
	{
	    public GotchaAttribute(Foo myClass, string str)
	    {
	    }
	}
	
	/*
	[Gotcha(new Foo(), "test")] // does not compile
	public class AttributeFail
	{
	}
	*/
	
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class MyAttributeForClassAndStructOnly : Attribute
	{
	}
	
	public class Foo
	{
	    // if the below attribute was uncommented, it would cause a compiler error
	    // [MyAttributeForClassAndStructOnly]
	    public Foo()
	    { }
	}
	
	/*
	public class MyUIClass : INotifyPropertyChanged
	{
	    public event PropertyChangedEventHandler? PropertyChanged;
	
	    public void RaisePropertyChanged([CallerMemberName] string propertyName = default!)
	    {
	        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
	
	    private string? _name;
	    public string? Name
	    {
	        get { return _name;}
	        set
	        {
	            if (value != _name)
	            {
	                _name = value;
	                RaisePropertyChanged();   // notice that "Name" is not needed here explicitly
	            }
	        }
	    }
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/generics-and-reflection
namespace DotnetCSharpAdvancedTopicsReflectionAndAttributesGenericsAndReflection
{
	public class AttributesGenericsAndReflection
	{
	
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/how-to-query-assembly-metadata-with-reflection-linq
namespace DotNetCSharpAdvancedTopicsReflectionAndAttributesHowToQueryAssemblyMetadataWithReflectionLinq
{
	public class AssemblyMetadataWithReflectionLinq
	{
		public static void RunAssemblyMetadataWithReflectionLinq()
		{
			Assembly assembly = Assembly.Load("System.Private.CoreLib, Version=7.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
			var pubTypesQuery = from type in assembly.GetTypes()
			                    where type.IsPublic
			                    from method in type.GetMethods()
			                    where method.ReturnType.IsArray == true
			                        || (method.ReturnType.GetInterface(
			                            typeof(System.Collections.Generic.IEnumerable<>).FullName!) != null
			                        && method.ReturnType.FullName != "System.String")
			                    group method.ToString() by type.ToString();
			
			foreach (var groupOfMethods in pubTypesQuery)
			{
			    Console.WriteLine($"Type: {groupOfMethods.Key}");
			    foreach (var method in groupOfMethods)
			    {
			        Console.WriteLine($"  {method}");
			    }
			}
			
			Assembly assembly2 = Assembly.Load("System.Private.CoreLib, Version=7.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
			var pubTypesQuery2 = from type in assembly2.GetTypes()
			                    where type.IsPublic
			                    from method in type.GetMethods()
			                    where method.ReturnType.IsArray == true
			                        || (method.ReturnType.GetInterface(
			                            typeof(System.Collections.Generic.IEnumerable<>).FullName!) != null
			                        && method.ReturnType.FullName != "System.String")
			                    group method.ToString() by type.ToString();
			
			foreach (var groupOfMethods in pubTypesQuery2)
			{
			    Console.WriteLine($"Type: {groupOfMethods.Key}");
			    foreach (var method in groupOfMethods)
			    {
			        Console.WriteLine($"  {method}");
			    }
			}
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/generics-and-attributes
namespace DotNetCSharpAdvancedTopicsReflectionAndAttributesGenericsAndAttributes
{
	public class ReflectionAndAttributesGenericsAndAttributes
	{
		public static void RunReflectionAndAttributesGenericsAndAttributes()
		{
			
		}
	}
	
	class CustomAttribute : Attribute
	{
	    public object? info;
	}
	
	public class GenericClass1<T> { }

	[CustomAttribute(info = typeof(GenericClass1<>))]
	class ClassA { }
	
	public class GenericClass2<T, U> { }

	[CustomAttribute(info = typeof(GenericClass2<,>))]
	class ClassB { }
	
	public class GenericClass3<T, U, V> { }

	[CustomAttribute(info = typeof(GenericClass3<int, double, string>))]
	class ClassC { }
	
	/*
	[CustomAttribute(info = typeof(GenericClass3<int, T, string>))]  //Error CS0416
	class ClassD<T> { }
	*/
	
	public class CustomGenericAttribute<T> : Attribute { }
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/how-to-create-a-c-cpp-union-by-using-attributes
namespace HowToCreateACCppUnionByUsingAttributes
{
	public class UnionByUsingAttributes
	{
		public static void RunUnionByUsingAttributes()
		{
			
		}
	}
	
	/*
	[System.Runtime.InteropServices.StructLayout(LayoutKind.Explicit)]
	struct TestUnion
	{
	    [System.Runtime.InteropServices.FieldOffset(0)]
	    public int i;
	
	    [System.Runtime.InteropServices.FieldOffset(0)]
	    public double d;
	
	    [System.Runtime.InteropServices.FieldOffset(0)]
	    public char c;
	
	    [System.Runtime.InteropServices.FieldOffset(0)]
	    public byte b;
	}
	
	
	[System.Runtime.InteropServices.StructLayout(LayoutKind.Explicit)]
	struct TestExplicit
	{
	    [System.Runtime.InteropServices.FieldOffset(0)]
	    public long lg;
	
	    [System.Runtime.InteropServices.FieldOffset(0)]
	    public int i1;
	
	    [System.Runtime.InteropServices.FieldOffset(4)]
	    public int i2;
	
	    [System.Runtime.InteropServices.FieldOffset(8)]
	    public double d;
	
	    [System.Runtime.InteropServices.FieldOffset(12)]
	    public char c;
	
	    [System.Runtime.InteropServices.FieldOffset(14)]
	    public byte b;
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/accessing-attributes-by-using-reflection
namespace DotnetCSharpAdvancedTopicsReflectionAndAttributesAccessingAttributesByUsingReflection
{
	public class AccessingAttributesByUsingReflection
	{
		public static void RunAccessingAttributesByUsingReflection()
		{
			/*
			var anonymousAuthorObject = new Author("P. Ackerman")
			{
			    Version = 1.1
			};
			*/
		}
	}
	
	/*
	[Author("P. Ackerman", Version = 1.1)]
	class SampleClass { }
	*/
	
	// Multiuse attribute.
	[System.AttributeUsage(System.AttributeTargets.Class |
	                       System.AttributeTargets.Struct,
	                       AllowMultiple = true)  // Multiuse attribute.
	]
	public class AuthorAttribute : System.Attribute
	{
	    string Name;
	    public string Version;
	
	    public AuthorAttribute(string name)
	    {
	        Name = name;
	
	        // Default value.
	        Version = "1.0";
	    }
	
	    public string GetName() => Name;
	}
	
	// Class with the Author attribute.
	[Author("P. Ackerman")]
	public class FirstClass
	{
	    // ...
	}
	
	// Class without the Author attribute.
	public class SecondClass
	{
	    // ...
	}
	
	// Class with multiple Author attributes.
	[Author("P. Ackerman"), Author("R. Koch", Version = "2.0")]
	public class ThirdClass
	{
	    // ...
	}
	
	class TestAuthorAttribute
	{
	    public static void Test()
	    {
	        PrintAuthorInfo(typeof(FirstClass));
	        PrintAuthorInfo(typeof(SecondClass));
	        PrintAuthorInfo(typeof(ThirdClass));
	    }
	
	    private static void PrintAuthorInfo(System.Type t)
	    {
	        System.Console.WriteLine($"Author information for {t}");
	
	        // Using reflection.
	        System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.
	
	        // Displaying output.
	        foreach (System.Attribute attr in attrs)
	        {
	            if (attr is AuthorAttribute a)
	            {
	                System.Console.WriteLine($"   {a.GetName()}, version {a.Version}");
	            }
	        }
	    }
	}
	/* Output:
	    Author information for FirstClass
	       P. Ackerman, version 1.0
	    Author information for SecondClass
	    Author information for ThirdClass
	       R. Koch, version 2.0
	       P. Ackerman, version 1.0
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/creating-custom-attributes
namespace DotnetCSharpAdvancedTopicsReflectionAndAttributesCreatingCustomAttributes
{
	public class CreatingCustomAttributes
	{
		public static void RunCreatingCustomAttributes()
		{
			
		}
	}
	
	/*
	[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)
	]
	public class AuthorAttribute : System.Attribute
	{
	    private string Name;
	    public string Version;
	
	    public AuthorAttribute(string name)
	    {
	        Name = name;
	        Version = "1.0";
	    }
	}
	*/
	
	[Author("P. Ackerman", Version = "1.1")]
	class SampleClass
	{
	    // P. Ackerman's code goes here...
	}
	
	[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct,
                       AllowMultiple = true)  // Multiuse attribute.
	]
	public class AuthorAttribute : System.Attribute
	{
	    string Name;
	    public string Version;
	
	    public AuthorAttribute(string name)
	    {
	        Name = name;
	
	        // Default value.
	        Version = "1.0";
	    }
	
	    public string GetName() => Name;
	}
	
	[Author("P. Ackerman"), Author("R. Koch", Version = "2.0")]
	public class ThirdClass
	{
	    // ...
	}
	
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/
namespace DotnetCSharpAdvancedTopicsReflectionAndAttributes
{
	public class ReflectionAndAttributes
	{
		public static void RunReflectionAndAttributes()
		{
			// Using GetType to obtain type information:
			int i = 42;
			Type type = i.GetType();
			Console.WriteLine(type);
			
			// Using Reflection to get information of an Assembly:
			Assembly info = typeof(int).Assembly;
			Console.WriteLine(info);
		}
		
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		extern static void SampleMethod();
		
		/*
		void MethodA([In][Out] ref double x) { }
		void MethodB([Out][In] ref double x) { }
		void MethodC([In, Out] ref double x) { }
		*/
		
		[Conditional("DEBUG"), Conditional("TEST1")]
		void TraceMethod()
		{
		    // ...
		}
		
		/*
		[DllImport("user32.dll")]
		[DllImport("user32.dll", SetLastError=false, ExactSpelling=false)]
		[DllImport("user32.dll", ExactSpelling=false, SetLastError=false)]
		*/
		
		[assembly: AssemblyTitleAttribute("Production assembly 4")]
		[module: CLSCompliant(true)]
		
		/*
		// default: applies to method
		[ValidatedContract]
		int Method1() { return 0; }
		
		// applies to method
		[method: ValidatedContract]
		int Method2() { return 0; }
		
		// applies to parameter
		int Method3([ValidatedContract] string contract) { return 0; }
		
		// applies to return value
		[return: ValidatedContract]
		int Method4() { return 0; }
		*/
	}
	
	[Serializable]
	public class SampleClass
	{
	    // Objects of this type can be serialized.
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/how-to/how-to-catch-a-non-cls-exception
namespace DotnetCSharpHowToHowToCatchANonClsException
{
	public class HowToCatchANonClsException
	{
		public static void RunHowToCatchANonClsException()
		{
			/*
			// Class library written in C++/CLI.
			var myClass = new ThrowNonCLS.Class1();
			
			try
			{
			    // throws gcnew System::String(  
			    // "I do not derive from System.Exception!");  
			    myClass.TestThrow();
			}
			catch (RuntimeWrappedException e)
			{
			    String s = e.WrappedException as String;
			    if (s != null)
			    {
			        Console.WriteLine(s);
			    }
			}
			*/
			
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings
namespace DotnetCSharpHowToCompareStrings
{
	public class CompareStrings
	{
		public static void RunCompareStrings()
		{
			string root = @"C:\users";
			string root2 = @"C:\Users";
			
			bool result = root.Equals(root2);
			Console.WriteLine($"Ordinal comparison: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");
			
			result = root.Equals(root2, StringComparison.Ordinal);
			Console.WriteLine($"Ordinal comparison: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");
			
			Console.WriteLine($"Using == says that <{root}> and <{root2}> are {(root == root2 ? "equal" : "not equal")}");
			
			root = @"C:\users";
			root2 = @"C:\Users";
			
			result = root.Equals(root2, StringComparison.OrdinalIgnoreCase);
			bool areEqual = String.Equals(root, root2, StringComparison.OrdinalIgnoreCase);
			int comparison = String.Compare(root, root2, comparisonType: StringComparison.OrdinalIgnoreCase);
			
			Console.WriteLine($"Ordinal ignore case: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");
			Console.WriteLine($"Ordinal static ignore case: <{root}> and <{root2}> are {(areEqual ? "equal." : "not equal.")}");
			if (comparison < 0)
			{
			    Console.WriteLine($"<{root}> is less than <{root2}>");
			}
			else if (comparison > 0)
			{
			    Console.WriteLine($"<{root}> is greater than <{root2}>");
			}
			else
			{
			    Console.WriteLine($"<{root}> and <{root2}> are equivalent in order");
			}
			
			string first = "Sie tanzen auf der Straße.";
			string second = "Sie tanzen auf der Strasse.";
			
			Console.WriteLine($"First sentence is <{first}>");
			Console.WriteLine($"Second sentence is <{second}>");
			
			bool equal = String.Equals(first, second, StringComparison.InvariantCulture);
			Console.WriteLine($"The two strings {(equal == true ? "are" : "are not")} equal.");
			showComparison(first, second);
			
			string word = "coop";
			string words = "co-op";
			string other = "cop";
			
			showComparison(word, words);
			showComparison(word, other);
			showComparison(words, other);
			void showComparison(string one, string two)
			{
			    int compareLinguistic = String.Compare(one, two, StringComparison.InvariantCulture);
			    int compareOrdinal = String.Compare(one, two, StringComparison.Ordinal);
			    if (compareLinguistic < 0)
			    {
			        Console.WriteLine($"<{one}> is less than <{two}> using invariant culture");
			    }
			    else if (compareLinguistic > 0)
			    {
			        Console.WriteLine($"<{one}> is greater than <{two}> using invariant culture");
			    }
			    else
			    {
			        Console.WriteLine($"<{one}> and <{two}> are equivalent in order using invariant culture");
			    }
			
			    if (compareOrdinal < 0)
			    {
			        Console.WriteLine($"<{one}> is less than <{two}> using ordinal comparison");
			    }
			    else if (compareOrdinal > 0)
			    {
			        Console.WriteLine($"<{one}> is greater than <{two}> using ordinal comparison");
			    }
			    else
			    {
			        Console.WriteLine($"<{one}> and <{two}> are equivalent in order using ordinal comparison");
			    }
			}
			
			string first2 = "Sie tanzen auf der Straße.";
			string second2 = "Sie tanzen auf der Strasse.";
			
			Console.WriteLine($"First sentence is <{first2}>");
			Console.WriteLine($"Second sentence is <{second2}>");
			
			var en = new System.Globalization.CultureInfo("en-US");
			
			// For culture-sensitive comparisons, use the String.Compare
			// overload that takes a StringComparison value.
			int i = String.Compare(first, second, en, System.Globalization.CompareOptions.None);
			Console.WriteLine($"Comparing in {en.Name} returns {i}.");
			
			var de = new System.Globalization.CultureInfo("de-DE");
			i = String.Compare(first, second, de, System.Globalization.CompareOptions.None);
			Console.WriteLine($"Comparing in {de.Name} returns {i}.");
			
			bool b = String.Equals(first, second, StringComparison.CurrentCulture);
			Console.WriteLine($"The two strings {(b ? "are" : "are not")} equal.");
			
			string word2 = "coop";
			string words2 = "co-op";
			string other2 = "cop";
			
			showComparison2(word2, words2, en);
			showComparison2(word2, other2, en);
			showComparison2(words2, other2, en);
			
			void showComparison2(string one, string two, System.Globalization.CultureInfo culture)
			{
			    int compareLinguistic = String.Compare(one, two, en, System.Globalization.CompareOptions.None);
			    int compareOrdinal = String.Compare(one, two, StringComparison.Ordinal);
			    if (compareLinguistic < 0)
			    {
			        Console.WriteLine($"<{one}> is less than <{two}> using en-US culture");
			    }
			    else if (compareLinguistic > 0)
			    {
			        Console.WriteLine($"<{one}> is greater than <{two}> using en-US culture");
			    }
			    else
			    {
			        Console.WriteLine($"<{one}> and <{two}> are equivalent in order using en-US culture");
			    }
			
			    if (compareOrdinal < 0)
			    {
			        Console.WriteLine($"<{one}> is less than <{two}> using ordinal comparison");
			    }
			    else if (compareOrdinal > 0)
			    {
			        Console.WriteLine($"<{one}> is greater than <{two}> using ordinal comparison");
			    }
			    else
			    {
			        Console.WriteLine($"<{one}> and <{two}> are equivalent in order using ordinal comparison");
			    }
			}
			
			string[] lines =
			[
			    @"c:\public\textfile.txt",
			    @"c:\public\textFile.TXT",
			    @"c:\public\Text.txt",
			    @"c:\public\testfile2.txt"
			];
			
			Console.WriteLine("Non-sorted order:");
			foreach (string s in lines)
			{
			    Console.WriteLine($"   {s}");
			}
			
			Console.WriteLine("\n\rSorted order:");
			
			// Specify Ordinal to demonstrate the different behavior.
			Array.Sort(lines, StringComparer.CurrentCulture);
			
			foreach (string s in lines)
			{
			    Console.WriteLine($"   {s}");
			}
			
			string[] lines3 =
			[
			    @"c:\public\textfile.txt",
			    @"c:\public\textFile.TXT",
			    @"c:\public\Text.txt",
			    @"c:\public\testfile2.txt"
			];
			Array.Sort(lines, StringComparer.CurrentCulture);
			
			string searchString = @"c:\public\TEXTFILE.TXT";
			Console.WriteLine($"Binary search for <{searchString}>");
			int result3 = Array.BinarySearch(lines3, searchString, StringComparer.CurrentCulture);
			ShowWhere<string>(lines, result3);
			
			Console.WriteLine($"{(result3 > 0 ? "Found" : "Did not find")} {searchString}");
			
			void ShowWhere<T>(T[] array, int index)
			{
			    if (index < 0)
			    {
			        index = ~index;
			
			        Console.Write("Not found. Sorts between: ");
			
			        if (index == 0)
			        {
			            Console.Write("beginning of sequence and ");
			        }
			        else
			        {
			            Console.Write($"{array[index - 1]} and ");
			        }
			
			        if (index == array.Length)
			        {
			            Console.WriteLine("end of sequence.");
			        }
			        else
			        {
			            Console.WriteLine($"{array[index]}.");
			        }
			    }
			    else
			    {
			        Console.WriteLine($"Found at index {index}.");
			    }
			}
			
			List<string> lines4 =
			[
			    @"c:\public\textfile.txt",
			    @"c:\public\textFile.TXT",
			    @"c:\public\Text.txt",
			    @"c:\public\testfile2.txt"
			];
			
			Console.WriteLine("Non-sorted order:");
			foreach (string s in lines4)
			{
			    Console.WriteLine($"   {s}");
			}
			
			Console.WriteLine("\n\rSorted order:");
			
			lines.Sort((left, right) => left.CompareTo(right));
			foreach (string s in lines4)
			{
			    Console.WriteLine($"   {s}");
			}
			
			List<string> lines5 =
			[
			    @"c:\public\textfile.txt",
			    @"c:\public\textFile.TXT",
			    @"c:\public\Text.txt",
			    @"c:\public\testfile2.txt"
			];
			lines.Sort((left, right) => left.CompareTo(right));
			
			string searchString2 = @"c:\public\TEXTFILE.TXT";
			Console.WriteLine($"Binary search for <{searchString}>");
			int result4 = lines.BinarySearch(searchString2);
			ShowWhere2<string>(lines5, result4);
			
			Console.WriteLine($"{(result4 > 0 ? "Found" : "Did not find")} {searchString2}");
			
			void ShowWhere2<T>(IList<T> collection, int index)
			{
			    if (index < 0)
			    {
			        index = ~index;
			
			        Console.Write("Not found. Sorts between: ");
			
			        if (index == 0)
			        {
			            Console.Write("beginning of sequence and ");
			        }
			        else
			        {
			            Console.Write($"{collection[index - 1]} and ");
			        }
			
			        if (index == collection.Count)
			        {
			            Console.WriteLine("end of sequence.");
			        }
			        else
			        {
			            Console.WriteLine($"{collection[index]}.");
			        }
			    }
			    else
			    {
			        Console.WriteLine($"Found at index {index}.");
			    }
			}
			
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/how-to/modify-string-contents
namespace DotnetCSharpHowToModifyStringContents
{
	public class ModifyStringContents
	{
		public static void RunModifyStringContents()
		{
			string source = "The mountains are behind the clouds today.";

			// Replace one substring with another with String.Replace.
			// Only exact matches are supported.
			var replacement = source.Replace("mountains", "peaks");
			Console.WriteLine($"The source string is <{source}>");
			Console.WriteLine($"The updated string is <{replacement}>");
			
			string source2 = "The mountains are behind the clouds today.";

			// Replace all occurrences of one char with another.
			var replacement2 = source2.Replace(' ', '_');
			Console.WriteLine(source2);
			Console.WriteLine(replacement2);
			
			// Remove trailing and leading white space.
			string source3 = "    I'm wider than I need to be.      ";
			// Store the results in a new string variable.
			var trimmedResult = source3.Trim();
			var trimLeading = source3.TrimStart();
			var trimTrailing = source3.TrimEnd();
			Console.WriteLine($"<{source3}>");
			Console.WriteLine($"<{trimmedResult}>");
			Console.WriteLine($"<{trimLeading}>");
			Console.WriteLine($"<{trimTrailing}>");
			
			string source4 = "Many mountains are behind many clouds today.";
			// Remove a substring from the middle of the string.
			string toRemove = "many ";
			string result = string.Empty;
			int i = source4.IndexOf(toRemove);
			if (i >= 0)
			{
			    result= source4.Remove(i, toRemove.Length);
			}
			Console.WriteLine(source4);
			Console.WriteLine(result);
			
			string source5 = "The mountains are still there behind the clouds today.";

			// Use Regex.Replace for more flexibility.
			// Replace "the" or "The" with "many" or "Many".
			// using System.Text.RegularExpressions
			string replaceWith = "many ";
			source = System.Text.RegularExpressions.Regex.Replace(source5, """the\s""", LocalReplaceMatchCase,
			    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			Console.WriteLine(source5);
			
			string LocalReplaceMatchCase(System.Text.RegularExpressions.Match matchExpression)
			{
			    // Test whether the match is capitalized
			    if (Char.IsUpper(matchExpression.Value[0]))
			    {
			        // Capitalize the replacement string
			        System.Text.StringBuilder replacementBuilder = new System.Text.StringBuilder(replaceWith);
			        replacementBuilder[0] = Char.ToUpper(replacementBuilder[0]);
			        return replacementBuilder.ToString();
			    }
			    else
			    {
			        return replaceWith;
			    }
			}
			
			string phrase = "The quick brown fox jumps over the fence";
			Console.WriteLine(phrase);
			
			char[] phraseAsChars = phrase.ToCharArray();
			int animalIndex = phrase.IndexOf("fox");
			if (animalIndex != -1)
			{
			    phraseAsChars[animalIndex++] = 'c';
			    phraseAsChars[animalIndex++] = 'a';
			    phraseAsChars[animalIndex] = 't';
			}
			
			string updatedPhrase = new string(phraseAsChars);
			Console.WriteLine(updatedPhrase);
			
			// constructing a string from a char array, prefix it with some additional characters
			char[] chars = [ 'a', 'b', 'c', 'd', '\0' ];
			int length = chars.Length + 2;
			string result2 = string.Create(length, chars, (Span<char> strContent, char[] charArray) =>
			{
			        strContent[0] = '0';
			        strContent[1] = '1';
			        for (int i = 0; i < charArray.Length; i++)
			        {
			            strContent[i + 2] = charArray[i];
			        }
			});
			
			Console.WriteLine(result2);
			
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/how-to/search-strings
namespace DotnetCSharpHowToSearchStrings
{
	public class SearchStrings
	{
		public static void RunSearchStrings()
		{
			string factMessage = "Extension methods have all the capabilities of regular static methods.";

			// Write the string and include the quotation marks.
			Console.WriteLine($"\"{factMessage}\"");
			
			// Simple comparisons are always case sensitive!
			bool containsSearchResult = factMessage.Contains("extension");
			// Raw string literals can work here because the output doesn't begin with "
			Console.WriteLine($"""Contains "extension"? {containsSearchResult}""");
			
			// For user input and strings that will be displayed to the end user,
			// use the StringComparison parameter on methods that have it to specify how to match strings.
			bool ignoreCaseSearchResult = factMessage.StartsWith("extension", System.StringComparison.CurrentCultureIgnoreCase);
			Console.WriteLine($"""Starts with "extension"? {ignoreCaseSearchResult} (ignoring case)""");
			
			bool endsWithSearchResult = factMessage.EndsWith(".", System.StringComparison.CurrentCultureIgnoreCase);
			Console.WriteLine($"Ends with '.'? {endsWithSearchResult}");
			
			string factMessage2 = "Extension methods have all the capabilities of regular static methods.";

			// Write the string and include the quotation marks.
			Console.WriteLine($"\"{factMessage2}\"");
			
			// This search returns the substring between two strings, so
			// the first index is moved to the character just after the first string.
			int first = factMessage2.IndexOf("methods") + "methods".Length;
			int last = factMessage2.LastIndexOf("methods");
			string str2 = factMessage2.Substring(first, last - first);
			Console.WriteLine($"""Substring between "methods" and "methods": '{str2}'""");
			
			string[] sentences =
			[
			    "Put the water over there.",
			    "They're quite thirsty.",
			    "Their water bottles broke."
			];
			
			string sPattern = "the(ir)?\\s";
			
			foreach (string s in sentences)
			{
			    Console.Write($"{s,24}");
			
			    if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
			    {
			        Console.WriteLine($"  (match for '{sPattern}' found)");
			    }
			    else
			    {
			        Console.WriteLine();
			    }
			}
			
			string[] numbers =
			[
			    "123-555-0190",
			    "444-234-22450",
			    "690-555-0178",
			    "146-893-232",
			    "146-555-0122",
			    "4007-555-0111",
			    "407-555-0111",
			    "407-2-5555",
			    "407-555-8974",
			    "407-2ab-5555",
			    "690-555-8148",
			    "146-893-232-"
			];
			
			string sPattern2 = """^\d{3}-\d{3}-\d{4}$""";
			
			foreach (string s in numbers)
			{
			    Console.Write($"{s,14}");
			
			    if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern2))
			    {
			        Console.WriteLine(" - valid");
			    }
			    else
			    {
			        Console.WriteLine(" - invalid");
			    }
			}
			
			string[] numbers2 =
			[
			    "123-555-0190",
			    "444-234-22450",
			    "690-555-0178",
			    "146-893-232",
			    "146-555-0122",
			    "4007-555-0111",
			    "407-555-0111",
			    "407-2-5555",
			    "407-555-8974",
			    "407-2ab-5555",
			    "690-555-8148",
			    "146-893-232-"
			];
			
			string sPattern3 = """^\d{3}-\d{3}-\d{4}$""";
			
			foreach (string s in numbers2)
			{
			    Console.Write($"{s,14}");
			
			    if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern3))
			    {
			        Console.WriteLine(" - valid");
			    }
			    else
			    {
			        Console.WriteLine(" - invalid");
			    }
			}
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings
namespace DotnetCSharpHowToConcatenateMultipleStrings
{
	public class ConcatenateMultipleStrings
	{
		public static void RunConcatenateMultipleStrings()
		{
			// Concatenation of literals is performed at compile time, not run time.
			string text = "Historically, the world of data and the world of objects " +
			"have not been well integrated. Programmers work in C# or Visual Basic " +
			"and also in SQL or XQuery. On the one side are concepts such as classes, " +
			"objects, fields, inheritance, and .NET Framework APIs. On the other side " +
			"are tables, columns, rows, nodes, and separate languages for dealing with " +
			"them. Data types often require translation between the two worlds; there are " +
			"different standard functions. Because the object world has no notion of query, a " +
			"query can only be represented as a string without compile-time type checking or " +
			"IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " +
			"objects in memory is often tedious and error-prone.";
			
			Console.WriteLine(text);
			
			string userName = "<Type your name here>";
			string dateString = DateTime.Today.ToShortDateString();
			
			// Use the + and += operators for one-time concatenations.
			string str = "Hello " + userName + ". Today is " + dateString + ".";
			Console.WriteLine(str);
			
			str += " How are you today?";
			Console.WriteLine(str);
			
			string userName2 = "<Type your name here>";
			string date = DateTime.Today.ToShortDateString();
			
			// Use string interpolation to concatenate strings.
			string str2 = $"Hello {userName2}. Today is {date}.";
			Console.WriteLine(str);
			
			str = $"{str2} How are you today?";
			Console.WriteLine(str2);
			
			// Use StringBuilder for concatenation in tight loops.
			var sb = new StringBuilder();
			for (int i = 0; i < 20; i++)
			{
			    sb.AppendLine(i.ToString());
			}
			Console.WriteLine(sb.ToString());
			
			string[] words = ["The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog."];

			var unreadablePhrase = string.Concat(words);
			Console.WriteLine(unreadablePhrase);
			
			var readablePhrase = string.Join(" ", words);
			Console.WriteLine(readablePhrase);
			
			string[] words3 = ["The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog."];

			var unreadablePhrase2 = string.Concat(words);
			Console.WriteLine(unreadablePhrase);
			
			var readablePhrase2 = string.Join(" ", words);
			Console.WriteLine(readablePhrase);
			
			string[] words4 = ["The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog."];

			var phrase = words4.Aggregate((partialPhrase, word) =>$"{partialPhrase} {words4}");
			Console.WriteLine(phrase);
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
namespace DotnetCSharpHowToParseStringsUsingSplit
{
	public class ParseStringsUsingSplit
	{
		public static void RunParseStringsUsingSplit()
		{
			string phrase = "The quick brown fox jumps over the lazy dog.";
			string[] words = phrase.Split(' ');
			
			foreach (var word in words)
			{
			    Console.WriteLine($"<{word}>");
			}
			
			string phrase2 = "The quick brown fox jumps over the lazy dog.";
			string[] words2 = phrase2.Split(' ');
			
			for (int i = 0; i < words.Length; i++)
			{
			    Console.WriteLine($"Index {i}: <{words2[i]}>");
			}
			
			char[] delimiterChars = [' ', ',', '.', ':', '\t'];

			string text = "one\ttwo three:four,five six seven";
			Console.WriteLine($"Original text: '{text}'");
			
			string[] words3 = text.Split(delimiterChars);
			Console.WriteLine($"{words3.Length} words in text:");
			
			foreach (var word in words3)
			{
			    Console.WriteLine($"<{word}>");
			}
			
			char[] delimiterChars2 = [' ', ',', '.', ':', '\t'];

			string text2 = "one\ttwo :,five six seven";
			Console.WriteLine($"Original text: '{text2}'");
			
			string[] words4 = text.Split(delimiterChars);
			Console.WriteLine($"{words4.Length} words in text:");
			
			foreach (var word in words4)
			{
			    Console.WriteLine($"<{word}>");
			}
			
			string[] separatingStrings = ["<<", "..."];

			string text3 = "one<<two......three<four";
			Console.WriteLine($"Original text: '{text3}'");
			
			string[] words5 = text.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
			Console.WriteLine($"{words5.Length} substrings in text:");
			
			foreach (var word in words5)
			{
			    Console.WriteLine(word);
			}
			
			string phrase3 = "The quick brown fox jumps over the lazy dog.";
			string[] words6 = phrase3.Split(' ', 4, StringSplitOptions.None);
			
			foreach (var word in words6)
			{
			    Console.WriteLine($"<{word}>");
			}
			
			string phrase4 = "The quick brown    fox     jumps over the lazy dog.";
			string[] words7 = phrase4.Split(' ');
			
			foreach (var word in words7)
			{
			    Console.WriteLine($"<{word}>");
			}
			
			string numerals = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
			string[] words8 = numerals.Split(',', StringSplitOptions.TrimEntries);
			
			Console.WriteLine("Trimmed entries:");
			foreach (var word in words8)
			{
			    Console.WriteLine($"<{word}>");
			}
			words8 = numerals.Split(',', StringSplitOptions.None);
			Console.WriteLine("Untrimmed entries:");
			foreach (var word in words8)
			{
			    Console.WriteLine($"<{word}>");
			}
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/versioning
namespace DotnetCSharpVersioning
{
	public class Versioning
	{
		public static void RunVersioning()
		{
			BaseClass b = new BaseClass();
		    DerivedClass d = new DerivedClass();
		
		    b.MyMethod();
		    d.MyMethod();
			
			//MyBaseClass b = new MyBaseClass();
			//MyDerivedClass d = new MyDerivedClass();
		
		    //Console.WriteLine($"Base Method One: {b.MethodOne()}");
		    //Console.WriteLine($"Derived Method One: {d.MethodOne()}");
			
		}
		
		// Version 1.0.0
		public void SaveFile(string filename) { }
		
		// Version 2.0.0 - MAJOR increment required
		public void SaveFile(string filename, bool overwrite) { } // Added required parameter
		
		// Version 1.0.0 - returns null when file not found
		public string ReadFile(string path) => File.Exists(path) ? File.ReadAllText(path) : null;
		
		// Version 2.0.0 - MAJOR increment required
		public string ReadFile2(string path) => File.ReadAllText(path); // Now throws exception when file not found
		
		// Version 1.0.0
		public void Log(string message) { }
		
		// Version 1.1.0 - MINOR increment
		public void Log2(string message) { } // Original method unchanged
		//public void Log3(string message, LogLevel level) { } // New overload added
		
		// Version 1.0.0
		public void SaveFile2(string filename) { }
		
		// Version 1.1.0 - MINOR increment
		public void SaveFile3(string filename, bool overwrite = false) { } // Optional parameter
		
		// Version 1.0.0 - has a bug
		public int Divide(int a, int b)
		{
		    return a / b; // Bug: doesn't handle division by zero
		}
		
		// Version 1.0.1 - PATCH increment
		public int Divide2(int a, int b)
		{
		    if (b == 0) throw new ArgumentException("Cannot divide by zero");
		    return a / b; // Bug fixed, behavior improved but API unchanged
		}
		
		// Version 1.0.0
		public List<int> SortNumbers(List<int> numbers)
		{
		    return numbers.OrderBy(x => x).ToList(); // Slower implementation
		}
		
		// Version 1.0.1 - PATCH increment
		public List<int> SortNumbers2(List<int> numbers)
		{
		    var result = new List<int>(numbers);
		    result.Sort(); // Faster implementation, same API
		    return result;
		}
	}
	
	// Version 1.0.0
	public class Calculator
	{
	    public int Add(int a, int b) => a + b;
	    public int Subtract(int a, int b) => a - b; // This method exists
	}
	
	// Version 2.0.0 - MAJOR increment required
	public class Calculator2
	{
	    public int Add(int a, int b) => a + b;
	    // Subtract method removed - breaking change!
	}
	
	// Version 1.0.0
	public class Calculator3
	{
	    public int Add(int a, int b) => a + b;
	}
	
	// Version 1.1.0 - MINOR increment
	public class Calculator4
	{
	    public int Add(int a, int b) => a + b;
	    public int Multiply(int a, int b) => a * b; // New method added
	}
	
	public class BaseClass
	{
	    public void MyMethod()
	    {
	        Console.WriteLine("A base method");
	    }
	}
	
	public class DerivedClass : BaseClass
	{
	    public new void MyMethod()
	    {
	        Console.WriteLine("A derived method");
	    }
	}
	
	public class MyBaseClass
	{
	    public virtual string MethodOne()
	    {
	        return "Method One";
	    }
	}
	
	public class MyDerivedClass : MyBaseClass
	{
	    public override string MethodOne()
	    {
	        return "Derived Method One";
	    }
	}

}

//https://learn.microsoft.com/en-us/dotnet/csharp/distinguish-delegates-events
namespace DotnetCSharpDistinguishDelegatesEvents
{
	public class DistinguishDelegatesEvents
	{
		public static void RunDistinguishDelegatesEvents()
		{
			
		}
	}
}
//https://learn.microsoft.com/en-us/dotnet/csharp/modern-events
namespace DotnetCSharpModernEvents
{
	public class ModernEvents
	{
		public static void RunModernEvents()
		{
			/*
			worker.StartWorking += async (sender, eventArgs) =>
			{
			    try
			    {
			        await DoWorkAsync();
			    }
			    catch (Exception e)
			    {
			        //Some form of logging.
			        Console.WriteLine($"Async task failure: {e.ToString()}");
			        // Consider gracefully, and quickly exiting.
			    }
			};
			*/
			
		}
	}
	
	internal struct SearchDirectoryArgs
	{
	    internal string CurrentSearchDirectory { get; }
	    internal int TotalDirs { get; }
	    internal int CompletedDirs { get; }
	
	    internal SearchDirectoryArgs(string dir, int totalDirs, int completedDirs) : this()
	    {
	        CurrentSearchDirectory = dir;
	        TotalDirs = totalDirs;
	        CompletedDirs = completedDirs;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/event-pattern
namespace DotnetCSharpEventPattern
{
	public class EventPattern
	{
		public static void RunEventPattern()
		{
			var fileLister = new FileSearcher();
			int filesFound = 0;
			
			EventHandler<FileFoundArgs> onFileFound = (sender, eventArgs) =>
			{
			    Console.WriteLine(eventArgs.FoundFile);
			    filesFound++;
			};
			
			fileLister.FileFound += onFileFound;
			
			fileLister.FileFound -= onFileFound;
			
			EventHandler<FileFoundArgs> onFileFound2 = (sender, eventArgs) =>
			{
			    Console.WriteLine(eventArgs.FoundFile);
			    eventArgs.CancelRequested = true;
			};
			
			/*
			fileLister.DirectoryChanged += (sender, eventArgs) =>
			{
			    Console.Write($"Entering '{eventArgs.CurrentSearchDirectory}'.");
			    Console.WriteLine($" {eventArgs.CompletedDirs} of {eventArgs.TotalDirs} completed...");
			};
			*/
			
			
		}
		
		//void EventRaised(object sender, EventArgs args);
		
		public event EventHandler<FileFoundArgs>? FileFound;
		
		internal event EventHandler<SearchDirectoryArgs> DirectoryChanged
		{
		    add { _directoryChanged += value; }
		    remove { _directoryChanged -= value; }
		}
		private EventHandler<SearchDirectoryArgs>? _directoryChanged;
		
		public void Search(string directory, string searchPattern, bool searchSubDirs = false)
		{
		    if (searchSubDirs)
		    {
		        var allDirectories = Directory.GetDirectories(directory, "*.*", SearchOption.AllDirectories);
		        var completedDirs = 0;
		        var totalDirs = allDirectories.Length + 1;
		        foreach (var dir in allDirectories)
		        {
		            _directoryChanged?.Invoke(this, new (dir, totalDirs, completedDirs++));
		            // Search 'dir' and its subdirectories for files that match the search pattern:
		            SearchDirectory(dir, searchPattern);
		        }
		        // Include the Current Directory:
		        _directoryChanged?.Invoke(this, new (directory, totalDirs, completedDirs++));
		        SearchDirectory(directory, searchPattern);
		    }
		    else
		    {
		        SearchDirectory(directory, searchPattern);
		    }
		}
		
		private void SearchDirectory(string directory, string searchPattern)
		{
		    foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
		    {
		        var args = new FileFoundArgs(file);
		        FileFound?.Invoke(this, args);
		        if (args.CancelRequested)
		            break;
		    }
		}
	}
	
	public class FileFoundArgs : EventArgs
	{
	    public string FoundFile { get; }
		public bool CancelRequested { get; set; }
	
	    public FileFoundArgs(string fileName) => FoundFile = fileName;
		
		/*
		private void SearchDirectory(string directory, string searchPattern)
		{
		    foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
		    {
		        var args = new FileFoundArgs(file);
		        FileFound?.Invoke(this, args);
		        if (args.CancelRequested)
		            break;
		    }
		}
		*/
	}
	
	public class FileSearcher
	{
	    public event EventHandler<FileFoundArgs>? FileFound;
	
	    public void Search(string directory, string searchPattern)
	    {
	        foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
	        {
	            FileFound?.Invoke(this, new FileFoundArgs(file));
	        }
	    }
	}
	
	internal class SearchDirectoryArgs : EventArgs
	{
	    internal string CurrentSearchDirectory { get; }
	    internal int TotalDirs { get; }
	    internal int CompletedDirs { get; }
	
	    internal SearchDirectoryArgs(string dir, int totalDirs, int completedDirs)
	    {
	        CurrentSearchDirectory = dir;
	        TotalDirs = totalDirs;
	        CompletedDirs = completedDirs;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/events-overview
namespace DotnetCSharpEventsOverview
{
	public class EventsOverview
	{
		//public event EventHandler<FileFoundArgs>? FileFound;
		
		public static void RunEventsOverview()
		{
			//FileFound?.Invoke(this, new FileFoundArgs(file));
			
			/*
			var fileLister = new FileSearcher();
			int filesFound = 0;
			
			EventHandler<FileFoundArgs> onFileFound = (sender, eventArgs) =>
			{
			    Console.WriteLine(eventArgs.FoundFile);
			    filesFound++;
			};
			
			fileLister.FileFound += onFileFound;
			
			fileLister.FileFound -= onFileFound;
			*/
			
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/delegates-patterns
namespace DotnetCSharpDelegatesPatterns
{
	public static class DelegatesPatterns
	{
		public static void RunDelegatesPatterns()
		{
			//var smallNumbers = numbers.Where(n => n < 10);
			
			Logger.WriteMessage += LoggingMethods.LogToConsole;
			
			var file = new FileLogger("log.txt");
			
			var fileOutput = new FileLogger("log.txt");
			Logger.WriteMessage += LoggingMethods.LogToConsole; // LoggingMethods is the static class we utilized earlier
			
			Logger.WriteMessage -= LoggingMethods.LogToConsole;
			
			
		}
		
		public static IEnumerable<TSource> Where<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}
	}
	
	/*
	public static class Logger
	{
	    public static Action<string>? WriteMessage;
	
	    public static void LogMessage(string msg)
	    {
	        if (WriteMessage is not null)
	            WriteMessage(msg);
	    }
	}
	*/
	
	public static class LoggingMethods
	{
	    public static void LogToConsole(string message)
	    {
	        Console.Error.WriteLine(message);
	    }
	}
	
	public enum Severity
	{
	    Verbose,
	    Trace,
	    Information,
	    Warning,
	    Error,
	    Critical
	}
	
	/*
	public static class Logger
	{
	    public static Action<string>? WriteMessage;
	
	    public static void LogMessage(Severity s, string component, string msg)
	    {
	        var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
	        if (WriteMessage is not null)
	            WriteMessage(outputMsg);
	    }
	}
	*/
	
	public static class Logger
	{
	    public static Action<string>? WriteMessage;
	
	    public static Severity LogLevel { get; set; } = Severity.Warning;
	
	    public static void LogMessage(Severity s, string component, string msg)
	    {
	        if (s < LogLevel)
	            return;
	
	        var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
	        if (WriteMessage is not null)
	            WriteMessage(outputMsg);
	    }
		
		public static void LogMessage(string msg)
		{
		    WriteMessage?.Invoke(msg);
		}
	}
	
	public class FileLogger
	{
	    private readonly string logPath;
	    public FileLogger(string path)
	    {
	        logPath = path;
	        Logger.WriteMessage += LogMessage;
	    }
	
	    public void DetachLog() => Logger.WriteMessage -= LogMessage;
	    // make sure this can't throw.
	    private void LogMessage(string msg)
	    {
	        try
	        {
	            using (var log = File.AppendText(logPath))
	            {
	                log.WriteLine(msg);
	                log.Flush();
	            }
	        }
	        catch (Exception)
	        {
	            // Hmm. We caught an exception while
	            // logging. We can't really log the
	            // problem (since it's the log that's failing).
	            // So, while normally, catching an exception
	            // and doing nothing isn't wise, it's really the
	            // only reasonable option here.
	        }
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/delegates-strongly-typed
namespace DotnetCSharpDelegatesStronglyTyped
{
	public class DelegateStronglyTyped
	{
		public delegate void Action();
		public delegate void Action<in T>(T arg);
		public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
		// Other variations removed for brevity.
		
		public delegate TResult Func<out TResult>();
		public delegate TResult Func<in T1, out TResult>(T1 arg);
		public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
		// Other variations removed for brevity
		
		public delegate bool Predicate<in T>(T obj);
		
		Func<string, bool> TestForString;
		Predicate<string> AnotherTestForString;
		
		
		
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/delegate-class
namespace DotnetCSharpDelegateClass
{
	public class DelegateClass
	{
		// Define a simple delegate that can point to methods taking two integers and returning an integer
		public delegate int Calculator(int x, int y);
		
		// From the .NET Core library
		public delegate int Comparison<in T>(T left, T right);
		
		// Inside a class definition:
		//public Comparison<T> comparator;
		
		public static void RunDelegateClass()
		{
			//int result = comparator(left, right);
			
			//phrases.Sort(CompareLength);
			
			//Comparison<string> comparer = CompareLength;
			//phrases.Sort(comparer);
			
			//Comparison<string> comparer = (left, right) => left.Length.CompareTo(right.Length);
			//phrases.Sort(comparer);
			
			
		}
		
		private static int CompareLength(string left, string right) =>
    		left.Length.CompareTo(right.Length);
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/delegates-overview
namespace DotnetCSharpDelegatesOverview
{
	public class DelegatesOverview
	{
		public static void RunDelegatesOverview()
		{
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/iterators
namespace DotnetCSharpIterators
{
	public static class Iterators
	{
		public static void RunIterators()
		{
			/*
			foreach (var item in collection)
			{
			    Console.WriteLine(item?.ToString());
			}
			*/
			
			/*
			await foreach (var item in asyncSequence)
			{
			Console.WriteLine(item?.ToString());
			}
			*/
			
			/*
			IEnumerator<int> enumerator = collection.GetEnumerator();
			while (enumerator.MoveNext())
			{
			    var item = enumerator.Current;
			    Console.WriteLine(item.ToString());
			}
			
			{
			    var enumerator = collection.GetEnumerator();
			    try
			    {
			        while (enumerator.MoveNext())
			        {
			            var item = enumerator.Current;
			            Console.WriteLine(item.ToString());
			        }
			    }
			    finally
			    {
			        // dispose of enumerator.
			    }
			}
			
			{
			    var enumerator = collection.GetAsyncEnumerator();
			    try
			    {
			        while (await enumerator.MoveNextAsync())
			        {
			            var item = enumerator.Current;
			            Console.WriteLine(item.ToString());
			        }
			    }
			    finally
			    {
			        // dispose of async enumerator.
					(enumerator as IDisposable)?.Dispose();
					
					if (enumerator is IAsyncDisposable asyncDisposable)
        				await asyncDisposable.DisposeAsync();
						
					finally
					{
					   ((IDisposable)enumerator).Dispose();
					}
			    }
			}
			*/
			
			
			
		}
		
		public static IEnumerable<int> GetSingleDigitNumbers()
		{
		    yield return 0;
		    yield return 1;
		    yield return 2;
		    yield return 3;
		    yield return 4;
		    yield return 5;
		    yield return 6;
		    yield return 7;
		    yield return 8;
		    yield return 9;
		}
		
		public static IEnumerable<int> GetSingleDigitNumbersLoop()
		{
		    int index = 0;
		    while (index < 10)
		        yield return index++;
		}
		
		public static IEnumerable<int> GetSetsOfNumbers()
		{
		    int index = 0;
		    while (index < 10)
		        yield return index++;
		
		    yield return 50;
		
		    index = 100;
		    while (index < 110)
		        yield return index++;
		}
		
		public static async IAsyncEnumerable<int> GetSetsOfNumbersAsync()
		{
		    int index = 0;
		    while (index < 10)
		        yield return index++;
		
		    await Task.Delay(500);
		
		    yield return 50;
		
		    await Task.Delay(500);
		
		    index = 100;
		    while (index < 110)
		        yield return index++;
		}
		
		public static IEnumerable<T> Sample<T>(this IEnumerable<T> sourceSequence, int interval)
		{
		    int index = 0;
		    foreach (T item in sourceSequence)
		    {
		        if (index++ % interval == 0)
		            yield return item;
		    }
		}
		
		/*
		public IEnumerable<int> GetSingleDigitNumbers()
		{
		    int index = 0;
		    while (index < 10)
		        yield return index++;
		
		    yield return 50;
		
		    // generates a compile time error:
		    var items = new int[] {100, 101, 102, 103, 104, 105, 106, 107, 108, 109 };
		    return items;
		}
		*/
		
		public static IEnumerable<int> GetFirstDecile()
		{
		    int index = 0;
		    while (index < 10)
		        yield return index++;
		
		    yield return 50;
		
		    var items = new int[] {100, 101, 102, 103, 104, 105, 106, 107, 108, 109 };
		    foreach (var item in items)
		        yield return item;
		}
		
		public static IEnumerable<int> GetSingleDigitOddNumbers(bool getCollection)
		{
		    if (getCollection == false)
		        return new int[0];
		    else
		        return IteratorMethod();
		}
		
		private static IEnumerable<int> IteratorMethod()
		{
		    int index = 0;
		    while (index < 10)
		    {
		        if (index % 2 == 1)
		            yield return index;
		        index++;
		    }
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/methods
namespace DotnetCSharpMethods
{
	public class CSharpMethods
	{
		public static void RunCSharpMethods()
		{
			
		}
	}
	
	namespace MotorCycleExample
	{
	    abstract class Motorcycle
	    {
	        // Anyone can call this.
	        public void StartEngine() {/* Method statements here */ }
	
	        // Only derived classes can call this.
	        protected void AddGas(int gallons) { /* Method statements here */ }
	
	        // Derived classes can override the base class implementation.
	        public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }
	
	        // Derived classes can override the base class implementation.
	        public virtual int Drive(TimeSpan time, int speed) { /* Method statements here */ return 0; }
	
	        // Derived classes must implement this.
	        public abstract double GetTopSpeed();
	    }
		
		class TestMotorcycle : Motorcycle
		{
		    public override double GetTopSpeed() => 108.4;
		
		    static void RunMain()
		    {
		        var moto = new TestMotorcycle();
		
		        moto.StartEngine();
		        moto.AddGas(15);
		        _ = moto.Drive(5, 20);
		        double speed = moto.GetTopSpeed();
		        Console.WriteLine($"My top speed is {speed}");
				
				int travelTime = moto.Drive(170, speed: 55);
		    }
		}
		
		/*
		class TestMotorcycle : Motorcycle
		{
		    public override int Drive(int miles, int speed) =>
		        (int)Math.Round((double)miles / speed, 0);
		
		    public override double GetTopSpeed() => 108.4;
		
		    static void Main()
		    {
		        var moto = new TestMotorcycle();
		        moto.StartEngine();
		        moto.AddGas(15);
		        int travelTime = moto.Drive(speed: 60, miles: 170);
		        Console.WriteLine($"Travel time: approx. {travelTime} hours");
		    }
		}
		// The example displays the following output:
		//      Travel time: approx. 3 hours
		*/
		
		public class Person
		{
		    public string FirstName = default!;
		}
		
		public static class ClassTypeExample
		{
		    public static void RunMain()
		    {
		        Person p1 = new() { FirstName = "John" };
		        Person p2 = new() { FirstName = "John" };
		        Console.WriteLine($"p1 = p2: {p1.Equals(p2)}");
		    }
		}
		// The example displays the following output:
		//      p1 = p2: False
	}
	
	public static class SquareExample
	{
	    public static void RunMain()
	    {
	        // Call with an int variable.
	        int num = 4;
	        int productA = Square(num);
	
	        // Call with an integer literal.
	        int productB = Square(12);
	
	        // Call with an expression that evaluates to int.
	        int productC = Square(productA * 3);
	    }
	
	    static int Square(int i)
	    {
	        // Store input argument in a local variable.
	        int input = i;
	        return input * input;
	    }
	}
	
	namespace methods
	{
		public class Person
		{
		    public string FirstName = default!;
		
		    public override bool Equals(object? obj) =>
		        obj is Person p2 &&
		        FirstName.Equals(p2.FirstName);
		
		    public override int GetHashCode() => FirstName.GetHashCode();
		}
		
		public static class Example
		{
		    public static void RunMain()
		    {
		        Person p1 = new() { FirstName = "John" };
		        Person p2 = new() { FirstName = "John" };
		        Console.WriteLine($"p1 = p2: {p1.Equals(p2)}");
		    }
		}
		// The example displays the following output:
		//      p1 = p2: True
	}
	
	public static class ByValueExample
	{
	    public static void RunMain()
	    {
	        var value = 20;
	        Console.WriteLine("In Main, value = {0}", value);
	        ModifyValue(value);
	        Console.WriteLine("Back in Main, value = {0}", value);
	    }
	
	    static void ModifyValue(int i)
	    {
	        i = 30;
	        Console.WriteLine("In ModifyValue, parameter value = {0}", i);
	        return;
	    }
	}
	// The example displays the following output:
	//      In Main, value = 20
	//      In ModifyValue, parameter value = 30
	//      Back in Main, value = 20
	
	public class SampleRefType
	{
	    public int value;
	}
	
	public static class ByRefTypeExample
	{
	    public static void RunMain()
	    {
	        var rt = new SampleRefType { value = 44 };
	        ModifyObject(rt);
	        Console.WriteLine(rt.value);
	    }
	
	    static void ModifyObject(SampleRefType obj) => obj.value = 33;
	}
	
	public static class ByRefExample2
	{
	    public static void RunMain()
	    {
	        var value = 20;
	        Console.WriteLine("In Main, value = {0}", value);
	        ModifyValue(ref value);
	        Console.WriteLine("Back in Main, value = {0}", value);
	    }
	
	    private static void ModifyValue(ref int i)
	    {
	        i = 30;
	        Console.WriteLine("In ModifyValue, parameter value = {0}", i);
	        return;
	    }
	}
	// The example displays the following output:
	//      In Main, value = 20
	//      In ModifyValue, parameter value = 30
	//      Back in Main, value = 30
	
	public static class RefSwapExample
	{
	    static void RunMain()
	    {
	        int i = 2, j = 3;
	        Console.WriteLine($"i = {i}  j = {j}");
	
	        Swap(ref i, ref j);
	
	        Console.WriteLine($"i = {i}  j = {j}");
	    }
	
	    static void Swap(ref int x, ref int y) =>
	        (y, x) = (x, y);
	}
	// The example displays the following output:
	//      i = 2  j = 3
	//      i = 3  j = 2
	
	static class ParamsExample
	{
	    static void RunMain()
	    {
	        string fromArray = GetVowels(["apple", "banana", "pear"]);
	        Console.WriteLine($"Vowels from collection expression: '{fromArray}'");
	
	        string fromMultipleArguments = GetVowels("apple", "banana", "pear");
	        Console.WriteLine($"Vowels from multiple arguments: '{fromMultipleArguments}'");
	
	        string fromNull = GetVowels(null);
	        Console.WriteLine($"Vowels from null: '{fromNull}'");
	
	        string fromNoValue = GetVowels();
	        Console.WriteLine($"Vowels from no value: '{fromNoValue}'");
	    }
	
	    static string GetVowels(params IEnumerable<string>? input)
	    {
	        if (input == null || !input.Any())
	        {
	            return string.Empty;
	        }
	
	        char[] vowels = ['A', 'E', 'I', 'O', 'U'];
	        return string.Concat(
	            input.SelectMany(
	                word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
	    }
	}
	
	// The example displays the following output:
	//     Vowels from array: 'aeaaaea'
	//     Vowels from multiple arguments: 'aeaaaea'
	//     Vowels from null: ''
	//     Vowels from no value: ''
	
	public class Options
	{
	    public void ExampleMethod(int required, int optionalInt = default,
	                              string? description = default)
	    {
	        var msg = $"{description ?? "N/A"}: {required} + {optionalInt} = {required + optionalInt}";
	        Console.WriteLine(msg);
	    }
	}
	
	public static class OptionsExample
	{
	    public static void RunMain()
	    {
	        var opt = new Options();
	        opt.ExampleMethod(10);
	        opt.ExampleMethod(10, 2);
	        opt.ExampleMethod(12, description: "Addition with zero:");
			
			/*
			int result = obj.DivideTwoNumbers(6,2);
			// The result is 3.
			Console.WriteLine(result);
			
			int result = obj.AddTwoNumbers(1, 2);
			result = obj.SquareANumber(result);
			// The result is 9.
			Console.WriteLine(result);
			
			result = obj.SquareANumber(obj.AddTwoNumbers(1, 2));
			// The result is 9.
			Console.WriteLine(result);
			*/
			
			/*
			var person = GetPersonalInfo("111111111");
			Console.WriteLine($"{person.Item1} {person.Item3}: age = {person.Item4}");
			
			var person = GetPersonalInfo("111111111");
			Console.WriteLine($"{person.FName} {person.LName}: age = {person.Age}");
			*/
			
			
	    }
		
		/*
		public (string FName, string MName, string LName, int Age) GetPersonalInfo(string id)
		{
		    PersonInfo per = PersonInfo.RetrieveInfoById(id);
		    return (per.FirstName, per.MiddleName, per.LastName, per.Age);
		}
		*/
	}
	// The example displays the following output:
	//      N/A: 10 + 0 = 10
	//      N/A: 10 + 2 = 12
	//      Addition with zero:: 12 + 0 = 12
	
	class SimpleMath
	{
	    public int AddTwoNumbers(int number1, int number2) =>
	        number1 + number2;
	
	    public int SquareANumber(int number) =>
	        number * number;
	}
	
	class SimpleMathExtension
	{
	    public int DivideTwoNumbers(int number1, int number2)
	    {
	        return number1 / number2;
	    }
		
		/*
		public (string, string, string, int) GetPersonalInfo(string id)
		{
		    PersonInfo per = PersonInfo.RetrieveInfoById(id);
		    return (per.FirstName, per.MiddleName, per.LastName, per.Age);
		}
		*/
	}
	
	public static class ArrayValueExample
	{
	    static void RunMain()
	    {
	        int[] values = [2, 4, 6, 8];
	        DoubleValues(values);
	        foreach (var value in values)
	        {
	            Console.Write("{0}  ", value);
	        }
	    }
	
	    public static void DoubleValues(int[] arr)
	    {
	        for (var ctr = 0; ctr <= arr.GetUpperBound(0); ctr++)
	        {
	            arr[ctr] *= 2;
	        }
	    }
	}
	// The example displays the following output:
	//       4  8  12  16
	
	class Program
	{
	    static Task RunMain() => DoSomethingAsync();
	
	    static async Task DoSomethingAsync()
	    {
	        Task<int> delayTask = DelayAsync();
	        int result = await delayTask;
	
	        // The previous two statements may be combined into
	        // the following statement.
	        //int result = await DelayAsync();
	
	        Console.WriteLine($"Result: {result}");
	    }
	
	    static async Task<int> DelayAsync()
	    {
	        await Task.Delay(100);
	        return 5;
	    }
		
		/*
		public Point Move(int dx, int dy) => new Point(x + dx, y + dy);
		public void Print() => Console.WriteLine(First + " " + Last);
		// Works with operators, properties, and indexers too.
		public static Complex operator +(Complex a, Complex b) => a.Add(b);
		public string Name => First + " " + Last;
		public Customer this[long id] => store.LookupCustomer(id);
		*/
	}
	// Example output:
	//   Result: 5
}

//https://learn.microsoft.com/en-us/dotnet/csharp/nullable-migration-strategies
namespace DotnetCSharpNullableMigrationStrategies
{
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references
namespace DotnetCSharpNullableReferences
{
	public class NullableReferences
	{
		public static void RunNullableReferences()
		{
			string message = "Hello, World!";
			int length = message.Length; // dereferencing "message"
			
			Collection<int> c = default;
    		c[10] = 1;    // CS8602: Possible dereference of null
			
			string? message2 = null;

			// warning: dereference null.
			Console.WriteLine($"The length of the message is {message2.Length}");
			
			var originalMessage = message2;
			message2 = "Hello, World!";
			
			// No warning. Analysis determined "message" is not-null.
			Console.WriteLine($"The length of the message is {message2.Length}");
			
			// warning!
			Console.WriteLine(originalMessage.Length);
			
			string? name = string.Empty;
			
			var x = name!.Length;
			
			
			
			
		}
		
		/*
		void FindRoot(Node node, Action<Node> processNode)
		{
		    for (var current = node; current != null; current = current.Parent)
		    {
		        processNode(current);
		    }
		}
		*/
		
		//bool IsNull(string? s) => s == null;
		
		bool IsNull([NotNullWhen(false)] string? s) => s == null;
		
		void PrintMessageUpper(string? message)
		{
		    if (!IsNull(message))
		    {
		        Console.WriteLine($"{DateTime.Now}: {message.ToUpper()}");
		    }
		}

	}
	
	public class Collection<T>
	{
	    private T[] array = new T[100];
	    public T this[int index]
	    {
	        get => array[index];
	        set => array[index] = value;
	    }
	}
	
	public class Person
	{
	    public string FirstName { get; set; }
	    public string LastName { get; set; }
	
	    public Person(string firstName, string lastName)
	    {
	        FirstName = firstName;
	        LastName = lastName;
	    }
	
	    public Person() : this("John", "Doe") { }
	}
	
	public class Student : Person
	{
	    public string Major { get; set; }
	
	    public Student(string firstName, string lastName, string major)
	        : base(firstName, lastName)
	    {
	        SetMajor(major);
	    }
	
	    public Student(string firstName, string lastName) :
	        base(firstName, lastName)
	    {
	        SetMajor();
	    }
	
	    public Student()
	    {
	        SetMajor();
	    }
	
	    [MemberNotNull(nameof(Major))]
	    private void SetMajor(string? major = default)
	    {
	        Major = major ?? "Undeclared";
	    }
	}
	
	public struct Student2
	{
	    public string FirstName;
	    public string? MiddleName;
	    public string LastName;
	}
	
	public static class Program
	{
	    public static void PrintStudent(Student2 student)
	    {
	        Console.WriteLine($"First name: {student.FirstName.ToUpper()}");
	        Console.WriteLine($"Middle name: {student.MiddleName?.ToUpper()}");
	        Console.WriteLine($"Last name: {student.LastName.ToUpper()}");
	    }
	
	    public static void RunMain() => PrintStudent(default);
	}
	
	public struct S<T>
	{
	    public T Prop { get; set; }
	}
	
	public static class Program2
	{
	    public static void RunMain()
	    {
	        string s = default(S<string>).Prop;
	    }
	}
	
	public static class Program3
	{
	    public static void RunMain()
	    {
	        string[] values = new string[10];
	        string s = values[0];
	        Console.WriteLine(s.ToUpper());
			
			var a = new A(string.Empty);
	    }
	}
	
	public class A
	{
	    private string _name;
	    private B _b;
	
	    public A(string name)
	    {
	        ArgumentNullException.ThrowIfNullOrEmpty(name);
	        _name = name;
	        _b = new B();
	    }
	
	  ~A()
	  {
	      Dispose();
	  }
	
	  public void Dispose()
	  {
	      _b.Dispose();
	      GC.SuppressFinalize(this);
	  }
	}
	
	public class B: IDisposable
	{
	    public void Dispose() { }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/generate-consume-asynchronous-stream
namespace DotnetCSharpAsynchronousProgrammingGenerateConsumeAsynchronousStream
{
	public class GenerateConsumeAsynchronousStream
	{
		public static void RunGenerateConsumeAsynchronousStream()
		{
			/*
			finalResults.Merge(issues(results)["nodes"]!);
			progress?.Report(issuesReturned);
			cancel.ThrowIfCancellationRequested();
			
			foreach (JObject issue in issues(results)["nodes"]!)
    			yield return issue;
			*/
			
			/*
			var progressReporter = new progressStatus((num) =>
			{
			    Console.WriteLine($"Received {num} issues in total");
			});
			CancellationTokenSource cancellationSource = new CancellationTokenSource();
			
			try
			{
			    var results = await RunPagedQueryAsync(client, PagedIssueQuery, "docs",
			        cancellationSource.Token, progressReporter);
			    foreach(var issue in results)
			        Console.WriteLine(issue);
			}
			catch (OperationCanceledException)
			{
			    Console.WriteLine("Work has been cancelled");
			}
			*/
			
			/*
			int num = 0;
			await foreach (var issue in RunPagedQueryAsync(client, PagedIssueQuery, "docs"))
			{
			    Console.WriteLine(issue);
			    Console.WriteLine($"Received {++num} issues in total");
			}
			
			int num = 0;
			var enumerator = RunPagedQueryAsync(client, PagedIssueQuery, "docs").GetAsyncEnumerator();
			try
			{
			    while (await enumerator.MoveNextAsync())
			    {
			        var issue = enumerator.Current;
			        Console.WriteLine(issue);
			        Console.WriteLine($"Received {++num} issues in total");
			    }
			} finally
			{
			    if (enumerator != null)
			        await enumerator.DisposeAsync();
			}
			*/
		}
		/*
		static async Task RunMain(string[] args)
		{
		    //Follow these steps to create a GitHub Access Token
		    // https://help.github.com/articles/creating-a-personal-access-token-for-the-command-line/#creating-a-token
		    //Select the following permissions for your GitHub Access Token:
		    // - repo:status
		    // - public_repo
		    // Replace the 3rd parameter to the following code with your GitHub access token.
		    var key = GetEnvVariable("GitHubKey",
		    "You must store your GitHub key in the 'GitHubKey' environment variable",
		    "");
		
		    var client = new GitHubClient(new Octokit.ProductHeaderValue("IssueQueryDemo"))
		    {
		        Credentials = new Octokit.Credentials(key)
		    };
		
		    var progressReporter = new progressStatus((num) =>
		    {
		        Console.WriteLine($"Received {num} issues in total");
		    });
		    CancellationTokenSource cancellationSource = new CancellationTokenSource();
		
		    try
		    {
		        var results = await RunPagedQueryAsync(client, PagedIssueQuery, "docs",
		            cancellationSource.Token, progressReporter);
		        foreach(var issue in results)
		            Console.WriteLine(issue);
		    }
		    catch (OperationCanceledException)
		    {
		        Console.WriteLine("Work has been cancelled");
		    }
		}
		
		private static async Task<JArray> RunPagedQueryAsync(GitHubClient client, string queryText, string repoName, CancellationToken cancel, IProgress<int> progress)
		{
		    var issueAndPRQuery = new GraphQLRequest
		    {
		        Query = queryText
		    };
		    issueAndPRQuery.Variables["repo_name"] = repoName;
		
		    JArray finalResults = new JArray();
		    bool hasMorePages = true;
		    int pagesReturned = 0;
		    int issuesReturned = 0;
		
		    // Stop with 10 pages, because these are large repos:
		    while (hasMorePages && (pagesReturned++ < 10))
		    {
		        var postBody = issueAndPRQuery.ToJsonText();
		        var response = await client.Connection.Post<string>(new Uri("https://api.github.com/graphql"),
		            postBody, "application/json", "application/json");
		
		        JObject results = JObject.Parse(response.HttpResponse.Body.ToString()!);
		
		        int totalCount = (int)issues(results)["totalCount"]!;
		        hasMorePages = (bool)pageInfo(results)["hasPreviousPage"]!;
		        issueAndPRQuery.Variables["start_cursor"] = pageInfo(results)["startCursor"]!.ToString();
		        issuesReturned += issues(results)["nodes"]!.Count();
		        finalResults.Merge(issues(results)["nodes"]!);
		        progress?.Report(issuesReturned);
		        cancel.ThrowIfCancellationRequested();
		    }
		    return finalResults;
		
		    JObject issues(JObject result) => (JObject)result["data"]!["repository"]!["issues"]!;
		    JObject pageInfo(JObject result) => (JObject)issues(result)["pageInfo"]!;
		}
		*/
		
		/*
		private static async IAsyncEnumerable<JToken> RunPagedQueryAsync(GitHubClient client,
    		string queryText, string repoName)
		*/
		
		/*
		private static async IAsyncEnumerable<JToken> RunPagedQueryAsync(GitHubClient client,
		    string queryText, string repoName)
		{
		    var issueAndPRQuery = new GraphQLRequest
		    {
		        Query = queryText
		    };
		    issueAndPRQuery.Variables["repo_name"] = repoName;
		
		    bool hasMorePages = true;
		    int pagesReturned = 0;
		    int issuesReturned = 0;
		
		    // Stop with 10 pages, because these are large repos:
		    while (hasMorePages && (pagesReturned++ < 10))
		    {
		        var postBody = issueAndPRQuery.ToJsonText();
		        var response = await client.Connection.Post<string>(new Uri("https://api.github.com/graphql"),
		            postBody, "application/json", "application/json");
		
		        JObject results = JObject.Parse(response.HttpResponse.Body.ToString()!);
		
		        int totalCount = (int)issues(results)["totalCount"]!;
		        hasMorePages = (bool)pageInfo(results)["hasPreviousPage"]!;
		        issueAndPRQuery.Variables["start_cursor"] = pageInfo(results)["startCursor"]!.ToString();
		        issuesReturned += issues(results)["nodes"]!.Count();
		
		        foreach (JObject issue in issues(results)["nodes"]!)
		            yield return issue;
		    }
		
		    JObject issues(JObject result) => (JObject)result["data"]!["repository"]!["issues"]!;
		    JObject pageInfo(JObject result) => (JObject)issues(result)["pageInfo"]!;
		}
		*/
		
		/*
		private static async IAsyncEnumerable<JToken> RunPagedQueryAsync(GitHubClient client,
		    string queryText, string repoName, [EnumeratorCancellation] CancellationToken cancellationToken = default)
		{
		    var issueAndPRQuery = new GraphQLRequest
		    {
		        Query = queryText
		    };
		    issueAndPRQuery.Variables["repo_name"] = repoName;
		
		    bool hasMorePages = true;
		    int pagesReturned = 0;
		    int issuesReturned = 0;
		
		    // Stop with 10 pages, because these are large repos:
		    while (hasMorePages && (pagesReturned++ < 10))
		    {
		        var postBody = issueAndPRQuery.ToJsonText();
		        var response = await client.Connection.Post<string>(new Uri("https://api.github.com/graphql"),
		            postBody, "application/json", "application/json");
		
		        JObject results = JObject.Parse(response.HttpResponse.Body.ToString()!);
		
		        int totalCount = (int)issues(results)["totalCount"]!;
		        hasMorePages = (bool)pageInfo(results)["hasPreviousPage"]!;
		        issueAndPRQuery.Variables["start_cursor"] = pageInfo(results)["startCursor"]!.ToString();
		        issuesReturned += issues(results)["nodes"]!.Count();
		
		        foreach (JObject issue in issues(results)["nodes"]!)
		            yield return issue;
		    }
		
		    JObject issues(JObject result) => (JObject)result["data"]!["repository"]!["issues"]!;
		    JObject pageInfo(JObject result) => (JObject)issues(result)["pageInfo"]!;
		}
		*/
		
		/*
		private static async Task EnumerateWithCancellation(GitHubClient client)
		{
		    int num = 0;
		    var cancellation = new CancellationTokenSource();
		    await foreach (var issue in RunPagedQueryAsync(client, PagedIssueQuery, "docs")
		        .WithCancellation(cancellation.Token))
		    {
		        Console.WriteLine(issue);
		        Console.WriteLine($"Received {++num} issues in total");
		    }
		}
		*/
	}
	
	/*
	public class GraphQLRequest
	{
	    [JsonProperty("query")]
	    public string? Query { get; set; }
	
	    [JsonProperty("variables")]
	    public IDictionary<string, object> Variables { get; } = new Dictionary<string, object>();
	
	    public string ToJsonText() =>
	        JsonConvert.SerializeObject(this);
	}
	*/
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/cancel-async-tasks-after-a-period-of-time
namespace DotnetCSharpAsynchronousProgrammingCancelAsyncTasksAfterAPeriodOfTime
{
	public class CancelAsyncTasksAfterAPeriodOfTime
	{
		public static void RunCancelAsyncTasksAfterAPeriodOfTime()
		{
			
		}
		
		static async Task RunMain()
		{
		    Console.WriteLine("Application started.");
			/*
		    try
		    {
		        s_cts.CancelAfter(3500);
		
		        await SumPageSizesAsync();
		    }
		    catch (OperationCanceledException)
		    {
		        Console.WriteLine("\nTasks cancelled: timed out.\n");
		    }
		    finally
		    {
		        s_cts.Dispose();
		    }
			*/
		    Console.WriteLine("Application ending.");
		}
	}
	
	class Program
	{
	    static readonly CancellationTokenSource s_cts = new CancellationTokenSource();
	
	    static readonly HttpClient s_client = new HttpClient
	    {
	        MaxResponseContentBufferSize = 1_000_000
	    };
	
	    static readonly IEnumerable<string> s_urlList = new string[]
	    {
	            "https://learn.microsoft.com",
	            "https://learn.microsoft.com/aspnet/core",
	            "https://learn.microsoft.com/azure",
	            "https://learn.microsoft.com/azure/devops",
	            "https://learn.microsoft.com/dotnet",
	            "https://learn.microsoft.com/dynamics365",
	            "https://learn.microsoft.com/education",
	            "https://learn.microsoft.com/enterprise-mobility-security",
	            "https://learn.microsoft.com/gaming",
	            "https://learn.microsoft.com/graph",
	            "https://learn.microsoft.com/microsoft-365",
	            "https://learn.microsoft.com/office",
	            "https://learn.microsoft.com/powershell",
	            "https://learn.microsoft.com/sql",
	            "https://learn.microsoft.com/surface",
	            "https://learn.microsoft.com/system-center",
	            "https://learn.microsoft.com/visualstudio",
	            "https://learn.microsoft.com/windows",
	            "https://learn.microsoft.com/maui"
	    };
	
	    static async Task RunMain()
	    {
	        Console.WriteLine("Application started.");
	
	        try
	        {
	            s_cts.CancelAfter(3500);
	
	            await SumPageSizesAsync();
	        }
	        catch (OperationCanceledException)
	        {
	            Console.WriteLine("\nTasks cancelled: timed out.\n");
	        }
	        finally
	        {
	            s_cts.Dispose();
	        }
	
	        Console.WriteLine("Application ending.");
	    }
	
	    static async Task SumPageSizesAsync()
	    {
	        var stopwatch = Stopwatch.StartNew();
	
	        int total = 0;
	        foreach (string url in s_urlList)
	        {
	            int contentLength = await ProcessUrlAsync(url, s_client, s_cts.Token);
	            total += contentLength;
	        }
	
	        stopwatch.Stop();
	
	        Console.WriteLine($"\nTotal bytes returned:  {total:#,#}");
	        Console.WriteLine($"Elapsed time:          {stopwatch.Elapsed}\n");
	    }
	
	    static async Task<int> ProcessUrlAsync(string url, HttpClient client, CancellationToken token)
	    {
	        HttpResponseMessage response = await client.GetAsync(url, token);
	        byte[] content = await response.Content.ReadAsByteArrayAsync(token);
	        Console.WriteLine($"{url,-60} {content.Length,10:#,#}");
	
	        return content.Length;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/cancel-an-async-task-or-a-list-of-tasks
namespace DotnetCSharpAsynchronousProgrammingCancelAnAsyncTaskOrAListOfTasks
{
	public class AsyncTaskOrAListOfTasks
	{
		public static async Task RunAsyncTaskOrAListOfTasks()
		{
			int total = 0;
			foreach (string url in s_urlList)
			{
			    int contentLength = await ProcessUrlAsync(url, s_client, s_cts.Token);
			    total += contentLength;
			}
		}
		
		static readonly CancellationTokenSource s_cts = new CancellationTokenSource();

		static readonly HttpClient s_client = new HttpClient
		{
		    MaxResponseContentBufferSize = 1_000_000
		};
		
		static readonly IEnumerable<string> s_urlList = new string[]
		{
		    "https://learn.microsoft.com",
		    "https://learn.microsoft.com/aspnet/core",
		    "https://learn.microsoft.com/azure",
		    "https://learn.microsoft.com/azure/devops",
		    "https://learn.microsoft.com/dotnet",
		    "https://learn.microsoft.com/dynamics365",
		    "https://learn.microsoft.com/education",
		    "https://learn.microsoft.com/enterprise-mobility-security",
		    "https://learn.microsoft.com/gaming",
		    "https://learn.microsoft.com/graph",
		    "https://learn.microsoft.com/microsoft-365",
		    "https://learn.microsoft.com/office",
		    "https://learn.microsoft.com/powershell",
		    "https://learn.microsoft.com/sql",
		    "https://learn.microsoft.com/surface",
		    "https://learn.microsoft.com/system-center",
		    "https://learn.microsoft.com/visualstudio",
		    "https://learn.microsoft.com/windows",
		    "https://learn.microsoft.com/maui"
		};
		
		static async Task RunMain()
		{
		    Console.WriteLine("Application started.");
		    Console.WriteLine("Press the ENTER key to cancel...\n");
		
		    Task cancelTask = Task.Run(() =>
		    {
		        while (Console.ReadKey().Key != ConsoleKey.Enter)
		        {
		            Console.WriteLine("Press the ENTER key to cancel...");
		        }
		
		        Console.WriteLine("\nENTER key pressed: cancelling downloads.\n");
		        s_cts.Cancel();
		    });
		
		    Task sumPageSizesTask = SumPageSizesAsync();
		
		    Task finishedTask = await Task.WhenAny(new[] { cancelTask, sumPageSizesTask });
		    if (finishedTask == cancelTask)
		    {
		        // wait for the cancellation to take place:
		        try
		        {
		            await sumPageSizesTask;
		            Console.WriteLine("Download task completed before cancel request was processed.");
		        }
		        catch (TaskCanceledException)
		        {
		            Console.WriteLine("Download task has been cancelled.");
		        }
		    }
		
		    Console.WriteLine("Application ending.");
		}
		
		static async Task SumPageSizesAsync()
		{
		    var stopwatch = Stopwatch.StartNew();
		
		    int total = 0;
		    foreach (string url in s_urlList)
		    {
		        int contentLength = await ProcessUrlAsync(url, s_client, s_cts.Token);
		        total += contentLength;
		    }
		
		    stopwatch.Stop();
		
		    Console.WriteLine($"\nTotal bytes returned:  {total:#,#}");
		    Console.WriteLine($"Elapsed time:          {stopwatch.Elapsed}\n");
		}
		
		static async Task<int> ProcessUrlAsync(string url, HttpClient client, CancellationToken token)
		{
		    HttpResponseMessage response = await client.GetAsync(url, token);
		    byte[] content = await response.Content.ReadAsByteArrayAsync(token);
		    Console.WriteLine($"{url,-60} {content.Length,10:#,#}");
		
		    return content.Length;
		}
	}
	
	class Program
	{
	    static readonly CancellationTokenSource s_cts = new CancellationTokenSource();
	
	    static readonly HttpClient s_client = new HttpClient
	    {
	        MaxResponseContentBufferSize = 1_000_000
	    };
	
	    static readonly IEnumerable<string> s_urlList = new string[]
	    {
	            "https://learn.microsoft.com",
	            "https://learn.microsoft.com/aspnet/core",
	            "https://learn.microsoft.com/azure",
	            "https://learn.microsoft.com/azure/devops",
	            "https://learn.microsoft.com/dotnet",
	            "https://learn.microsoft.com/dynamics365",
	            "https://learn.microsoft.com/education",
	            "https://learn.microsoft.com/enterprise-mobility-security",
	            "https://learn.microsoft.com/gaming",
	            "https://learn.microsoft.com/graph",
	            "https://learn.microsoft.com/microsoft-365",
	            "https://learn.microsoft.com/office",
	            "https://learn.microsoft.com/powershell",
	            "https://learn.microsoft.com/sql",
	            "https://learn.microsoft.com/surface",
	            "https://learn.microsoft.com/system-center",
	            "https://learn.microsoft.com/visualstudio",
	            "https://learn.microsoft.com/windows",
	            "https://learn.microsoft.com/maui"
	    };
	
	    static async Task RunMain()
	    {
	        Console.WriteLine("Application started.");
	        Console.WriteLine("Press the ENTER key to cancel...\n");
	
	        Task cancelTask = Task.Run(() =>
	        {
	            while (Console.ReadKey().Key != ConsoleKey.Enter)
	            {
	                Console.WriteLine("Press the ENTER key to cancel...");
	            }
	
	            Console.WriteLine("\nENTER key pressed: cancelling downloads.\n");
	            s_cts.Cancel();
	        });
	
	        Task sumPageSizesTask = SumPageSizesAsync();
	
	        Task finishedTask = await Task.WhenAny(new[] { cancelTask, sumPageSizesTask });
	        if (finishedTask == cancelTask)
	        {
	            // wait for the cancellation to take place:
	            try
	            {
	                await sumPageSizesTask;
	                Console.WriteLine("Download task completed before cancel request was processed.");
	            }
	            catch (OperationCanceledException)
	            {
	                Console.WriteLine("Download task has been cancelled.");
	            }
	        }
	
	        Console.WriteLine("Application ending.");
	    }
	
	    static async Task SumPageSizesAsync()
	    {
	        var stopwatch = Stopwatch.StartNew();
	
	        int total = 0;
	        foreach (string url in s_urlList)
	        {
	            int contentLength = await ProcessUrlAsync(url, s_client, s_cts.Token);
	            total += contentLength;
	        }
	
	        stopwatch.Stop();
	
	        Console.WriteLine($"\nTotal bytes returned:  {total:#,#}");
	        Console.WriteLine($"Elapsed time:          {stopwatch.Elapsed}\n");
	    }
	
	    static async Task<int> ProcessUrlAsync(string url, HttpClient client, CancellationToken token)
	    {
	        HttpResponseMessage response = await client.GetAsync(url, token);
	        byte[] content = await response.Content.ReadAsByteArrayAsync(token);
	        Console.WriteLine($"{url,-60} {content.Length,10:#,#}");
	
	        return content.Length;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/using-async-for-file-access
namespace DotnetCSharpAsynchronousProgrammingUsingAsyncForFileAccess
{
	public class AsynchronousProgrammingUsingAsyncForFileAccess
	{
		public static void RunAsynchronousProgrammingUsingAsyncForFileAccess()
		{
			//Task theTask = sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
			//await theTask;
			
		}
		
		public async Task SimpleWriteAsync()
		{
		    string filePath = "simple.txt";
		    string text = $"Hello World";
		
		    await File.WriteAllTextAsync(filePath, text);
		}
		
		public async Task ProcessWriteAsync()
		{
		    string filePath = "temp.txt";
		    string text = $"Hello World{Environment.NewLine}";
		
		    await WriteTextAsync(filePath, text);
		}
		
		async Task WriteTextAsync(string filePath, string text)
		{
		    byte[] encodedText = Encoding.Unicode.GetBytes(text);
		
		    using var sourceStream =
		        new FileStream(
		            filePath,
		            FileMode.Create, FileAccess.Write, FileShare.None,
		            bufferSize: 4096, useAsync: true);
		
		    await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
		}
		
		public async Task SimpleReadAsync()
		{
		    string filePath = "simple.txt";
		    string text = await File.ReadAllTextAsync(filePath);
		
		    Console.WriteLine(text);
		}
		
		public async Task ProcessReadAsync()
		{
		    try
		    {
		        string filePath = "temp.txt";
		        if (File.Exists(filePath) != false)
		        {
		            string text = await ReadTextAsync(filePath);
		            Console.WriteLine(text);
		        }
		        else
		        {
		            Console.WriteLine($"file not found: {filePath}");
		        }
		    }
		    catch (Exception ex)
		    {
		        Console.WriteLine(ex.Message);
		    }
		}
		
		async Task<string> ReadTextAsync(string filePath)
		{
		    using var sourceStream =
		        new FileStream(
		            filePath,
		            FileMode.Open, FileAccess.Read, FileShare.Read,
		            bufferSize: 4096, useAsync: true);
		
		    var sb = new StringBuilder();
		
		    byte[] buffer = new byte[0x1000];
		    int numRead;
		    while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
		    {
		        string text = Encoding.Unicode.GetString(buffer, 0, numRead);
		        sb.Append(text);
		    }
		
		    return sb.ToString();
		}
		
		public async Task SimpleParallelWriteAsync()
		{
		    string folder = Directory.CreateDirectory("tempfolder").Name;
		    IList<Task> writeTaskList = new List<Task>();
		
		    for (int index = 11; index <= 20; ++ index)
		    {
		        string fileName = $"file-{index:00}.txt";
		        string filePath = $"{folder}/{fileName}";
		        string text = $"In file {index}{Environment.NewLine}";
		
		        writeTaskList.Add(File.WriteAllTextAsync(filePath, text));
		    }
		
		    await Task.WhenAll(writeTaskList);
		}
		
		public async Task ProcessMultipleWritesAsync()
		{
		    IList<FileStream> sourceStreams = new List<FileStream>();
		
		    try
		    {
		        string folder = Directory.CreateDirectory("tempfolder").Name;
		        IList<Task> writeTaskList = new List<Task>();
		
		        for (int index = 1; index <= 10; ++ index)
		        {
		            string fileName = $"file-{index:00}.txt";
		            string filePath = $"{folder}/{fileName}";
		
		            string text = $"In file {index}{Environment.NewLine}";
		            byte[] encodedText = Encoding.Unicode.GetBytes(text);
		
		            var sourceStream =
		                new FileStream(
		                    filePath,
		                    FileMode.Create, FileAccess.Write, FileShare.None,
		                    bufferSize: 4096, useAsync: true);
		
		            Task writeTask = sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
		            sourceStreams.Add(sourceStream);
		
		            writeTaskList.Add(writeTask);
		        }
		
		        await Task.WhenAll(writeTaskList);
		    }
		    finally
		    {
		        foreach (FileStream sourceStream in sourceStreams)
		        {
		            sourceStream.Close();
		        }
		    }
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/start-multiple-async-tasks-and-process-them-as-they-complete
namespace DotnetCSharpAsynchronousProgrammingStartMultipleAsyncTasksAndProcessThemAsTheyComplete
{
	public class StartMultipleAsyncTasksAndProcessThemAsTheyComplete
	{
		public static void RunStartMultipleAsyncTasksAndProcessThemAsTheyComplete()
		{
			
		}
	}
	
	class Program
	{
		/*
	    static void RunMain(string[] args)
	    {
	        Console.WriteLine("Hello World!");
			
			List<Task<int>> downloadTasks = downloadTasksQuery.ToList();
			
			Task<int> finishedTask = await Task.WhenAny(downloadTasks);
			
			downloadTasks.Remove(finishedTask);
			
			total += await finishedTask;
			
			while (downloadTasks.Any())
		    {
		        Task<int> finishedTask = await Task.WhenAny(downloadTasks);
		        downloadTasks.Remove(finishedTask);
		        total += await finishedTask;
		    }
			
			await foreach (Task<int> t in Task.WhenEach(downloadTasks))
		    {
		        total += await t;
		    }
			
			HttpClient s_client = new()
			{
			    MaxResponseContentBufferSize = 1_000_000
			};
			
			IEnumerable<string> s_urlList = new string[]
			{
			    "https://learn.microsoft.com",
			    "https://learn.microsoft.com/aspnet/core",
			    "https://learn.microsoft.com/azure",
			    "https://learn.microsoft.com/azure/devops",
			    "https://learn.microsoft.com/dotnet",
			    "https://learn.microsoft.com/dynamics365",
			    "https://learn.microsoft.com/education",
			    "https://learn.microsoft.com/enterprise-mobility-security",
			    "https://learn.microsoft.com/gaming",
			    "https://learn.microsoft.com/graph",
			    "https://learn.microsoft.com/microsoft-365",
			    "https://learn.microsoft.com/office",
			    "https://learn.microsoft.com/powershell",
			    "https://learn.microsoft.com/sql",
			    "https://learn.microsoft.com/surface",
			    "https://learn.microsoft.com/system-center",
			    "https://learn.microsoft.com/visualstudio",
			    "https://learn.microsoft.com/windows",
			    "https://learn.microsoft.com/maui"
			};
			
			await SumPageSizesAsync();
			
			
	    }
		*/
		
		static Task RunMain() => SumPageSizesAsync();
		
		static readonly HttpClient s_client = new HttpClient
		{
		    MaxResponseContentBufferSize = 1_000_000
		};
		
		static readonly IEnumerable<string> s_urlList = new string[]
		{
		    "https://learn.microsoft.com",
		    "https://learn.microsoft.com/aspnet/core",
		    "https://learn.microsoft.com/azure",
		    "https://learn.microsoft.com/azure/devops",
		    "https://learn.microsoft.com/dotnet",
		    "https://learn.microsoft.com/dynamics365",
		    "https://learn.microsoft.com/education",
		    "https://learn.microsoft.com/enterprise-mobility-security",
		    "https://learn.microsoft.com/gaming",
		    "https://learn.microsoft.com/graph",
		    "https://learn.microsoft.com/microsoft-365",
		    "https://learn.microsoft.com/office",
		    "https://learn.microsoft.com/powershell",
		    "https://learn.microsoft.com/sql",
		    "https://learn.microsoft.com/surface",
		    "https://learn.microsoft.com/system-center",
		    "https://learn.microsoft.com/visualstudio",
		    "https://learn.microsoft.com/windows",
		    "https://learn.microsoft.com/maui"
		};
		
		static async Task SumPageSizesAsync()
		{
		    var stopwatch = Stopwatch.StartNew();
		
		    IEnumerable<Task<int>> downloadTasksQuery =
		        from url in s_urlList
		        select ProcessUrlAsync(url, s_client);
		
		    List<Task<int>> downloadTasks = downloadTasksQuery.ToList();
		
		    int total = 0;
		    while (downloadTasks.Any())
		    {
		        Task<int> finishedTask = await Task.WhenAny(downloadTasks);
		        downloadTasks.Remove(finishedTask);
		        total += await finishedTask;
		    }
		
		    stopwatch.Stop();
		
		    Console.WriteLine($"\nTotal bytes returned:  {total:#,#}");
		    Console.WriteLine($"Elapsed time:          {stopwatch.Elapsed}\n");
		}
		
		IEnumerable<Task<int>> downloadTasksQuery =
		    from url in s_urlList
		    select ProcessUrlAsync(url, s_client);
			
		static async Task<int> ProcessUrlAsync(string url, HttpClient client)
		{
		    byte[] content = await client.GetByteArrayAsync(url);
		    Console.WriteLine($"{url,-60} {content.Length,10:#,#}");
		
		    return content.Length;
		}
		
		/*
		static async Task<int> ProcessUrlAsync(string url, HttpClient client)
		{
		    byte[] content = await client.GetByteArrayAsync(url);
		    Console.WriteLine($"{url,-60} {content.Length,10:#,#}");
		
		    return content.Length;
		}
		*/
		
		/*
		async Task SumPageSizesAsync()
		{
		    var stopwatch = Stopwatch.StartNew();
		
		    IEnumerable<Task<int>> downloadTasksQuery =
		        from url in s_urlList
		        select ProcessUrlAsync(url, s_client);
		
		    List<Task<int>> downloadTasks = downloadTasksQuery.ToList();
		
		    int total = 0;
		    while (downloadTasks.Any())
		    {
		        Task<int> finishedTask = await Task.WhenAny(downloadTasks);
		        downloadTasks.Remove(finishedTask);
		        total += await finishedTask;
		    }
		
		    stopwatch.Stop();
		
		    Console.WriteLine($"\nTotal bytes returned:    {total:#,#}");
		    Console.WriteLine($"Elapsed time:              {stopwatch.Elapsed}\n");
		}
		
		static async Task<int> ProcessUrlAsync(string url, HttpClient client)
		{
		    byte[] content = await client.GetByteArrayAsync(url);
		    Console.WriteLine($"{url,-60} {content.Length,10:#,#}");
		
		    return content.Length;
		}
		
		// Example output:
		// https://learn.microsoft.com                                      132,517
		// https://learn.microsoft.com/powershell                            57,375
		// https://learn.microsoft.com/gaming                                33,549
		// https://learn.microsoft.com/aspnet/core                           88,714
		// https://learn.microsoft.com/surface                               39,840
		// https://learn.microsoft.com/enterprise-mobility-security          30,903
		// https://learn.microsoft.com/microsoft-365                         67,867
		// https://learn.microsoft.com/windows                               26,816
		// https://learn.microsoft.com/maui                               57,958
		// https://learn.microsoft.com/dotnet                                78,706
		// https://learn.microsoft.com/graph                                 48,277
		// https://learn.microsoft.com/dynamics365                           49,042
		// https://learn.microsoft.com/office                                67,867
		// https://learn.microsoft.com/system-center                         42,887
		// https://learn.microsoft.com/education                             38,636
		// https://learn.microsoft.com/azure                                421,663
		// https://learn.microsoft.com/visualstudio                          30,925
		// https://learn.microsoft.com/sql                                   54,608
		// https://learn.microsoft.com/azure/devops                          86,034
		
		// Total bytes returned:    1,454,184
		// Elapsed time:            00:00:01.1290403
		*/
			
		
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/async-return-types
namespace DotnetCSharpAsynchronousProgrammingAsyncReturnTypes
{
	public class AsynchronousProgrammingAsyncReturnTypes
	{
		public static async Task RunAsynchronousProgrammingAsyncReturnTypes()
		{
			Task waitAndApologizeTask = WaitAndApologizeAsync();

			string output =
			    $"Today is {DateTime.Now:D}\n" +
			    $"The current time is {DateTime.Now.TimeOfDay:t}\n" +
			    "The current temperature is 76 degrees.\n";
			
			await waitAndApologizeTask;
			Console.WriteLine(output);
			
			var getLeisureHoursTask = GetLeisureHoursAsync();

			string message =
			    $"Today is {DateTime.Today:D}\n" +
			    "Today's hours of leisure: " +
			    $"{await getLeisureHoursTask}";
			
			Console.WriteLine(message);
			
		}
		
		public static async Task DisplayCurrentInfoAsync()
		{
		    await WaitAndApologizeAsync();
		
		    Console.WriteLine($"Today is {DateTime.Now:D}");
		    Console.WriteLine($"The current time is {DateTime.Now.TimeOfDay:t}");
		    Console.WriteLine("The current temperature is 76 degrees.");
		}
		
		static async Task WaitAndApologizeAsync()
		{
		    await Task.Delay(2000);
		
		    Console.WriteLine("Sorry for the delay...\n");
		}
		// Example output:
		//    Sorry for the delay...
		//
		// Today is Monday, August 17, 2020
		// The current time is 12:59:24.2183304
		// The current temperature is 76 degrees.
		
		public static async Task ShowTodaysInfoAsync()
		{
		    string message =
		        $"Today is {DateTime.Today:D}\n" +
		        "Today's hours of leisure: " +
		        $"{await GetLeisureHoursAsync()}";
		
		    Console.WriteLine(message);
		}
		
		static async Task<int> GetLeisureHoursAsync()
		{
		    DayOfWeek today = await Task.FromResult(DateTime.Now.DayOfWeek);
		
		    int leisureHours =
		        today is DayOfWeek.Saturday || today is DayOfWeek.Sunday
		        ? 16 : 5;
		
		    return leisureHours;
		}
		// Example output:
		//    Today is Wednesday, May 24, 2017
		//    Today's hours of leisure: 5
	}
	
	public class NaiveButton
	{
	    public event EventHandler? Clicked;
	
	    public void Click()
	    {
	        Console.WriteLine("Somebody has clicked a button. Let's raise the event...");
	        Clicked?.Invoke(this, EventArgs.Empty);
	        Console.WriteLine("All listeners are notified.");
	    }
	}
	
	public class AsyncVoidExample
	{
	    static readonly TaskCompletionSource<bool> s_tcs = new TaskCompletionSource<bool>();
	
	    public static async Task MultipleEventHandlersAsync()
	    {
	        Task<bool> secondHandlerFinished = s_tcs.Task;
	
	        var button = new NaiveButton();
	
	        button.Clicked += OnButtonClicked1;
	        button.Clicked += OnButtonClicked2Async;
	        button.Clicked += OnButtonClicked3;
	
	        Console.WriteLine("Before button.Click() is called...");
	        button.Click();
	        Console.WriteLine("After button.Click() is called...");
	
	        await secondHandlerFinished;
	    }
	
	    private static void OnButtonClicked1(object? sender, EventArgs e)
	    {
	        Console.WriteLine("   Handler 1 is starting...");
	        Task.Delay(100).Wait();
	        Console.WriteLine("   Handler 1 is done.");
	    }
	
	    private static async void OnButtonClicked2Async(object? sender, EventArgs e)
	    {
	        Console.WriteLine("   Handler 2 is starting...");
	        Task.Delay(100).Wait();
	        Console.WriteLine("   Handler 2 is about to go async...");
	        await Task.Delay(500);
	        Console.WriteLine("   Handler 2 is done.");
	        s_tcs.SetResult(true);
	    }
	
	    private static void OnButtonClicked3(object? sender, EventArgs e)
	    {
	        Console.WriteLine("   Handler 3 is starting...");
	        Task.Delay(100).Wait();
	        Console.WriteLine("   Handler 3 is done.");
	    }
	}
	// Example output:
	//
	// Before button.Click() is called...
	// Somebody has clicked a button. Let's raise the event...
	//    Handler 1 is starting...
	//    Handler 1 is done.
	//    Handler 2 is starting...
	//    Handler 2 is about to go async...
	//    Handler 3 is starting...
	//    Handler 3 is done.
	// All listeners are notified.
	// After button.Click() is called...
	//    Handler 2 is done.
	
	class Program
	{
	    static readonly Random s_rnd = new Random();
	
	    static async Task RunMain() =>
	        Console.WriteLine($"You rolled {await GetDiceRollAsync()}");
	
	    static async ValueTask<int> GetDiceRollAsync()
	    {
	        Console.WriteLine("Shaking dice...");
	
	        int roll1 = await RollAsync();
	        int roll2 = await RollAsync();
	
	        return roll1 + roll2;
	    }
	
	    static async ValueTask<int> RollAsync()
	    {
	        await Task.Delay(500);
	
	        int diceRoll = s_rnd.Next(1, 7);
	        return diceRoll;
	    }
		
		static async IAsyncEnumerable<string> ReadWordsFromStreamAsync()
		{
		    string data =
		        @"This is a line of text.
		              Here is the second line of text.
		              And there is one more for good measure.
		              Wait, that was the penultimate line.";
		
		    using var readStream = new StringReader(data);
		
		    string? line = await readStream.ReadLineAsync();
		    while (line != null)
		    {
		        foreach (string word in line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
		        {
		            yield return word;
		        }
		
		        line = await readStream.ReadLineAsync();
		    }
		}
	}
	// Example output:
	//    Shaking dice...
	//    You rolled 8
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/task-asynchronous-programming-model
namespace DotnetCSharpAsynchronousProgrammingTaskAsynchronousProgrammingModel
{
	public class AsynchronousProgrammingModel
	{
		public static void RunAsynchronousProgrammingModel()
		{
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/task-asynchronous-programming-model
namespace DotnetCSharpAsynchronousProgrammingTaskAsynchronousProgrammingModel
{
	public class AsynchronousProgrammingModel2
	{
		public static async Task RunAsynchronousProgrammingModel()
		{
			Task<int> returnedTaskTResult = GetTaskOfTResultAsync();
			int intResult = await returnedTaskTResult;
			// Single line
			// int intResult = await GetTaskOfTResultAsync();
			
			async Task GetTaskAsync()
			{
			    await Task.Delay(0);
			    // No return statement needed
			}
			
			Task returnedTask = GetTaskAsync();
			await returnedTask;
			// Single line
			await GetTaskAsync();
		}
		public async Task<int> GetUrlContentLengthAsync()
		{
		    using var client = new HttpClient();
		
		    Task<string> getStringTask =
		        client.GetStringAsync("https://learn.microsoft.com/dotnet");
		
		    DoIndependentWork();
		
		    string contents = await getStringTask;
			//string contents = await client.GetStringAsync("https://learn.microsoft.com/dotnet");
		
		    return contents.Length;
		}
		
		void DoIndependentWork()
		{
		    Console.WriteLine("Working...");
		}
		
		static async Task<int> GetTaskOfTResultAsync()
		{
		    int hours = 0;
		    await Task.Delay(0);
		
		    return hours;
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/async-scenarios
namespace DotnetCSharpAsynchronousProgrammingAsyncScenarios
{
	public class AsyncScenarios
	{
		public static void RunAsyncScenarios()
		{
			// When you cannot use await
			//Task<string> task = GetDataAsync();
			//string result = task.GetAwaiter().GetResult();
			
			// Offload to thread pool to avoid context deadlocks
			//string result = Task.Run(async () => await GetDataAsync()).GetAwaiter().GetResult();
			
			//Task<string> task = GetDataAsync();
			//task.Wait();
			//string result = task.Result;
			
			
			
		}
		
		/*
		s_downloadButton.Clicked += async (o, e) =>
		{
		    // This line will yield control to the UI as the request
		    // from the web service is happening.
		    //
		    // The UI thread is now free to perform other work.
		    var stringData = await s_httpClient.GetStringAsync(URL);
		    DoSomethingWithData(stringData);
		};
		*/
		/*
		static DamageResult CalculateDamageDone()
		{
		    return new DamageResult()
		    {
		        // Code omitted:
		        //
		        // Does an expensive calculation and returns
		        // the result of that calculation.
		    };
		}
		
		s_calculateButton.Clicked += async (o, e) =>
		{
		    // This line will yield control to the UI while CalculateDamageDone()
		    // performs its work. The UI thread is free to perform other work.
		    var damageResult = await Task.Run(() => CalculateDamageDone());
		    DisplayDamage(damageResult);
		};
		*/
		
		/*
		[HttpGet, Route("DotNetCount")]
		static public async Task<int> GetDotNetCountAsync(string URL)
		{
		    // Suspends GetDotNetCountAsync() to allow the caller (the web server)
		    // to accept another request, rather than blocking on this one.
		    var html = await s_httpClient.GetStringAsync(URL);
		    return Regex.Matches(html, @"\.NET").Count;
		}
		*/
		
		/*
		private readonly HttpClient _httpClient = new HttpClient();

		private async void OnSeeTheDotNetsButtonClick(object sender, RoutedEventArgs e)
		{
		    // Capture the task handle here so we can await the background task later.
		    var getDotNetFoundationHtmlTask = _httpClient.GetStringAsync("https://dotnetfoundation.org");
		
		    // Any other work on the UI thread can be done here, such as enabling a Progress Bar.
		    // It's important to do the extra work here before the "await" call,
		    // so the user sees the progress bar before execution of this method is yielded.
		    NetworkProgressBar.IsEnabled = true;
		    NetworkProgressBar.Visibility = Visibility.Visible;
		
		    // The await operator suspends OnSeeTheDotNetsButtonClick(), returning control to its caller.
		    // This action is what allows the app to be responsive and not block the UI thread.
		    var html = await getDotNetFoundationHtmlTask;
		    int count = Regex.Matches(html, @"\.NET").Count;
		
		    DotNetCountLabel.Text = $"Number of .NETs on dotnetfoundation.org: {count}";
		
		    NetworkProgressBar.IsEnabled = false;
		    NetworkProgressBar.Visibility = Visibility.Collapsed;
		}
		*/
		
		/*
		private static async Task<User> GetUserAsync(int userId)
		{
		    // Code omitted:
		    //
		    // Given a user Id {userId}, retrieves a User object corresponding
		    // to the entry in the database with {userId} as its Id.
		
		    return await Task.FromResult(new User() { id = userId });
		}
		
		private static async Task<IEnumerable<User>> GetUsersAsync(IEnumerable<int> userIds)
		{
		    var getUserTasks = new List<Task<User>>();
		    foreach (int userId in userIds)
		    {
		        getUserTasks.Add(GetUserAsync(userId));
		    }
		
		    return await Task.WhenAll(getUserTasks);
		}
		*/
		
		/*
		private static async Task<User[]> GetUsersByLINQAsync(IEnumerable<int> userIds)
		{
		    var getUserTasks = userIds.Select(id => GetUserAsync(id)).ToArray();
		    return await Task.WhenAll(getUserTasks);
		}
		*/
		
		/*
		private static async Task ProcessTasksAsTheyCompleteAsync(IEnumerable<int> userIds)
		{
		    var getUserTasks = userIds.Select(id => GetUserAsync(id)).ToList();
		    
		    while (getUserTasks.Count > 0)
		    {
		        Task<User> completedTask = await Task.WhenAny(getUserTasks);
		        getUserTasks.Remove(completedTask);
		        
		        User user = await completedTask;
		        Console.WriteLine($"Processed user {user.id}");
		    }
		}
		*/
		
		
	}
	
	class Button
	{
	    public Func<object, object, Task>? Clicked
	    {
	        get;
	        internal set;
	    }
	}
	
	class DamageResult
	{
	    public int Damage
	    {
	        get { return 0; }
	    }
	}
	
	class User
	{
	    public bool isEnabled
	    {
	        get;
	        set;
	    }
	
	    public int id
	    {
	        get;
	        set;
	    }
	}
	
	/*
	public class Program
	{
	    private static readonly Button s_downloadButton = new();
	    private static readonly Button s_calculateButton = new();
	
	    private static readonly HttpClient s_httpClient = new();
	
	    private static readonly IEnumerable<string> s_urlList = new string[]
	    {
	            "https://learn.microsoft.com",
	            "https://learn.microsoft.com/aspnet/core",
	            "https://learn.microsoft.com/azure",
	            "https://learn.microsoft.com/azure/devops",
	            "https://learn.microsoft.com/dotnet",
	            "https://learn.microsoft.com/dotnet/desktop/wpf/get-started/create-app-visual-studio",
	            "https://learn.microsoft.com/education",
	            "https://learn.microsoft.com/shows/net-core-101/what-is-net",
	            "https://learn.microsoft.com/enterprise-mobility-security",
	            "https://learn.microsoft.com/gaming",
	            "https://learn.microsoft.com/graph",
	            "https://learn.microsoft.com/microsoft-365",
	            "https://learn.microsoft.com/office",
	            "https://learn.microsoft.com/powershell",
	            "https://learn.microsoft.com/sql",
	            "https://learn.microsoft.com/surface",
	            "https://dotnetfoundation.org",
	            "https://learn.microsoft.com/visualstudio",
	            "https://learn.microsoft.com/windows",
	            "https://learn.microsoft.com/maui"
	    };
	
	    private static void Calculate()
	    {
	        static DamageResult CalculateDamageDone()
	        {
	            return new DamageResult()
	            {
	                // Code omitted:
	                //
	                // Does an expensive calculation and returns
	                // the result of that calculation.
	            };
	        }
	
	        s_calculateButton.Clicked += async (o, e) =>
	        {
	            // This line will yield control to the UI while CalculateDamageDone()
	            // performs its work. The UI thread is free to perform other work.
	            var damageResult = await Task.Run(() => CalculateDamageDone());
	            DisplayDamage(damageResult);
	        };
	    }
	
	    private static void DisplayDamage(DamageResult damage)
	    {
	        Console.WriteLine(damage.Damage);
	    }
	
	    private static void Download(string URL)
	    {
	        s_downloadButton.Clicked += async (o, e) =>
	        {
	            // This line will yield control to the UI as the request
	            // from the web service is happening.
	            //
	            // The UI thread is now free to perform other work.
	            var stringData = await s_httpClient.GetStringAsync(URL);
	            DoSomethingWithData(stringData);
	        };
	    }
	
	    private static void DoSomethingWithData(object stringData)
	    {
	        Console.WriteLine($"Displaying data: {stringData}");
	    }
	
	    private static async Task<User> GetUserAsync(int userId)
	    {
	        // Code omitted:
	        //
	        // Given a user Id {userId}, retrieves a User object corresponding
	        // to the entry in the database with {userId} as its Id.
	
	        return await Task.FromResult(new User() { id = userId });
	    }
	
	    private static async Task<IEnumerable<User>> GetUsersAsync(IEnumerable<int> userIds)
	    {
	        var getUserTasks = new List<Task<User>>();
	        foreach (int userId in userIds)
	        {
	            getUserTasks.Add(GetUserAsync(userId));
	        }
	
	        return await Task.WhenAll(getUserTasks);
	    }
	
	    private static async Task<User[]> GetUsersByLINQAsync(IEnumerable<int> userIds)
	    {
	        var getUserTasks = userIds.Select(id => GetUserAsync(id)).ToArray();
	        return await Task.WhenAll(getUserTasks);
	    }
	
	    private static async Task ProcessTasksAsTheyCompleteAsync(IEnumerable<int> userIds)
	    {
	        var getUserTasks = userIds.Select(id => GetUserAsync(id)).ToList();
	        
	        while (getUserTasks.Count > 0)
	        {
	            Task<User> completedTask = await Task.WhenAny(getUserTasks);
	            getUserTasks.Remove(completedTask);
	            
	            User user = await completedTask;
	            Console.WriteLine($"Processed user {user.id}");
	        }
	    }
	
	    [HttpGet, Route("DotNetCount")]
	    static public async Task<int> GetDotNetCountAsync(string URL)
	    {
	        // Suspends GetDotNetCountAsync() to allow the caller (the web server)
	        // to accept another request, rather than blocking on this one.
	        var html = await s_httpClient.GetStringAsync(URL);
	        return Regex.Matches(html, @"\.NET").Count;
	    }
	
	    static async Task Main()
	    {
	        Console.WriteLine("Application started.");
	
	        Console.WriteLine("Counting '.NET' phrase in websites...");
	        int total = 0;
	        foreach (string url in s_urlList)
	        {
	            var result = await GetDotNetCountAsync(url);
	            Console.WriteLine($"{url}: {result}");
	            total += result;
	        }
	        Console.WriteLine("Total: " + total);
	
	        Console.WriteLine("Retrieving User objects with list of IDs...");
	        IEnumerable<int> ids = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
	        var users = await GetUsersAsync(ids);
	        foreach (User? user in users)
	        {
	            Console.WriteLine($"{user.id}: isEnabled={user.isEnabled}");
	        }
	
	        Console.WriteLine("Processing tasks as they complete...");
	        await ProcessTasksAsTheyCompleteAsync(ids);
	
	        Console.WriteLine("Application ending.");
	    }
	}
	*/
	
	// Example output:
	//
	// Application started.
	// Counting '.NET' phrase in websites...
	// https://learn.microsoft.com: 0
	// https://learn.microsoft.com/aspnet/core: 57
	// https://learn.microsoft.com/azure: 1
	// https://learn.microsoft.com/azure/devops: 2
	// https://learn.microsoft.com/dotnet: 83
	// https://learn.microsoft.com/dotnet/desktop/wpf/get-started/create-app-visual-studio: 31
	// https://learn.microsoft.com/education: 0
	// https://learn.microsoft.com/shows/net-core-101/what-is-net: 42
	// https://learn.microsoft.com/enterprise-mobility-security: 0
	// https://learn.microsoft.com/gaming: 0
	// https://learn.microsoft.com/graph: 0
	// https://learn.microsoft.com/microsoft-365: 0
	// https://learn.microsoft.com/office: 0
	// https://learn.microsoft.com/powershell: 0
	// https://learn.microsoft.com/sql: 0
	// https://learn.microsoft.com/surface: 0
	// https://dotnetfoundation.org: 16
	// https://learn.microsoft.com/visualstudio: 0
	// https://learn.microsoft.com/windows: 0
	// https://learn.microsoft.com/maui: 6
	// Total: 238
	// Retrieving User objects with list of IDs...
	// 1: isEnabled= False
	// 2: isEnabled= False
	// 3: isEnabled= False
	// 4: isEnabled= False
	// 5: isEnabled= False
	// 6: isEnabled= False
	// 7: isEnabled= False
	// 8: isEnabled= False
	// 9: isEnabled= False
	// 0: isEnabled= False
	// Application ending.
}

//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/
namespace DotnetCSharpAsynchronousProgramming
{
	namespace AsyncBreakfast
	{
	    // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
	    internal class HashBrown { }
	    internal class Coffee { }
	    internal class Egg { }
	    internal class Juice { }
	    internal class Toast { }
	
	    class Program
	    {
	        static void RunProgram(string[] args)
	        {
	            Coffee cup = PourCoffee();
	            Console.WriteLine("coffee is ready");
	
	            Egg eggs = FryEggs(2);
	            Console.WriteLine("eggs are ready");
	
	            HashBrown hashBrown = FryHashBrowns(3);
	            Console.WriteLine("hash browns are ready");
	
	            Toast toast = ToastBread(2);
	            ApplyButter(toast);
	            ApplyJam(toast);
	            Console.WriteLine("toast is ready");
	
	            Juice oj = PourOJ();
	            Console.WriteLine("oj is ready");
	            Console.WriteLine("Breakfast is ready!");
	        }
	
	        private static Juice PourOJ()
	        {
	            Console.WriteLine("Pouring orange juice");
	            return new Juice();
	        }
	
	        private static void ApplyJam(Toast toast) =>
	            Console.WriteLine("Putting jam on the toast");
	
	        private static void ApplyButter(Toast toast) =>
	            Console.WriteLine("Putting butter on the toast");
	
	        private static Toast ToastBread(int slices)
	        {
	            for (int slice = 0; slice < slices; slice++)
	            {
	                Console.WriteLine("Putting a slice of bread in the toaster");
	            }
	            Console.WriteLine("Start toasting...");
	            Task.Delay(3000).Wait();
	            Console.WriteLine("Remove toast from toaster");
	
	            return new Toast();
	        }
	
	        private static HashBrown FryHashBrowns(int patties)
	        {
	            Console.WriteLine($"putting {patties} hash brown patties in the pan");
	            Console.WriteLine("cooking first side of hash browns...");
	            Task.Delay(3000).Wait();
	            for (int patty = 0; patty < patties; patty++)
	            {
	                Console.WriteLine("flipping a hash brown patty");
	            }
	            Console.WriteLine("cooking the second side of hash browns...");
	            Task.Delay(3000).Wait();
	            Console.WriteLine("Put hash browns on plate");
	
	            return new HashBrown();
	        }
	
	        private static Egg FryEggs(int howMany)
	        {
	            Console.WriteLine("Warming the egg pan...");
	            Task.Delay(3000).Wait();
	            Console.WriteLine($"cracking {howMany} eggs");
	            Console.WriteLine("cooking the eggs ...");
	            Task.Delay(3000).Wait();
	            Console.WriteLine("Put eggs on plate");
	
	            return new Egg();
	        }
	
	        private static Coffee PourCoffee()
	        {
	            Console.WriteLine("Pouring coffee");
	            return new Coffee();
	        }
			
			
			static async Task RunMain(string[] args)
			{
			    Coffee cup = PourCoffee();
			    Console.WriteLine("coffee is ready");
				/*
			    Egg eggs = await FryEggsAsync(2);
			    Console.WriteLine("eggs are ready");
			
			    HashBrown hashBrown = await FryHashBrownsAsync(3);
			    Console.WriteLine("hash browns are ready");
			
			    Toast toast = await ToastBreadAsync(2);
			    ApplyButter(toast);
			    ApplyJam(toast);
			    Console.WriteLine("toast is ready");
				*/
			    Juice oj = PourOJ();
			    Console.WriteLine("oj is ready");
			    Console.WriteLine("Breakfast is ready!");
				/*
				Coffee cup = PourCoffee();
				Console.WriteLine("Coffee is ready");
				
				Task<Egg> eggsTask = FryEggsAsync(2);
				Egg eggs = await eggsTask;
				Console.WriteLine("Eggs are ready");
				
				Task<HashBrown> hashBrownTask = FryHashBrownsAsync(3);
				HashBrown hashBrown = await hashBrownTask;
				Console.WriteLine("Hash browns are ready");
				
				Task<Toast> toastTask = ToastBreadAsync(2);
				Toast toast = await toastTask;
				ApplyButter(toast);
				ApplyJam(toast);
				Console.WriteLine("Toast is ready");
				
				Juice oj = PourOJ();
				Console.WriteLine("Oj is ready");
				Console.WriteLine("Breakfast is ready!");
				*/
				/*
				Coffee cup = PourCoffee();
				Console.WriteLine("Coffee is ready");
				
				Task<Egg> eggsTask = FryEggsAsync(2);
				Task<HashBrown> hashBrownTask = FryHashBrownsAsync(3);
				Task<Toast> toastTask = ToastBreadAsync(2);
				
				Toast toast = await toastTask;
				ApplyButter(toast);
				ApplyJam(toast);
				Console.WriteLine("Toast is ready");
				Juice oj = PourOJ();
				Console.WriteLine("Oj is ready");
				
				Egg eggs = await eggsTask;
				Console.WriteLine("Eggs are ready");
				HashBrown hashBrown = await hashBrownTask;
				Console.WriteLine("Hash browns are ready");
				
				Console.WriteLine("Breakfast is ready!");
				*/
				
				Console.WriteLine("Fire! Toast is ruined!");
				//throw new InvalidOperationException("The toaster is on fire");
				
				//await Task.WhenAll(eggsTask, hashBrownTask, toastTask);
				Console.WriteLine("Eggs are ready");
				Console.WriteLine("Hash browns are ready");
				Console.WriteLine("Toast is ready");
				Console.WriteLine("Breakfast is ready!");
				/*
				var breakfastTasks = new List<Task> { eggsTask, hashBrownTask, toastTask };
				while (breakfastTasks.Count > 0)
				{
				    Task finishedTask = await Task.WhenAny(breakfastTasks);
				    if (finishedTask == eggsTask)
				    {
				        Console.WriteLine("Eggs are ready");
				    }
				    else if (finishedTask == hashBrownTask)
				    {
				        Console.WriteLine("Hash browns are ready");
				    }
				    else if (finishedTask == toastTask)
				    {
				        Console.WriteLine("Toast is ready");
				    }
				    await finishedTask;
				    breakfastTasks.Remove(finishedTask);
				}
				*/
				
				
			}
			
			/*
			static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
			{
			    var toast = await ToastBreadAsync(number);
			    ApplyButter(toast);
			    ApplyJam(toast);
			
			    return toast;
			}
			*/
			/*
			static async Task Main(string[] args)
			{
			    Coffee cup = PourCoffee();
			    Console.WriteLine("coffee is ready");
			
			    var eggsTask = FryEggsAsync(2);
			    var hashBrownTask = FryHashBrownsAsync(3);
			    var toastTask = MakeToastWithButterAndJamAsync(2);
			
			    var eggs = await eggsTask;
			    Console.WriteLine("eggs are ready");
			
			    var hashBrown = await hashBrownTask;
			    Console.WriteLine("hash browns are ready");
			
			    var toast = await toastTask;
			    Console.WriteLine("toast is ready");
			
			    Juice oj = PourOJ();
			    Console.WriteLine("oj is ready");
			    Console.WriteLine("Breakfast is ready!");
			}
			*/
			
			private static async Task<Toast> ToastBreadAsync(int slices)
			{
			    for (int slice = 0; slice < slices; slice++)
			    {
			        Console.WriteLine("Putting a slice of bread in the toaster");
			    }
			    Console.WriteLine("Start toasting...");
			    await Task.Delay(2000);
			    Console.WriteLine("Fire! Toast is ruined!");
			    throw new InvalidOperationException("The toaster is on fire");
			    await Task.Delay(1000);
			    Console.WriteLine("Remove toast from toaster");
			
			    return new Toast();
			}
	    }
	}
	
	namespace AsyncBreakfast
	{
	
	    class AsyncBreakfast
	    {
	        static async Task RunMain(string[] args)
	        {
	            Coffee cup = PourCoffee();
	            Console.WriteLine("coffee is ready");
	
	            var eggsTask = FryEggsAsync(2);
	            var hashBrownTask = FryHashBrownsAsync(3);
	            var toastTask = MakeToastWithButterAndJamAsync(2);
	
	            var breakfastTasks = new List<Task> { eggsTask, hashBrownTask, toastTask };
	            while (breakfastTasks.Count > 0)
	            {
	                Task finishedTask = await Task.WhenAny(breakfastTasks);
	                if (finishedTask == eggsTask)
	                {
	                    Console.WriteLine("eggs are ready");
	                }
	                else if (finishedTask == hashBrownTask)
	                {
	                    Console.WriteLine("hash browns are ready");
	                }
	                else if (finishedTask == toastTask)
	                {
	                    Console.WriteLine("toast is ready");
	                }
	                await finishedTask;
	                breakfastTasks.Remove(finishedTask);
	            }
	
	            Juice oj = PourOJ();
	            Console.WriteLine("oj is ready");
	            Console.WriteLine("Breakfast is ready!");
	        }
	
	        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
	        {
	            var toast = await ToastBreadAsync(number);
	            ApplyButter(toast);
	            ApplyJam(toast);
	
	            return toast;
	        }
	
	        private static Juice PourOJ()
	        {
	            Console.WriteLine("Pouring orange juice");
	            return new Juice();
	        }
	
	        private static void ApplyJam(Toast toast) =>
	            Console.WriteLine("Putting jam on the toast");
	
	        private static void ApplyButter(Toast toast) =>
	            Console.WriteLine("Putting butter on the toast");
	
	        private static async Task<Toast> ToastBreadAsync(int slices)
	        {
	            for (int slice = 0; slice < slices; slice++)
	            {
	                Console.WriteLine("Putting a slice of bread in the toaster");
	            }
	            Console.WriteLine("Start toasting...");
	            await Task.Delay(3000);
	            Console.WriteLine("Remove toast from toaster");
	
	            return new Toast();
	        }
	
	        private static async Task<HashBrown> FryHashBrownsAsync(int patties)
	        {
	            Console.WriteLine($"putting {patties} hash brown patties in the pan");
	            Console.WriteLine("cooking first side of hash browns...");
	            await Task.Delay(3000);
	            for (int patty = 0; patty < patties; patty++)
	            {
	                Console.WriteLine("flipping a hash brown patty");
	            }
	            Console.WriteLine("cooking the second side of hash browns...");
	            await Task.Delay(3000);
	            Console.WriteLine("Put hash browns on plate");
	
	            return new HashBrown();
	        }
	
	        private static async Task<Egg> FryEggsAsync(int howMany)
	        {
	            Console.WriteLine("Warming the egg pan...");
	            await Task.Delay(3000);
	            Console.WriteLine($"cracking {howMany} eggs");
	            Console.WriteLine("cooking the eggs ...");
	            await Task.Delay(3000);
	            Console.WriteLine("Put eggs on plate");
	
	            return new Egg();
	        }
	
	        private static Coffee PourCoffee()
	        {
	            Console.WriteLine("Pouring coffee");
	            return new Coffee();
	        }
			
			// Using ContinueWith - demonstrates the complexity when chaining operations
			/*
			static Task MakeBreakfastWithContinueWith()
			{
			    return StartCookingEggsAsync()
			        .ContinueWith(eggsTask =>
			        {
			            var eggs = eggsTask.Result;
			            Console.WriteLine("Eggs ready, starting bacon...");
			            return StartCookingBaconAsync();
			        })
			        .Unwrap()
			        .ContinueWith(baconTask =>
			        {
			            var bacon = baconTask.Result;
			            Console.WriteLine("Bacon ready, starting toast...");
			            return StartToastingBreadAsync();
			        })
			        .Unwrap()
			        .ContinueWith(toastTask =>
			        {
			            var toast = toastTask.Result;
			            Console.WriteLine("Toast ready, applying butter...");
			            return ApplyButterAsync(toast);
			        })
			        .Unwrap()
			        .ContinueWith(butteredToastTask =>
			        {
			            var butteredToast = butteredToastTask.Result;
			            Console.WriteLine("Butter applied, applying jam...");
			            return ApplyJamAsync(butteredToast);
			        })
			        .Unwrap()
			        .ContinueWith(finalToastTask =>
			        {
			            var finalToast = finalToastTask.Result;
			            Console.WriteLine("Breakfast completed with ContinueWith!");
			        });
			}
			*/
			
			// Using async/await - much cleaner and easier to read
			/*
			static async Task MakeBreakfastWithAsyncAwait()
			{
			    var eggs = await StartCookingEggsAsync();
			    Console.WriteLine("Eggs ready, starting bacon...");
			    
			    var bacon = await StartCookingBaconAsync();
			    Console.WriteLine("Bacon ready, starting toast...");
			    
			    var toast = await StartToastingBreadAsync();
			    Console.WriteLine("Toast ready, applying butter...");
			    
			    var butteredToast = await ApplyButterAsync(toast);
			    Console.WriteLine("Butter applied, applying jam...");
			    
			    var finalToast = await ApplyJamAsync(butteredToast);
			    Console.WriteLine("Breakfast completed with async/await!");
			}
			*/
	    }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/how-to-build-dynamic-queries
namespace DotnetCSharpLinqHowToBuildDynamicQueries
{
	public class DynamicQueries
	{
		public static void RunDynamicQueries()
		{
			string[] companyNames = [
			    "Consolidated Messenger", "Alpine Ski House", "Southridge Video",
			    "City Power & Light", "Coho Winery", "Wide World Importers",
			    "Graphic Design Institute", "Adventure Works", "Humongous Insurance",
			    "Woodgrove Bank", "Margie's Travel", "Northwind Traders",
			    "Blue Yonder Airlines", "Trey Research", "The Phone Company",
			    "Wingtip Toys", "Lucerne Publishing", "Fourth Coffee"
			];
			
			// Use an in-memory array as the data source, but the IQueryable could have come
			// from anywhere -- an ORM backed by a database, a web request, or any other LINQ provider.
			IQueryable<string> companyNamesSource = companyNames.AsQueryable();
			var fixedQry = companyNames.OrderBy(x => x);
			
			var length = 1;
			var qry = companyNamesSource
			    .Select(x => x.Substring(0, length))
			    .Distinct();
			
			Console.WriteLine(string.Join(",", qry));
			// prints: C, A, S, W, G, H, M, N, B, T, L, F
			
			length = 2;
			Console.WriteLine(string.Join(",", qry));
			// prints: Co, Al, So, Ci, Wi, Gr, Ad, Hu, Wo, Ma, No, Bl, Tr, Th, Lu, Fo
			
			// bool sortByLength = /* ... */;
			/*
			var qry = companyNamesSource;
			if (sortByLength)
			{
			    qry = qry.OrderBy(x => x.Length);
			}
			*/
			
			string? startsWith = "some regex"; // /* ... */;
			string? endsWith = "some other regex"; // /* ... */;
			
			Expression<Func<string, bool>> expr = (startsWith, endsWith) switch
			{
			    ("" or null, "" or null) => x => true,
			    (_, "" or null) => x => x.StartsWith(startsWith),
			    ("" or null, _) => x => x.EndsWith(endsWith),
			    (_, _) => x => x.StartsWith(startsWith) || x.EndsWith(endsWith)
			};
			
			var qry2 = companyNamesSource.Where(expr);
			
			// This is functionally equivalent to the previous example.

			// using LinqKit;
			// string? startsWith = /* ... */;
			// string? endsWith = /* ... */;
			/*
			Expression<Func<string, bool>>? expr2 = PredicateBuilder.New<string>(false);
			var original = expr;
			if (!string.IsNullOrEmpty(startsWith))
			{
			    expr = expr.Or(x => x.StartsWith(startsWith));
			}
			if (!string.IsNullOrEmpty(endsWith))
			{
			    expr = expr.Or(x => x.EndsWith(endsWith));
			}
			if (expr == original)
			{
			    expr = x => true;
			}
			
			var qry = companyNamesSource.Where(expr);
			*/
			
			Expression<Func<string, bool>> expr3 = x => x.StartsWith("a");
			
			//ParameterExpression x = Parameter(typeof(string), "x");
			/*
			Expression body = Call(
			    x,
			    typeof(string).GetMethod("StartsWith", [typeof(string)])!,
			    Constant("a")
			);
			*/
			
			//Expression<Func<string, bool>> expr4 = Lambda<Func<string, bool>>(body, x);
			
			string term = "some regex"; // /* ... */;
			var personsQry = new List<Person>()
			    .AsQueryable()
			    .Where(x => x.FirstName.Contains(term) || x.LastName.Contains(term));
				
			string term2 = "some regex"; // /* ... */;
			var carsQry = new List<Car>()
			    .AsQueryable()
			    .Where(x => x.Model.Contains(term2));
				
			var qry3 = TextFilter(
		        new List<Person>().AsQueryable(),
		        "abcd"
		    )
		    .Where(x => x.DateOfBirth < new DateTime(2001, 1, 1));
		
		var qry1 = TextFilter(
		        new List<Car>().AsQueryable(),
		        "abcd"
		    )
		    .Where(x => x.Year == 2010);
				
			
		}
		
		// using static System.Linq.Expressions.Expression;

		static IQueryable<T> TextFilter<T>(IQueryable<T> source, string term)
		{
		    if (string.IsNullOrEmpty(term)) { return source; }
		
		    // T is a compile-time placeholder for the element type of the query.
		    Type elementType = typeof(T);
		
		    // Get all the string properties on this specific type.
		    PropertyInfo[] stringProperties = elementType
		        .GetProperties()
		        .Where(x => x.PropertyType == typeof(string))
		        .ToArray();
		    if (!stringProperties.Any()) { return source; }
		
		    // Get the right overload of String.Contains
		    MethodInfo containsMethod = typeof(string).GetMethod("Contains", [typeof(string)])!;
		
		    // Create a parameter for the expression tree:
		    // the 'x' in 'x => x.PropertyName.Contains("term")'
		    // The type of this parameter is the query's element type
		    ParameterExpression prm = Parameter(elementType);
		
		    // Map each property to an expression tree node
		    IEnumerable<Expression> expressions = stringProperties
		        .Select(prp =>
		            // For each property, we have to construct an expression tree node like x.PropertyName.Contains("term")
		            Call(                  // .Contains(...) 
		                Property(          // .PropertyName
		                    prm,           // x 
		                    prp
		                ),
		                containsMethod,
		                Constant(term)     // "term" 
		            )
		        );
		
		    // Combine all the resultant expression nodes using ||
		    Expression body = expressions
		        .Aggregate((prev, current) => Or(prev, current));
		
		    // Wrap the expression body in a compile-time-typed lambda expression
		    Expression<Func<T, bool>> lambda = Lambda<Func<T, bool>>(body, prm);
		
		    // Because the lambda is compile-time-typed (albeit with a generic parameter), we can use it with the Where method
		    return source.Where(lambda);
		}
		
		/*
		IQueryable TextFilter_Untyped(IQueryable source, string term)
		{
		    if (string.IsNullOrEmpty(term)) { return source; }
		    Type elementType = source.ElementType;
		
		    // The logic for building the ParameterExpression and the LambdaExpression's body is the same as in the previous example,
		    // but has been refactored into the constructBody function.
		    (Expression? body, ParameterExpression? prm) = constructBody(elementType, term);
		    if (body is null) { return source; }
		
		    Expression filteredTree = Call(
		        typeof(Queryable),
		        "Where",
		        [elementType],
		        source.Expression,
		        Lambda(body, prm!)
		    );
		
		    return source.Provider.CreateQuery(filteredTree);
		}
		*/
		
		IQueryable TextFilter_Strings(IQueryable source, string term)
		{
		    if (string.IsNullOrEmpty(term)) { return source; }
		
		    var elementType = source.ElementType;
		
		    // Get all the string property names on this specific type.
		    var stringProperties =
		        elementType.GetProperties()
		            .Where(x => x.PropertyType == typeof(string))
		            .ToArray();
		    if (!stringProperties.Any()) { return source; }
		
		    // Build the string expression
		    string filterExpr = string.Join(
		        " || ",
		        stringProperties.Select(prp => $"{prp.Name}.Contains(@0)")
		    );
		
		    //return source.Where(filterExpr, term);
			return null;
		}
	}
	
	record Person(string LastName, string FirstName, DateTime DateOfBirth);
	record Car(string Model, int Year);
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/how-to-extend-linq
namespace DotnetCSharpLinqHowToExtendLinq
{
	public static class HowToExtendLinq
	{
		public static void RunExtendLinq()
		{
			double[] numbers = [1.9, 2, 8, 4, 5.7, 6, 7.2, 0];
			var query = numbers.Median();
			
			Console.WriteLine($"double: Median = {query}");
			// This code produces the following output:
			//     double: Median = 4.85
			
			double[] numbers1 = [1.9, 2, 8, 4, 5.7, 6, 7.2, 0];
			var query1 = numbers1.Median();
			
			Console.WriteLine($"double: Median = {query1}");
			
			int[] numbers2 = [1, 2, 3, 4, 5];
			var query2 = numbers2.Median();
			
			Console.WriteLine($"int: Median = {query2}");
			// This code produces the following output:
			//     double: Median = 4.85
			//     int: Median = 3
			
			int[] numbers3 = [1, 2, 3, 4, 5];

			/*
			    You can use the num => num lambda expression as a parameter for the Median method
			    so that the compiler will implicitly convert its value to double.
			    If there is no implicit conversion, the compiler will display an error message.
			*/
			var query3 = numbers3.Median(num => num);
			
			Console.WriteLine($"int: Median = {query3}");
			
			string[] numbers4 = ["one", "two", "three", "four", "five"];
			
			// With the generic overload, you can also use numeric properties of objects.
			var query4 = numbers4.Median(str => str.Length);
			
			Console.WriteLine($"string: Median = {query4}");
			// This code produces the following output:
			//     int: Median = 3
			//     string: Median = 4
			
			string[] strings = ["a", "b", "c", "d", "e"];

			var query5 = strings.AlternateElements();
			
			foreach (var element in query5)
			{
			    Console.WriteLine(element);
			}
			// This code produces the following output:
			//     a
			//     c
			//     e
		}
		
		// int overload
		public static double Median2(this IEnumerable<int> source) =>
		    (from number in source select (double)number).Median();
			
		// generic overload
		public static double Median3<T>(
		    this IEnumerable<T> numbers, Func<T, double> selector) =>
		    (from num in numbers select selector(num)).Median();
			
		// Extension method for the IEnumerable<T> interface.
		// The method returns every other element of a sequence.
		public static IEnumerable<T> AlternateElements<T>(this IEnumerable<T> source)
		{
		    int index = 0;
		    foreach (T element in source)
		    {
		        if (index % 2 == 0)
		        {
		            yield return element;
		        }
		
		        index++;
		    }
		}
	}
	
	public static class ExtendLinq
	{
		extension(IEnumerable<double>? source)
		{
		    public double Median()
		    {
		        if (source is null || !source.Any())
		        {
		            throw new InvalidOperationException("Cannot compute median for a null or empty set.");
		        }
		
		        var sortedList =
		            source.OrderBy(number => number).ToList();
		
		        int itemIndex = sortedList.Count / 2;
		
		        if (sortedList.Count % 2 == 0)
		        {
		            // Even number of items.
		            return (sortedList[itemIndex] + sortedList[itemIndex - 1]) / 2;
		        }
		        else
		        {
		            // Odd number of items.
		            return sortedList[itemIndex];
		        }
		    }
		}
	}
	
	public static class EnumerableExtension2
	{
	    public static double Median2(this IEnumerable<double>? source)
	    {
	        if (source is null || !source.Any())
	        {
	            throw new InvalidOperationException("Cannot compute median for a null or empty set.");
	        }
	
	        var sortedList =
	            source.OrderBy(number => number).ToList();
	
	        int itemIndex = sortedList.Count / 2;
	
	        if (sortedList.Count % 2 == 0)
	        {
	            // Even number of items.
	            return (sortedList[itemIndex] + sortedList[itemIndex - 1]) / 2;
	        }
	        else
	        {
	            // Odd number of items.
	            return sortedList[itemIndex];
	        }
	    }
	}
	
	public static class EnumerableExtension1
	{
	    extension(IEnumerable<double>? source)
	    {
	        public double Median1()
	        {
	            if (source is null || !source.Any())
	            {
	                throw new InvalidOperationException("Cannot compute median for a null or empty set.");
	            }
	
	            var sortedList =
	                source.OrderBy(number => number).ToList();
	
	            int itemIndex = sortedList.Count / 2;
	
	            if (sortedList.Count % 2 == 0)
	            {
	                // Even number of items.
	                return (sortedList[itemIndex] + sortedList[itemIndex - 1]) / 2;
	            }
	            else
	            {
	                // Odd number of items.
	                return sortedList[itemIndex];
	            }
	        }
	    }
	
	    extension(IEnumerable<int> source)
	    {
	        public double Median() =>
	            (from number in source select (double)number).Median();
	    }
	
	    extension<T>(IEnumerable<T> source)
	    {
	        public double Median(Func<T, double> selector) =>
	            (from num in source select selector(num)).Median();
	
	        public IEnumerable<T> AlternateElements1()
	        {
	            int index = 0;
	            foreach (T element in source)
	            {
	                if (index % 2 == 0)
	                {
	                    yield return element;
	                }
	
	                index++;
	            }
	        }
	    }
	}
	
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/how-to-query-collections
namespace DotnetCSharpLinqHowToQueryCollections
{
	public class QueryCollections
	{
		public static void RunQueryCollections()
		{
			// Create the IEnumerable data sources.
			string[] names1 = File.ReadAllLines("names1.txt");
			string[] names2 = File.ReadAllLines("names2.txt");
			
			// Create the query. Note that method syntax must be used here.
			var differenceQuery = names1.Except(names2);
			
			// Execute the query.
			Console.WriteLine("The following lines are in names1.txt but not names2.txt");
			foreach (string s in differenceQuery)
			    Console.WriteLine(s);
			/* Output:
			 The following lines are in names1.txt but not names2.txt
			 Potra, Cristina
			 Noriega, Fabricio
			 Aw, Kam Foo
			 Toyoshima, Tim
			 Guy, Wey Yuan
			 Garcia, Debra
			 */
			 
			//Put text files in your solution folder
			string[] fileA = File.ReadAllLines("names1.txt");
			string[] fileB = File.ReadAllLines("names2.txt");
			
			//Simple concatenation and sort. Duplicates are preserved.
			var concatQuery = fileA.Concat(fileB).OrderBy(s => s);
			
			// Pass the query variable to another function for execution.
			OutputQueryResults(concatQuery, "Simple concatenate and sort. Duplicates are preserved:");
			
			// Concatenate and remove duplicate names based on
			// default string comparer.
			var uniqueNamesQuery = fileA.Union(fileB).OrderBy(s => s);
			OutputQueryResults(uniqueNamesQuery, "Union removes duplicate names:");
			
			// Find the names that occur in both files (based on
			// default string comparer).
			var commonNamesQuery = fileA.Intersect(fileB);
			OutputQueryResults(commonNamesQuery, "Merge based on intersect:");
			
			// Find the matching fields in each list. Merge the two
			// results by using Concat, and then
			// sort using the default string comparer.
			string nameMatch = "Garcia";
			
			var tempQuery1 = from name in fileA
			                 let n = name.Split(',')
			                 where n[0] == nameMatch
			                 select name;
			
			var tempQuery2 = from name2 in fileB
			                 let n2 = name2.Split(',')
			                 where n2[0] == nameMatch
			                 select name2;
							 
			var nameMatchQuery = tempQuery1.Concat(tempQuery2).OrderBy(s => s);
			OutputQueryResults(nameMatchQuery, $"""Concat based on partial name match "{nameMatch}":""");
			
		}
		
		static void OutputQueryResults(IEnumerable<string> query, string message)
		{
		    Console.WriteLine(Environment.NewLine + message);
		    foreach (string item in query)
		    {
		        Console.WriteLine(item);
		    }
		    Console.WriteLine($"{query.Count()} total names in list");
		}
		/* Output:
		    Simple concatenate and sort. Duplicates are preserved:
		    Aw, Kam Foo
		    Bankov, Peter
		    Bankov, Peter
		    Beebe, Ann
		    Beebe, Ann
		    El Yassir, Mehdi
		    Garcia, Debra
		    Garcia, Hugo
		    Garcia, Hugo
		    Giakoumakis, Leo
		    Gilchrist, Beth
		    Guy, Wey Yuan
		    Holm, Michael
		    Holm, Michael
		    Liu, Jinghao
		    McLin, Nkenge
		    Myrcha, Jacek
		    Noriega, Fabricio 
		    Potra, Cristina
		    Toyoshima, Tim
		    20 total names in list
		
		    Union removes duplicate names:
		    Aw, Kam Foo
		    Bankov, Peter
		    Beebe, Ann
		    El Yassir, Mehdi
		    Garcia, Debra
		    Garcia, Hugo
		    Giakoumakis, Leo
		    Gilchrist, Beth
		    Guy, Wey Yuan
		    Holm, Michael
		    Liu, Jinghao
		    McLin, Nkenge
		    Myrcha, Jacek
		    Noriega, Fabricio
		    Potra, Cristina
		    Toyoshima, Tim
		    16 total names in list
		
		    Merge based on intersect:
		    Bankov, Peter
		    Holm, Michael
		    Garcia, Hugo
		    Beebe, Ann
		    4 total names in list
		
		    Concat based on partial name match "Garcia":
		    Garcia, Debra
		    Garcia, Hugo
		    Garcia, Hugo
		    3 total names in list
		*/
		
		/*
		// Each line of names.csv consists of a last name, a first name, and an
		// ID number, separated by commas. For example, Omelchenko,Svetlana,111
		string[] names = File.ReadAllLines("names.csv");
		
		// Each line of scores.csv consists of an ID number and four test
		// scores, separated by commas. For example, 111, 97, 92, 81, 60
		string[] scores = File.ReadAllLines("scores.csv");
		
		// Merge the data sources using a named type.
		// var could be used instead of an explicit type. Note the dynamic
		// creation of a list of ints for the ExamScores member. The first item
		// is skipped in the split string because it is the student ID,
		// not an exam score.
		IEnumerable<Student> queryNamesScores = from nameLine in names
		                                        let splitName = nameLine.Split(',')
		                                        from scoreLine in scores
		                                        let splitScoreLine = scoreLine.Split(',')
		                                        where Convert.ToInt32(splitName[2]) == Convert.ToInt32(splitScoreLine[0])
		                                        select new Student
		                                        (
		                                            FirstName: splitName[0],
		                                            LastName: splitName[1],
		                                            ID: Convert.ToInt32(splitName[2]),
		                                            ExamScores: (from scoreAsText in splitScoreLine.Skip(1)
		                                                         select Convert.ToInt32(scoreAsText)
		                                                        ).ToArray()
		                                        );
		
		// Optional. Store the newly created student objects in memory
		// for faster access in future queries. This could be useful with
		// very large data files.
		List<Student> students = queryNamesScores.ToList();
		
		// Display each student's name and exam score average.
		foreach (var student in students)
		{
		    Console.WriteLine($"The average score of {student.FirstName} {student.LastName} is {student.ExamScores.Average()}.");
		}
		Output:
		The average score of Omelchenko Svetlana is 82.5.
		The average score of O'Donnell Claire is 72.25.
		The average score of Mortensen Sven is 84.5.
		The average score of Garcia Cesar is 88.25.
		The average score of Garcia Debra is 67.
		The average score of Fakhouri Fadi is 92.25.
		The average score of Feng Hanying is 88.
		The average score of Garcia Hugo is 85.75.
		The average score of Tucker Lance is 81.75.
		The average score of Adams Terry is 85.25.
		The average score of Zabokritski Eugene is 83.
		The average score of Tucker Michael is 92.

		
		// Merge the data sources by using an anonymous type.
		// Note the dynamic creation of a list of ints for the
		// ExamScores member. We skip 1 because the first string
		// in the array is the student ID, not an exam score.
		var queryNamesScores2 = from nameLine in names
		                        let splitName = nameLine.Split(',')
		                        from scoreLine in scores
		                        let splitScoreLine = scoreLine.Split(',')
		                        where Convert.ToInt32(splitName[2]) == Convert.ToInt32(splitScoreLine[0])
		                        select (FirstName: splitName[0], 
		                                LastName: splitName[1], 
		                                ExamScores: (from scoreAsText in splitScoreLine.Skip(1)
		                                             select Convert.ToInt32(scoreAsText))
		                                             .ToList()
		                               );
		
		// Display each student's name and exam score average.
		foreach (var student in queryNamesScores2)
		{
		    Console.WriteLine($"The average score of {student.FirstName} {student.LastName} is {student.ExamScores.Average()}.");
		}
		*/
		
		/*
		ArrayList arrList = new ArrayList();
		arrList.Add(
		    new Student
		    (
		        FirstName: "Svetlana",
		        LastName: "Omelchenko",
		        ExamScores: new int[] { 98, 92, 81, 60 }
		    ));
		arrList.Add(
		    new Student
		    (
		        FirstName: "Claire",
		        LastName: "O’Donnell",
		        ExamScores: new int[] { 75, 84, 91, 39 }
		    ));
		arrList.Add(
		    new Student
		    (
		        FirstName: "Sven",
		        LastName: "Mortensen",
		        ExamScores: new int[] { 88, 94, 65, 91 }
		    ));
		arrList.Add(
		    new Student
		    (
		        FirstName: "Cesar",
		        LastName: "Garcia",
		        ExamScores: new int[] { 97, 89, 85, 82 }
		    ));
		
		var query = from Student student in arrList
		            where student.ExamScores[0] > 95
		            select student;
		
		foreach (Student s in query)
		    Console.WriteLine(s.LastName + ": " + s.ExamScores[0]);
			
		*/
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/how-to-query-strings
namespace DotnetCSharpLinqHowToQueryStrings
{
	public class QueryStrings
	{
		public static void RunQueryStrings()
		{
			string aString = "ABCDE99F-J74-12-89A";

			// Select only those characters that are numbers
			var stringQuery = from ch in aString
			                  where Char.IsDigit(ch)
			                  select ch;
			
			// Execute the query
			foreach (char c in stringQuery)
			    Console.Write(c + " ");
			
			// Call the Count method on the existing query.
			int count = stringQuery.Count();
			Console.WriteLine($"Count = {count}");
			
			// Select all characters before the first '-'
			var stringQuery2 = aString.TakeWhile(c => c != '-');
			
			// Execute the second query
			foreach (char c in stringQuery2)
			    Console.Write(c);
			/* Output:
			  Output: 9 9 7 4 1 2 8 9
			  Count = 8
			  ABCDE99F
			*/
			
			string text = """
			    Historically, the world of data and the world of objects 
			    have not been well integrated. Programmers work in C# or Visual Basic 
			    and also in SQL or XQuery. On the one side are concepts such as classes, 
			    objects, fields, inheritance, and .NET APIs. On the other side 
			    are tables, columns, rows, nodes, and separate languages for dealing with 
			    them. Data types often require translation between the two worlds; there are 
			    different standard functions. Because the object world has no notion of query, a 
			    query can only be represented as a string without compile-time type checking or 
			    IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to 
			    objects in memory is often tedious and error-prone. 
			    """;
			
			string searchTerm = "data";
			
			//Convert the string into an array of words
			char[] separators = ['.', '?', '!', ' ', ';', ':', ','];
			string[] source = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
			
			// Create the query.  Use the InvariantCultureIgnoreCase comparison to match "data" and "Data"
			var matchQuery = from word in source
			                 where word.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
			                 select word;
			
			// Count the matches, which executes the query.
			int wordCount = matchQuery.Count();
			Console.WriteLine($"""{wordCount} occurrences(s) of the search term "{searchTerm}" were found.""");
			/* Output:
			   3 occurrences(s) of the search term "data" were found.
			*/
			
			// Create an IEnumerable data source
			string[] scores = File.ReadAllLines("scores.csv");
			
			// Change this to any value from 0 to 4.
			int sortField = 1;
			
			Console.WriteLine($"Sorted highest to lowest by field [{sortField}]:");
			
			// Split the string and sort on field[num]
			var scoreQuery = from line in scores
			                 let fields = line.Split(',')
			                 orderby fields[sortField] descending
			                 select line;
			
			foreach (string str in scoreQuery)
			{
			    Console.WriteLine(str);
			}
			/* Output (if sortField == 1):
			   Sorted highest to lowest by field [1]:
			    116, 99, 86, 90, 94
			    120, 99, 82, 81, 79
			    111, 97, 92, 81, 60
			    114, 97, 89, 85, 82
			    121, 96, 85, 91, 60
			    122, 94, 92, 91, 91
			    117, 93, 92, 80, 87
			    118, 92, 90, 83, 78
			    113, 88, 94, 65, 91
			    112, 75, 84, 91, 39
			    119, 68, 79, 88, 92
			    115, 35, 72, 91, 70
			 */
			 
			text = """
			Historically, the world of data and the world of objects 
			have not been well integrated. Programmers work in C# or Visual Basic 
			and also in SQL or XQuery. On the one side are concepts such as classes, 
			objects, fields, inheritance, and .NET APIs. On the other side 
			are tables, columns, rows, nodes, and separate languages for dealing with 
			them. Data types often require translation between the two worlds; there are 
			different standard functions. Because the object world has no notion of query, a 
			query can only be represented as a string without compile-time type checking or 
			IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to 
			objects in memory is often tedious and error-prone.
			""";
			
			// Split the text block into an array of sentences.
			string[] sentences = text.Split(['.', '?', '!']);
			
			// Define the search terms. This list could also be dynamically populated at run time.
			string[] wordsToMatch = [ "Historically", "data", "integrated" ];
			
			// Find sentences that contain all the terms in the wordsToMatch array.
			// Note that the number of terms to match is not specified at compile time.
			separators = ['.', '?', '!', ' ', ';', ':', ','];
			var sentenceQuery = from sentence in sentences
			                    let w = sentence.Split(separators,StringSplitOptions.RemoveEmptyEntries)
			                    where w.Distinct().Intersect(wordsToMatch).Count() == wordsToMatch.Count()
			                    select sentence;
			
			foreach (string str in sentenceQuery)
			{
			    Console.WriteLine(str);
			}
			/* Output:
			Historically, the world of data and the world of objects have not been well integrated
			*/
			
			string startFolder = """C:\Program Files\dotnet\sdk""";
			// Or
			// string startFolder = "/usr/local/share/dotnet/sdk";
			
			// Take a snapshot of the file system.
			var fileList = from file in Directory.GetFiles(startFolder, "*.*", SearchOption.AllDirectories)
			                let fileInfo = new FileInfo(file)
			                select fileInfo;
			
			// Create the regular expression to find all things "Visual".
			System.Text.RegularExpressions.Regex searchTerm2 =
			    new System.Text.RegularExpressions.Regex(@"microsoft.net.(sdk|workload)");
			
			// Search the contents of each .htm file.
			// Remove the where clause to find even more matchedValues!
			// This query produces a list of files where a match
			// was found, and a list of the matchedValues in that file.
			// Note: Explicit typing of "Match" in select clause.
			// This is required because MatchCollection is not a
			// generic IEnumerable collection.
			var queryMatchingFiles =
			    from file in fileList
			    where file.Extension == ".txt"
			    let fileText = File.ReadAllText(file.FullName)
			    let matches = searchTerm2.Matches(fileText)
			    where matches.Count > 0
			    select new
			    {
			        name = file.FullName,
			        matchedValues = from System.Text.RegularExpressions.Match match in matches
			                        select match.Value
			    };
			
			// Execute the query.
			Console.WriteLine($"""The term "{searchTerm}" was found in:""");
			
			foreach (var v in queryMatchingFiles)
			{
			    // Trim the path a bit, then write
			    // the file name in which a match was found.
			    string s = v.name.Substring(startFolder.Length - 1);
			    Console.WriteLine(s);
			
			    // For this file, write out all the matching strings
			    foreach (var v2 in v.matchedValues)
			    {
			        Console.WriteLine($"  {v2}");
			    }
			}
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/how-to-query-files-and-directories
namespace DotnetCSharpLinqHowToQueryFilesAndDirectories
{
	public class QueryFilesAndDirectories
	{
		public static void RunQueryFilesAndDirectories()
		{
			string startFolder = """C:\Program Files\dotnet\sdk""";
			// Or
			// string startFolder = "/usr/local/share/dotnet/sdk";
			
			DirectoryInfo dir = new DirectoryInfo(startFolder);
			var fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
			
			var fileQuery = from file in fileList
			                where file.Extension == ".txt"
			                orderby file.Name
			                select file;
			
			// Uncomment this block to see the full query
			// foreach (FileInfo fi in fileQuery)
			// {
			//    Console.WriteLine(fi.FullName);
			// }
			
			var newestFile = (from file in fileQuery
			                  orderby file.CreationTime
			                  select new { file.FullName, file.CreationTime })
			                  .Last();
			
			Console.WriteLine($"\r\nThe newest .txt file is {newestFile.FullName}. Creation time: {newestFile.CreationTime}");
			
			// Or
			// string startFolder = "/usr/local/share/dotnet/sdk";
			
			int trimLength = startFolder.Length;
			
			DirectoryInfo dir2 = new DirectoryInfo(startFolder);
			
			var fileList2 = dir.GetFiles("*.*", SearchOption.AllDirectories);
			
			var queryGroupByExt = from file in fileList2
			                      group file by file.Extension.ToLower() into fileGroup
			                      orderby fileGroup.Count(), fileGroup.Key
			                      select fileGroup;
			
			// Iterate through the outer collection of groups.
			foreach (var filegroup in queryGroupByExt.Take(5))
			{
			    Console.WriteLine($"Extension: {filegroup.Key}");
			    var resultPage = filegroup.Take(20);
			
			    //Execute the resultPage query
			    foreach (var f in resultPage)
			    {
			        Console.WriteLine($"\t{f.FullName.Substring(trimLength)}");
			    }
			    Console.WriteLine();
			}
				
			/*	
			string startFolder = """C:\Program Files\dotnet\sdk""";
			// Or
			// string startFolder = "/usr/local/share/dotnet/sdk";
			
			var fileList = Directory.GetFiles(startFolder, "*.*", SearchOption.AllDirectories);
			
			var fileQuery = from file in fileList
			                let fileLen = new FileInfo(file).Length
			                where fileLen > 0
			                select fileLen;
			
			// Cache the results to avoid multiple trips to the file system.
			long[] fileLengths = fileQuery.ToArray();
			
			// Return the size of the largest file
			long largestFile = fileLengths.Max();
			
			// Return the total number of bytes in all the files under the specified folder.
			long totalBytes = fileLengths.Sum();
			
			Console.WriteLine($"There are {totalBytes} bytes in {fileList.Count()} files under {startFolder}");
			Console.WriteLine($"The largest file is {largestFile} bytes.");
			
			// Return the FileInfo object for the largest file
			// by sorting and selecting from beginning of list
			FileInfo longestFile = (from file in fileList
			                        let fileInfo = new FileInfo(file)
			                        where fileInfo.Length > 0
			                        orderby fileInfo.Length descending
			                        select fileInfo
			                        ).First();
			
			Console.WriteLine($"The largest file under {startFolder} is {longestFile.FullName} with a length of {longestFile.Length} bytes");
			
			//Return the FileInfo of the smallest file
			FileInfo smallestFile = (from file in fileList
			                         let fileInfo = new FileInfo(file)
			                         where fileInfo.Length > 0
			                         orderby fileInfo.Length ascending
			                         select fileInfo
			                        ).First();
			
			Console.WriteLine($"The smallest file under {startFolder} is {smallestFile.FullName} with a length of {smallestFile.Length} bytes");
			
			//Return the FileInfos for the 10 largest files
			var queryTenLargest = (from file in fileList
			                       let fileInfo = new FileInfo(file)
			                       let len = fileInfo.Length
			                       orderby len descending
			                       select fileInfo
			                      ).Take(10);
			
			Console.WriteLine($"The 10 largest files under {startFolder} are:");
			
			foreach (var v in queryTenLargest)
			{
			    Console.WriteLine($"{v.FullName}: {v.Length} bytes");
			}
			
			// Group the files according to their size, leaving out
			// files that are less than 200000 bytes.
			var querySizeGroups = from file in fileList
			                      let fileInfo = new FileInfo(file)
			                      let len = fileInfo.Length
			                      where len > 0
			                      group fileInfo by (len / 100000) into fileGroup
			                      where fileGroup.Key >= 2
			                      orderby fileGroup.Key descending
			                      select fileGroup;
			
			foreach (var filegroup in querySizeGroups)
			{
			    Console.WriteLine($"{filegroup.Key}00000");
			    foreach (var item in filegroup)
			    {
			        Console.WriteLine($"\t{item.Name}: {item.Length}");
			    }
			}
			
			
			string startFolder = """C:\Program Files\dotnet\sdk""";
			// Or
			// string startFolder = "/usr/local/share/dotnet/sdk";
			
			DirectoryInfo dir = new DirectoryInfo(startFolder);
			
			IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
			
			// used in WriteLine to keep the lines shorter
			int charsToSkip = startFolder.Length;
			
			// var can be used for convenience with groups.
			var queryDupNames = from file in fileList
			                    group file.FullName.Substring(charsToSkip) by file.Name into fileGroup
			                    where fileGroup.Count() > 1
			                    select fileGroup;
			
			foreach (var queryDup in queryDupNames.Take(20))
			{
			    Console.WriteLine($"Filename = {(queryDup.Key.ToString() == string.Empty ? "[none]" : queryDup.Key.ToString())}");
			
			    foreach (var fileName in queryDup.Take(10))
			    {
			        Console.WriteLine($"\t{fileName}");
			    }   
			}
			
			
			string startFolder = """C:\Program Files\dotnet\sdk""";
		    // Or
		    // string startFolder = "/usr/local/share/dotnet/sdk";
		
		    // Make the lines shorter for the console display
		    int charsToSkip = startFolder.Length;
		
		    // Take a snapshot of the file system.
		    DirectoryInfo dir = new DirectoryInfo(startFolder);
		    IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
		
		    // Note the use of a compound key. Files that match
		    // all three properties belong to the same group.
		    // A named type is used to enable the query to be
		    // passed to another method. Anonymous types can also be used
		    // for composite keys but cannot be passed across method boundaries
		    //
		    var queryDupFiles = from file in fileList
		                        group file.FullName.Substring(charsToSkip) by
		                        (Name: file.Name, LastWriteTime: file.LastWriteTime, Length: file.Length )
		                        into fileGroup
		                        where fileGroup.Count() > 1
		                        select fileGroup;
		
		    foreach (var queryDup in queryDupFiles.Take(20))
		    {
		        Console.WriteLine($"Filename = {(queryDup.Key.ToString() == string.Empty ? "[none]" : queryDup.Key.ToString())}");
		
		        foreach (var fileName in queryDup)
		        {
		            Console.WriteLine($"\t{fileName}");
		        }
		    }
		
		
			string startFolder = """C:\Program Files\dotnet\sdk""";
			// Or
			// string startFolder = "/usr/local/share/dotnet/sdk";
			
			DirectoryInfo dir = new DirectoryInfo(startFolder);
			
			var fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
			
			string searchTerm = "change";
			
			var queryMatchingFiles = from file in fileList
			                         where file.Extension == ".txt"
			                         let fileText = File.ReadAllText(file.FullName)
			                         where fileText.Contains(searchTerm)
			                         select file.FullName;
			
			// Execute the query.
			Console.WriteLine($"""The term "{searchTerm}" was found in:""");
			foreach (string filename in queryMatchingFiles)
			{
			    Console.WriteLine(filename);
			}
			*/
			
			string[] lines = File.ReadAllLines("spreadsheet1.csv");

			// Create the query. Put field 2 first, then
			// reverse and combine fields 0 and 1 from the old field
			IEnumerable<string> query = from line in lines
			                            let fields = line.Split(',')
			                            orderby fields[2]
			                            select $"{fields[2]}, {fields[1]} {fields[0]}";
			
			File.WriteAllLines("spreadsheet2.csv", query.ToArray());
			
			/* Output to spreadsheet2.csv:
			111, Svetlana Omelchenko
			112, Claire O'Donnell
			113, Sven Mortensen
			114, Cesar Garcia
			115, Debra Garcia
			116, Fadi Fakhouri
			117, Hanying Feng
			118, Hugo Garcia
			119, Lance Tucker
			120, Terry Adams
			121, Eugene Zabokritski
			122, Michael Tucker
			*/
			
			string[] fileA = File.ReadAllLines("names1.txt");
			string[] fileB = File.ReadAllLines("names2.txt");
			
			// Concatenate and remove duplicate names
			var mergeQuery = fileA.Union(fileB);
			
			// Group the names by the first letter in the last name.
			var groupQuery = from name in mergeQuery
			                 let n = name.Split(',')[0]
			                 group name by n[0] into g
			                 orderby g.Key
			                 select g;
			
			foreach (var g in groupQuery)
			{
			    string fileName = $"testFile_{g.Key}.txt";
			
			    Console.WriteLine(g.Key);
			
			    using StreamWriter sw = new StreamWriter(fileName);
			    foreach (var item in g)
			    {
			        sw.WriteLine(item);
			        // Output to console for example purposes.
			        Console.WriteLine($"   {item}");
			    }
			}
			/* Output:
			    A
			       Aw, Kam Foo
			    B
			       Bankov, Peter
			       Beebe, Ann
			    E
			       El Yassir, Mehdi
			    G
			       Garcia, Hugo
			       Guy, Wey Yuan
			       Garcia, Debra
			       Gilchrist, Beth
			       Giakoumakis, Leo
			    H
			       Holm, Michael
			    L
			       Liu, Jinghao
			    M
			       Myrcha, Jacek
			       McLin, Nkenge
			    N
			       Noriega, Fabricio
			    P
			       Potra, Cristina
			    T
			       Toyoshima, Tim
			 */
			 
			string[] names = File.ReadAllLines(@"names.csv");
			string[] scores = File.ReadAllLines(@"scores.csv");
			
			var scoreQuery = from name in names
			                  let nameFields = name.Split(',')
			                  from id in scores
			                  let scoreFields = id.Split(',')
			                  where System.Convert.ToInt32(nameFields[2]) == System.Convert.ToInt32(scoreFields[0])
			                  select $"{nameFields[0]},{scoreFields[1]},{scoreFields[2]},{scoreFields[3]},{scoreFields[4]}";
			
			Console.WriteLine("\r\nMerge two spreadsheets:");
			foreach (string item in scoreQuery)
			{
			    Console.WriteLine(item);
			}
			Console.WriteLine($"{scoreQuery.Count()} total names in list");
			/* Output:
			Merge two spreadsheets:
			Omelchenko, 97, 92, 81, 60
			O'Donnell, 75, 84, 91, 39
			Mortensen, 88, 94, 65, 91
			Garcia, 97, 89, 85, 82
			Garcia, 35, 72, 91, 70
			Fakhouri, 99, 86, 90, 94
			Feng, 93, 92, 80, 87
			Garcia, 92, 90, 83, 78
			Tucker, 68, 79, 88, 92
			Adams, 99, 82, 81, 79
			Zabokritski, 96, 85, 91, 60
			Tucker, 94, 92, 91, 91
			12 total names in list
			 */

		}
		
		public static void CompareDirectories()
		{
		    string pathA = """C:\Program Files\dotnet\sdk\8.0.104""";
		    string pathB = """C:\Program Files\dotnet\sdk\8.0.204""";
		
		    DirectoryInfo dir1 = new DirectoryInfo(pathA);
		    DirectoryInfo dir2 = new DirectoryInfo(pathB);
		
		    IEnumerable<FileInfo> list1 = dir1.GetFiles("*.*", SearchOption.AllDirectories);
		    IEnumerable<FileInfo> list2 = dir2.GetFiles("*.*", SearchOption.AllDirectories);
		
		    //A custom file comparer defined below
		    FileCompare myFileCompare = new FileCompare();
		
		    // This query determines whether the two folders contain
		    // identical file lists, based on the custom file comparer
		    // that is defined in the FileCompare class.
		    // The query executes immediately because it returns a bool.
		    bool areIdentical = list1.SequenceEqual(list2, myFileCompare);
		
		    if (areIdentical == true)
		    {
		        Console.WriteLine("the two folders are the same");
		    }
		    else
		    {
		        Console.WriteLine("The two folders are not the same");
		    }
		
		    // Find the common files. It produces a sequence and doesn't
		    // execute until the foreach statement.
		    var queryCommonFiles = list1.Intersect(list2, myFileCompare);
		
		    if (queryCommonFiles.Any())
		    {
		        Console.WriteLine($"The following files are in both folders (total number = {queryCommonFiles.Count()}):");
		        foreach (var v in queryCommonFiles.Take(10))
		        {
		            Console.WriteLine(v.Name); //shows which items end up in result list
		        }
		    }
		    else
		    {
		        Console.WriteLine("There are no common files in the two folders.");
		    }
		
		    // Find the set difference between the two folders.
		    var queryList1Only = (from file in list1
		                          select file)
		                          .Except(list2, myFileCompare);
		
		    Console.WriteLine();
		    Console.WriteLine($"The following files are in list1 but not list2 (total number = {queryList1Only.Count()}):");
		    foreach (var v in queryList1Only.Take(10))
		    {
		        Console.WriteLine(v.FullName);
		    }
		
		    var queryList2Only = (from file in list2
		                          select file)
		                          .Except(list1, myFileCompare);
		
		    Console.WriteLine();
		    Console.WriteLine($"The following files are in list2 but not list1 (total number = {queryList2Only.Count()}:");
		    foreach (var v in queryList2Only.Take(10))
		    {
		        Console.WriteLine(v.FullName);
		    }
		}
	}
	
	// This implementation defines a very simple comparison
	// between two FileInfo objects. It only compares the name
	// of the files being compared and their length in bytes.
	class FileCompare : IEqualityComparer<FileInfo>
	{
	    public bool Equals(FileInfo? f1, FileInfo? f2)
	    {
	        return (f1?.Name == f2?.Name &&
	                f1?.Length == f2?.Length);
	    }
	
	    // Return a hash that reflects the comparison criteria. According to the
	    // rules for IEqualityComparer<T>, if Equals is true, then the hash codes must
	    // also be equal. Because equality as defined here is a simple value equality, not
	    // reference identity, it is possible that two or more objects will produce the same
	    // hash code.
	    public int GetHashCode(FileInfo fi)
	    {
	        string s = $"{fi.Name}{fi.Length}";
	        return s.GetHashCode();
	    }
	}
	
	
	public static class SumColumns
	{
	    public static void ProcessColumns(string filePath, string seperator)
	    {
	        // Divide each exam into a group
	        var exams = from line in MatrixFrom(filePath, seperator)
	                    from score in line
	
	                    // Identify the column number
	                    let colNumber = Array.FindIndex(line, t => ReferenceEquals(score, t))
	
	                    // The first column is the student ID, not the exam score
	                    // so it needs to be excluded
	                    where colNumber > 0
	
	                    // Convert the score from string to int
	                    // Group by column number, i.e. one group per exam
	                    group double.Parse(score) by colNumber into g
	                    select new
	                    {
	                        Title = $"Exam#{g.Key}",
	                        Min = g.Min(),
	                        Max = g.Max(),
	                        Avg = Math.Round(g.Average(), 2),
	                        Total = g.Sum()
	                    };
	
	        foreach (var exam in exams)
	        {
	            Console.WriteLine($"{exam.Title}\t"
	            + $"Average:{exam.Avg,6}\t"
	            + $"High Score:{exam.Max,3}\t"
	            + $"Low Score:{exam.Min,3}\t"
	            + $"Total:{exam.Total,5}");
	        }
	    }
	
	    // Transform the file content to an IEnumerable of string arrays
	    // like a matrix
	    private static IEnumerable<string[]> MatrixFrom(string filePath, string seperator)
	    {
	        using StreamReader reader = File.OpenText(filePath);
	
	        for (string? line = reader.ReadLine(); line is not null; line = reader.ReadLine())
	        {
	            yield return line.Split(seperator, StringSplitOptions.TrimEntries);
	        }
	    }
	}
	
	// Output:
	// Exam#1  Average: 86.08  High Score: 99  Low Score: 35   Total: 1033
	// Exam#2  Average: 86.42  High Score: 94  Low Score: 72   Total: 1037
	// Exam#3  Average: 84.75  High Score: 91  Low Score: 65   Total: 1017
	// Exam#4  Average: 76.92  High Score: 94  Low Score: 39   Total:  923
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/grouping-data
namespace DotnetCSharpLinqStandardQueryOperatorsGroupingData
{
	public class GroupingData
	{
		public static void RunGroupingData()
		{
			List<int> numbers = [35, 44, 200, 84, 3987, 4, 199, 329, 446, 208];

			IEnumerable<IGrouping<int, int>> query = from number in numbers
			                                         group number by number % 2;
			
			foreach (var group in query)
			{
			    Console.WriteLine(group.Key == 0 ? "\nEven numbers:" : "\nOdd numbers:");
			    foreach (int i in group)
			    {
			        Console.WriteLine(i);
			    }
			}
			
			List<int> numbers2 = [35, 44, 200, 84, 3987, 4, 199, 329, 446, 208];

			IEnumerable<IGrouping<int, int>> query2 = numbers2
			    .GroupBy(number => number % 2);
			
			foreach (var group in query2)
			{
			    Console.WriteLine(group.Key == 0 ? "\nEven numbers:" : "\nOdd numbers:");
			    foreach (int i in group)
			    {
			        Console.WriteLine(i);
			    }
			}
			
			/*
			var groupByYearQuery =
			    from student in students
			    group student by student.Year into newGroup
			    orderby newGroup.Key
			    select newGroup;
			
			foreach (var yearGroup in groupByYearQuery)
			{
			    Console.WriteLine($"Key: {yearGroup.Key}");
			    foreach (var student in yearGroup)
			    {
			        Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
			    }
			}
			
			// Variable groupByYearQuery is an IEnumerable<IGrouping<GradeLevel,
			// DataClass.Student>>.
			var groupByYearQuery = students
			    .GroupBy(student => student.Year)
			    .OrderBy(newGroup => newGroup.Key);
			
			foreach (var yearGroup in groupByYearQuery)
			{
			    Console.WriteLine($"Key: {yearGroup.Key}");
			    foreach (var student in yearGroup)
			    {
			        Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
			    }
			}
			
			var groupByFirstLetterQuery =
			    from student in students
			    let firstLetter = student.LastName[0]
			    group student by firstLetter;
			
			foreach (var studentGroup in groupByFirstLetterQuery)
			{
			    Console.WriteLine($"Key: {studentGroup.Key}");
			    foreach (var student in studentGroup)
			    {
			        Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
			    }
			}
			
			var groupByFirstLetterQuery = students
			    .GroupBy(student => student.LastName[0]);
			
			foreach (var studentGroup in groupByFirstLetterQuery)
			{
			    Console.WriteLine($"Key: {studentGroup.Key}");
			    foreach (var student in studentGroup)
			    {
			        Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
			    }
			}
			
			
			var groupByPercentileQuery = students
			    .Select(student => new { student, percentile = GetPercentile(student) })
			    .GroupBy(student => student.percentile)
			    .Select(percentGroup => new
			    {
			        percentGroup.Key,
			        Students = percentGroup.Select(s => new { s.student.FirstName, s.student.LastName })
			    })
			    .OrderBy(percentGroup => percentGroup.Key);
			
			foreach (var studentGroup in groupByPercentileQuery)
			{
			    Console.WriteLine($"Key: {studentGroup.Key * 10}");
			    foreach (var item in studentGroup.Students)
			    {
			        Console.WriteLine($"\t{item.LastName}, {item.FirstName}");
			    }
			}
			
			
			var groupByHighAverageQuery =
			    from student in students
			    group new
			    {
			        student.FirstName,
			        student.LastName
			    } by student.Scores.Average() > 75 into studentGroup
			    select studentGroup;
			
			foreach (var studentGroup in groupByHighAverageQuery)
			{
			    Console.WriteLine($"Key: {studentGroup.Key}");
			    foreach (var student in studentGroup)
			    {
			        Console.WriteLine($"\t{student.FirstName} {student.LastName}");
			    }
			}
			
			var groupByHighAverageQuery = students
			    .GroupBy(student => student.Scores.Average() > 75)
			    .Select(group => new
			    {
			        group.Key,
			        Students = group.AsEnumerable().Select(s => new { s.FirstName, s.LastName })
			    });
			
			foreach (var studentGroup in groupByHighAverageQuery)
			{
			    Console.WriteLine($"Key: {studentGroup.Key}");
			    foreach (var student in studentGroup.Students)
			    {
			        Console.WriteLine($"\t{student.FirstName} {student.LastName}");
			    }
			}
			
			
			var groupByCompoundKey =
			    from student in students
			    group student by new
			    {
			        FirstLetterOfLastName = student.LastName[0],
			        IsScoreOver85 = student.Scores[0] > 85
			    } into studentGroup
			    orderby studentGroup.Key.FirstLetterOfLastName
			    select studentGroup;
			
			foreach (var scoreGroup in groupByCompoundKey)
			{
			    var s = scoreGroup.Key.IsScoreOver85 ? "more than 85" : "less than 85";
			    Console.WriteLine($"Name starts with {scoreGroup.Key.FirstLetterOfLastName} who scored {s}");
			    foreach (var item in scoreGroup)
			    {
			        Console.WriteLine($"\t{item.FirstName} {item.LastName}");
			    }
			}
			
			var groupByCompoundKey = students
			    .GroupBy(student => new
			    {
			        FirstLetterOfLastName = student.LastName[0],
			        IsScoreOver85 = student.Scores[0] > 85
			    })
			    .OrderBy(studentGroup => studentGroup.Key.FirstLetterOfLastName);
			
			foreach (var scoreGroup in groupByCompoundKey)
			{
			    var s = scoreGroup.Key.IsScoreOver85 ? "more than 85" : "less than 85";
			    Console.WriteLine($"Name starts with {scoreGroup.Key.FirstLetterOfLastName} who scored {s}");
			    foreach (var item in scoreGroup)
			    {
			        Console.WriteLine($"\t{item.FirstName} {item.LastName}");
			    }
			}
			
			
			var nestedGroupsQuery =
			    from student in students
			    group student by student.Year into newGroup1
			    from newGroup2 in
			    from student in newGroup1
			    group student by student.LastName
			    group newGroup2 by newGroup1.Key;
			
			foreach (var outerGroup in nestedGroupsQuery)
			{
			    Console.WriteLine($"DataClass.Student Level = {outerGroup.Key}");
			    foreach (var innerGroup in outerGroup)
			    {
			        Console.WriteLine($"\tNames that begin with: {innerGroup.Key}");
			        foreach (var innerGroupElement in innerGroup)
			        {
			            Console.WriteLine($"\t\t{innerGroupElement.LastName} {innerGroupElement.FirstName}");
			        }
			    }
			}
			
			var nestedGroupsQuery =
			    students
			    .GroupBy(student => student.Year)
			    .Select(newGroup1 => new
			    {
			        newGroup1.Key,
			        NestedGroup = newGroup1
			            .GroupBy(student => student.LastName)
			    });
			
			foreach (var outerGroup in nestedGroupsQuery)
			{
			    Console.WriteLine($"DataClass.Student Level = {outerGroup.Key}");
			    foreach (var innerGroup in outerGroup.NestedGroup)
			    {
			        Console.WriteLine($"\tNames that begin with: {innerGroup.Key}");
			        foreach (var innerGroupElement in innerGroup)
			        {
			            Console.WriteLine($"\t\t{innerGroupElement.LastName} {innerGroupElement.FirstName}");
			        }
			    }
			}
			
			
			var queryGroupMax =
			    from student in students
			    group student by student.Year into studentGroup
			    select new
			    {
			        Level = studentGroup.Key,
			        HighestScore = (
			            from student2 in studentGroup
			            select student2.Scores.Average()
			        ).Max()
			    };
			
			var count = queryGroupMax.Count();
			Console.WriteLine($"Number of groups = {count}");
			
			foreach (var item in queryGroupMax)
			{
			    Console.WriteLine($"  {item.Level} Highest Score={item.HighestScore}");
			}
			
			var queryGroupMax =
			    students
			        .GroupBy(student => student.Year)
			        .Select(studentGroup => new
			        {
			            Level = studentGroup.Key,
			            HighestScore = studentGroup.Max(student2 => student2.Scores.Average())
			        });
			
			var count = queryGroupMax.Count();
			Console.WriteLine($"Number of groups = {count}");
			
			foreach (var item in queryGroupMax)
			{
			    Console.WriteLine($"  {item.Level} Highest Score={item.HighestScore}");
			}
			*/
			
		}
		
		static int GetPercentile(Student s)
		{
		    double avg = s.Scores.Average();
		    return avg > 0 ? (int)avg / 10 : 0;
		}
	}
	
	public enum GradeLevel
	{
	    FirstYear = 1,
	    SecondYear,
	    ThirdYear,
	    FourthYear
	};
	
	public class Student
	{
	    public required string FirstName { get; init; }
	    public required string LastName { get; init; }
	    public required int ID { get; init; }
	
	    public required GradeLevel Year { get; init; }
	    public required List<int> Scores { get; init; }
	
	    public required int DepartmentID { get; init; }
	}
	
	public class Teacher
	{
	    public required string First { get; init; }
	    public required string Last { get; init; }
	    public required int ID { get; init; }
	    public required string City { get; init; }
	}
	
	public class Department
	{
	    public required string Name { get; init; }
	    public int ID { get; init; }
	
	    public required int TeacherID { get; init; }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/join-operations
namespace DotnetCSharpLinqStandardQueryOperatorsJoinOperations
{
	public class JoinOperations
	{
		public static void RunJoinOperations()
		{
			/*
			var query = from student in students
			            join department in departments on student.DepartmentID equals department.ID
			            select new { Name = $"{student.FirstName} {student.LastName}", DepartmentName = department.Name };
			
			foreach (var item in query)
			{
			    Console.WriteLine($"{item.Name} - {item.DepartmentName}");
			}
			
			var query = students.Join(departments,
			    student => student.DepartmentID, department => department.ID,
			    (student, department) => new { Name = $"{student.FirstName} {student.LastName}", DepartmentName = department.Name });
			
			foreach (var item in query)
			{
			    Console.WriteLine($"{item.Name} - {item.DepartmentName}");
			}
			
			IEnumerable<IEnumerable<Student>> studentGroups = from department in departments
			                    join student in students on department.ID equals student.DepartmentID into studentGroup
			                    select studentGroup;
			
			foreach (IEnumerable<Student> studentGroup in studentGroups)
			{
			    Console.WriteLine("Group");
			    foreach (Student student in studentGroup)
			    {
			        Console.WriteLine($"  - {student.FirstName}, {student.LastName}");
			    }
			}
			
			// Join department and student based on DepartmentId and grouping result
			IEnumerable<IEnumerable<Student>> studentGroups = departments.GroupJoin(students,
			    department => department.ID, student => student.DepartmentID,
			    (department, studentGroup) => studentGroup);
			
			foreach (IEnumerable<Student> studentGroup in studentGroups)
			{
			    Console.WriteLine("Group");
			    foreach (Student student in studentGroup)
			    {
			        Console.WriteLine($"  - {student.FirstName}, {student.LastName}");
			    }
			}
			
			var query = from department in departments
			            join teacher in teachers on department.TeacherID equals teacher.ID
			            select new
			            {
			                DepartmentName = department.Name,
			                TeacherName = $"{teacher.First} {teacher.Last}"
			            };
			
			foreach (var departmentAndTeacher in query)
			{
			    Console.WriteLine($"{departmentAndTeacher.DepartmentName} is managed by {departmentAndTeacher.TeacherName}");
			}
			
			var query = teachers
			    .Join(departments, teacher => teacher.ID, department => department.TeacherID,
			        (teacher, department) =>
			        new { DepartmentName = department.Name, TeacherName = $"{teacher.First} {teacher.Last}" });
			
			foreach (var departmentAndTeacher in query)
			{
			    Console.WriteLine($"{departmentAndTeacher.DepartmentName} is managed by {departmentAndTeacher.TeacherName}");
			}
			
			// Join the two data sources based on a composite key consisting of first and last name,
			// to determine which employees are also students.
			IEnumerable<string> query =
			    from teacher in teachers
			    join student in students on new
			    {
			        FirstName = teacher.First,
			        LastName = teacher.Last
			    } equals new
			    {
			        student.FirstName,
			        student.LastName
			    }
			    select teacher.First + " " + teacher.Last;
			
			string result = "The following people are both teachers and students:\r\n";
			foreach (string name in query)
			{
			    result += $"{name}\r\n";
			}
			Console.Write(result);
			
			IEnumerable<string> query = teachers
			    .Join(students,
			        teacher => new { FirstName = teacher.First, LastName = teacher.Last },
			        student => new { student.FirstName, student.LastName },
			        (teacher, student) => $"{teacher.First} {teacher.Last}"
			 );
			
			Console.WriteLine("The following people are both teachers and students:");
			foreach (string name in query)
			{
			    Console.WriteLine(name);
			}
			
			// The first join matches Department.ID and Student.DepartmentID from the list of students and
			// departments, based on a common ID. The second join matches teachers who lead departments
			// with the students studying in that department.
			var query = from student in students
			    join department in departments on student.DepartmentID equals department.ID
			    join teacher in teachers on department.TeacherID equals teacher.ID
			    select new {
			        StudentName = $"{student.FirstName} {student.LastName}",
			        DepartmentName = department.Name,
			        TeacherName = $"{teacher.First} {teacher.Last}"
			    };
			
			foreach (var obj in query)
			{
			    Console.WriteLine($"""The student "{obj.StudentName}" studies in the department run by "{obj.TeacherName}".""");
			}
			
			var query = students
			    .Join(departments, student => student.DepartmentID, department => department.ID,
			        (student, department) => new { student, department })
			    .Join(teachers, commonDepartment => commonDepartment.department.TeacherID, teacher => teacher.ID,
			        (commonDepartment, teacher) => new
			        {
			            StudentName = $"{commonDepartment.student.FirstName} {commonDepartment.student.LastName}",
			            DepartmentName = commonDepartment.department.Name,
			            TeacherName = $"{teacher.First} {teacher.Last}"
			        });
			
			foreach (var obj in query)
			{
			    Console.WriteLine($"""The student "{obj.StudentName}" studies in the department run by "{obj.TeacherName}".""");
			}
			
			var query1 =
			    from department in departments
			    join student in students on department.ID equals student.DepartmentID into gj
			    from subStudent in gj
			    select new
			    {
			        DepartmentName = department.Name,
			        StudentName = $"{subStudent.FirstName} {subStudent.LastName}"
			    };
			Console.WriteLine("Inner join using GroupJoin():");
			foreach (var v in query1)
			{
			    Console.WriteLine($"{v.DepartmentName} - {v.StudentName}");
			}
			
			var queryMethod1 = departments
			    .GroupJoin(students, department => department.ID, student => student.DepartmentID,
			        (department, gj) => new { department, gj })
			    .SelectMany(departmentAndStudent => departmentAndStudent.gj,
			        (departmentAndStudent, subStudent) => new
			        {
			            DepartmentName = departmentAndStudent.department.Name,
			            StudentName = $"{subStudent.FirstName} {subStudent.LastName}"
			        });
			
			Console.WriteLine("Inner join using GroupJoin():");
			foreach (var v in queryMethod1)
			{
			    Console.WriteLine($"{v.DepartmentName} - {v.StudentName}");
			}
			
			var query2 = from department in departments
			    join student in students on department.ID equals student.DepartmentID
			    select new
			    {
			        DepartmentName = department.Name,
			        StudentName = $"{student.FirstName} {student.LastName}"
			    };
			
			Console.WriteLine("The equivalent operation using Join():");
			foreach (var v in query2)
			{
			    Console.WriteLine($"{v.DepartmentName} - {v.StudentName}");
			}
			
			var queryMethod2 = departments.Join(students, departments => departments.ID, student => student.DepartmentID,
			    (department, student) => new
			    {
			        DepartmentName = department.Name,
			        StudentName = $"{student.FirstName} {student.LastName}"
			    });
			
			Console.WriteLine("The equivalent operation using Join():");
			foreach (var v in queryMethod2)
			{
			    Console.WriteLine($"{v.DepartmentName} - {v.StudentName}");
			}
			
			var query = from department in departments
			    join student in students on department.ID equals student.DepartmentID into studentGroup
			    select new
			    {
			        DepartmentName = department.Name,
			        Students = studentGroup
			    };
			
			foreach (var v in query)
			{
			    // Output the department's name.
			    Console.WriteLine($"{v.DepartmentName}:");
			
			    // Output each of the students in that department.
			    foreach (Student? student in v.Students)
			    {
			        Console.WriteLine($"  {student.FirstName} {student.LastName}");
			    }
			}
			
			var query = departments.GroupJoin(students, department => department.ID, student => student.DepartmentID,
			    (department, Students) => new { DepartmentName = department.Name, Students });
			
			foreach (var v in query)
			{
			    // Output the department's name.
			    Console.WriteLine($"{v.DepartmentName}:");
			
			    // Output each of the students in that department.
			    foreach (Student? student in v.Students)
			    {
			        Console.WriteLine($"  {student.FirstName} {student.LastName}");
			    }
			}
			
			XElement departmentsAndStudents = new("DepartmentEnrollment",
			    from department in departments
			    join student in students on department.ID equals student.DepartmentID into studentGroup
			    select new XElement("Department",
			        new XAttribute("Name", department.Name),
			        from student in studentGroup
			        select new XElement("Student",
			            new XAttribute("FirstName", student.FirstName),
			            new XAttribute("LastName", student.LastName)
			        )
			    )
			);
			
			Console.WriteLine(departmentsAndStudents);
			
			XElement departmentsAndStudents = new("DepartmentEnrollment",
			    departments.GroupJoin(students, department => department.ID, student => student.DepartmentID,
			        (department, Students) => new XElement("Department",
			            new XAttribute("Name", department.Name),
			            from student in Students
			            select new XElement("Student",
			                new XAttribute("FirstName", student.FirstName),
			                new XAttribute("LastName", student.LastName)
			            )
			        )
			    )
			);
			
			Console.WriteLine(departmentsAndStudents);
			
			var query =
			    from student in students
			    join department in departments on student.DepartmentID equals department.ID into gj
			    from subgroup in gj.DefaultIfEmpty()
			    select new
			    {
			        student.FirstName,
			        student.LastName,
			        Department = subgroup?.Name ?? string.Empty
			    };
			
			foreach (var v in query)
			{
			    Console.WriteLine($"{v.FirstName:-15} {v.LastName:-15}: {v.Department}");
			}
			
			var query = students
			    .GroupJoin(
			        departments,
			        student => student.DepartmentID,
			        department => department.ID,
			        (student, departmentList) => new { student, subgroup = departmentList })
			    .SelectMany(
			        joinedSet => joinedSet.subgroup.DefaultIfEmpty(),
			        (student, department) => new
			        {
			            student.student.FirstName,
			            student.student.LastName,
			            Department = department?.Name ?? string.Empty
			        });
			
			foreach (var v in query)
			{
			    Console.WriteLine($"{v.FirstName:-15} {v.LastName:-15}: {v.Department}");
			}
			*/
			
		}
	}
	
	public enum GradeLevel
	{
	    FirstYear = 1,
	    SecondYear,
	    ThirdYear,
	    FourthYear
	};
	
	public class Student
	{
	    public required string FirstName { get; init; }
	    public required string LastName { get; init; }
	    public required int ID { get; init; }
	
	    public required GradeLevel Year { get; init; }
	    public required List<int> Scores { get; init; }
	
	    public required int DepartmentID { get; init; }
	}
	
	public class Teacher
	{
	    public required string First { get; init; }
	    public required string Last { get; init; }
	    public required int ID { get; init; }
	    public required string City { get; init; }
	}
	
	public class Department
	{
	    public required string Name { get; init; }
	    public int ID { get; init; }
	
	    public required int TeacherID { get; init; }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/converting-data-types
namespace DotnetCSharpLinqStandardQueryOperatorsConvertingDataTypes
{
	public class ConvertingDataTypes
	{
		public static void RunConvertingDataTypes()
		{
			IEnumerable people = students;

			var query = from Student student in people
			            where student.Year == GradeLevel.ThirdYear
			            select student;
			
			foreach (Student student in query)
			{
			    Console.WriteLine(student.FirstName);
			}
			
			IEnumerable people2 = students;

			var query2 = people2
			    .Cast<Student>()
			    .Where(student => student.Year == GradeLevel.ThirdYear);
			
			foreach (Student student in query)
			{
			    Console.WriteLine(student.FirstName);
			}
			
		}
		
		// Create a data source by using a collection initializer.
		static IEnumerable<Student> students =
		[

		];
	}
	
	public enum GradeLevel
	{
	    FirstYear = 1,
	    SecondYear,
	    ThirdYear,
	    FourthYear
	};
	
	public class Student
	{
	    public required string FirstName { get; init; } = string.Empty;
	    public required string LastName { get; init; }
	    public required int ID { get; init; }
	
	    public required GradeLevel Year { get; init; }
	    public required List<int> Scores { get; init; }
	
	    public required int DepartmentID { get; init; }
		
		public Student(string firstName, string lastName, int id, List<int> scores)
		{
			FirstName = firstName;
			LastName = lastName;
			id = ID;
			Scores = scores;
		}
	}
	
	public class Teacher
	{
	    public required string First { get; init; }
	    public required string Last { get; init; }
	    public required int ID { get; init; }
	    public required string City { get; init; }
	}
	
	public class Department
	{
	    public required string Name { get; init; }
	    public int ID { get; init; }
	
	    public required int TeacherID { get; init; }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/partitioning-data
namespace DotnetCSharpLinqStandardQueryOperatorsPartitioningData
{
	public class PartitioningData
	{
		public static void RunPartitioningData()
		{
			foreach (int number in Enumerable.Range(0, 8).Take(3))
			{
			    Console.WriteLine(number);
			}
			// This code produces the following output:
			// 0
			// 1
			// 2
			
			foreach (int number in Enumerable.Range(0, 8).Skip(3))
			{
			    Console.WriteLine(number);
			}
			// This code produces the following output:
			// 3
			// 4
			// 5
			// 6
			// 7
			
			foreach (int number in Enumerable.Range(0, 8).TakeWhile(n => n < 5))
			{
			    Console.WriteLine(number);
			}
			// This code produces the following output:
			// 0
			// 1
			// 2
			// 3
			// 4
			
			foreach (int number in Enumerable.Range(0, 8).SkipWhile(n => n < 5))
			{
			    Console.WriteLine(number);
			}
			// This code produces the following output:
			// 5
			// 6
			// 7
			
			int chunkNumber = 1;
			foreach (int[] chunk in Enumerable.Range(0, 8).Chunk(3))
			{
			    Console.WriteLine($"Chunk {chunkNumber++}:");
			    foreach (int item in chunk)
			    {
			        Console.WriteLine($"    {item}");
			    }
			
			    Console.WriteLine();
			}
			// This code produces the following output:
			// Chunk 1:
			//    0
			//    1
			//    2
			//
			//Chunk 2:
			//    3
			//    4
			//    5
			//
			//Chunk 3:
			//    6
			//    7
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/quantifier-operations
namespace DotnetCSharpLinqStandardQueryOperatorsQuantifierOperations
{
	public class QuantifierOperations
	{
		public static void RunQuantifierOperations()
		{
			/*
			IEnumerable<string> names = from student in students
			                            where student.Scores.All(score => score > 70)
			                            select $"{student.FirstName} {student.LastName}: {string.Join(", ", student.Scores.Select(s => s.ToString()))}";
			
			foreach (string name in names)
			{
			    Console.WriteLine($"{name}");
			}
			
			// This code produces the following output:
			//
			// Cesar Garcia: 71, 86, 77, 97
			// Nancy Engström: 75, 73, 78, 83
			// Ifunanya Ugomma: 84, 82, 96, 80
			*/
			
			/*
			IEnumerable<string> names = from student in students
			                            where student.Scores.Any(score => score > 95)
			                            select $"{student.FirstName} {student.LastName}: {student.Scores.Max()}";
			
			foreach (string name in names)
			{
			    Console.WriteLine($"{name}");
			}
			
			// This code produces the following output:
			//
			// Svetlana Omelchenko: 97
			// Cesar Garcia: 97
			// Debra Garcia: 96
			// Ifeanacho Jamuike: 98
			// Ifunanya Ugomma: 96
			// Michelle Caruana: 97
			// Nwanneka Ifeoma: 98
			// Martina Mattsson: 96
			// Anastasiya Sazonova: 96
			// Jesper Jakobsson: 98
			// Max Lindgren: 96
			*/
			
			/*
			IEnumerable<string> names = from student in students
			                            where student.Scores.Contains(95)
			                            select $"{student.FirstName} {student.LastName}: {string.Join(", ", student.Scores.Select(s => s.ToString()))}";
			
			foreach (string name in names)
			{
			    Console.WriteLine($"{name}");
			}
			
			// This code produces the following output:
			//
			// Claire O'Donnell: 56, 78, 95, 95
			// Donald Urquhart: 92, 90, 95, 57
			*/
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/sorting-data
namespace DotnetCSharpLinqStandardQueryOperatorsSortingData
{
	public class SortingData
	{
		public static void RunSortingData()
		{
			/*
			IEnumerable<string> query = from teacher in teachers
			                            orderby teacher.Last
			                            select teacher.Last;
			
			foreach (string str in query)
			{
			    Console.WriteLine(str);
			}
			*/
			
			/*
			IEnumerable<string> query = teachers
			    .OrderBy(teacher => teacher.Last)
			    .Select(teacher => teacher.Last);
			
			foreach (string str in query)
			{
			    Console.WriteLine(str);
			}
			*/
			
			/*
			IEnumerable<string> query = from teacher in teachers
			                            orderby teacher.Last descending
			                            select teacher.Last;
			
			foreach (string str in query)
			{
			    Console.WriteLine(str);
			}
			*/
			
			/*
			IEnumerable<string> query = teachers
			    .OrderByDescending(teacher => teacher.Last)
			    .Select(teacher => teacher.Last);
			
			foreach (string str in query)
			{
			    Console.WriteLine(str);
			}
			*/
			
			/*
			IEnumerable<(string, string)> query = from teacher in teachers
			                            orderby teacher.City, teacher.Last
			                            select (teacher.Last, teacher.City);
			
			foreach ((string last, string city) in query)
			{
			    Console.WriteLine($"City: {city}, Last Name: {last}");
			}
			*/
			
			/*
			IEnumerable<(string, string)> query = teachers
			    .OrderBy(teacher => teacher.City)
			    .ThenBy(teacher => teacher.Last)
			    .Select(teacher => (teacher.Last, teacher.City));
			
			foreach ((string last, string city) in query)
			{
			    Console.WriteLine($"City: {city}, Last Name: {last}");
			}
			*/
			
			/*
			IEnumerable<(string, string)> query = from teacher in teachers
			                            orderby teacher.City, teacher.Last descending
			                            select (teacher.Last, teacher.City);
			
			foreach ((string last, string city) in query)
			{
			    Console.WriteLine($"City: {city}, Last Name: {last}");
			}
			*/
			
			/*
			IEnumerable<(string, string)> query = teachers
			    .OrderBy(teacher => teacher.City)
			    .ThenByDescending(teacher => teacher.Last)
			    .Select(teacher => (teacher.Last, teacher.City));
			
			foreach ((string last, string city) in query)
			{
			    Console.WriteLine($"City: {city}, Last Name: {last}");
			}
			*/
			
		}
	}
	
	public enum GradeLevel
	{
	    FirstYear = 1,
	    SecondYear,
	    ThirdYear,
	    FourthYear
	};
	
	public class Student
	{
	    public required string FirstName { get; init; }
	    public required string LastName { get; init; }
	    public required int ID { get; init; }
	
	    public required GradeLevel Year { get; init; }
	    public required List<int> Scores { get; init; }
	
	    public required int DepartmentID { get; init; }
	}
	
	public class Teacher
	{
	    public required string First { get; init; }
	    public required string Last { get; init; }
	    public required int ID { get; init; }
	    public required string City { get; init; }
	}
	
	public class Department
	{
	    public required string Name { get; init; }
	    public int ID { get; init; }
	
	    public required int TeacherID { get; init; }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/set-operations
namespace DotnetCSharpLinqStandardQueryOperatorsSetOperations
{
	public class SetOperations
	{
		public static void RunSetOperations()
		{
			string[] words = ["the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog"];

			IEnumerable<string> query = from word in words.Distinct()
			                            select word;
			
			foreach (var str in query)
			{
			    Console.WriteLine(str);
			}
			
			/* This code produces the following output:
			 *
			 * the
			 * quick
			 * brown
			 * fox
			 * jumped
			 * over
			 * lazy
			 * dog
			 */
			 
			 string[] words2 = ["the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog"];

			foreach (string word in words2.DistinctBy(p => p.Length))
			{
			    Console.WriteLine(word);
			}
			
			// This code produces the following output:
			//     the
			//     quick
			//     jumped
			//     over
			
			string[] words3 = ["the", "quick", "brown", "fox"];
			string[] words4 = ["jumped", "over", "the", "lazy", "dog"];
			
			IEnumerable<string> query2 = from word in words3.Except(words4)
			                            select word;
			
			foreach (var str in query2)
			{
			    Console.WriteLine(str);
			}
			
			/* This code produces the following output:
			 *
			 * quick
			 * brown
			 * fox
			 */
			 
			int[] teachersToExclude =
			[
			    901,    // English
			    965,    // Mathematics
			    932,    // Engineering
			    945,    // Economics
			    987,    // Physics
			    901     // Chemistry
			];
			/*
			foreach (Teacher teacher in
			    teachers.ExceptBy(
			        teachersToExclude, teacher => teacher.ID))
			{
			    Console.WriteLine($"{teacher.First} {teacher.Last}");
			}
			*/
			
			string[] words5 = ["the", "quick", "brown", "fox"];
			string[] words6 = ["jumped", "over", "the", "lazy", "dog"];
			
			IEnumerable<string> query3 = from word in words5.Intersect(words6)
			                            select word;
			
			foreach (var str in query3)
			{
			    Console.WriteLine(str);
			}
			
			/* This code produces the following output:
			 *
			 * the
			 */
			
			/*
			foreach (Student person in
			    students.IntersectBy(
			        teachers.Select(t => (t.First, t.Last)), s => (s.FirstName, s.LastName)))
			{
			    Console.WriteLine($"{person.FirstName} {person.LastName}");
			}
			*/
			
			string[] words7 = ["the", "quick", "brown", "fox"];
			string[] words8 = ["jumped", "over", "the", "lazy", "dog"];
			
			IEnumerable<string> query4 = from word in words7.Union(words8)
			                            select word;
			
			foreach (var str in query4)
			{
			    Console.WriteLine(str);
			}
			
			/* This code produces the following output:
			 *
			 * the
			 * quick
			 * brown
			 * fox
			 * jumped
			 * over
			 * lazy
			 * dog
			*/
			
			/*
			foreach (var person in
			    students.Select(s => (s.FirstName, s.LastName)).UnionBy(
			        teachers.Select(t => (FirstName: t.First, LastName: t.Last)), s => (s.FirstName, s.LastName)))
			{
			    Console.WriteLine($"{person.FirstName} {person.LastName}");
			}
			*/
		}
	}
	
	public enum GradeLevel
	{
	    FirstYear = 1,
	    SecondYear,
	    ThirdYear,
	    FourthYear
	};
	
	public class Student
	{
	    public required string FirstName { get; init; }
	    public required string LastName { get; init; }
	    public required int ID { get; init; }
	
	    public required GradeLevel Year { get; init; }
	    public required List<int> Scores { get; init; }
	
	    public required int DepartmentID { get; init; }
	}
	
	public class Teacher
	{
	    public required string First { get; init; }
	    public required string Last { get; init; }
	    public required int ID { get; init; }
	    public required string City { get; init; }
	}
	
	public class Department
	{
	    public required string Name { get; init; }
	    public int ID { get; init; }
	
	    public required int TeacherID { get; init; }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/projection-operations
namespace DotnetCSharpLinqStandardQueryOperatorsProjectionOperations
{
	public class ProjectionOperations
	{
		public static void RunProjectionOperations()
		{
			List<string> words = ["an", "apple", "a", "day"];
	
			var query = from word in words
			            select word.Substring(0, 1);
			
			foreach (string s in query)
			{
			    Console.WriteLine(s);
			}
			
			/* This code produces the following output:
			
			    a
			    a
			    a
			    d
			*/

			var query2 = words.Select(word => word.Substring(0, 1));
			
			foreach (string s in query2)
			{
			    Console.WriteLine(s);
			}
			
			/* This code produces the following output:
			
			    a
			    a
			    a
			    d
			*/
			
			List<string> phrases = ["an apple a day", "the quick brown fox"];

			var query3 = from phrase in phrases
			            from word in phrase.Split(' ')
			            select word;
			
			foreach (string s in query)
			{
			    Console.WriteLine(s);
			}
			
			/* This code produces the following output:
			
			    an
			    apple
			    a
			    day
			    the
			    quick
			    brown
			    fox
			*/
			
			var query4 = phrases.SelectMany(phrase => phrase.Split(' '));

			foreach (string s in query4)
			{
			    Console.WriteLine(s);
			}
			
			/* This code produces the following output:
			
			    an
			    apple
			    a
			    day
			    the
			    quick
			    brown
			    fox
			*/
			
			// An int array with 7 elements.
			IEnumerable<int> numbers = [1, 2, 3, 4, 5, 6, 7];
			// A char array with 6 elements.
			IEnumerable<char> letters = ['A', 'B', 'C', 'D', 'E', 'F'];
			
			
			var query5 = from number in numbers
			            from letter in letters
			            select (number, letter);
			
			foreach (var item in query5)
			{
			    Console.WriteLine(item);
			}
			
			var method = numbers
			    .SelectMany(number => letters,
			    (number, letter) => (number, letter));
			
			foreach (var item in method)
			{
			    Console.WriteLine(item);
			}
			
			foreach ((int number, char letter) in numbers.Zip(letters))
			{
			    Console.WriteLine($"Number: {number} zipped with letter: '{letter}'");
			}
			// This code produces the following output:
			//     Number: 1 zipped with letter: 'A'
			//     Number: 2 zipped with letter: 'B'
			//     Number: 3 zipped with letter: 'C'
			//     Number: 4 zipped with letter: 'D'
			//     Number: 5 zipped with letter: 'E'
			//     Number: 6 zipped with letter: 'F'
			
			// A string array with 8 elements.
			IEnumerable<string> emoji = [ "🤓", "🔥", "🎉", "👀", "⭐", "💜", "✔", "💯"];
			
			foreach ((int number, char letter, string em) in numbers.Zip(letters, emoji))
			{
			    Console.WriteLine(
			        $"Number: {number} is zipped with letter: '{letter}' and emoji: {em}");
			}
			// This code produces the following output:
			//     Number: 1 is zipped with letter: 'A' and emoji: 🤓
			//     Number: 2 is zipped with letter: 'B' and emoji: 🔥
			//     Number: 3 is zipped with letter: 'C' and emoji: 🎉
			//     Number: 4 is zipped with letter: 'D' and emoji: 👀
			//     Number: 5 is zipped with letter: 'E' and emoji: ⭐
			//     Number: 6 is zipped with letter: 'F' and emoji: 💜
			
			foreach (string result in
			    numbers.Zip(letters, (number, letter) => $"{number} = {letter} ({(int)letter})"))
			{
			    Console.WriteLine(result);
			}
			// This code produces the following output:
			//     1 = A (65)
			//     2 = B (66)
			//     3 = C (67)
			//     4 = D (68)
			//     5 = E (69)
			//     6 = F (70)
			
			
			
		}
		
		static void SelectVsSelectMany()
		{
		    List<Bouquet> bouquets =
		    [
		        new Bouquet { Flowers = ["sunflower", "daisy", "daffodil", "larkspur"] },
		        new Bouquet { Flowers = ["tulip", "rose", "orchid"] },
		        new Bouquet { Flowers = ["gladiolis", "lily", "snapdragon", "aster", "protea"] },
		        new Bouquet { Flowers = ["larkspur", "lilac", "iris", "dahlia"] }
		    ];
		
		    IEnumerable<List<string>> query1 = bouquets.Select(bq => bq.Flowers);
		
		    IEnumerable<string> query2 = bouquets.SelectMany(bq => bq.Flowers);
		
		    Console.WriteLine("Results by using Select():");
		    // Note the extra foreach loop here.
		    foreach (IEnumerable<string> collection in query1)
		    {
		        foreach (string item in collection)
		        {
		            Console.WriteLine(item);
		        }
		    }
		
		    Console.WriteLine("\nResults by using SelectMany():");
		    foreach (string item in query2)
		    {
		        Console.WriteLine(item);
		    }
		}
		
	}
	
	class Bouquet
	{
	    public required List<string> Flowers { get; init; }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/filtering-data
namespace DotnetCSharpLinqStandardQueryOperatorsFilteringData
{
	public class CSharpLinqStandardQueryOperatorsFilteringData
	{
		public static void RunDotnetCSharpLinqStandardQueryOperatorsFilteringData()
		{
			string[] words = ["the", "quick", "brown", "fox", "jumps"];

			IEnumerable<string> query = from word in words
			                            where word.Length == 3
			                            select word;
			
			foreach (string str in query)
			{
			    Console.WriteLine(str);
			}
			
			/* This code produces the following output:
			
			    the
			    fox
			*/
			
			IEnumerable<string> query2 =
			    words.Where(word => word.Length == 3);
			
			foreach (string str in query)
			{
			    Console.WriteLine(str);
			}
			
			/* This code produces the following output:
			
			    the
			    fox
			*/
			
		}
	
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/
namespace DotnetCSharpLinqStandardQueryOperators
{
	public class StandardQueryOperators
	{
		public static void RunStandardQueryOperators()
		{
			string sentence = "the quick brown fox jumps over the lazy dog";
			// Split the string into individual words to create a collection.
			string[] words = sentence.Split(' ');
			
			// Using query expression syntax.
			var query = from word in words
			            group word.ToUpper() by word.Length into gr
			            orderby gr.Key
			            select new { Length = gr.Key, Words = gr };
			
			// Using method-based query syntax.
			var query2 = words.
			    GroupBy(w => w.Length, w => w.ToUpper()).
			    Select(g => new { Length = g.Key, Words = g }).
			    OrderBy(o => o.Length);
			
			foreach (var obj in query)
			{
			    Console.WriteLine($"Words of length {obj.Length}:");
			    foreach (string word in obj.Words)
			        Console.WriteLine(word);
			}
			
			// This code example produces the following output:
			//
			// Words of length 3:
			// THE
			// FOX
			// THE
			// DOG
			// Words of length 4:
			// OVER
			// LAZY
			// Words of length 5:
			// QUICK
			// BROWN
			// JUMPS
			
			//queryAllStudents is an IEnumerable<Student>
			/*
			var queryAllStudents = from student in students
			                        select student;
			*/
			
			// Create the query.
			/*
			var studentsToXML = new XElement("Root",
			    from student in students
			    let scores = string.Join(",", student.Scores)
			    select new XElement("student",
			                new XElement("First", student.FirstName),
			                new XElement("Last", student.LastName),
			                new XElement("Scores", scores)
			            ) // end "student"
			        ); // end "Root"
			
			// Execute the query.
			Console.WriteLine(studentsToXML);
			*/
			/*
			var orderedQuery = from department in departments
			                   join student in students on department.ID equals student.DepartmentID into studentGroup
			                   orderby department.Name
			                   select new
			                   {
			                       DepartmentName = department.Name,
			                       Students = from student in studentGroup
			                                  orderby student.LastName
			                                    select student
			                   };
			
			foreach (var departmentList in orderedQuery)
			{
			    Console.WriteLine(departmentList.DepartmentName);
			    foreach (var student in departmentList.Students)
			    {
			        Console.WriteLine($"  {student.LastName,-10} {student.FirstName,-10}");
			    }
			}
			*/
			/* Output:
			Chemistry
			  Balzan     Josephine
			  Fakhouri   Fadi
			  Popov      Innocenty
			  Seleznyova Sofiya
			  Vella      Carmen
			Economics
			  Adams      Terry
			  Adaobi     Izuchukwu
			  Berggren   Jeanette
			  Garcia     Cesar
			  Ifeoma     Nwanneka
			  Jamuike    Ifeanacho
			  Larsson    Naima
			  Svensson   Noel
			  Ugomma     Ifunanya
			Engineering
			  Axelsson   Erik
			  Berg       Veronika
			  Engström   Nancy
			  Hicks      Cassie
			  Keever     Bruce
			  Micallef   Nicholas
			  Mortensen  Sven
			  Nilsson    Erna
			  Tucker     Michael
			  Yermolayeva Anna
			English
			  Andersson  Sarah
			  Feng       Hanying
			  Ivanova    Arina
			  Jakobsson  Jesper
			  Jensen     Christiane
			  Johansson  Mark
			  Kolpakova  Nadezhda
			  Omelchenko Svetlana
			  Urquhart   Donald
			Mathematics
			  Frost      Gaby
			  Garcia     Hugo
			  Hedlund    Anna
			  Kovaleva   Katerina
			  Lindgren   Max
			  Maslova    Evgeniya
			  Olsson     Ruth
			  Sammut     Maria
			  Sazonova   Anastasiya
			Physics
			  Åkesson    Sami
			  Edwards    Amy E.
			  Falzon     John
			  Garcia     Debra
			  Hansson    Sanna
			  Mattsson   Martina
			  Richardson Don
			  Zabokritski Eugene
			*/
			
			/*
			var orderedQuery = departments
			    .GroupJoin(students, department => department.ID, student => student.DepartmentID,
			    (department, studentGroup) => new
			    {
			        DepartmentName = department.Name,
			        Students = studentGroup.OrderBy(student => student.LastName)
			    })
			    .OrderBy(department => department.DepartmentName);
			
			
			foreach (var departmentList in orderedQuery)
			{
			    Console.WriteLine(departmentList.DepartmentName);
			    foreach (var student in departmentList.Students)
			    {
			        Console.WriteLine($"  {student.LastName,-10} {student.FirstName,-10}");
			    }
			}
			*/
		}
	}
	
	public enum GradeLevel
	{
	    FirstYear = 1,
	    SecondYear,
	    ThirdYear,
	    FourthYear
	};
	
	public class Student
	{
	    public required string FirstName { get; init; }
	    public required string LastName { get; init; }
	    public required int ID { get; init; }
	
	    public required GradeLevel Year { get; init; }
	    public required List<int> Scores { get; init; }
	
	    public required int DepartmentID { get; init; }
	}
	
	public class Teacher
	{
	    public required string First { get; init; }
	    public required string Last { get; init; }
	    public required int ID { get; init; }
	    public required string City { get; init; }
	}
	
	public class Department
	{
	    public required string Name { get; init; }
	    public int ID { get; init; }
	
	    public required int TeacherID { get; init; }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/walkthrough-writing-queries-linq
namespace DotnetCSharpLinqGetStartedWalkthroughWritingQueriesLinq
{
	public class WritingQueriesLinq
	{
		public static void RunWritingQueriesLinq()
		{
			// See https://aka.ms/new-console-template for more information
			Console.WriteLine("Hello, World!");
			
			// Create a data source by using a collection initializer.
			IEnumerable<Student> students =
			[
			    new Student(First: "Svetlana", Last: "Omelchenko", ID: 111, Scores: [97, 92, 81, 60]),
			    new Student(First: "Claire",   Last: "O'Donnell",  ID: 112, Scores: [75, 84, 91, 39]),
			    new Student(First: "Sven",     Last: "Mortensen",  ID: 113, Scores: [88, 94, 65, 91]),
			    new Student(First: "Cesar",    Last: "Garcia",     ID: 114, Scores: [97, 89, 85, 82]),
			    new Student(First: "Debra",    Last: "Garcia",     ID: 115, Scores: [35, 72, 91, 70]),
			    new Student(First: "Fadi",     Last: "Fakhouri",   ID: 116, Scores: [99, 86, 90, 94]),
			    new Student(First: "Hanying",  Last: "Feng",       ID: 117, Scores: [93, 92, 80, 87]),
			    new Student(First: "Hugo",     Last: "Garcia",     ID: 118, Scores: [92, 90, 83, 78]),
			
			    new Student("Lance",   "Tucker",      119, [68, 79, 88, 92]),
			    new Student("Terry",   "Adams",       120, [99, 82, 81, 79]),
			    new Student("Eugene",  "Zabokritski", 121, [96, 85, 91, 60]),
			    new Student("Michael", "Tucker",      122, [94, 92, 91, 91])
			];
			
			// Create the query.
			// The first line could also be written as "var studentQuery ="
			IEnumerable<Student> studentQuery =
			    from student in students
			    where student.Scores[0] > 90 && student.Scores[3] < 80
				//orderby student.Last ascending
				orderby student.Scores[0] descending
			    select student;
			
			// Execute the query.
			// var could be used here also.
			foreach (Student student in studentQuery)
			{
			    Console.WriteLine($"{student.Last}, {student.First} {student.Scores[0]}");
			}
			
			// Output:
			// Omelchenko, Svetlana
			// Garcia, Cesar
			// Fakhouri, Fadi
			// Feng, Hanying
			// Garcia, Hugo
			// Adams, Terry
			// Zabokritski, Eugene
			// Tucker, Michael
			
			IEnumerable<IGrouping<char, Student>> studentQuery2 =
			    from student in students
			    group student by student.Last[0];
				
			foreach (IGrouping<char, Student> studentGroup in studentQuery2)
			{
			    Console.WriteLine(studentGroup.Key);
			    foreach (Student student in studentGroup)
			    {
			        Console.WriteLine($"   {student.Last}, {student.First}");
			    }
			}
			// Output:
			// O
			//   Omelchenko, Svetlana
			//   O'Donnell, Claire
			// M
			//   Mortensen, Sven
			// G
			//   Garcia, Cesar
			//   Garcia, Debra
			//   Garcia, Hugo
			// F
			//   Fakhouri, Fadi
			//   Feng, Hanying
			// T
			//   Tucker, Lance
			//   Tucker, Michael
			// A
			//   Adams, Terry
			// Z
			//   Zabokritski, Eugene
			
			IEnumerable<IGrouping<char, Student>> studentQuery3 =
			    from student in students
			    group student by student.Last[0];
			
			foreach (IGrouping<char, Student> studentGroup in studentQuery3)
			{
			    Console.WriteLine(studentGroup.Key);
			    foreach (Student student in studentGroup)
			    {
			        Console.WriteLine($"   {student.Last}, {student.First}");
			    }
			}
			
			var studentQuery4 =
			    from student in students
			    group student by student.Last[0] into studentGroup
			    orderby studentGroup.Key
			    select studentGroup;
			
			foreach (var groupOfStudents in studentQuery4)
			{
			    Console.WriteLine(groupOfStudents.Key);
			    foreach (var student in groupOfStudents)
			    {
			        Console.WriteLine($"   {student.Last}, {student.First}");
			    }
			}
			
			// Output:
			//A
			//   Adams, Terry
			//F
			//   Fakhouri, Fadi
			//   Feng, Hanying
			//G
			//   Garcia, Cesar
			//   Garcia, Debra
			//   Garcia, Hugo
			//M
			//   Mortensen, Sven
			//O
			//   Omelchenko, Svetlana
			//   O'Donnell, Claire
			//T
			//   Tucker, Lance
			//   Tucker, Michael
			//Z
			//   Zabokritski, Eugene
			
			// This query returns those students whose
			// first test score was higher than their
			// average score.
			var studentQuery5 =
			    from student in students
			    let totalScore = student.Scores[0] + student.Scores[1] +
			        student.Scores[2] + student.Scores[3]
			    where totalScore / 4 < student.Scores[0]
			    select $"{student.Last}, {student.First}";
			
			foreach (string s in studentQuery5)
			{
			    Console.WriteLine(s);
			}
			
			// Output:
			// Omelchenko, Svetlana
			// O'Donnell, Claire
			// Mortensen, Sven
			// Garcia, Cesar
			// Fakhouri, Fadi
			// Feng, Hanying
			// Garcia, Hugo
			// Adams, Terry
			// Zabokritski, Eugene
			// Tucker, Michael
			
			var studentQuery6 =
			    from student in students
			    let totalScore = student.Scores[0] + student.Scores[1] +
			        student.Scores[2] + student.Scores[3]
			    select totalScore;
			
			double averageScore = studentQuery6.Average();
			Console.WriteLine($"Class average score = {averageScore}");
			
			// Output:
			// Class average score = 334.166666666667
			
			IEnumerable<string> studentQuery7 =
			    from student in students
			    where student.Last == "Garcia"
			    select student.First;
			
			Console.WriteLine("The Garcias in the class are:");
			foreach (string s in studentQuery7)
			{
			    Console.WriteLine(s);
			}
			
			// Output:
			// The Garcias in the class are:
			// Cesar
			// Debra
			// Hugo
			
			var aboveAverageQuery =
			    from student in students
			    let x = student.Scores[0] + student.Scores[1] +
			        student.Scores[2] + student.Scores[3]
			    where x > averageScore
			    select new { id = student.ID, score = x };
			
			foreach (var item in aboveAverageQuery)
			{
			    Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
			}
			
			// Output:
			// Student ID: 113, Score: 338
			// Student ID: 114, Score: 353
			// Student ID: 116, Score: 369
			// Student ID: 117, Score: 352
			// Student ID: 118, Score: 343
			// Student ID: 120, Score: 341
			// Student ID: 122, Score: 368
			
		}
	}
	
	public record Student(string First, string Last, int ID, int[] Scores);
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/features-that-support-linq
namespace DotnetCSharpLinqGetStartedFeaturesThatSupportLinq
{
	public class FeaturesThatSupportLinq
	{
		public static void RunFeaturesThatSupportLinq()
		{
			/*
			var query = from str in stringArray
			            group str by str[0] into stringGroup
			            orderby stringGroup.Key
			            select stringGroup;
			*/
			
			/*
			var number = 5;
			var name = "Virginia";
			var query = from str in stringArray
			            where str[0] == 'm'
			            select str;
			*/
			
			//var cust = new Customer { Name = "Mike", Phone = "555-1212" };
			
			/*
			var newLargeOrderCustomers = from o in IncomingOrders
			                            where o.OrderSize > 5
			                            select new Customer { Name = o.Name, Phone = o.Phone };
			*/
			
			//var newLargeOrderCustomers = IncomingOrders.Where(x => x.OrderSize > 5).Select(y => new Customer { Name = y.Name, Phone = y.Phone });
			
			//select new {name = cust.Name, phone = cust.Phone};
			
			int[] nums = [ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 ];

			var myQuery1 = QueryMethod1(nums);
			
			foreach (var s in myQuery1)
			{
			    Console.WriteLine(s);
			}
			
			foreach (var s in QueryMethod1(nums))
			{
			    Console.WriteLine(s);
			}
			
			QueryMethod2(nums, out IEnumerable<string> myQuery2);

			// Execute the returned query.
			foreach (var s in myQuery2)
			{
			    Console.WriteLine(s);
			}
			
			myQuery1 = from item in myQuery1
           orderby item descending
           select item;

			// Execute the modified query.
			Console.WriteLine("\nResults of executing modified myQuery1:");
			foreach (var s in myQuery1)
			{
			    Console.WriteLine(s);
			}
										
			
		}
		
		static IEnumerable<string> QueryMethod1(int[] ints) =>
		    from i in ints
		    where i > 4
		    select i.ToString();
		
		static void QueryMethod2(int[] ints, out IEnumerable<string> returnQ) =>
		    returnQ = from i in ints
		              where i < 4
		              select i.ToString();
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/type-relationships-in-linq-query-operations
namespace DotnetCSharpLinqGetStartedTypeRelationshipsInLinqQueryOperations
{
	public class TypeRelationshipsInQueryOperations
	{
		public static void RunTypeRelationshipsInQueryOperations()
		{
			/*
			IEnumerable<Customer> customerQuery = from cust in customers
			                                      where cust.City == "London"
			                                      select cust;
			
			foreach (Customer customer in customerQuery)
			{
			    Console.WriteLine($"{customer.LastName}, {customer.FirstName}");
			}
			*/
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/write-linq-queries
namespace DotnetCSharpLinqGetStartedWriteLinqQueries
{
	public class WriteLinqQueries
	{
		public static void RunWriteLinqQueries()
		{
			int[] numbers = [ 5, 10, 8, 3, 6, 12 ];

			//Query syntax:
			IEnumerable<int> numQuery1 =
			    from num in numbers
			    where num % 2 == 0
			    orderby num
			    select num;
			
			//Method syntax:
			IEnumerable<int> numQuery2 = numbers
			    .Where(num => num % 2 == 0)
			    .OrderBy(n => n);
			
			foreach (int i in numQuery1)
			{
			    Console.Write(i + " ");
			}
			Console.WriteLine(System.Environment.NewLine);
			foreach (int i in numQuery2)
			{
			    Console.Write(i + " ");
			}
			
			List<int> numbers2 = [ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 ];

			// The query variables can also be implicitly typed by using var
			
			// Query #1.
			IEnumerable<int> filteringQuery =
			    from num in numbers2
			    where num is < 3 or > 7
			    select num;
			
			// Query #2.
			IEnumerable<int> orderingQuery =
			    from num in numbers2
			    where num is < 3 or > 7
			    orderby num ascending
			    select num;
			
			// Query #3.
			string[] groupingQuery = ["carrots", "cabbage", "broccoli", "beans", "barley"];
			IEnumerable<IGrouping<char, string>> queryFoodGroups =
			    from item in groupingQuery
			    group item by item[0];
				
			List<int> numbers3 = [ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 ];
			List<int> numbers4 = [ 15, 14, 11, 13, 19, 18, 16, 17, 12, 10 ];
			
			// Query #4.
			double average = numbers3.Average();
			
			// Query #5.
			IEnumerable<int> concatenationQuery = numbers3.Concat(numbers4);
			
			// Query #6.
			IEnumerable<int> largeNumbersQuery = numbers2.Where(c => c > 15);
			
			// var is used for convenience in these queries
			double average2 = numbers3.Average();
			var concatenationQuery2 = numbers3.Concat(numbers4);
			var largeNumbersQuery2 = numbers4.Where(c => c > 15);
			
			// Query #7.

			// Using a query expression with method syntax
			var numCount1 = (
			    from num in numbers3
			    where num is > 3 and < 7
			    select num
			).Count();
			
			// Better: Create a new variable to store
			// the method call result
			IEnumerable<int> numbersQuery =
			    from num in numbers3
			    where num is > 3 and < 7
			    select num;
			
			var numCount2 = numbersQuery.Count();
			
			//var numCount = (from num in numbers...
			
			var numCount = numbers.Count(n => n is > 3 and < 7);
			
			int[] ids = [ 111, 114, 112 ];
			/*
			var queryNames = from student in students
			                 where ids.Contains(student.ID)
			                 select new
			                 {
			                     student.LastName,
			                     student.ID
			                 };
			
			foreach (var name in queryNames)
			{
			    Console.WriteLine($"{name.LastName}: {name.ID}");
			}
			*/
			
			/* Output:
			    Garcia: 114
			    O'Donnell: 112
			    Omelchenko: 111
			 */
			
			// Change the ids.
			ids = [ 122, 117, 120, 115 ];
			
			// The query will now return different results
			/*
			foreach (var name in queryNames)
			{
			    Console.WriteLine($"{name.LastName}: {name.ID}");
			}
			*/
			
			/* Output:
			    Adams: 120
			    Feng: 117
			    Garcia: 115
			    Tucker: 122
			 */
			 
			 
			
			
		}
		
		
		
		static readonly City[] cities = [
		    new City("Tokyo", 37_833_000),
		    new City("Delhi", 30_290_000),
		    new City("Shanghai", 27_110_000),
		    new City("São Paulo", 22_043_000),
		    new City("Mumbai", 20_412_000),
		    new City("Beijing", 20_384_000),
		    new City("Cairo", 18_772_000),
		    new City("Dhaka", 17_598_000),
		    new City("Osaka", 19_281_000),
		    new City("New York-Newark", 18_604_000),
		    new City("Karachi", 16_094_000),
		    new City("Chongqing", 15_872_000),
		    new City("Istanbul", 15_029_000),
		    new City("Buenos Aires", 15_024_000),
		    new City("Kolkata", 14_850_000),
		    new City("Lagos", 14_368_000),
		    new City("Kinshasa", 14_342_000),
		    new City("Manila", 13_923_000),
		    new City("Rio de Janeiro", 13_374_000),
		    new City("Tianjin", 13_215_000)
		];
		
		static readonly Country[] countries = [
		    new Country ("Vatican City", 0.44, 526, [new City("Vatican City", 826)]),
		    new Country ("Monaco", 2.02, 38_000, [new City("Monte Carlo", 38_000)]),
		    new Country ("Nauru", 21, 10_900, [new City("Yaren", 1_100)]),
		    new Country ("Tuvalu", 26, 11_600, [new City("Funafuti", 6_200)]),
		    new Country ("San Marino", 61, 33_900, [new City("San Marino", 4_500)]),
		    new Country ("Liechtenstein", 160, 38_000, [new City("Vaduz", 5_200)]),
		    new Country ("Marshall Islands", 181, 58_000, [new City("Majuro", 28_000)]),
		    new Country ("Saint Kitts & Nevis", 261, 53_000, [new City("Basseterre", 13_000)])
		];
	}
	
	record City(string Name, long Population);
	record Country(string Name, double Area, long Population, List<City> Cities);
	record Product(string Name, string Category);
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/query-expression-basics
namespace DotnetCSharpLinqGetStartedQueryExpressionBasics
{
	public class QueryExpressionBasics
	{
		public static void RunQueryExpressionBasics()
		{
			/*
			IEnumerable<int> highScoresQuery =
			    from score in scores
			    where score > 80
			    orderby score descending
			    select score;
			*/
			
			/*
			IEnumerable<string> highScoresQuery2 =
			    from score in scores
			    where score > 80
			    orderby score descending
			    select $"The score is {score}";
			*/
			
			/*
			var highScoreCount = (
			    from score in scores
			    where score > 80
			    select score
			).Count();
			*/
			
			/*
			IEnumerable<int> highScoresQuery3 =
			    from score in scores
			    where score > 80
			    select score;
			
			var scoreCount = highScoresQuery3.Count();
			*/
			
			// Data source.
			int[] scores = [90, 71, 82, 93, 75, 82];
			
			// Query Expression.
			IEnumerable<int> scoreQuery = //query variable
			    from score in scores //required
			    where score > 80 // optional
			    orderby score descending // optional
			    select score; //must end with select or group
			
			// Execute the query to produce the results
			foreach (var testScore in scoreQuery)
			{
			    Console.WriteLine(testScore);
			}
			
			// Output: 93 90 82 82
			
			City[] cities = [
			    new City("Tokyo", 37_833_000),
			    new City("Delhi", 30_290_000),
			    new City("Shanghai", 27_110_000),
			    new City("São Paulo", 22_043_000)
			];
			
			//Query syntax
			IEnumerable<City> queryMajorCities =
			    from city in cities
			    where city.Population > 30_000_000
			    select city;
			
			// Execute the query to produce the results
			foreach (City city in queryMajorCities)
			{
			    Console.WriteLine(city);
			}
			
			// Output:
			// City { Name = Tokyo, Population = 37833000 }
			// City { Name = Delhi, Population = 30290000 }
			
			// Method-based syntax
			IEnumerable<City> queryMajorCities2 = cities.Where(c => c.Population > 30_000_000);
			// Execute the query to produce the results
			foreach (City city in queryMajorCities2)
			{
			    Console.WriteLine(city);
			}
			// Output:
			// City { Name = Tokyo, Population = 37833000 }
			// City { Name = Delhi, Population = 30290000 }
			
			var highestScore = (
			    from score in scores
			    select score
			).Max();
			
			// or split the expression
			IEnumerable<int> scoreQuery2 =
			    from score in scores
			    select score;
			
			var highScore = scoreQuery2.Max();
			// the following returns the same result
			highScore = scores.Max();
			
			var largeCitiesList = (
			    from country in countries
			    from city in country.Cities
			    where city.Population > 10000
			    select city
			).ToList();
			
			// or split the expression
			IEnumerable<City> largeCitiesQuery =
			    from country in countries
			    from city in country.Cities
			    where city.Population > 10000
			    select city;
			var largeCitiesList2 = largeCitiesQuery.ToList();
			
			var queryCities =
			    from city in cities
			    where city.Population > 100000
			    select city;
				
			IEnumerable<Country> countryAreaQuery =
			    from country in countries
			    where country.Area > 20 //sq km
			    select country;
				
			IEnumerable<City> cityQuery =
			    from country in countries
			    from city in country.Cities
			    where city.Population > 10000
			    select city;
				
			var queryCountryGroups =
			    from country in countries
			    group country by country.Name[0];
				
			IEnumerable<Country> sortedQuery =
			    from country in countries
			    orderby country.Area
			    select country;
				
			var queryNameAndPop =
			    from country in countries
			    select new
			    {
			        Name = country.Name,
			        Pop = country.Population
			    };
				
			// percentileQuery is an IEnumerable<IGrouping<int, Country>>
			var percentileQuery =
			    from country in countries
			    let percentile = (int)country.Population / 1_000
			    group country by percentile into countryGroup
			    where countryGroup.Key >= 20
			    orderby countryGroup.Key
			    select countryGroup;
			
			// grouping is an IGrouping<int, Country>
			foreach (var grouping in percentileQuery)
			{
			    Console.WriteLine(grouping.Key);
			    foreach (var country in grouping)
			    {
			        Console.WriteLine(country.Name + ":" + country.Population);
			    }
			}
			
			IEnumerable<City> queryCityPop =
			    from city in cities
			    where city.Population is < 15_000_000 and > 10_000_000
			    select city;
				
			IEnumerable<Country> querySortedCountries =
			    from country in countries
			    orderby country.Area, country.Population descending
			    select country;
				
			/*
			var categoryQuery =
			    from cat in categories
			    join prod in products on cat equals prod.Category
			    select new
			    {
			        Category = cat,
			        Name = prod.Name
			    };
			*/
			
			string[] names = ["Svetlana Omelchenko", "Claire O'Donnell", "Sven Mortensen", "Cesar Garcia"];
			IEnumerable<string> queryFirstNames =
			    from name in names
			    let firstName = name.Split(' ')[0]
			    select firstName;
			
			foreach (var s in queryFirstNames)
			{
			    Console.Write(s + " ");
			}
			
			//Output: Svetlana Claire Sven Cesar
			
			/*
			var queryGroupMax =
			    from student in students
			    group student by student.Year into studentGroup
			    select new
			    {
			        Level = studentGroup.Key,
			        HighestScore = (
			            from student2 in studentGroup
			            select student2.ExamScores.Average()
			        ).Max()
			    };
			*/
			
			//FilterByYearType(true);

			/* Output:
			    The following students are at an odd year level:
			    Fakhouri: 116
			    Feng: 117
			    Garcia: 115
			    Mortensen: 113
			    Tucker: 119
			    Tucker: 122
			 */
			
			//FilterByYearType(false);
			
			/* Output:
			    The following students are at an even year level:
			    Adams: 120
			    Garcia: 114
			    Garcia: 118
			    O'Donnell: 112
			    Omelchenko: 111
			    Zabokritski: 121
			 */
			 
			 /*
			 var query1 = from c in categories
             where c != null
             join p in products on c.ID equals p?.CategoryID
             select new
             {
                 Category = c.Name,
                 Name = p.Name
             };
			 */
			 
			 /*
			 var query =
			    from o in db.Orders
			    join e in db.Employees
			        on o.EmployeeID equals (int?)e.EmployeeID
			    select new { o.OrderID, e.FirstName };
			*/
			
			// DO THIS with a datasource that might
			// throw an exception.
			IEnumerable<int>? dataSource = null;
			try
			{
			    dataSource = GetData();
			}
			catch (InvalidOperationException)
			{
			    Console.WriteLine("Invalid operation");
			}
			
			if (dataSource is not null)
			{
			    // If we get here, it is safe to proceed.
			    var query = from i in dataSource
			                select i * i;
			
			    foreach (var i in query)
			    {
			        Console.WriteLine(i.ToString());
			    }
			}
			
			// Not very useful as a general purpose method.
			string SomeMethodThatMightThrow(string s) =>
			    s[4] == 'C' ?
			        throw new InvalidOperationException() :
			        $"""C:\newFolder\{s}""";
			
			// Data source.
			string[] files = ["fileA.txt", "fileB.txt", "fileC.txt"];
			
			// Demonstration query that throws.
			var exceptionDemoQuery = from file in files
			                         let n = SomeMethodThatMightThrow(file)
			                         select n;
			
			try
			{
			    foreach (var item in exceptionDemoQuery)
			    {
			        Console.WriteLine($"Processing {item}");
			    }
			}
			catch (InvalidOperationException e)
			{
			    Console.WriteLine(e.Message);
			}
			
			/* Output:
			    Processing C:\newFolder\fileA.txt
			    Processing C:\newFolder\fileB.txt
			    Operation is not valid due to the current state of the object.
			 */
			
			
			
			
			
		}
		
		static readonly City[] cities = [
		    new City("Tokyo", 37_833_000),
		    new City("Delhi", 30_290_000),
		    new City("Shanghai", 27_110_000),
		    new City("São Paulo", 22_043_000),
		    new City("Mumbai", 20_412_000),
		    new City("Beijing", 20_384_000),
		    new City("Cairo", 18_772_000),
		    new City("Dhaka", 17_598_000),
		    new City("Osaka", 19_281_000),
		    new City("New York-Newark", 18_604_000),
		    new City("Karachi", 16_094_000),
		    new City("Chongqing", 15_872_000),
		    new City("Istanbul", 15_029_000),
		    new City("Buenos Aires", 15_024_000),
		    new City("Kolkata", 14_850_000),
		    new City("Lagos", 14_368_000),
		    new City("Kinshasa", 14_342_000),
		    new City("Manila", 13_923_000),
		    new City("Rio de Janeiro", 13_374_000),
		    new City("Tianjin", 13_215_000)
		];
		
		static readonly Country[] countries = [
		    new Country ("Vatican City", 0.44, 526, [new City("Vatican City", 826)]),
		    new Country ("Monaco", 2.02, 38_000, [new City("Monte Carlo", 38_000)]),
		    new Country ("Nauru", 21, 10_900, [new City("Yaren", 1_100)]),
		    new Country ("Tuvalu", 26, 11_600, [new City("Funafuti", 6_200)]),
		    new Country ("San Marino", 61, 33_900, [new City("San Marino", 4_500)]),
		    new Country ("Liechtenstein", 160, 38_000, [new City("Vaduz", 5_200)]),
		    new Country ("Marshall Islands", 181, 58_000, [new City("Majuro", 28_000)]),
		    new Country ("Saint Kitts & Nevis", 261, 53_000, [new City("Basseterre", 13_000)])
		];
		
		/*
		static Category?[] categories =
		[
		    new ("brass", 1),
		    null,
		    new ("winds", 2),
		    default,
		    new ("percussion", 3)
		];
		
		static Product?[] products =
		[
		    new Product("Trumpet", 1),
		    new Product("Trombone", 1),
		    new Product("French Horn", 1),
		    null,
		    new Product("Clarinet", 2),
		    new Product("Flute", 2),
		    null,
		    new Product("Cymbal", 3),
		    new Product("Drum", 3)
		];
		*/

		
		/*
		void FilterByYearType(bool oddYear)
		{
		    IEnumerable<Student> studentQuery = oddYear
		        ? (from student in students
		           where student.Year is GradeLevel.FirstYear or GradeLevel.ThirdYear
		           select student)
		        : (from student in students
		           where student.Year is GradeLevel.SecondYear or GradeLevel.FourthYear
		           select student);
		    var descr = oddYear ? "odd" : "even";
		    Console.WriteLine($"The following students are at an {descr} year level:");
		    foreach (Student name in studentQuery)
		    {
		        Console.WriteLine($"{name.LastName}: {name.ID}");
		    }
		}
		*/
		
		// A data source that is very likely to throw an exception!
		public static IEnumerable<int> GetData() => throw new InvalidOperationException();
	}
	
	
	record City(string Name, long Population);
	record Country(string Name, double Area, long Population, List<City> Cities);
	record Product(string Name, string Category);
	
	/*
	record Product(string Name, int CategoryID);
	record Category(string Name, int ID);
	*/
	
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/introduction-to-linq-queries
namespace DotnetCSharpLinqGetStartedIntroductionToLinqQueries
{
	public class IntroductionToLinqQueries
	{
		public static void RunIntroductionToLinqQueries()
		{
			// The Three Parts of a LINQ Query:
			// 1. Data source.
			int[] numbers = [ 0, 1, 2, 3, 4, 5, 6 ];
			
			// 2. Query creation.
			// numQuery is an IEnumerable<int>
			var numQuery = from num in numbers
			               where (num % 2) == 0
			               select num;
			
			// 3. Query execution.
			foreach (int num in numQuery)
			{
			    Console.Write("{0,1} ", num);
			}
			
			// Create a data source from an XML document.
			// using System.Xml.Linq;
			XElement contacts = XElement.Load(@"c:\myContactList.xml");
			
			/*
			Northwnd db = new Northwnd(@"c:\northwnd.mdf");

			// Query for customers in London.
			IQueryable<Customer> custQuery =
			    from cust in db.Customers
			    where cust.City == "London"
			    select cust;
			*/
			
			var evenNumQuery = from num in numbers
			                   where (num % 2) == 0
			                   select num;
			
			int evenNumCount = evenNumQuery.Count();
			
			List<int> numQuery2 = (from num in numbers
			                       where (num % 2) == 0
			                       select num).ToList();
			
			// or like this:
			// numQuery3 is still an int[]
			
			var numQuery3 = (from num in numbers
			                 where (num % 2) == 0
			                 select num).ToArray();
							 
			foreach (int num in numQuery)
			{
			    Console.Write("{0,1} ", num);
			}
			
			List<int> numbers2 = [ 1, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 ];

			IEnumerable<int> queryFactorsOfFour = from num in numbers2
			                                      where num % 4 == 0
			                                      select num;
			
			// Store the results in a new variable
			// without executing a foreach loop.
			var factorsofFourList = queryFactorsOfFour.ToList();
			
			// Read and write from the newly created list to demonstrate that it holds data.
			Console.WriteLine(factorsofFourList[2]);
			factorsofFourList[2] = 0;
			Console.WriteLine(factorsofFourList[2]);
			
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/
namespace DotnetCSharpLinq
{
	public class CSharpLinq
	{
		public static void RunCSharpLinq()
		{
			// Specify the data source.
			int[] scores = [97, 92, 81, 60];
			
			// Define the query expression.
			IEnumerable<int> scoreQuery =
			    from score in scores
			    where score > 80
			    select score;
			
			// Execute the query.
			foreach (var i in scoreQuery)
			{
			    Console.Write(i + " ");
			}
			
			// Output: 97 92 81
		
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq
namespace DotnetCSharpTutorialsWorkingWithLinq
{
	public class WorkingWithLinq
	{
		static IEnumerable<string> Suits()
		{
		    yield return "clubs";
		    yield return "diamonds";
		    yield return "hearts";
		    yield return "spades";
		}
		
		static IEnumerable<string> Ranks()
		{
		    yield return "two";
		    yield return "three";
		    yield return "four";
		    yield return "five";
		    yield return "six";
		    yield return "seven";
		    yield return "eight";
		    yield return "nine";
		    yield return "ten";
		    yield return "jack";
		    yield return "queen";
		    yield return "king";
		    yield return "ace";
		}
		
		public static void RunWorkingWithLinq()
		{
			/*
			var startingDeck = from s in Suits()
                   from r in Ranks()
                   select (Suit: s, Rank: r);

			// Display each card that's generated and placed in startingDeck
			foreach (var card in startingDeck)
			{
			    Console.WriteLine(card);
			}
			
			var startingDeck2 = Suits().SelectMany(suit => Ranks().Select(rank => (Suit: suit, Rank: rank )));
			
			var top = startingDeck.Take(26);
			var bottom = startingDeck.Skip(26);
			
			var shuffledDeck = top.InterleaveSequenceWith(bottom);

			foreach (var c in shuffledDeck)
			{
			    Console.WriteLine(c);
			}
			
			var startingDeck3 = from s in Suits()
                   from r in Ranks()
                   select (Suit: s, Rank: r);

			// Display each card generated and placed in startingDeck in the console
			foreach (var card in startingDeck3)
			{
			    Console.WriteLine(card);
			}
			
			var top3 = startingDeck3.Take(26);
			var bottom3 = startingDeck3.Skip(26);
			
			var shuffledDeck3 = top.InterleaveSequenceWith(bottom);
			
			var times = 0;
			// Re-use the shuffle variable from earlier, or you can make a new one
			shuffledDeck3 = startingDeck3;
			do
			{
			    shuffledDeck3 = shuffledDeck3.Take(26).InterleaveSequenceWith(shuffledDeck3.Skip(26));
			
			    foreach (var card in shuffledDeck3)
			    {
			        Console.WriteLine(card);
			    }
			    Console.WriteLine();
			    times++;
			
			} while (!startingDeck3.SequenceEquals(shuffledDeck3));
			
			Console.WriteLine(times);
			
			//shuffledDeck = shuffledDeck.Skip(26).InterleaveSequenceWith(shuffledDeck.Take(26));
			*/
			
			var startingDeck = (from s in Suits().LogQuery("Suit Generation")
                    from r in Ranks().LogQuery("Value Generation")
                    select new { Suit = s, Rank = r })
                    .LogQuery("Starting Deck")
                    .ToArray();

			foreach (var c in startingDeck)
			{
			    Console.WriteLine(c);
			}
			
			Console.WriteLine();
			
			var times = 0;
			var shuffle = startingDeck;
			
			do
			{
			    /*
			    shuffle = shuffle.Take(26)
			        .LogQuery("Top Half")
			        .InterleaveSequenceWith(shuffle.Skip(26).LogQuery("Bottom Half"))
			        .LogQuery("Shuffle")
			        .ToArray();
			    */
			
			    shuffle = shuffle.Skip(26)
			        .LogQuery("Bottom Half")
			        .InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half"))
			        .LogQuery("Shuffle")
			        .ToArray();
			
			    foreach (var c in shuffle)
			    {
			        Console.WriteLine(c);
			    }
			
			    times++;
			    Console.WriteLine(times);
			} while (!startingDeck.SequenceEquals(shuffle));
			
			Console.WriteLine(times);
			
			
			
		}

		
		
	}
	
	public static class CardExtensions
	{
	    extension<T>(IEnumerable<T> sequence)
	    {
	        public IEnumerable<T> InterleaveSequenceWith(IEnumerable<T> second)
			{
			    var firstIter = sequence.GetEnumerator();
			    var secondIter = second.GetEnumerator();
			
			    while (firstIter.MoveNext() && secondIter.MoveNext())
			    {
			        yield return firstIter.Current;
			        yield return secondIter.Current;
			    }
			}
			
			public bool SequenceEquals(IEnumerable<T> second)
			{
			    var firstIter = sequence.GetEnumerator();
			    var secondIter = second.GetEnumerator();
			
			    while ((firstIter?.MoveNext() == true) && secondIter.MoveNext())
			    {
			        if ((firstIter.Current is not null) && !firstIter.Current.Equals(secondIter.Current))
			        {
			            return false;
			        }
			    }
			
			    return true;
			}
			
			public IEnumerable<T> LogQuery(string tag)
			{
			    // File.AppendText creates a new file if the file doesn't exist.
			    using (var writer = File.AppendText("debug.log"))
			    {
			        writer.WriteLine($"Executing Query {tag}");
			    }
			
			    return sequence;
			}
	    }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient
namespace DotnetCSharpTutorialsConsoleWebApiClient
{
	public class ConsoleWebApiClient
	{
		public static async Task RunConsoleWebApiClient()
		{
			using HttpClient client = new();
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(
			    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
			client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
			
			var repositories = await ProcessRepositoriesAsync(client);
			
			foreach (var repo in repositories)
			{
			    Console.WriteLine($"Name: {repo.Name}");
			    Console.WriteLine($"Homepage: {repo.Homepage}");
			    Console.WriteLine($"GitHub: {repo.GitHubHomeUrl}");
			    Console.WriteLine($"Description: {repo.Description}");
			    Console.WriteLine($"Watchers: {repo.Watchers:#,0}");
			    Console.WriteLine($"{repo.LastPush}");
			    Console.WriteLine();
			}
			
		}
		
		static async Task<List<Repository>> ProcessRepositoriesAsync(HttpClient client)
		{
		    var repositories = await client.GetFromJsonAsync<List<Repository>>("https://api.github.com/orgs/dotnet/repos");
		    return repositories ?? new List<Repository>();
		}
	}
	
	public record class Repository(
	    string Name,
	    string Description,
	    [property: JsonPropertyName("html_url")] Uri GitHubHomeUrl,
	    Uri Homepage,
	    int Watchers,
	    [property: JsonPropertyName("pushed_at")] DateTime LastPushUtc
	    )
	{
	    public DateTime LastPush => LastPushUtc.ToLocalTime();
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/console-teleprompter
namespace DotnetCSharpTutorialsConsoleTeleprompter
{
	public class ConsoleTeleprompter
	{
	    static IEnumerable<string> RunConsoleTeleprompter(string[] args)
	    {
	        Console.WriteLine("Hello World!");
			
			var lines = ReadFrom("sampleQuotes.txt");
			foreach (var line in lines)
			{
			    if (!string.IsNullOrWhiteSpace(line))
				{
				    var pause = Task.Delay(200);
				    // Synchronously waiting on a task is an
				    // anti-pattern. This will get fixed in later
				    // steps.
				    pause.Wait();
					
					var words = line.Split(' ');
					var lineLength = 0;
					foreach (var word in words)
					{
					    yield return word + " ";
						lineLength += word.Length + 1;
						if (lineLength > 70)
						{
						    yield return Environment.NewLine;
						    lineLength = 0;
						}
					}
					yield return Environment.NewLine;
				}
			}
			
			//await ShowTeleprompter();
			//await RunTeleprompter();
			
			
	    }
		
		static IEnumerable<string> ReadFrom(string file)
		{
		    string? line;
		    using (var reader = File.OpenText(file))
		    {
		        while ((line = reader.ReadLine()) != null)
		        {
		            yield return line;
		        }
		    }
		}
		
		private static async Task ShowTeleprompter(TelePrompterConfig config)
		{
		    var words = ReadFrom("sampleQuotes.txt");
		    foreach (var word in words)
		    {
		        Console.Write(word);
		        if (!string.IsNullOrWhiteSpace(word))
		        {
		            await Task.Delay(config.DelayInMilliseconds);
		        }
		    }
		    config.SetDone();
		}
		
		private static async Task GetInput(TelePrompterConfig config)
		{
		    Action work = () =>
		    {
		        do {
		            var key = Console.ReadKey(true);
		            if (key.KeyChar == '>')
		                config.UpdateDelay(-10);
		            else if (key.KeyChar == '<')
		                config.UpdateDelay(10);
		            else if (key.KeyChar == 'X' || key.KeyChar == 'x')
		                config.SetDone();
		        } while (!config.Done);
		    };
		    await Task.Run(work);
		}
		
		private static async Task RunTeleprompter()
		{
		    var config = new TelePrompterConfig();
		    var displayTask = ShowTeleprompter(config);
		
		    var speedTask = GetInput(config);
		    await Task.WhenAny(displayTask, speedTask);
		}
	}
	
	internal class TelePrompterConfig
	{
	    public int DelayInMilliseconds { get; private set; } = 200;
	    public void UpdateDelay(int increment) // negative to speed up
	    {
	        var newDelay = Min(DelayInMilliseconds + increment, 1000);
	        newDelay = Max(newDelay, 20);
	        DelayInMilliseconds = newDelay;
	    }
	    public bool Done { get; private set; }
	    public void SetDone()
	    {
	        Done = true;
	    }
	}
	
	
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation
namespace DotnetCSharpTutorialsStringInterpolation
{
	public class StringInterpolation
	{
		public static void RunStringInterpolation()
		{
			double a = 3;
			double b = 4;
			Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
			Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");
			double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);
			// Output:
			// Area of the right triangle with legs of 3 and 4 is 6
			// Length of the hypotenuse of the right triangle with legs of 3 and 4 is 5
			
			var date = new DateTime(1731, 11, 25);
			Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} L. Euler introduced the letter e to denote {Math.E:F5}.");
			// Output:
			// On Sunday, November 25, 1731 L. Euler introduced the letter e to denote 2.71828.
			
			var titles = new Dictionary<string, string>()
			{
			    ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
			    ["London, Jack"] = "Call of the Wild, The",
			    ["Shakespeare, William"] = "Tempest, The"
			};
			
			Console.WriteLine("Author and Title List");
			Console.WriteLine();
			Console.WriteLine($"|{"Author",-25}|{"Title",30}|");
			foreach (var title in titles)
			{
			    Console.WriteLine($"|{title.Key,-25}|{title.Value,30}|");
			}
			// Output:
			// Author and Title List
			// 
			// |Author                   |                         Title|
			// |Doyle, Arthur Conan      |Hound of the Baskervilles, The|
			// |London, Jack             |         Call of the Wild, The|
			// |Shakespeare, William     |                  Tempest, The|
			
			const int NameAlignment = -9;
			const int ValueAlignment = 7;
			double a2 = 3;
			double b2 = 4;
			Console.WriteLine($"Three classical Pythagorean means of {a2} and {b2}:");
			Console.WriteLine($"|{"Arithmetic",NameAlignment}|{0.5 * (a2 + b2),ValueAlignment:F3}|");
			Console.WriteLine($"|{"Geometric",NameAlignment}|{Math.Sqrt(a2 * b2),ValueAlignment:F3}|");
			Console.WriteLine($"|{"Harmonic",NameAlignment}|{2 / (1 / a2 + 1 / b2),ValueAlignment:F3}|");
			// Output:
			// Three classical Pythagorean means of 3 and 4:
			// |Arithmetic|  3.500|
			// |Geometric|  3.464|
			// |Harmonic |  3.429|
			
			var xs = new int[] { 1, 2, 7, 9 };
			var ys = new int[] { 7, 9, 12 };
			Console.WriteLine($"Find the intersection of the {{{string.Join(", ",xs)}}} and {{{string.Join(", ",ys)}}} sets.");
			// Output:
			// Find the intersection of the {1, 2, 7, 9} and {7, 9, 12} sets.
			
			var userName = "Jane";
			var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
			var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
			Console.WriteLine(stringWithEscapes);
			Console.WriteLine(verbatimInterpolated);
			// Output:
			// C:\Users\Jane\Documents
			// C:\Users\Jane\Documents
			
			var rand = new Random();
			for (int i = 0; i < 7; i++)
			{
			    Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : "tails")}");
			}
			
			var cultures = new System.Globalization.CultureInfo[]
			{
			    System.Globalization.CultureInfo.GetCultureInfo("en-US"),
			    System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
			    System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
			    System.Globalization.CultureInfo.InvariantCulture
			};
			var date2 = DateTime.Now;
			var number = 31_415_926.536;
			foreach (var culture in cultures)
			{
			    var cultureSpecificMessage = string.Create(culture, $"{date2,23}{number,20:N3}");
			    Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
			}
			// Output is similar to:
			// en-US       8/27/2023 12:35:31 PM      31,415,926.536
			// en-GB         27/08/2023 12:35:31      31,415,926.536
			// nl-NL         27-08-2023 12:35:31      31.415.926,536
			//               08/27/2023 12:35:31      31,415,926.536
			
			var cultures2 = new System.Globalization.CultureInfo[]
			{
			    System.Globalization.CultureInfo.GetCultureInfo("en-US"),
			    System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
			    System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
			    System.Globalization.CultureInfo.InvariantCulture
			};
			var date3 = DateTime.Now;
			var number2 = 31_415_926.536;
			FormattableString message = $"{date3,23}{number2,20:N3}";
			foreach (var culture in cultures)
			{
			    var cultureSpecificMessage = message.ToString(culture);
			    Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
			}
			// Output is similar to:
			// en-US       8/27/2023 12:35:31 PM      31,415,926.536
			// en-GB         27/08/2023 12:35:31      31,415,926.536
			// nl-NL         27-08-2023 12:35:31      31.415.926,536
			//               08/27/2023 12:35:31      31,415,926.536
			
			string message3 = string.Create(CultureInfo.InvariantCulture, $"Date and time in invariant culture: {DateTime.Now}");
			Console.WriteLine(message3);
			// Output is similar to:
			// Date and time in invariant culture: 05/17/2018 15:46:24
			
			string message4 = FormattableString.Invariant($"Date and time in invariant culture: {DateTime.Now}");
			Console.WriteLine(message4);
			// Output is similar to:
			// Date and time in invariant culture: 05/17/2018 15:46:24
			
			
			
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/patterns-objects
namespace DotnetCSharpTutorialsPatternsObjects
{
	public enum WaterLevel
	{
	    Low,
	    High
	}
	public class CanalLock
	{
	    // Query canal lock state:
	    public WaterLevel CanalLockWaterLevel { get; private set; } = WaterLevel.Low;
	    public bool HighWaterGateOpen { get; private set; } = false;
	    public bool LowWaterGateOpen { get; private set; } = false;
	
	    // Change the upper gate.
		public void SetHighGate(bool open)
		{
			HighWaterGateOpen = (open, HighWaterGateOpen, CanalLockWaterLevel) switch
		    {
		        (false, _,    _)               => false,
		        (true, _,     WaterLevel.High) => true,
		        (true, false, WaterLevel.Low)  => throw new InvalidOperationException("Cannot open high gate when the water is low"),
		        _                              => throw new InvalidOperationException("Invalid internal state"),
		    };
			
			/*
			HighWaterGateOpen = (open, HighWaterGateOpen, CanalLockWaterLevel) switch
			{
				(false, _, _) => false,
			    (false, false, WaterLevel.High) => false,
			    (false, false, WaterLevel.Low) => false,
			    (false, true, WaterLevel.High) => false,
			    (false, true, WaterLevel.Low) => false, // should never happen
			    //(true, false, WaterLevel.High) => true,
				//(true, _, WaterLevel.High) => true,
			    (true, false, WaterLevel.Low) => throw new InvalidOperationException("Cannot open high gate when the water is low"),
			    (true, true, WaterLevel.High) => true,
			    (true, true, WaterLevel.Low) => false, // should never happen
				_  => throw new InvalidOperationException("Invalid internal state"),
			};
			*/
			
			/*
		    if (open && (CanalLockWaterLevel == WaterLevel.High))
		        HighWaterGateOpen = true;
		    else if (open && (CanalLockWaterLevel == WaterLevel.Low))
		        throw new InvalidOperationException("Cannot open high gate when the water is low");
			*/
		}
		
		// Change the lower gate.
		public void SetLowGate(bool open)
		{
		    LowWaterGateOpen = (open, LowWaterGateOpen, CanalLockWaterLevel) switch
		    {
		        (false, _, _) => false,
		        (true, _, WaterLevel.Low) => true,
		        (true, false, WaterLevel.High) => throw new InvalidOperationException("Cannot open low gate when the water is high"),
		        _ => throw new InvalidOperationException("Invalid internal state"),
		    };
		}
		
		// Change water level.
		public void SetWaterLevel(WaterLevel newLevel)
		{
		    CanalLockWaterLevel = (newLevel, CanalLockWaterLevel, LowWaterGateOpen, HighWaterGateOpen) switch
		    {
		        (WaterLevel.Low, WaterLevel.Low, true, false) => WaterLevel.Low,
		        (WaterLevel.High, WaterLevel.High, false, true) => WaterLevel.High,
		        (WaterLevel.Low, _, false, false) => WaterLevel.Low,
		        (WaterLevel.High, _, false, false) => WaterLevel.High,
		        (WaterLevel.Low, WaterLevel.High, false, true) => throw new InvalidOperationException("Cannot lower water when the high gate is open"),
		        (WaterLevel.High, WaterLevel.Low, true, false) => throw new InvalidOperationException("Cannot raise water when the low gate is open"),
		        _ => throw new InvalidOperationException("Invalid internal state"),
		    };
		}
	
	    public override string ToString() =>
	        $"The lower gate is {(LowWaterGateOpen ? "Open" : "Closed")}. " +
	        $"The upper gate is {(HighWaterGateOpen ? "Open" : "Closed")}. " +
	        $"The water level is {CanalLockWaterLevel}.";
			
		public static void RunCanalLock()
		{
			// Create a new canal lock:
			var canalGate = new CanalLock();
			
			// State should be doors closed, water level low:
			Console.WriteLine(canalGate);
			
			canalGate.SetLowGate(open: true);
			Console.WriteLine($"Open the lower gate:  {canalGate}");
			
			Console.WriteLine("Boat enters lock from lower gate");
			
			canalGate.SetLowGate(open: false);
			Console.WriteLine($"Close the lower gate:  {canalGate}");
			
			canalGate.SetWaterLevel(WaterLevel.High);
			Console.WriteLine($"Raise the water level: {canalGate}");
			
			canalGate.SetHighGate(open: true);
			Console.WriteLine($"Open the higher gate:  {canalGate}");
			
			Console.WriteLine("Boat exits lock at upper gate");
			Console.WriteLine("Boat enters lock from upper gate");
			
			canalGate.SetHighGate(open: false);
			Console.WriteLine($"Close the higher gate: {canalGate}");
			
			canalGate.SetWaterLevel(WaterLevel.Low);
			Console.WriteLine($"Lower the water level: {canalGate}");
			
			canalGate.SetLowGate(open: true);
			Console.WriteLine($"Open the lower gate:  {canalGate}");
			
			Console.WriteLine("Boat exits lock at upper gate");
			
			canalGate.SetLowGate(open: false);
			Console.WriteLine($"Close the lower gate:  {canalGate}");
			
			Console.WriteLine("=============================================");
			Console.WriteLine("     Test invalid commands");
			// Open "wrong" gate (2 tests)
			try
			{
			    canalGate = new CanalLock();
			    canalGate.SetHighGate(open: true);
			}
			catch (InvalidOperationException)
			{
			    Console.WriteLine("Invalid operation: Can't open the high gate. Water is low.");
			}
			Console.WriteLine($"Try to open upper gate: {canalGate}");
			
			Console.WriteLine();
			Console.WriteLine();
			try
			{
			    canalGate = new CanalLock();
			    canalGate.SetWaterLevel(WaterLevel.High);
			    canalGate.SetLowGate(open: true);
			}
			catch (InvalidOperationException)
			{
			    Console.WriteLine("invalid operation: Can't open the lower gate. Water is high.");
			}
			Console.WriteLine($"Try to open lower gate: {canalGate}");
			// change water level with gate open (2 tests)
			Console.WriteLine();
			Console.WriteLine();
			try
			{
			    canalGate = new CanalLock();
			    canalGate.SetLowGate(open: true);
			    canalGate.SetWaterLevel(WaterLevel.High);
			}
			catch (InvalidOperationException)
			{
			    Console.WriteLine("invalid operation: Can't raise water when the lower gate is open.");
			}
			Console.WriteLine($"Try to raise water with lower gate open: {canalGate}");
			Console.WriteLine();
			Console.WriteLine();
			try
			{
			    canalGate = new CanalLock();
			    canalGate.SetWaterLevel(WaterLevel.High);
			    canalGate.SetHighGate(open: true);
			    canalGate.SetWaterLevel(WaterLevel.Low);
			}
			catch (InvalidOperationException)
			{
			    Console.WriteLine("invalid operation: Can't lower water when the high gate is open.");
			}
			Console.WriteLine($"Try to lower water with high gate open: {canalGate}");
			
			
		}
		
		
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/nullable-reference-types
namespace DotnetCSharpTutorialsNullableReferenceTypes
{
	namespace NullableIntroduction
	{
		
		public enum QuestionType
	    {
	        YesNo,
	        Number,
	        Text
	    }
	
	    public class SurveyQuestion
		{
		    public string QuestionText { get; }
		    public QuestionType TypeOfQuestion { get; }
		
		    public SurveyQuestion(QuestionType typeOfQuestion, string text) =>
		        (TypeOfQuestion, QuestionText) = (typeOfQuestion, text);
		}
		
		public class SurveyRun
	    {
	        private List<SurveyQuestion> surveyQuestions = new List<SurveyQuestion>();
			private List<SurveyResponse>? respondents;
	
	        public void AddQuestion(QuestionType type, string question) =>
	            AddQuestion(new SurveyQuestion(type, question));
	        public void AddQuestion(SurveyQuestion surveyQuestion) => surveyQuestions.Add(surveyQuestion);
			
			public static void RunSurveyRun()
			{
				var surveyRun = new SurveyRun();
				surveyRun.AddQuestion(QuestionType.YesNo, "Has your code ever thrown a NullReferenceException?");
				surveyRun.AddQuestion(new SurveyQuestion(QuestionType.Number, "How many times (to the nearest 100) has that happened?"));
				surveyRun.AddQuestion(QuestionType.Text, "What is your favorite color?");
				
				surveyRun.AddQuestion(QuestionType.Text, default);
				
				surveyRun.PerformSurvey(50);
				
				foreach (var participant in surveyRun.AllParticipants)
				{
				    Console.WriteLine($"Participant: {participant.Id}:");
				    if (participant.AnsweredSurvey)
				    {
				        for (int i = 0; i < surveyRun.Questions.Count; i++)
				        {
				            var answer = participant.Answer(i);
				            Console.WriteLine($"\t{surveyRun.GetQuestion(i).QuestionText} : {answer}");
				        }
				    }
				    else
				    {
				        Console.WriteLine("\tNo responses");
				    }
				}
			}
			
			public void PerformSurvey(int numberOfRespondents)
			{
			    int respondentsConsenting = 0;
			    respondents = new List<SurveyResponse>();
			    while (respondentsConsenting < numberOfRespondents)
			    {
			        var respondent = SurveyResponse.GetRandomId();
			        if (respondent.AnswerSurvey(surveyQuestions))
			            respondentsConsenting++;
			        respondents.Add(respondent);
			    }
			}
			
			public IEnumerable<SurveyResponse> AllParticipants => (respondents ?? Enumerable.Empty<SurveyResponse>());
			public ICollection<SurveyQuestion> Questions => surveyQuestions;
			public SurveyQuestion GetQuestion(int index) => surveyQuestions[index];
	    }
		
		public class SurveyResponse
	    {
			private static readonly Random randomGenerator = new Random();
			public static SurveyResponse GetRandomId() => new SurveyResponse(randomGenerator.Next());
			
	        public int Id { get; }
	
	        public SurveyResponse(int id) => Id = id;
			
			private Dictionary<int, string>? surveyResponses;

			public bool AnswerSurvey(IEnumerable<SurveyQuestion> questions)
			{
			    if (ConsentToSurvey())
			    {
			        surveyResponses = new Dictionary<int, string>();
			        int index = 0;
			        foreach (var question in questions)
			        {
			            var answer = GenerateAnswer(question);
			            if (answer != null)
			            {
			                surveyResponses.Add(index, answer);
			            }
			            index++;
			        }
			    }
			    return surveyResponses != null;
			}
			
			private bool ConsentToSurvey() => randomGenerator.Next(0, 2) == 1;
			
			private string? GenerateAnswer(SurveyQuestion question)
			{
			    switch (question.TypeOfQuestion)
			    {
			        case QuestionType.YesNo:
			            int n = randomGenerator.Next(-1, 2);
			            return (n == -1) ? default : (n == 0) ? "No" : "Yes";
			        case QuestionType.Number:
			            n = randomGenerator.Next(-30, 101);
			            return (n < 0) ? default : n.ToString();
			        case QuestionType.Text:
			        default:
			            switch (randomGenerator.Next(0, 5))
			            {
			                case 0:
			                    return default;
			                case 1:
			                    return "Red";
			                case 2:
			                    return "Green";
			                case 3:
			                    return "Blue";
			            }
			            return "Red. No, Green. Wait.. Blue... AAARGGGGGHHH!";
			    }
			}
			
			public bool AnsweredSurvey => surveyResponses != null;
			public string Answer(int index) => surveyResponses?.GetValueOrDefault(index) ?? "No answer";
	    }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
namespace DotnetCSharpTutorialsRangesIndexes
{
	public class RangesIndexes
	{
		private static string[] words = [
		                // index from start     index from end
		    "first",    // 0                    ^10
		    "second",   // 1                    ^9
		    "third",    // 2                    ^8
		    "fourth",   // 3                    ^7
		    "fifth",    // 4                    ^6
		    "sixth",    // 5                    ^5
		    "seventh",  // 6                    ^4
		    "eighth",   // 7                    ^3
		    "ninth",    // 8                    ^2
		    "tenth"     // 9                    ^1
		];              // 10 (or words.Length) ^0
		
		public static void RunRangesIndexes()
		{
			Console.WriteLine($"The last word is < {words[^1]} >."); // The last word is < tenth >.
			
			string[] secondThirdFourth = words[1..4]; // contains "second", "third" and "fourth"

			// < second >< third >< fourth >
			foreach (var word in secondThirdFourth)
			    Console.Write($"< {word} >"); 
			Console.WriteLine();
			
			string[] lastTwo = words[^2..^0]; // contains "ninth" and "tenth"

			// < ninth >< tenth >
			foreach (var word in lastTwo)
			    Console.Write($"< {word} >"); 
			Console.WriteLine();
			 
			string[] allWords = words[..]; // contains "first" through "tenth".
			string[] firstPhrase = words[..4]; // contains "first" through "fourth"
			string[] lastPhrase = words[6..]; // contains "seventh", "eight", "ninth" and "tenth"
			
			// < first >< second >< third >< fourth >< fifth >< sixth >< seventh >< eighth >< ninth >< tenth >
			foreach (var word in allWords)
			    Console.Write($"< {word} >"); 
			Console.WriteLine();
			
			// < first >< second >< third >< fourth >
			foreach (var word in firstPhrase)
			    Console.Write($"< {word} >"); 
			Console.WriteLine();
			
			// < seventh >< eighth >< ninth >< tenth >
			foreach (var word in lastPhrase)
			    Console.Write($"< {word} >"); 
			Console.WriteLine();
			
			Index thirdFromEnd = ^3;
			Console.WriteLine($"< {words[thirdFromEnd]} > "); // < eighth > 
			Range phrase = 1..4;
			string[] text = words[phrase];
			
			// < second >< third >< fourth >
			foreach (var word in text)
			    Console.Write($"< {word} >");  
			Console.WriteLine();
			
			
			int[] numbers = [..Enumerable.Range(0, 100)];
			int x = 12;
			int y = 25;
			int z = 36;
			
			Console.WriteLine($"{numbers[^x]} is the same as {numbers[numbers.Length - x]}");
			Console.WriteLine($"{numbers[x..y].Length} is the same as {y - x}");
			
			Console.WriteLine("numbers[x..y] and numbers[y..z] are consecutive and disjoint:");
			Span<int> x_y = numbers[x..y];
			Span<int> y_z = numbers[y..z];
			Console.WriteLine($"\tnumbers[x..y] is {x_y[0]} through {x_y[^1]}, numbers[y..z] is {y_z[0]} through {y_z[^1]}");
			
			Console.WriteLine("numbers[x..^x] removes x elements at each end:");
			Span<int> x_x = numbers[x..^x];
			Console.WriteLine($"\tnumbers[x..^x] starts with {x_x[0]} and ends with {x_x[^1]}");
			
			Console.WriteLine("numbers[..x] means numbers[0..x] and numbers[x..] means numbers[x..^0]");
			Span<int> start_x = numbers[..x];
			Span<int> zero_x = numbers[0..x];
			Console.WriteLine($"\t{start_x[0]}..{start_x[^1]} is the same as {zero_x[0]}..{zero_x[^1]}");
			Span<int> z_end = numbers[z..];
			Span<int> z_zero = numbers[z..^0];
			Console.WriteLine($"\t{z_end[0]}..{z_end[^1]} is the same as {z_zero[0]}..{z_zero[^1]}");
			
			Range implicitRange = 3..^5;

			Range explicitRange = new(
			    start: new Index(value: 3, fromEnd: false),
			    end: new Index(value: 5, fromEnd: true));
			
			if (implicitRange.Equals(explicitRange))
			{
			    Console.WriteLine(
			        $"The implicit range '{implicitRange}' equals the explicit range '{explicitRange}'");
			}
			// Sample output:
			//     The implicit range '3..^5' equals the explicit range '3..^5'
			
			int[][] jagged = 
			[
			   [0, 1, 2, 3, 4, 5, 6, 7, 8, 9],
			   [10,11,12,13,14,15,16,17,18,19],
			   [20,21,22,23,24,25,26,27,28,29],
			   [30,31,32,33,34,35,36,37,38,39],
			   [40,41,42,43,44,45,46,47,48,49],
			   [50,51,52,53,54,55,56,57,58,59],
			   [60,61,62,63,64,65,66,67,68,69],
			   [70,71,72,73,74,75,76,77,78,79],
			   [80,81,82,83,84,85,86,87,88,89],
			   [90,91,92,93,94,95,96,97,98,99],
			];
			
			var selectedRows = jagged[3..^3];
			
			foreach (var row in selectedRows)
			{
			    var selectedColumns = row[2..^2];
			    foreach (var cell in selectedColumns)
			    {
			        Console.Write($"{cell}, ");
			    }
			    Console.WriteLine();
			}
			
			int[] sequence = Sequence(1000);

			for(int start = 0; start < sequence.Length; start += 100)
			{
			    Range r = start..(start+10);
			    var (min, max, average) = MovingAverage(sequence, r);
			    Console.WriteLine($"From {r.Start} to {r.End}:    \tMin: {min},\tMax: {max},\tAverage: {average}");
			}
			
			for (int start = 0; start < sequence.Length; start += 100)
			{
			    Range r = ^(start + 10)..^start;
			    var (min, max, average) = MovingAverage(sequence, r);
			    Console.WriteLine($"From {r.Start} to {r.End}:  \tMin: {min},\tMax: {max},\tAverage: {average}");
			}
			
			(int min, int max, double average) MovingAverage(int[] subSequence, Range range) =>
			    (
			        subSequence[range].Min(),
			        subSequence[range].Max(),
			        subSequence[range].Average()
			    );
			
			int[] Sequence(int count) => [..Enumerable.Range(0, count).Select(x => (int)(Math.Sqrt(x) * 100))];
			
			var arrayOfFiveItems = new[] { 1, 2, 3, 4, 5 };

			var firstThreeItems = arrayOfFiveItems[..3]; // contains 1,2,3
			firstThreeItems[0] =  11; // now contains 11,2,3
			
			Console.WriteLine(string.Join(",", firstThreeItems));
			Console.WriteLine(string.Join(",", arrayOfFiveItems));
			
			// output:
			// 11,2,3
			// 1,2,3,4,5
		}
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/top-level-statements
namespace DotnetCSharpTutorialsTopLevelStatements
{
	class Program
    {
        static async Task RunProgram(string[] args)
        {
            Console.WriteLine("Hello World!");
			
			// See https://aka.ms/new-console-template for more information
			Console.WriteLine("Hello, World!");
			
			Console.WriteLine();
			
			foreach(var s in args)
			{
			    Console.Write(s);
			    Console.Write(' ');
			}
			Console.WriteLine();
			
			string[] answers =
			[
			    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
			    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
			    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
			    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
			    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
			    "As I see it, yes.",
			    "Most likely.",
			    "Outlook good.",
			    "Yes.",
			    "Signs point to yes.",
			];
			
			var index = new Random().Next(answers.Length - 1);
			Console.WriteLine(answers[index]);
			
			for (int i = 0; i < 20; i++)
			{
			    Console.Write("| -");
			    await Task.Delay(50);
			    Console.Write("\b\b\b");
			    Console.Write("/ \\");
			    await Task.Delay(50);
			    Console.Write("\b\b\b");
			    Console.Write("- |");
			    await Task.Delay(50);
			    Console.Write("\b\b\b");
			    Console.Write("\\ /");
			    await Task.Delay(50);
			    Console.Write("\b\b\b");
			}
			Console.WriteLine();
			
			Console.WriteLine();
			
			foreach(var s in args)
			{
			    Console.Write(s);
			    Console.Write(' ');
			}
			Console.WriteLine();
			
			for (int i = 0; i < 20; i++)
			{
			    Console.Write("| -");
			    await Task.Delay(50);
			    Console.Write("\b\b\b");
			    Console.Write("/ \\");
			    await Task.Delay(50);
			    Console.Write("\b\b\b");
			    Console.Write("- |");
			    await Task.Delay(50);
			    Console.Write("\b\b\b");
			    Console.Write("\\ /");
			    await Task.Delay(50);
			    Console.Write("\b\b\b");
			}
			Console.WriteLine();
			
			string[] answers2 =
			[
			    "It is certain.",       "Reply hazy, try again.",     "Don't count on it.",
			    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
			    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
			    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
			    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
			    "As I see it, yes.",
			    "Most likely.",
			    "Outlook good.",
			    "Yes.",
			    "Signs point to yes.",
			];
			
			var index2 = new Random().Next(answers2.Length - 1);
			Console.WriteLine(answers[index2]);
			
			await ShowConsoleAnimation();
			
			Console.WriteLine();
			foreach(var s in args)
			{
			    Console.Write(s);
			    Console.Write(' ');
			}
			Console.WriteLine();
			
			await Utilities.ShowConsoleAnimation();
			
			string[] answers3 =
			[
			    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
			    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
			    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
			    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
			    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
			    "As I see it, yes.",
			    "Most likely.",
			    "Outlook good.",
			    "Yes.",
			    "Signs point to yes.",
			];
			
			var index3 = new Random().Next(answers3.Length - 1);
			Console.WriteLine(answers[index3]);

        }
		
		static async Task ShowConsoleAnimation()
		{
		    for (int i = 0; i < 20; i++)
		    {
		        Console.Write("| -");
		        await Task.Delay(50);
		        Console.Write("\b\b\b");
		        Console.Write("/ \\");
		        await Task.Delay(50);
		        Console.Write("\b\b\b");
		        Console.Write("- |");
		        await Task.Delay(50);
		        Console.Write("\b\b\b");
		        Console.Write("\\ /");
		        await Task.Delay(50);
		        Console.Write("\b\b\b");
		    }
		    Console.WriteLine();
		}
    }
	
	public static class Utilities
    {
        public static async Task ShowConsoleAnimation()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("| -");
                await Task.Delay(50);
                Console.Write("\b\b\b");
                Console.Write("/ \\");
                await Task.Delay(50);
                Console.Write("\b\b\b");
                Console.Write("- |");
                await Task.Delay(50);
                Console.Write("\b\b\b");
                Console.Write("\\ /");
                await Task.Delay(50);
                Console.Write("\b\b\b");
            }
            Console.WriteLine();
        }
		
		public static async Task ShowConsoleAnimation2()
		{
		    string[] animations = ["| -", "/ \\", "- |", "\\ /"];
		    for (int i = 0; i < 20; i++)
		    {
		        foreach (string s in animations)
		        {
		            Console.Write(s);
		            await Task.Delay(50);
		            Console.Write("\b\b\b");
		        }
		    }
		    Console.WriteLine();
		}
    }
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/records
namespace DotnetCSharpTutorialsRecords
{
	//public readonly record struct DailyTemperature(double HighTemp, double LowTemp);
	
	public class TutorialsRecords
	{
		public static void RunTutorialsRecords()
		{
			foreach (var item in data)
    			Console.WriteLine(item);
				
			var heatingDegreeDays = new HeatingDegreeDays(65, data);
			Console.WriteLine(heatingDegreeDays);
			
			var coolingDegreeDays = new CoolingDegreeDays(65, data);
			Console.WriteLine(coolingDegreeDays);
			
			// Growing degree days measure warming to determine plant growing rates
			var growingDegreeDays = coolingDegreeDays with { BaseTemperature = 41 };
			Console.WriteLine(growingDegreeDays);
			
			// showing moving accumulation of 5 days using range syntax
			List<CoolingDegreeDays> movingAccumulation = new();
			int rangeSize = (data.Length > 5) ? 5 : data.Length;
			for (int start = 0; start < data.Length - rangeSize; start++)
			{
			    var fiveDayTotal = growingDegreeDays with { TempRecords = data[start..(start + rangeSize)] };
			    movingAccumulation.Add(fiveDayTotal);
			}
			Console.WriteLine();
			Console.WriteLine("Total degree days in the last five days");
			foreach(var item in movingAccumulation)
			{
			    Console.WriteLine(item);
			}
			
			var growingDegreeDaysCopy = growingDegreeDays with { };
			
		}
		
		private static DailyTemperature[] data = [
		    new DailyTemperature(HighTemp: 57, LowTemp: 30), 
		    new DailyTemperature(60, 35),
		    new DailyTemperature(63, 33),
		    new DailyTemperature(68, 29),
		    new DailyTemperature(72, 47),
		    new DailyTemperature(75, 55),
		    new DailyTemperature(77, 55),
		    new DailyTemperature(72, 58),
		    new DailyTemperature(70, 47),
		    new DailyTemperature(77, 59),
		    new DailyTemperature(85, 65),
		    new DailyTemperature(87, 65),
		    new DailyTemperature(85, 72),
		    new DailyTemperature(83, 68),
		    new DailyTemperature(77, 65),
		    new DailyTemperature(72, 58),
		    new DailyTemperature(77, 55),
		    new DailyTemperature(76, 53),
		    new DailyTemperature(80, 60),
		    new DailyTemperature(85, 66) 
		];
	}
	
	public readonly record struct DailyTemperature(double HighTemp, double LowTemp)
	{
	    public double Mean => (HighTemp + LowTemp) / 2.0;
	}
	
	public abstract record DegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
	{
		protected virtual bool PrintMembers(StringBuilder stringBuilder)
		{
		    stringBuilder.Append($"BaseTemperature = {BaseTemperature}");
		    return true;
		}
	}

	public sealed record HeatingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
	    : DegreeDays(BaseTemperature, TempRecords)
	{
	    public double DegreeDays => TempRecords.Where(s => s.Mean < BaseTemperature).Sum(s => BaseTemperature - s.Mean);
		
		public override string ToString()
		{
		    StringBuilder stringBuilder = new StringBuilder();
		    stringBuilder.Append("HeatingDegreeDays");
		    stringBuilder.Append(" { ");
		    if (PrintMembers(stringBuilder))
		    {
		        stringBuilder.Append(" ");
		    }
		    stringBuilder.Append("}");
		    return stringBuilder.ToString();
		}
	}
	
	public sealed record CoolingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
	    : DegreeDays(BaseTemperature, TempRecords)
	{
	    public double DegreeDays => TempRecords.Where(s => s.Mean > BaseTemperature).Sum(s => s.Mean - BaseTemperature);
	}

}

//https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors
namespace DotnetCSharpWhatsNewTutorialsPrimaryConstructors
{
	public readonly struct Distance(double dx, double dy)
	{
	    public readonly double Magnitude { get; } = Math.Sqrt(dx * dx + dy * dy);
	    public readonly double Direction { get; } = Math.Atan2(dy, dx);
	}
	// =
	public readonly struct Distance2
	{
	    public readonly double Magnitude { get; }
	
	    public readonly double Direction { get; }
	
	    public Distance2(double dx, double dy)
	    {
	        Magnitude = Math.Sqrt(dx * dx + dy * dy);
	        Direction = Math.Atan2(dy, dx);
	    }
	}
	
	public struct Distance3(double dx, double dy)
	{
	    public readonly double Magnitude => Math.Sqrt(dx * dx + dy * dy);
	    public readonly double Direction => Math.Atan2(dy, dx);
	
	    public void Translate(double deltaX, double deltaY)
	    {
	        dx += deltaX;
	        dy += deltaY;
	    }
	
	    public Distance3() : this(0,0) { }
	}
	
	public struct Distance4
	{
	    private double __unspeakable_dx;
	    private double __unspeakable_dy;
	
	    public readonly double Magnitude => Math.Sqrt(__unspeakable_dx * __unspeakable_dx + __unspeakable_dy * __unspeakable_dy);
	    public readonly double Direction => Math.Atan2(__unspeakable_dy, __unspeakable_dx);
	
	    public void Translate(double deltaX, double deltaY)
	    {
	        __unspeakable_dx += deltaX;
	        __unspeakable_dy += deltaY;
	    }
	
	    public Distance4(double dx, double dy)
	    {
	        __unspeakable_dx = dx;
	        __unspeakable_dy = dy;
	    }
	    public Distance4() : this(0, 0) { }
	}
	
	public interface IService
	{
	    Distance GetDistance();
	}
	
	/*
	public class ExampleController(IService service) : ControllerBase
	{
	    [HttpGet]
	    public ActionResult<Distance> Get()
	    {
	        return service.GetDistance();
	    }
	}
	*/
	
	public class BankAccount(string accountID, string owner)
	{
	    public string AccountID { get; } = accountID;
	    public string Owner { get; } = owner;
	
	    public override string ToString() => $"Account ID: {AccountID}, Owner: {Owner}";
	}
	
	public class BankAccount2(string accountID, string owner)
	{
	    public string AccountID { get; } = ValidAccountNumber(accountID) 
	        ? accountID 
	        : throw new ArgumentException("Invalid account number", nameof(accountID));
	
	    public string Owner { get; } = string.IsNullOrWhiteSpace(owner) 
	        ? throw new ArgumentException("Owner name cannot be empty", nameof(owner)) 
	        : owner;
	
	    public override string ToString() => $"Account ID: {AccountID}, Owner: {Owner}";
	
	    public static bool ValidAccountNumber(string accountID) => 
	    accountID?.Length == 10 && accountID.All(c => char.IsDigit(c));
	}
	
	public class CheckingAccount(string accountID, string owner, decimal overdraftLimit = 0) : BankAccount(accountID, owner)
	{
	    public decimal CurrentBalance { get; private set; } = 0;
	
	    public void Deposit(decimal amount)
	    {
	        if (amount < 0)
	        {
	            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive");
	        }
	        CurrentBalance += amount;
	    }
	
	    public void Withdrawal(decimal amount)
	    {
	        if (amount < 0)
	        {
	            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive");
	        }
	        if (CurrentBalance - amount < -overdraftLimit)
	        {
	            throw new InvalidOperationException("Insufficient funds for withdrawal");
	        }
	        CurrentBalance -= amount;
	    }
	    
	    public override string ToString() => $"Account ID: {AccountID}, Owner: {Owner}, Balance: {CurrentBalance}";
	}
	
	
	public class LineOfCreditAccount : BankAccount
	{
	    private readonly decimal _creditLimit;
	    public LineOfCreditAccount(string accountID, string owner, decimal creditLimit) : base(accountID, owner)
	    {
	        _creditLimit = creditLimit;
	    }
	    public decimal CurrentBalance { get; private set; } = 0;
	
	    public void Deposit(decimal amount)
	    {
	        if (amount < 0)
	        {
	            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive");
	        }
	        CurrentBalance += amount;
	    }
	
	    public void Withdrawal(decimal amount)
	    {
	        if (amount < 0)
	        {
	            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive");
	        }
	        if (CurrentBalance - amount < -_creditLimit)
	        {
	            throw new InvalidOperationException("Insufficient funds for withdrawal");
	        }
	        CurrentBalance -= amount;
	    }
	
	    public override string ToString() => $"{base.ToString()}, Balance: {CurrentBalance}";
	}
	
	public class SavingsAccount(string accountID, string owner, decimal interestRate) : BankAccount(accountID, owner)
	{
	    public SavingsAccount() : this("default", "default", 0.01m) { }
	    public decimal CurrentBalance { get; private set; } = 0;
	
	    public void Deposit(decimal amount)
	    {
	        if (amount < 0)
	        {
	            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive");
	        }
	        CurrentBalance += amount;
	    }
	
	    public void Withdrawal(decimal amount)
	    {
	        if (amount < 0)
	        {
	            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive");
	        }
	        if (CurrentBalance - amount < 0)
	        {
	            throw new InvalidOperationException("Insufficient funds for withdrawal");
	        }
	        CurrentBalance -= amount;
	    }
	
	    public void ApplyInterest()
	    {
	        CurrentBalance *= 1 + interestRate;
	    }
	
	    public override string ToString() => $"Account ID: {accountID}, Owner: {owner}, Balance: {CurrentBalance}";
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/compound-assignment-operators

//https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/extension-members
namespace DotnetCSharpWhatsNewTutorialsExtensionMembers
{
	public static class PointExtensions
	{
		public static void RunPointExtensions()
		{
			// Inline implementation since Point.Origin doesn't exist in ExtensionMethods
			Point origin = Point.Empty; // Equivalent to Point.Origin
			Console.WriteLine($"Point.Origin (inline): {origin}");
			Console.WriteLine($"Same as Point.Empty: {origin == Point.Empty}");
			Console.WriteLine();
			
			Console.WriteLine("1. Static Properties");
			Console.WriteLine("-------------------");
			
			Point origin2 = Point.Origin;
			Console.WriteLine($"Point.Origin: {origin2}");
			Console.WriteLine($"Same as Point.Empty: {origin2 == Point.Empty}");
			Console.WriteLine();
			
			Point p1 = new Point(5, 3);
			Point p2 = new Point(2, 7);
			
			Console.WriteLine($"Point 1: {p1}");
			Console.WriteLine($"Point 2: {p2}");
			
			// Inline implementation since + and - operators don't exist in ExtensionMethods
			Point addition = new Point(p1.X + p2.X, p1.Y + p2.Y);
			Point subtraction1 = new Point(p1.X - p2.X, p1.Y - p2.Y);
			Point subtraction2 = new Point(p2.X - p1.X, p2.Y - p1.Y);
			
			Console.WriteLine($"Addition (p1 + p2): {addition}");
			Console.WriteLine($"Subtraction (p1 - p2): {subtraction1}");
			Console.WriteLine($"Subtraction (p2 - p1): {subtraction2}");
			Console.WriteLine();
			
		}
		
	    public static Vector2 ToVector(this Point point) =>
	        new Vector2(point.X, point.Y);
	
	    public static void Translate(this Point point, int xDist, int yDist)
	    {
	        point.X += xDist;
	        point.Y += yDist;
	    }
	
	    public static void Scale(this Point point, int xScale, int yScale)
	    {
	        point.X *= xScale;
	        point.Y *= yScale;
	    }
	
	    public static void Rotate(this Point point, int angleInDegrees)
	    {
	        double theta = ((double)angleInDegrees * Math.PI) / 180.0;
	        double sinTheta = Math.Sin(theta);
	        double cosTheta = Math.Cos(theta);
	        double newX = (double)point.X * cosTheta - (double)point.Y * sinTheta;
	        double newY = (double)point.X * sinTheta + (double)point.Y * cosTheta;
	        point.X = (int)newX;
	        point.Y = (int)newY;
	    }
		
	}
	
	public static class ExtensionMethodsDemonstrations
	{
	    public static void TraditionalExtensionMethods()
	    {
	        OriginAsADataElement();
	        ArithmeticWithPoints();
	        DiscreteArithmeticWithPoints();
	        ExtensionMethodsThis();
	        MoreExamples();
	    }
	
	    static void OriginAsADataElement()
	    {
	        // Inline implementation since Point.Origin doesn't exist in ExtensionMethods
	        Point origin = Point.Empty; // Equivalent to Point.Origin
	        Console.WriteLine($"Point.Origin (inline): {origin}");
	        Console.WriteLine($"Same as Point.Empty: {origin == Point.Empty}");
	        Console.WriteLine();
	    }
	
	    static void ArithmeticWithPoints()
	    {
	        Point p1 = new Point(5, 3);
	        Point p2 = new Point(2, 7);
	
	        Console.WriteLine($"Point 1: {p1}");
	        Console.WriteLine($"Point 2: {p2}");
	        
	        // Inline implementation since + and - operators don't exist in ExtensionMethods
	        Point addition = new Point(p1.X + p2.X, p1.Y + p2.Y);
	        Point subtraction1 = new Point(p1.X - p2.X, p1.Y - p2.Y);
	        Point subtraction2 = new Point(p2.X - p1.X, p2.Y - p1.Y);
	        
	        Console.WriteLine($"Addition (p1 + p2): {addition}");
	        Console.WriteLine($"Subtraction (p1 - p2): {subtraction1}");
	        Console.WriteLine($"Subtraction (p2 - p1): {subtraction2}");
	        Console.WriteLine();
	    }
	
	    static void DiscreteArithmeticWithPoints()
	    {
	        Point point = new Point(10, 8);
	        int offsetX = 3;
	        int offsetY = -2;
	        int scaleX = 2;
	        int scaleY = 3;
	        int divisorX = 2;
	        int divisorY = 4;
	
	        Console.WriteLine($"Original point: {point}");
	        Console.WriteLine($"Offset: ({offsetX}, {offsetY})");
	        Console.WriteLine($"Scale: ({scaleX}, {scaleY})");
	        Console.WriteLine($"Divisor: ({divisorX}, {divisorY})");
	        Console.WriteLine();
	
	        // Inline implementations since tuple operators don't exist in ExtensionMethods
	        Point addedOffset = new Point(point.X + offsetX, point.Y + offsetY);
	        Point subtractedOffset = new Point(point.X - offsetX, point.Y - offsetY);
	        Point scaledPoint = new Point(point.X * scaleX, point.Y * scaleY);
	        Point dividedPoint = new Point(point.X / divisorX, point.Y / divisorY);
	
	        Console.WriteLine($"point + offset: {addedOffset}");
	        Console.WriteLine($"point - offset: {subtractedOffset}");
	        Console.WriteLine($"point * scale: {scaledPoint}");
	        Console.WriteLine($"point / divisor: {dividedPoint}");
	        Console.WriteLine();
	    }
	
	    static void ExtensionMethodsThis()
	    {
	        // ToVector demonstration - using extension method
	        Point vectorPoint = new Point(12, 16);
	        Vector2 vector = vectorPoint.ToVector();
	        Console.WriteLine($"Point {vectorPoint} as Vector2: {vector}");
	        Console.WriteLine();
	
	        // Translate demonstration - using extension method
	        Point translatePoint = new Point(5, 5);
	        Console.WriteLine($"Before Translate: {translatePoint}");
	        translatePoint.Translate(3, -2);
	        Console.WriteLine($"After Translate(3, -2): {translatePoint}");
	        Console.WriteLine();
	
	        // Scale demonstration - using extension method
	        Point scalePoint = new Point(4, 6);
	        Console.WriteLine($"Before Scale: {scalePoint}");
	        scalePoint.Scale(2, 3);
	        Console.WriteLine($"After Scale(2, 3): {scalePoint}");
	        Console.WriteLine();
	
	        // Rotate demonstration - using extension method
	        Point rotatePoint1 = new Point(10, 0);
	        Console.WriteLine($"Before Rotate: {rotatePoint1}");
	        rotatePoint1.Rotate(90);
	        Console.WriteLine($"After Rotate(90°): {rotatePoint1}");
	
	        Point rotatePoint2 = new Point(5, 5);
	        Console.WriteLine($"Before Rotate: {rotatePoint2}");
	        rotatePoint2.Rotate(45);
	        Console.WriteLine($"After Rotate(45°): {rotatePoint2}");
	
	        Point rotatePoint3 = new Point(3, 4);
	        Console.WriteLine($"Before Rotate: {rotatePoint3}");
	        rotatePoint3.Rotate(180);
	        Console.WriteLine($"After Rotate(180°): {rotatePoint3}");
	        Console.WriteLine();
	    }
	
	    static void MoreExamples()
	    {
	        // Combining operators and methods
	        Console.WriteLine("Scenario 1: Building a rectangle using inline operators");
	        Point topLeft = Point.Empty; // Inline equivalent of Point.Origin
	        Point bottomRight = new Point(topLeft.X + 10, topLeft.Y + 8); // Inline addition
	        Point topRight = new Point(bottomRight.X, topLeft.Y);
	        Point bottomLeft = new Point(topLeft.X, bottomRight.Y);
	
	        Console.WriteLine($"Rectangle corners:");
	        Console.WriteLine($"  Top-Left: {topLeft}");
	        Console.WriteLine($"  Top-Right: {topRight}");
	        Console.WriteLine($"  Bottom-Left: {bottomLeft}");
	        Console.WriteLine($"  Bottom-Right: {bottomRight}");
	        Console.WriteLine();
	
	        // Transformation chain
	        Console.WriteLine("Scenario 2: Transformation chain (mixed methods)");
	        Point transformPoint = new Point(2, 3);
	        Console.WriteLine($"Starting point: {transformPoint}");
	
	        // Scale up - using extension method
	        transformPoint.Scale(3, 2);
	        Console.WriteLine($"After scaling by (3, 2): {transformPoint}");
	
	        // Translate - using inline addition
	        transformPoint = new Point(transformPoint.X + 5, transformPoint.Y + (-3));
	        Console.WriteLine($"After translating by (5, -3): {transformPoint}");
	
	        // Rotate - using extension method
	        transformPoint.Rotate(45);
	        Console.WriteLine($"After rotating 45�: {transformPoint}");
	
	        // Convert to vector - using extension method
	        Vector2 finalVector = transformPoint.ToVector();
	        Console.WriteLine($"Final result as Vector2: {finalVector}");
	        Console.WriteLine();
	
	        // Distance calculation using inline operators and extension methods
	        Console.WriteLine("Scenario 3: Distance calculation (mixed methods)");
	        Point point1 = new Point(1, 1);
	        Point point2 = new Point(4, 5);
	        Point difference = new Point(point2.X - point1.X, point2.Y - point1.Y); // Inline subtraction
	        Vector2 diffVector = difference.ToVector(); // Extension method
	        float distance = diffVector.Length();
	
	        Console.WriteLine($"Point 1: {point1}");
	        Console.WriteLine($"Point 2: {point2}");
	        Console.WriteLine($"Difference: {difference}");
	        Console.WriteLine($"Distance: {distance:F2}");
	        Console.WriteLine();
	
	        Console.WriteLine("Traditional extension methods demonstration complete!");
	    }
	}
	
	public static class PointExtensions2
	{
	    extension (Point)
	    {
	        public static Point Origin => Point.Empty;
	    }
		
	}

}

//https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
namespace DotnetCSharpWhatsNewCSharp12
{
	public class WhatsNewCSharp12
	{
	
		public static void RunWhatsNewCSharp12()
		{
			// Create an array:
			int[] a = [1, 2, 3, 4, 5, 6, 7, 8];
			
			// Create a list:
			List<string> b = ["one", "two", "three"];
			
			// Create a span
			Span<char> c  = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];
			
			// Create a jagged 2D array:
			int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
			
			// Create a jagged 2D array from variables:
			int[] row0 = [1, 2, 3];
			int[] row1 = [4, 5, 6];
			int[] row2 = [7, 8, 9];
			int[][] twoDFromVariables = [row0, row1, row2];
			
			int[] row_0 = [1, 2, 3];
			int[] row_1 = [4, 5, 6];
			int[] row_2 = [7, 8, 9];
			int[] single = [.. row_0, .. row_1, .. row_2];
			foreach (var element in single)
			{
			    Console.Write($"{element}, ");
			}
			// output:
			// 1, 2, 3, 4, 5, 6, 7, 8, 9,
			
			var buffer = new Buffer();
			for (int i = 0; i < 10; i++)
			{
			    buffer[i] = i;
			}
			
			foreach (var i in buffer)
			{
			    Console.WriteLine(i);
			}
		}
	}
	
	[System.Runtime.CompilerServices.InlineArray(10)]
	public struct Buffer
	{
	    private int _element0;
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13
namespace DotnetCSharpWhatsNewCSharp13
{
	public class WhatsNewCSharp13
	{
		public static void RunWhatsNewCSharp13()
		{
			var countdown = new TimerRemaining()
			{
			    buffer =
			    {
			        [^1] = 0,
			        [^2] = 1,
			        [^3] = 2,
			        [^4] = 3,
			        [^5] = 4,
			        [^6] = 5,
			        [^7] = 6,
			        [^8] = 7,
			        [^9] = 8,
			        [^10] = 9
			    }
			};
			
		}
		
		public void Concat<T>(params ReadOnlySpan<T> items)
		{
		    for (int i = 0; i < items.Length; i++)
		    {
		        Console.Write(items[i]);
		        Console.Write(" ");
		    }
		    Console.WriteLine();
		}
	}
	
	public class TimerRemaining
	{
	    public int[] buffer { get; set; } = new int[10];
	}
	
	public class C<T> where T : allows ref struct
	{
	    // Use T as a ref struct:
	    public void M(scoped T p)
	    {
	        // The parameter p must follow ref safety rules
	    }
	}
	
	public partial class C
	{
	    // Declaring declaration
	    public partial string Name { get; set; }
	}
	
	public partial class C
	{
	    // implementation declaration:
	    private string _name;
	    public partial string Name
	    {
	        get => _name;
	        set => _name = value;
	    }
	}

}

//https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-14
namespace DotnetCSharpWhatsNewCSharp14
{
	public static class Enumerable
	{
	    // Extension block
	    extension<TSource>(IEnumerable<TSource> source) // extension members for IEnumerable<TSource>
	    {
	        // Extension property:
	        public bool IsEmpty => !source.Any();
	
	        // Extension method:
	        public IEnumerable<TSource> Where(Func<TSource, bool> predicate) { return null; }
	    }
	
	    // extension block, with a receiver type only
	    extension<TSource>(IEnumerable<TSource>) // static extension members for IEnumerable<Source>
	    {
	        // static extension method:
	        public static IEnumerable<TSource> Combine(IEnumerable<TSource> first, IEnumerable<TSource> second) { return null; }
	
	        // static extension property:
	        //public static IEnumerable<TSource> Identity => Enumerable.Empty<TSource>();
	
	        // static user defined operator:
	        public static IEnumerable<TSource> operator + (IEnumerable<TSource> left, IEnumerable<TSource> right) => left.Concat(right);
	    }
	}
	
	public class WhatsNewCSharp14
	{
		private string _msg;
		public string Message
		{
		    get => _msg;
		    set => _msg = value ?? throw new ArgumentNullException(nameof(value));
		}
		
		public static void RunWhatsNewCSharp14()
		{
			TryParse<int> parse1 = (text, out result) => Int32.TryParse(text, out result);
			
			TryParse<int> parse2 = (string text, out int result) => Int32.TryParse(text, out result);
			
			/*
			if (customer is not null)
			{
			    customer.Order = GetCurrentOrder();
			}
			
			customer?.Order = GetCurrentOrder();
			*/
		}
	}
	
	public class WhatsNewCSharp142
	{
		public string Message
		{
		    get;
		    set => field = value ?? throw new ArgumentNullException(nameof(value));
		}
	}
	
	delegate bool TryParse<T>(string text, out T result);
}



//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
namespace DotnetCSharpFundamentalsCodingStyleCodingConventions
{
	public class CodingConventions
	{
		public static void RunCodingConventions()
		{
			//string displayName = $"{nameList[0].LastName}, {nameList[1].FirstName}";
			
			var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
			var manyPhrases = new StringBuilder();
			for (var i = 0; i < 10000; i++)
			{
			    manyPhrases.Append(phrase);
			}
			//Console.WriteLine("tra" + manyPhrases);
			
			var message = """
			    This is a long message that spans across multiple lines.
			    It uses raw string literals. This means we can 
			    also include characters like \n and \t without escaping them.
			    """;
			
			/*
			//Execute the queries.
			Console.WriteLine("scoreQuery:");
			foreach (var student in scoreQuery)
			{
			    Console.WriteLine($"{student.Last} Score: {student.score}");
			}
			*/
			
			string[] vowels = [ "a", "e", "i", "o", "u" ];
			
			Action<string> actionExample1 = x => Console.WriteLine($"x is: {x}");

			Action<string, string> actionExample2 = (x, y) =>
			    Console.WriteLine($"x is: {x}, y is {y}");
			
			Func<string, int> funcExample1 = x => System.Convert.ToInt32(x);
			
			Func<int, int, int> funcExample2 = (x, y) => x + y;
			
			actionExample1("string for x");

			actionExample2("string for x", "string for y");
			
			Console.WriteLine($"The value is {funcExample1("1")}");
			
			Console.WriteLine($"The sum is {funcExample2(1, 2)}");
			
			Del exampleDel2 = DelMethod;
			exampleDel2("Hey");
			
			Del exampleDel1 = new Del(DelMethod);
			exampleDel1("Hey");
			
			/*
			Font bodyStyle = new Font("Arial", 10.0f);
			try
			{
			    byte charset = bodyStyle.GdiCharSet;
			}
			finally
			{
			    bodyStyle?.Dispose();
			}
			*/
			
			/*
			using (Font arial = new Font("Arial", 10.0f))
			{
			    byte charset2 = arial.GdiCharSet;
			}
			*/
			
			/*
			using Font normalStyle = new Font("Arial", 10.0f);
			byte charset3 = normalStyle.GdiCharSet;
			*/
			
			Console.Write("Enter a dividend: ");
			int dividend = System.Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter a divisor: ");
			int divisor = System.Convert.ToInt32(Console.ReadLine());
			
			if ((divisor != 0) && (dividend / divisor) is var result)
			{
			    Console.WriteLine($"Quotient: {result}");
			}
			else
			{
			    Console.WriteLine("Attempted division by 0 ends up here.");
			}
			
			var firstExample = new ExampleClass();
			
			ExampleClass instance2 = new();
			
			ExampleClass secondExample = new ExampleClass();
			
			/*
			var fourthExample = new ExampleClass();
			fourthExample.Name = "Desktop";
			fourthExample.ID = 37414;
			fourthExample.Location = "Redmond";
			fourthExample.Age = 2.3;
			*/
			
			/*
			var seattleCustomers = from customer in Customers
			                       where customer.City == "Seattle"
			                       select customer.Name;
								   
			
			var localDistributors =
			    from customer in Customers
			    join distributor in Distributors on customer.City equals distributor.City
			    select new { Customer = customer, Distributor = distributor };
				
			var localDistributors2 =
			    from customer in Customers
			    join distributor in Distributors on customer.City equals distributor.City
			    select new { CustomerName = customer.Name, DistributorName = distributor.Name };
				
			var seattleCustomers = from customer in Customers
			                       where customer.City == "Seattle"
			                       select customer.Name;
								   
			var seattleCustomers2 = from customer in Customers
                        where customer.City == "Seattle"
                        orderby customer.Name
                        select customer;
						
			var scoreQuery = from student in students
                 from score in student.Scores
                 where score > 90
                 select new { Last = student.LastName, score };
			*/
			
			var message2 = "This is clearly a string.";
			var currentTemperature = 27;
			
			//int numberOfIterations = Convert.ToInt32(Console.ReadLine());
			//int currentMaximum = ExampleClass.ResultSoFar();
			
			//var inputInt = Console.ReadLine();
			//Console.WriteLine(inputInt);
			
			var phrase2 = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
			var manyPhrases2 = new StringBuilder();
			for (var i = 0; i < 10000; i++)
			{
			    manyPhrases2.Append(phrase2);
			}
			//Console.WriteLine("tra" + manyPhrases);
			
			foreach (char ch in "laugh")
			{
			    if (ch == 'h')
			    {
			        Console.Write("H");
			    }
			    else
			    {
			        Console.Write(ch);
			    }
			}
			Console.WriteLine();
		}
		
		public static void DelMethod(string str)
		{
		    Console.WriteLine($"DelMethod argument: {str}");
		}
		
		static double ComputeDistance(double x1, double y1, double x2, double y2)
		{
		    try
		    {
		        return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
		    }
		    catch (System.ArithmeticException ex)
		    {
		        Console.WriteLine($"Arithmetic overflow or underflow: {ex}");
		        throw;
		    }
		}
		
		/*
		public Form2()
		{
		    this.Click += (s, e) =>
		        {
		            MessageBox.Show(
		                ((MouseEventArgs)e).Location.ToString());
		        };
		}
		*/
		
		/*
		public Form1()
		{
		    this.Click += new EventHandler(Form1_Click);
		}
		
		void Form1_Click(object? sender, EventArgs e)
		{
		    MessageBox.Show(((MouseEventArgs)e).Location.ToString());
		}
		*/
	}
	
	public record Person(string FirstName, string LastName);
	
	public class LabelledContainer<T>(string label)
	{
	    public string Label { get; } = label;
	    public required T Contents 
	    { 
	        get;
	        init;
	    }
	}
	
	public delegate void Del(string message);
	
	public class ExampleClass
	{
		
	}
	
	public class SecretsManagement
    {
        public string FetchFromKeyVault(string vaultId, string secretId) { return null; }
    }
	

	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names
namespace DotnetCSharpFundamentalsCodingStyleIdentifierName
{
	public class DataService
	{
	}
	
	public record PhysicalAddress(
	    string Street,
	    string City,
	    string StateOrProvince,
	    string ZipCode);
		
	public struct ValueCoordinate
	{
	}
	
	public delegate void DelegateType(string message);
	
	public interface IWorkerQueue
	{
	}
	
	public class ExampleEvents
	{
	    // A public field, these should be used sparingly
	    public bool IsValid;
	
	    // An init-only property
	    public IWorkerQueue WorkerQueue { get; init; }
	
	    // An event
	    public event Action EventProcessing;
	
	    // Method
	    public void StartEventProcessing()
	    {
	        // Local function
	        static int CountQueueItems() => 0; //WorkerQueue.Count;
	        // ...
	    }
		
		public record PhysicalAddress(
		    string Street,
		    string City,
		    string StateOrProvince,
		    string ZipCode);
			
		public class DataService
		{
		    private IWorkerQueue _workerQueue;
		}
		
		public class DataService2
		{
		    private static IWorkerQueue s_workerQueue;
		
		    [ThreadStatic]
		    private static TimeSpan t_timeSpan;
		}
		
		/*
		public T SomeMethod<T>(int someNumber, bool isValid)
		{
		}
		*/
		
		/*
		public class DataService(IWorkerQueue workerQueue, ILogger logger)
		{
		    public void ProcessData()
		    {
		        // Use the parameters directly
		        logger.LogInformation("Processing data");
		        workerQueue.Enqueue("data");
		    }
		}
		*/
		
		public struct Point(double x, double y)
		{
		    public double Distance => Math.Sqrt(x * x + y * y);
		}
		
		public record Person(string FirstName, string LastName);
		public record Address(string Street, string City, string PostalCode);
		
		public interface ISessionChannel<TSession> { /*...*/ }
		public delegate TOutput Converter<TInput, TOutput>(TInput from);
		public class List<T> { /*...*/ }
		
		public int IComparer<T>() => 0;
		public delegate bool Predicate<T>(T item);
		public struct Nullable<T> where T : struct { /*...*/ }
		
		public interface ISessionChannel2<TSession>
		{
		    TSession Session { get; }
		}
		
		//var currentPerformanceCounterCategory = new System.Diagnostics.PerformanceCounterCategory();
		
		
		
		
		
		
		
		
	}
	
	
	
	
	
	
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/compiler-generated-exceptions
namespace DotnetCSharpFundamentalsExceptionsCompilerGeneratedExceptions
{
	/*
	ArithmeticException	A base class for exceptions that occur during arithmetic operations, such as DivideByZeroException and OverflowException.
	ArrayTypeMismatchException	Thrown when an array can't store a given element because the actual type of the element is incompatible with the actual type of the array.
	DivideByZeroException	Thrown when an attempt is made to divide an integral value by zero.
	IndexOutOfRangeException	Thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array.
	InvalidCastException	Thrown when an explicit conversion from a base type to an interface or to a derived type fails at run time.
	NullReferenceException	Thrown when an attempt is made to reference an object whose value is null.
	OutOfMemoryException	Thrown when an attempt to allocate memory using the new operator fails. This exception indicates that the memory available to the common language runtime has been exhausted.
	OverflowException	Thrown when an arithmetic operation in a checked context overflows.
	StackOverflowException	Thrown when the execution stack is exhausted by having too many pending method calls; usually indicates a very deep or infinite recursion.
	TypeInitializationException	Thrown when a static constructor throws an exception and no compatible catch clause exists to catch it.
	*/
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exceptions
namespace DotnetCSharpFundamentalsExceptionsCreatingAndThrowingExceptions
{
	public class CreatingAndThrowingExceptions
	{
		static void CopyObject(SampleClass original)
		{
		    _ = original ?? throw new ArgumentException("Parameter cannot be null", nameof(original));
		}
		
		static int GetValueFromArray(int[] array, int index)
		{
		    try
		    {
		        return array[index];
		    }
		    catch (IndexOutOfRangeException e)
		    {
		        throw new ArgumentOutOfRangeException(
		            "Parameter index is out of range.", e);
		    }
		}
		
		
		// Non-async, task-returning method.
		// Within this method (but outside of the local function),
		// any thrown exceptions emerge synchronously.
		public static Task<Toast> ToastBreadAsync(int slices, int toastTime)
		{
		    if (slices is < 1 or > 4)
		    {
		        throw new ArgumentException(
		            "You must specify between 1 and 4 slices of bread.",
		            nameof(slices));
		    }
		
		    if (toastTime < 1)
		    {
		        throw new ArgumentException(
		            "Toast time is too short.", nameof(toastTime));
		    }
		
		    return ToastBreadAsyncCore(slices, toastTime);
		
		    // Local async function.
		    // Within this function, any thrown exceptions are stored in the task.
		    static async Task<Toast> ToastBreadAsyncCore(int slices, int time)
		    {
		        for (int slice = 0; slice < slices; slice++)
		        {
		            Console.WriteLine("Putting a slice of bread in the toaster");
		        }
		        // Start toasting.
		        await Task.Delay(time);
		
		        if (time > 2_000)
		        {
		            throw new InvalidOperationException("The toaster is on fire!");
		        }
		
		        Console.WriteLine("Toast is ready!");
		
		        return new Toast();
		    }
		}
		
		public class Toast
		{
			
		}
		
		[Serializable]
		public class InvalidDepartmentException : Exception
		{
		    public InvalidDepartmentException() : base() { }
		    public InvalidDepartmentException(string message) : base(message) { }
		    public InvalidDepartmentException(string message, Exception inner) : base(message, inner) { }
		}
	}
	
	public class SampleClass
	{
		
	}
	
	public class ProgramLog
	{
	    FileStream logFile = null!;
	    public void OpenLog(FileInfo fileName, FileMode mode) { }
	
	    public void WriteLog()
	    {
	        if (!logFile.CanWrite)
	        {
	            throw new InvalidOperationException("Logfile cannot be read-only");
	        }
	        // Else write data to the log and return.
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/exception-handling
namespace DotnetCSharpFundamentalsExceptionsExceptionHandling
{
	public class ExceptionHandling
	{
		public static void RunExceptionHandling()
		{
			try
			{
			    // Code to try goes here.
			}
			catch (Exception ex)
			{
			    // Code to handle the exception goes here.
			    // Only catch exceptions that you know how to handle.
			    // Never catch base class System.Exception without
			    // rethrowing it at the end of the catch block.
			}
			
			try
			{
			    // Code to try goes here.
			}
			finally
			{
			    // Code to execute after the try block goes here.
			}
			
			try
			{
			    // Code to try goes here.
			}
			catch (Exception ex)
			{
			    // Code to handle the exception goes here.
			}
			finally
			{
			    // Code to execute after the try (and possibly catch) blocks
			    // goes here.
			}
			
			try
			{
			    // Try to access a resource.
			}
			catch (UnauthorizedAccessException e)
			{
			    // Call a custom error logging procedure.
			    //LogError(e);
			    // Re-throw the error.
			    throw;
			}
			
			FileStream? file = null;
			FileInfo fileinfo = new System.IO.FileInfo("./file.txt");
			try
			{
			    file = fileinfo.OpenWrite();
			    file.WriteByte(0xF);
			}
			finally
			{
			    // Check for null because OpenWrite might have failed.
			    file?.Close();
			}
		
		}
		
		int GetInt(int[] array, int index)
		{
		    try
		    {
		        return array[index];
		    }
		    catch (IndexOutOfRangeException e)
		    {
		        throw new ArgumentOutOfRangeException(
		            "Parameter index is out of range.", e);
		    }
		}
		
		int GetInt2(int[] array, int index)
		{
		    try
		    {
		        return array[index];
		    }
		    catch (IndexOutOfRangeException e) when (index < 0) 
		    {
		        throw new ArgumentOutOfRangeException(
		            "Parameter index cannot be negative.", e);
		    }
		    catch (IndexOutOfRangeException e)
		    {
		        throw new ArgumentOutOfRangeException(
		            "Parameter index cannot be greater than the array size.", e);
		    }
		}
	}
	
	public class ExceptionFilter
	{
	    public static void RunExceptionFilter()
	    {
	        try
	        {
	            string? s = null;
	            Console.WriteLine(s.Length);
	        }
	        catch (Exception e) when (LogException(e))
	        {
	        }
	        Console.WriteLine("Exception must have been handled");
	    }
	
	    private static bool LogException(Exception e)
	    {
	        Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
	        Console.WriteLine($"\tMessage: {e.Message}");
	        return false;
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/using-exceptions
namespace DotnetCSharpFundamentalsExceptionsUsingExceptions
{
	class CustomException : Exception
	{
	    public CustomException(string message)
	    {
	    }
		
		private static void TestThrow()
		{
		    throw new CustomException("Custom exception in TestThrow()");
		}
		
		public static void RunCustomException()
		{
			try
			{
			    TestThrow();
			}
			catch (CustomException ex)
			{
			    System.Console.WriteLine(ex.ToString());
			}
		}
	}
	
	public class CatchOrder
    {
        public static void RunCatchOrder()
        {
            try
            {
                using (var sw = new StreamWriter("./test.txt"))
                {
                    sw.WriteLine("Hello");
                }
            }
            // Put the more specific exceptions first.
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            // Put the least specific exception last.
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Done");
        }
		
		
		static void TestFinally()
		{
		    FileStream? file = null;
		    //Change the path to something that works on your machine.
		    FileInfo fileInfo = new System.IO.FileInfo("./file.txt");
		
		    try
		    {
		        file = fileInfo.OpenWrite();
		        file.WriteByte(0xF);
		    }
		    finally
		    {
		        // Closing the file allows you to reopen it immediately - otherwise IOException is thrown.
		        file?.Close();
		    }
		
		    try
		    {
		        file = fileInfo.OpenWrite();
		        Console.WriteLine("OpenWrite() succeeded");
		    }
		    catch (IOException)
		    {
		        Console.WriteLine("OpenWrite() failed");
		    }
		}
    }
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
namespace DotnetCSharpFundamentalsExceptions
{
	public class ExceptionTest
	{
	    static double SafeDivision(double x, double y)
	    {
	        if (y == 0)
	            throw new DivideByZeroException();
	        return x / y;
	    }
	
	    public static void RunExceptionTest()
	    {
	        // Input for test purposes. Change the values to see
	        // exception handling behavior.
	        double a = 98, b = 0;
	        double result;
	
	        try
	        {
	            result = SafeDivision(a, b);
	            Console.WriteLine($"{a} divided by {b} = {result}");
	        }
	        catch (DivideByZeroException)
	        {
	            Console.WriteLine("Attempted divide by zero.");
	        }
	    }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct
namespace DotnetCSharpFundamentalsFunctionalDeconstruct
{
	public class Example
	{
	    public static void FunctionalDeconstruct()
	    {
	        var result = QueryCityData("New York City");
	
	        var city = result.Item1;
	        var pop = result.Item2;
	        var size = result.Item3;
	
	         // Do something with the data.
			 
			 //var (name, address, city, zip) = contact.GetAddressInfo();
			 
			(string city2, int population, double area) = QueryCityData("New York City");
			  
			var (city3, population3, area3) = QueryCityData("New York City");
			  
			(string city4, var population4, var area4) = QueryCityData("New York City");
			  
			string city6 = "Raleigh";
		    int population6 = 458880;
		    double area6 = 144.8;
		
		    (city, population, area) = QueryCityData("New York City");
		
		    // Do something with the data.
			
			string city7 = "Raleigh";
		    int population7 = 458880;
		
		    (city7, population7, double area7) = QueryCityData("New York City");
		
		    // Do something with the data.
			
			var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

	        // Deconstruct the person object.
	        var (fName, lName, city8, state) = p;
	        Console.WriteLine($"Hello {fName} {lName} of {city8}, {state}!");
			
			// Deconstruct the person object.
			var (fName2, _, city9, _) = p;
			Console.WriteLine($"Hello {fName2} of {city9}!");
			// The example displays the following output:
			//      Hello John of Boston!
			
			Dictionary<string, int> snapshotCommitMap = new(StringComparer.OrdinalIgnoreCase)
			{
			    ["https://github.com/dotnet/docs"] = 16_465,
			    ["https://github.com/dotnet/runtime"] = 114_223,
			    ["https://github.com/dotnet/installer"] = 22_436,
			    ["https://github.com/dotnet/roslyn"] = 79_484,
			    ["https://github.com/dotnet/aspnetcore"] = 48_386
			};
			
			foreach (var (repo, commitCount) in snapshotCommitMap)
			{
			    Console.WriteLine(
			        $"The {repo} repository had {commitCount:N0} commits as of November 10th, 2021.");
			}
			
			
	    }
	
	    private static (string, int, double) QueryCityData(string name)
	    {
	        if (name == "New York City")
	            return (name, 8175133, 468.48);
	
	        return ("", 0, 0);
	    }
		
		//public void Deconstruct(out string fname, out string mname, out string lname)
		//var (fName, mName, lName) = p;
		
		
	}
	
	public class ExampleDiscard
	{
	    public static void RunExampleDiscard()
	    {
	        var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);
	
	        Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");
	    }
	
	    private static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
	    {
	        int population1 = 0, population2 = 0;
	        double area = 0;
	
	        if (name == "New York City")
	        {
	            area = 468.48;
	            if (year1 == 1960)
	            {
	                population1 = 7781984;
	            }
	            if (year2 == 2010)
	            {
	                population2 = 8175133;
	            }
	            return (name, area, year1, population1, year2, population2);
	        }
	
	        return ("", 0, 0, 0, 0, 0);
	    }
	}
	// The example displays the following output:
	//      Population change, 1960 to 2010: 393,149
	
	public class Person
	{
	    public string FirstName { get; set; }
	    public string MiddleName { get; set; }
	    public string LastName { get; set; }
	    public string City { get; set; }
	    public string State { get; set; }
	
	    public Person(string fname, string mname, string lname,
	                  string cityName, string stateName)
	    {
	        FirstName = fname;
	        MiddleName = mname;
	        LastName = lname;
	        City = cityName;
	        State = stateName;
	    }
	
	    // Return the first and last name.
	    public void Deconstruct(out string fname, out string lname)
	    {
	        fname = FirstName;
	        lname = LastName;
	    }
	
	    public void Deconstruct(out string fname, out string mname, out string lname)
	    {
	        fname = FirstName;
	        mname = MiddleName;
	        lname = LastName;
	    }
	
	    public void Deconstruct(out string fname, out string lname,
	                            out string city, out string state)
	    {
	        fname = FirstName;
	        lname = LastName;
	        city = City;
	        state = State;
	    }
	}
	
	public static class ReflectionExtensions
	{
	    extension(PropertyInfo propertyInfo)
	    {
	        public void Deconstruct(out bool isStatic,
	                                out bool isReadOnly, out bool isIndexed,
	                                out Type propertyType)
	        {
	            var getter = propertyInfo.GetMethod;
	
	            // Is the property read-only?
	            isReadOnly = ! propertyInfo.CanWrite;
	
	            // Is the property instance or static?
	            isStatic = getter.IsStatic;
	
	            // Is the property indexed?
	            isIndexed = propertyInfo.GetIndexParameters().Length > 0;
	
	            // Get the property type.
	            propertyType = propertyInfo.PropertyType;
	        }
	
	        public void Deconstruct(out bool hasGetAndSet,
	                                out bool sameAccess, out string access,
	                                out string getAccess, out string setAccess)
	        {
	            hasGetAndSet = sameAccess = false;
	            string getAccessTemp = null;
	            string setAccessTemp = null;
	
	            MethodInfo getter = null;
	            if (propertyInfo.CanRead)
	                getter = propertyInfo.GetMethod;
	
	            MethodInfo setter = null;
	            if (propertyInfo.CanWrite)
	                setter = propertyInfo.SetMethod;
	
	            if (setter != null && getter != null)
	                hasGetAndSet = true;
	
	            if (getter != null)
	            {
	                if (getter.IsPublic)
	                    getAccessTemp = "public";
	                else if (getter.IsPrivate)
	                    getAccessTemp = "private";
	                else if (getter.IsAssembly)
	                    getAccessTemp = "internal";
	                else if (getter.IsFamily)
	                    getAccessTemp = "protected";
	                else if (getter.IsFamilyOrAssembly)
	                    getAccessTemp = "protected internal";
	            }
	
	            if (setter != null)
	            {
	                if (setter.IsPublic)
	                    setAccessTemp = "public";
	                else if (setter.IsPrivate)
	                    setAccessTemp = "private";
	                else if (setter.IsAssembly)
	                    setAccessTemp = "internal";
	                else if (setter.IsFamily)
	                    setAccessTemp = "protected";
	                else if (setter.IsFamilyOrAssembly)
	                    setAccessTemp = "protected internal";
	            }
	
	            // Are the accessibility of the getter and setter the same?
	            if (setAccessTemp == getAccessTemp)
	            {
	                sameAccess = true;
	                access = getAccessTemp;
	                getAccess = setAccess = String.Empty;
	            }
	            else
	            {
	                access = null;
	                getAccess = getAccessTemp;
	                setAccess = setAccessTemp;
	            }
	        }
	    }
	}
	
	public class ExampleExtension
	{
	    public static void RunExampleExtension()
	    {
	        Type dateType = typeof(DateTime);
	        PropertyInfo prop = dateType.GetProperty("Now");
	        var (isStatic, isRO, isIndexed, propType) = prop;
	        Console.WriteLine($"\nThe {dateType.FullName}.{prop.Name} property:");
	        Console.WriteLine($"   PropertyType: {propType.Name}");
	        Console.WriteLine($"   Static:       {isStatic}");
	        Console.WriteLine($"   Read-only:    {isRO}");
	        Console.WriteLine($"   Indexed:      {isIndexed}");
	
	        Type listType = typeof(List<>);
	        prop = listType.GetProperty("Item",
	                                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
	        var (hasGetAndSet, sameAccess, accessibility, getAccessibility, setAccessibility) = prop;
	        Console.Write($"\nAccessibility of the {listType.FullName}.{prop.Name} property: ");
	
	        if (!hasGetAndSet | sameAccess)
	        {
	            Console.WriteLine(accessibility);
	        }
	        else
	        {
	            Console.WriteLine($"\n   The get accessor: {getAccessibility}");
	            Console.WriteLine($"   The set accessor: {setAccessibility}");
	        }
	    }
	}
	// The example displays the following output:
	//       The System.DateTime.Now property:
	//          PropertyType: DateTime
	//          Static:       True
	//          Read-only:    True
	//          Indexed:      False
	//
	//       Accessibility of the System.Collections.Generic.List`1.Item property: public
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/discards
namespace DotnetCSharpFundamentalsFunctionalDiscards
{
	public static class FunctionalDiscards
	{
		public static void RunFunctionalDiscards()
		{
			//(_, _, area) = city.GetCityInformation(cityName);
			
			var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

			Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");
			
			static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
			{
			    int population1 = 0, population2 = 0;
			    double area = 0;
			
			    if (name == "New York City")
			    {
			        area = 468.48;
			        if (year1 == 1960)
			        {
			            population1 = 7781984;
			        }
			        if (year2 == 2010)
			        {
			            population2 = 8175133;
			        }
			        return (name, area, year1, population1, year2, population2);
			    }
			
			    return ("", 0, 0, 0, 0, 0);
			}
			// The example displays the following output:
			//      Population change, 1960 to 2010: 393,149
			
			object?[] objects = [CultureInfo.CurrentCulture,
			                   CultureInfo.CurrentCulture.DateTimeFormat,
			                   CultureInfo.CurrentCulture.NumberFormat,
			                   new ArgumentException(), null];
			foreach (var obj in objects)
			    ProvidesFormatInfo(obj);
			
			static void ProvidesFormatInfo(object? obj) =>
			    Console.WriteLine(obj switch
			    {
			        IFormatProvider fmt => $"{fmt.GetType()} object",
			        null => "A null object reference: Its use could result in a NullReferenceException",
			        _ => "Some object type without format information"
			    });
			// The example displays the following output:
			//    System.Globalization.CultureInfo object
			//    System.Globalization.DateTimeFormatInfo object
			//    System.Globalization.NumberFormatInfo object
			//    Some object type without format information
			//    A null object reference: Its use could result in a NullReferenceException
			
			string[] dateStrings = ["05/01/2018 14:57:32.8", "2018-05-01 14:57:32.8",
			                      "2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
			                      "5/01/2018 14:57:32.80 -07:00",
			                      "1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
			                      "Fri, 15 May 2018 20:10:57 GMT"];
			foreach (string dateString in dateStrings)
			{
			    if (DateTime.TryParse(dateString, out _))
			        Console.WriteLine($"'{dateString}': valid");
			    else
			        Console.WriteLine($"'{dateString}': invalid");
			}
			// The example displays output like the following:
			//       '05/01/2018 14:57:32.8': valid
			//       '2018-05-01 14:57:32.8': valid
			//       '2018-05-01T14:57:32.8375298-04:00': valid
			//       '5/01/2018': valid
			//       '5/01/2018 14:57:32.80 -07:00': valid
			//       '1 May 2018 2:57:32.8 PM': valid
			//       '16-05-2018 1:00:32 PM': invalid
			//       'Fri, 15 May 2018 20:10:57 GMT': invalid
			
			
		}
		
		public static void Method(string arg)
		{
		    _ = arg ?? throw new ArgumentNullException(paramName: nameof(arg), message: "arg can't be null");
		
		    // Do work with arg.
		}
		
		private static async Task ExecuteAsyncMethods()
		{
		    Console.WriteLine("About to launch a task...");
		    _ = Task.Run(() =>
		    {
		        var iterations = 0;
		        for (int ctr = 0; ctr < int.MaxValue; ctr++)
		            iterations++;
		        Console.WriteLine("Completed looping operation...");
		        throw new InvalidOperationException();
		    });
		    await Task.Delay(5000);
		    Console.WriteLine("Exiting after 5 second delay");
		}
		// The example displays output like the following:
		//       About to launch a task...
		//       Completed looping operation...
		//       Exiting after 5 second delay
		
		private static async Task ExecuteAsyncMethods2()
		{
		    Console.WriteLine("About to launch a task...");
		    // CS4014: Because this call is not awaited, execution of the current method continues before the call is completed.
		    // Consider applying the 'await' operator to the result of the call.
		    Task.Run(() =>
		    {
		        var iterations = 0;
		        for (int ctr = 0; ctr < int.MaxValue; ctr++)
		            iterations++;
		        Console.WriteLine("Completed looping operation...");
		        throw new InvalidOperationException();
		    });
		    await Task.Delay(5000);
		    Console.WriteLine("Exiting after 5 second delay");
		}
		
		private static void ShowValue(int _)
		{
		   byte[] arr = [0, 0, 1, 2];
		   _ = BitConverter.ToInt32(arr, 0);
		   Console.WriteLine(_);
		}
		 // The example displays the following output:
		 //       33619968
		 
		private static bool RoundTrips(int _)
		{
		   string value = _.ToString();
		   int newValue = 0;
		   //_ = Int32.TryParse(value, out newValue);
		   return _ == newValue;
		}
		// The example displays the following compiler error:
		//      error CS0029: Cannot implicitly convert type 'bool' to 'int'
		
		
	}
	
	public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Person(string fname, string mname, string lname,
                      string cityName, string stateName)
        {
            FirstName = fname;
            MiddleName = mname;
            LastName = lname;
            City = cityName;
            State = stateName;
        }

        // Return the first and last name.
        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string mname, out string lname)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string lname,
                                out string city, out string state)
        {
            fname = FirstName;
            lname = LastName;
            city = City;
            state = State;
        }
    }
    class Example
    {
        public static void RunExample()
        {
            var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

            // Deconstruct the person object.
            var (fName, _, city, _) = p;
            Console.WriteLine($"Hello {fName} of {city}!");
            // The example displays the following output:
            //      Hello John of Boston!
        }
    }
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/pattern-matching
namespace DotnetCSharpFundamentalsFunctionalPatternMatching
{
	public static class FunctionalPatternMatching
	{
		public static void RunFunctionalPatternMatching()
		{
			int? maybe = 12;

			if (maybe is int number)
			{
			    Console.WriteLine($"The nullable int 'maybe' has the value {number}");
			}
			else
			{
			    Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
			}
			
			string? message = "something"; //ReadMessageOrDefault();

			if (message is not null)
			{
			    Console.WriteLine(message);
			}
			
			/*
			if (observation.Annotation is { })
			{
			    Console.WriteLine($"Observation description: {observation.Annotation}");
			}
			*/
			
			decimal balance = 0m;
			/*
			foreach (string[] transaction in ReadRecords())
			{
			    balance += transaction switch
			    {
			        [_, "DEPOSIT", _, var amount]     => decimal.Parse(amount),
			        [_, "WITHDRAWAL", .., var amount] => -decimal.Parse(amount),
			        [_, "INTEREST", var amount]       => decimal.Parse(amount),
			        [_, "FEE", var fee]               => -decimal.Parse(fee),
			        _                                 => throw new InvalidOperationException($"Record {string.Join(", ", transaction)} is not in the expected format!"),
			    };
			    Console.WriteLine($"Record: {string.Join(", ", transaction)}, New balance: {balance:C}");
			}
			*/
			
			
		}
		
		public static T MidPoint<T>(IEnumerable<T> sequence)
		{
		    if (sequence is IList<T> list)
		    {
		        return list[list.Count / 2];
		    }
		    else if (sequence is null)
		    {
		        throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
		    }
		    else
		    {
		        int halfLength = sequence.Count() / 2 - 1;
		        if (halfLength < 0) halfLength = 0;
		        return sequence.Skip(halfLength).First();
		    }
		}
		
		/*
		public State PerformOperation(Operation command) =>
		   command switch
		   {
		       Operation.SystemTest => RunDiagnostics(),
		       Operation.Start => StartSystem(),
		       Operation.Stop => StopSystem(),
		       Operation.Reset => ResetToReady(),
		       _ => throw new ArgumentException("Invalid enum value for command", nameof(command)),
		   };
		*/
		
		/*
		public State PerformOperation(string command) =>
		   command switch
		   {
		       "SystemTest" => RunDiagnostics(),
		       "Start" => StartSystem(),
		       "Stop" => StopSystem(),
		       "Reset" => ResetToReady(),
		       _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
		   };
		*/
		
		/*
		public State PerformOperation(ReadOnlySpan<char> command) =>
		   command switch
		   {
		       "SystemTest" => RunDiagnostics(),
		       "Start" => StartSystem(),
		       "Stop" => StopSystem(),
		       "Reset" => ResetToReady(),
		       _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
		   };
		*/
		
		public static string WaterState(int tempInFahrenheit) =>
		    tempInFahrenheit switch
		    {
		        < 32 => "solid",
		        32 => "solid/liquid transition",
		        (> 32) and (< 212) => "liquid",
		        212 => "liquid / gas transition",
		        > 212 => "gas",
		    };
			
		public static string WaterState2(int tempInFahrenheit) =>
		    tempInFahrenheit switch
		    {
		        < 32 => "solid",
		        32 => "solid/liquid transition",
		        < 212 => "liquid",
		        212 => "liquid / gas transition",
		        _ => "gas",
			};
			
		public static decimal CalculateDiscount(Order order) =>
		    order switch
		    {
		        { Items: > 10, Cost: > 1000.00m } => 0.10m,
		        { Items: > 5, Cost: > 500.00m } => 0.05m,
		        { Cost: > 250.00m } => 0.02m,
		        null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
		        var someObject => 0m,
		    };
			
		public static decimal CalculateDiscount2(Order order) =>
		    order switch
		    {
		        ( > 10,  > 1000.00m) => 0.10m,
		        ( > 5, > 50.00m) => 0.05m,
		        { Cost: > 250.00m } => 0.02m,
		        null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
		        var someObject => 0m,
		    };
		
	}

	public record Order(int Items, decimal Cost);
	
	public record class Observation(int Value, string Units, string Name)
	{
	    public string? Annotation { get; set; }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism
namespace DotnetCSharpFundamentalsObjectOrientedPolymorphism
{
	public class Shape
	{
	    // A few example members
	    public int X { get; init; }
	    public int Y { get; init; }
	    public int Height { get; init; }
	    public int Width { get; init; }
	
	    // Virtual method
	    public virtual void Draw()
	    {
	        Console.WriteLine("Performing base class drawing tasks");
	    }
	}
	
	public class Circle : Shape
	{
	    public override void Draw()
	    {
	        // Code to draw a circle...
	        Console.WriteLine("Drawing a circle");
	        base.Draw();
	    }
	}
	public class Rectangle : Shape
	{
	    public override void Draw()
	    {
	        // Code to draw a rectangle...
	        Console.WriteLine("Drawing a rectangle");
	        base.Draw();
	    }
	}
	public class Triangle : Shape
	{
	    public override void Draw()
	    {
	        // Code to draw a triangle...
	        Console.WriteLine("Drawing a triangle");
	        base.Draw();
	    }
	}
	
	public static class ObjectOrientedPolymorphism
	{
		public static void RunObjectOrientedPolymorphism()
		{
			// Polymorphism at work #1: a Rectangle, Triangle and Circle
			// can all be used wherever a Shape is expected. No cast is
			// required because an implicit conversion exists from a derived
			// class to its base class.
			List<Shape> shapes =
			[
			    new Rectangle(),
			    new Triangle(),
			    new Circle()
			];
			
			// Polymorphism at work #2: the virtual method Draw is
			// invoked on each of the derived classes, not the base class.
			foreach (var shape in shapes)
			{
			    shape.Draw();
			}
			/* Output:
			    Drawing a rectangle
			    Performing base class drawing tasks
			    Drawing a triangle
			    Performing base class drawing tasks
			    Drawing a circle
			    Performing base class drawing tasks
			*/
			
			DerivedClass B = new();
			B.DoWork();  // Calls the new method.
			
			BaseClass A = B;
			A.DoWork();  // Also calls the new method.
			
			DerivedClass2 B2 = new();
			B.DoWork();  // Calls the new method.
			
			BaseClass2 A2 = (BaseClass2)B2;
			A2.DoWork();  // Calls the old method.
			
		}
		
	}
	
	public class BaseClass
	{
	    public virtual void DoWork() { }
	    public virtual int WorkProperty => 0;
	}
	public class DerivedClass : BaseClass
	{
	    public override void DoWork() { }
	    public override int WorkProperty
	    {
	        get { return 0; }
	    }
	}
	
	public class BaseClass2
	{
	    public void DoWork() { WorkField++; }
	    public int WorkField;
	    public int WorkProperty
	    {
	        get { return 0; }
	    }
	}
	
	public class DerivedClass2 : BaseClass2
	{
	    public new void DoWork() { WorkField++; }
	    public new int WorkField;
	    public new int WorkProperty
	    {
	        get { return 0; }
	    }
	}
	
	public class A
	{
	    public virtual void DoWork() { }
	}
	public class B : A
	{
	    public override void DoWork() { }
	}
	
	public class C : B
	{
	    public sealed override void DoWork() { }
	}
	
	public class D : C
	{
	    public new void DoWork() { }
	}
	
	public class Base
	{
	    public virtual void DoWork() {/*...*/ }
	}
	
	public class Derived : Base
	{
	    public override void DoWork()
	    {
	        //Perform Derived's work here
	        //...
	        // Call DoWork on base class
	        base.DoWork();
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance
namespace DotnetCSharpFundamentalsObjectOrientedInheritance
{
	// WorkItem implicitly inherits from the Object class.
	public class WorkItem
	{
	    // Static field currentID stores the job ID of the last WorkItem that
	    // has been created.
	    private static int currentID;
	
	    //Properties.
	    protected int ID { get; set; }
	    protected string Title { get; set; }
	    protected string Description { get; set; }
	    protected TimeSpan jobLength { get; set; }
	
	    // Default constructor. If a derived class does not invoke a base-
	    // class constructor explicitly, the default constructor is called
	    // implicitly.
	    public WorkItem()
	    {
	        ID = 0;
	        Title = "Default title";
	        Description = "Default description.";
	        jobLength = new TimeSpan();
	    }
	
	    // Instance constructor that has three parameters.
	    public WorkItem(string title, string desc, TimeSpan joblen)
	    {
	        ID = GetNextID();
	        Title = title;
	        Description = desc;
	        jobLength = joblen;
	    }
	
	    // Static constructor to initialize the static member, currentID. This
	    // constructor is called one time, automatically, before any instance
	    // of WorkItem or ChangeRequest is created, or currentID is referenced.
	    static WorkItem() => currentID = 0;
	
	    // currentID is a static field. It is incremented each time a new
	    // instance of WorkItem is created.
	    protected int GetNextID() => ++currentID;
	
	    // Method Update enables you to update the title and job length of an
	    // existing WorkItem object.
	    public void Update(string title, TimeSpan joblen)
	    {
	        this.Title = title;
	        this.jobLength = joblen;
	    }
	
	    // Virtual method override of the ToString method that is inherited
	    // from System.Object.
	    public override string ToString() =>
	        $"{this.ID} - {this.Title}";
	}
	
	// ChangeRequest derives from WorkItem and adds a property (originalItemID)
	// and two constructors.
	public class ChangeRequest : WorkItem
	{
	    protected int originalItemID { get; set; }
	
	    // Constructors. Because neither constructor calls a base-class
	    // constructor explicitly, the default constructor in the base class
	    // is called implicitly. The base class must contain a default
	    // constructor.
	
	    // Default constructor for the derived class.
	    public ChangeRequest() { }
	
	    // Instance constructor that has four parameters.
	    public ChangeRequest(string title, string desc, TimeSpan jobLen,
	                         int originalID)
	    {
	        // The following properties and the GetNexID method are inherited
	        // from WorkItem.
	        this.ID = GetNextID();
	        this.Title = title;
	        this.Description = desc;
	        this.jobLength = jobLen;
	
	        // Property originalItemID is a member of ChangeRequest, but not
	        // of WorkItem.
	        this.originalItemID = originalID;
	    }
	}
	
	public static class ObjectOrientedInheritance
	{
		public static void RunObjectOrientedInheritance()
		{
			// Create an instance of WorkItem by using the constructor in the
			// base class that takes three arguments.
			WorkItem item = new("Fix Bugs",
			            "Fix all bugs in my code branch",
			            new TimeSpan(3, 4, 0, 0));
			
			// Create an instance of ChangeRequest by using the constructor in
			// the derived class that takes four arguments.
			ChangeRequest change = new("Change Base Class Design",
			                  "Add members to the class",
			                  new TimeSpan(4, 0, 0),
			                  1);
			
			// Use the ToString method defined in WorkItem.
			Console.WriteLine(item.ToString());
			
			// Use the inherited Update method to change the title of the
			// ChangeRequest object.
			change.Update("Change the Design of the Base Class",
			    new TimeSpan(4, 0, 0));
			
			// ChangeRequest inherits WorkItem's override of ToString.
			Console.WriteLine(change.ToString());
			/* Output:
			    1 - Fix Bugs
			    2 - Change the Design of the Base Class
			*/
		
		}
		
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects
namespace DotnetCSharpFundamentalsObjectOrientedObjects
{
	public class Person(string name, int age)
	{
	    public string Name { get; set; } = name;
	    public int Age { get; set; } = age;
	    // Other properties, methods, events...
	}
	
	class ObjectOrientedObjects
	{
	    static void RunObjectOrientedObjects()
	    {
	        Person person1 = new("Leopold", 6);
	        Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}");
	
	        // Declare new person, assign person1 to it.
	        Person person2 = person1;
	
	        // Change the name of person2, and person1 also changes.
	        person2.Name = "Molly";
	        person2.Age = 16;
	
	        Console.WriteLine($"person2 Name = {person2.Name} Age = {person2.Age}");
	        Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}");
	
	        /*
	            Output:
	            person1 Name = Leopold Age = 6
	            person2 Name = Molly Age = 16
	            person1 Name = Molly Age = 16
	        */
	    }
	}
	
	public struct PersonStruct
    {
        public string Name;
        public int Age;
        public PersonStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class PersonStructApp
    {
        static void RunPersonStruct()
        {
            // Create  struct instance and initialize by using "new".
            // Memory is allocated on thread stack.
            Person p1 = new("Alex", 9);
            Console.WriteLine($"p1 Name = {p1.Name} Age = {p1.Age}");

            // Create  new struct object. Note that  struct can be initialized
            // without using "new".
            Person p2 = p1;

            // Assign values to p2 members.
            p2.Name = "Spencer";
            p2.Age = 7;
            Console.WriteLine($"p2 Name = {p2.Name} Age = {p2.Age}");

            // p1 values remain unchanged because p2 is  copy.
            Console.WriteLine($"p1 Name = {p1.Name} Age = {p1.Age}");
			
			// Person is defined in the previous example.

			//public struct Person(string name, int age)
			//{
			//    public string Name { get; set; } = name;
			//    public int Age { get; set; } = age;
			//}
			
			PersonStruct p3 = new("Wallace", 75);
			PersonStruct p4 = new("", 42);
			p4.Name = "Wallace";
			p4.Age = 75;
			
			if (p2.Equals(p1))
			    Console.WriteLine("p2 and p1 have the same values.");
			
			// Output: p2 and p1 have the same values.
        }
    }
    /*
        Output:
        p1 Name = Alex Age = 9
        p2 Name = Spencer Age = 7
        p1 Name = Alex Age = 9
    */
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/
namespace DotnetCSharpFundamentalsObjectOriented
{
	//public
	//protected
	//internal
	//protected internal
	//private
	//private protected
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types
namespace DotnetCSharpFundamentalsTypesAnonymousTypes
{
	public class AnonymousTypes
	{
		public static void RunAnonymousTypes()
		{
			// Tuple with named elements.
			var tupleProduct = (Name: "Widget", Price: 19.99M);
			Console.WriteLine($"Tuple: {tupleProduct.Name} costs ${tupleProduct.Price}");
			
			// Equivalent example using anonymous types.
			var anonymousProduct = new { Name = "Widget", Price = 19.99M };
			Console.WriteLine($"Anonymous: {anonymousProduct.Name} costs ${anonymousProduct.Price}");
			
			// Deconstruct using var for all variables
			var (name, age, city) = GetPersonInfo();
			Console.WriteLine($"{name} is {age} years old and lives in {city}");
			// Output: Alice is 30 years old and lives in Seattle
			
			// Deconstruct with explicit types
			(string personName, int personAge, string personCity) = GetPersonInfo();
			Console.WriteLine($"{personName}, {personAge}, {personCity}");
			
			// Deconstruct into existing variables
			string existingName;
			int existingAge;
			string existingCity;
			(existingName, existingAge, existingCity) = GetPersonInfo();
			
			// Deconstruct and discard unwanted values using the discard pattern (_)
			var (name2, _, city2) = GetPersonInfo();
			Console.WriteLine($"{name2} lives in {city2}");
			// Output: Alice lives in Seattle
			
			var people = new List<(string Name, int Age)>
			{
			    ("Bob", 25),
			    ("Carol", 35),
			    ("Dave", 40)
			};
			
			foreach (var (personName2, personAge2) in people)
			{
			    Console.WriteLine($"{personName2} is {personAge2} years old");
			}
			
			var configLookup = new Dictionary<int, (int Min, int Max)>()
			{
			    [2] = (4, 10),
			    [4] = (10, 20),
			    [6] = (0, 23)
			};
			
			if (configLookup.TryGetValue(4, out (int Min, int Max) range))
			{
			    Console.WriteLine($"Found range: min is {range.Min}, max is {range.Max}");
			}
			// Output: Found range: min is 10, max is 20
			
			/*
			var productQuery =
			    from prod in products
			    select new { prod.Color, prod.Price };
			*/
			
			/*
			foreach (var v in productQuery)
			{
			    Console.WriteLine("Color={0}, Price={1}", v.Color, v.Price);
			}
			*/
			
			// Explicit member names.
			var personExplicit = new { FirstName = "Kyle", LastName = "Mit" };
			
			// Projection initializers (inferred member names).
			var firstName = "Kyle";
			var lastName = "Mit";
			var personInferred = new { firstName, lastName };
			
			// Both create equivalent anonymous types with the same property names.
			Console.WriteLine($"Explicit: {personExplicit.FirstName} {personExplicit.LastName}");
			Console.WriteLine($"Inferred: {personInferred.firstName} {personInferred.lastName}");
			
			var title = "Software Engineer";
			var department = "Engineering";
			var salary = 75000;
			
			// Using projection initializers.
			var employee = new { title, department, salary };
			
			// Equivalent to explicit syntax:
			// var employee = new { title = title, department = department, salary = salary };
			
			Console.WriteLine($"Title: {employee.title}, Department: {employee.department}, Salary: {employee.salary}");
			
			var product = new Product();
			var bonus = new { note = "You won!" };
			var shipment = new { address = "Nowhere St.", product };
			var shipmentWithBonus = new { address = "Somewhere St.", product, bonus };
			
			var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 }};
			
			var apple = new { Item = "apples", Price = 1.35 };
			var onSale = apple with { Price = 0.79 };
			Console.WriteLine(apple);
			Console.WriteLine(onSale);
			
			var v = new { Title = "Hello", Age = 24 };

			Console.WriteLine(v.ToString()); // "{ Title = Hello, Age = 24 }"
		}
		
		static (string Name, int Age, string City) GetPersonInfo()
		{
		    return ("Alice", 30, "Seattle");
		}
	}
	
	class Product
	{
	    public string? Color { get; init; }
	    public decimal Price { get; init; }
	    public string? Name { get; init; }
	    public string? Category { get; init; }
	    public string? Size { get; init; }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
namespace DotnetCSharpFundamentalsTypesGenerics
{
	// Declare the generic class.
	public class GenericList<T>
	{
	    public void Add(T item) { }
	}
	
	public class ExampleClass { }
	
	class TestGenericList
	{
	    public static void RunTestGenericList()
	    {
	        // Create a list of type int.
	        GenericList<int> list1 = new();
	        list1.Add(1);
	
	        // Create a list of type string.
	        GenericList<string> list2 = new();
	        list2.Add("");
	
	        // Create a list of type ExampleClass.
	        GenericList<ExampleClass> list3 = new();
	        list3.Add(new ExampleClass());
	    }
	}
	
	// Type parameter T in angle brackets.
	public class GenericList2<T>
	{
	    // The nested class is also generic, and
	    // holds a data item of type T.
	    private class Node(T t)
	    {
	        // T as property type.
	        public T Data { get; set; } = t;
	
	        public Node? Next { get; set; }
	    }
	
	    // First item in the linked list
	    private Node? head;
	
	    // T as parameter type.
	    public void AddHead(T t)
	    {
	        Node n = new(t);
	        n.Next = head;
	        head = n;
	    }
	
	    // T in method return type.
	    public IEnumerator<T> GetEnumerator()
	    {
	        Node? current = head;
	
	        while (current is not null)
	        {
	            yield return current.Data;
	            current = current.Next;
	        }
	    }
		
		public static void RunGenericList2()
		{
			// A generic list of int.
			GenericList2<int> list = new();
			
			// Add ten int values.
			for (int x = 0; x < 10; x++)
			{
			    list.AddHead(x);
			}
			
			// Write them to the console.
			foreach (int i in list)
			{
			    Console.WriteLine(i);
			}
			
			Console.WriteLine("Done");
		}
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces
namespace DotnetCSharpFundamentalsTypesInterface
{
	interface IEquatable<T>
	{
	    bool Equals(T obj);
	}
	
	public class Car : IEquatable<Car>
	{
	    public string? Make { get; set; }
	    public string? Model { get; set; }
	    public string? Year { get; set; }
	
	    // Implementation of IEquatable<T> interface
	    public bool Equals(Car? car)
	    {
	        return (this.Make, this.Model, this.Year) ==
	            (car?.Make, car?.Model, car?.Year);
	    }
	}
	
	// Internal type that cannot be exposed publicly
	internal class InternalConfiguration
	{
	    public string Setting { get; set; } = "";
	}
	
	// Internal interface that CAN be implemented with public members
	// because it only uses public types in its signature
	internal interface ILoggable
	{
	    void Log(string message); // string is public, so this works with implicit implementation
	}
	
	// Interface with internal accessibility using internal types
	internal interface IConfigurable
	{
	    void Configure(InternalConfiguration config); // Internal type prevents implicit implementation
	}
	
	// This class shows both implicit and explicit interface implementation
	public class ServiceImplementation : ILoggable, IConfigurable
	{
	    // Implicit implementation works for ILoggable because string is public
	    public void Log(string message)
	    {
	        Console.WriteLine($"Log: {message}");
	    }
	
	    // Explicit implementation required for IConfigurable because it uses internal types
	    void IConfigurable.Configure(InternalConfiguration config)
	    {
	        // Implementation here
	        Console.WriteLine($"Configured with: {config.Setting}");
	    }
	    
	    // If we tried implicit implementation for IConfigurable, this wouldn't compile:
	    // public void Configure(InternalConfiguration config) // Error: cannot expose internal type
	}
}



//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records
namespace DotnetCSharpFundamentalsTypesRecords
{
	public record Person(string FirstName, string LastName);
	
	public record Person2(string FirstName, string LastName, string[] PhoneNumbers);
	
	public record Person3(string FirstName, string LastName)
	{
	    public required string[] PhoneNumbers { get; init; }
	}

	public static class TypesRecords
	{
	    public static void RunTypesRecords()
	    {
	        Person person = new("Nancy", "Davolio");
	        Console.WriteLine(person);
	        // output: Person { FirstName = Nancy, LastName = Davolio }
			
			var phoneNumbers = new string[2];
	        Person2 person1 = new("Nancy", "Davolio", phoneNumbers);
	        Person2 person2 = new("Nancy", "Davolio", phoneNumbers);
	        Console.WriteLine(person1 == person2); // output: True
	
	        person1.PhoneNumbers[0] = "555-1234";
	        Console.WriteLine(person1 == person2); // output: True
	
	        Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
			
			Person3 person3 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
	        Console.WriteLine(person1);
	        // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
	
	        Person3 person4 = person3 with { FirstName = "John" };
	        Console.WriteLine(person4);
	        // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
	        Console.WriteLine(person3 == person4); // output: False
	
	        person4 = person3 with { PhoneNumbers = new string[1] };
	        Console.WriteLine(person4);
	        // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
	        Console.WriteLine(person3 == person4); // output: False
	
	        person2 = person1 with { };
	        Console.WriteLine(person3 == person4); // output: True
	    }
	
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes
namespace DotnetCSharpFundamentalsTypesClasses
{
	public class MyClass
	{
		public static void RunMyClass()
		{
			// Declaring an object of type MyClass.
			MyClass mc = new MyClass();
			
			// Declaring another object of the same type, assigning it the value of the first object.
			MyClass mc2 = mc;
			
			Customer object1 = new();
			
			Customer object2;
			
			Customer object3 = new();
			Customer object4 = object3;
			
			//var p1 = new Person(); // Error! Required properties not set
			var p2 = new Person() { FirstName = "Grace", LastName = "Hopper" };
		}
	}
	
	//[access modifier] - [class] - [identifier]
	public class Customer
	{
	   // Fields, properties, methods and events go here...
	}
	
	public class Container
	{
	    // Initialize capacity field to a default value of 10:
	    private int _capacity = 10;
		
		public Container(int capacity) => _capacity = capacity;
	}
	
	public class Container2(int capacity)
	{
	    private int _capacity = capacity;
	}
	
	public class Person
	{
	    public required string LastName { get; set; }
	    public required string FirstName { get; set; }
	}
	
	public class Employee
	{
		
	}
	
	public class Manager : Employee
	{
	    // Employee fields, properties, methods and events are inherited
	    // New Manager fields, properties, methods and events go here...
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces
namespace DotnetCSharpFundamentalsTypesNamespaces
{
	namespace SampleNamespace
	{
	    class SampleClass
	    {
	        public void SampleMethod()
	        {
	            System.Console.WriteLine(
	                "SampleMethod inside SampleNamespace");
	        }
	    }
	}
	
	class AnotherSampleClass
	{
	    public void AnotherSampleMethod()
	    {
	        System.Console.WriteLine(
	            "SampleMethod inside SampleNamespace");
	    }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
namespace DotnetCSharpFundamentalsTypes
{
	public class SCFT
	{
		private string[] names = ["Spencer", "Sally", "Doug"];
		
		public string GetName(int ID)
		{
		    if (ID < names.Length)
		        return names[ID];
		    else
		        return String.Empty;
		}
	}
	
	public struct Coords(int x, int y)
	{
	    public int X { get; init; } = x;
	    public int Y { get; init; } = y;
	}
	
	public enum FileMode
	{
	    CreateNew = 1,
	    Create = 2,
	    Open = 3,
	    OpenOrCreate = 4,
	    Truncate = 5,
	    Append = 6,
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements
namespace DotnetCSharpFundamentalsProgramStructureTopLevelStatements
{
	public class SBDemo
	{
		public static int StringBuilderDemo(string[] args)
		{
			StringBuilder builder = new();
			builder.AppendLine("The following arguments are passed:");
			
			foreach (var arg in args)
			{
			    builder.AppendLine($"Argument={arg}");
			}
			
			Console.WriteLine(builder.ToString());
			
			return 0;
		}
		
		public static async void AsyncMethod()
		{
			Console.Write("Hello ");
			await Task.Delay(5000);
			Console.WriteLine("World!");
		}
	}
	
	namespace MyNamespace
	{
	    class MyClass
	    {
	        public static void MyMethod()
	        {
	            Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
	        }
	    }
	}
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line
namespace DotnetCSharpFundamentalsProgramStructureMainCommandLine
{
	public class Functions
	{
	    public static long Factorial(int n)
	    {
	        // Test for invalid input.
	        if ((n < 0) || (n > 20))
	        {
	            return -1;
	        }
	
	        // Calculate the factorial iteratively rather than recursively.
	        long tempResult = 1;
	        for (int i = 1; i <= n; i++)
	        {
	            tempResult *= i;
	        }
	        return tempResult;
	    }
	}
	
	public class MainClass
	{
	    public static int RunMainClass(string[] args)
	    {
	        if (args.Length == 0)
	        {
	            Console.WriteLine("Please enter a numeric argument.");
	            Console.WriteLine("Usage: Factorial <num>");
	            return 1;
	        }
	
	        int num;
	        bool test = int.TryParse(args[0], out num);
	        if (!test)
	        {
	            Console.WriteLine("Please enter a numeric argument.");
	            Console.WriteLine("Usage: Factorial <num>");
	            return 1;
	        }
	
	        long result = Functions.Factorial(num);
	
	        if (result == -1)
	            Console.WriteLine("Input must be >= 0 and <= 20.");
	        else
	            Console.WriteLine($"The Factorial of {num} is {result}.");
	
	        return 0;
	    }
	}
	
}

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/
namespace DotnetCSharpFundamentaslsProgramStructure
{
	namespace YourNamespace
	{
	    class YourClass
	    {
	    }
	
	    struct YourStruct
	    {
	    }
	
	    interface IYourInterface
	    {
	    }
		
		interface IMyInterface
	    {
	    }
	
	    delegate int YourDelegate();
	
	    enum YourEnum
	    {
	    }
	
	    namespace YourNestedNamespace
	    {
	        struct YourStruct
	        {
	        }
	    }
	}
}



