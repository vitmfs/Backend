<Query Kind="Program" />

using System;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//namespace GlobalNamespace;

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
	}
	
	public class WhatsNewCSharp142
	{
		public string Message
		{
		    get;
		    set => field = value ?? throw new ArgumentNullException(nameof(value));
		}
	}
	
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
			
			Func<string, int> funcExample1 = x => Convert.ToInt32(x);
			
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
			int dividend = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter a divisor: ");
			int divisor = Convert.ToInt32(Console.ReadLine());
			
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



