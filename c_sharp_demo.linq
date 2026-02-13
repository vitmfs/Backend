<Query Kind="Program" />

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

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/filtering-data
namespace DotnetCSharpLinqStandardQueryOperatorsFilteringData
{
	public class CSharpLinqStandardQueryOperatorsFilteringData
	{
		public static void RunDotnetCSharpLinqStandardQueryOperatorsFilteringData()
		{
			
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



