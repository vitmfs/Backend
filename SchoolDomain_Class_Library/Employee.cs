using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDomain_Class_Library;

internal class Employee: Person
{
    public string FirstName { get; set; } = string.Empty;
    public object? Y { get; set; }

    public double? Salary { get; set; }


    public Employee()
    {
        FirstName = string.Empty;
    
    }

    

    public static Employee? GetEmployee()
    {
        Console.WriteLine(new Employee().Y?.ToString() ?? string.Empty);

        return new();
    }
}

public class Customer : Person
{
    public double? CustomerBalance { get; set; }
}

public class Suplier : Person
{
    public double? SuplierBalance { get; set; }
}

public class Manager : Person
{
    
}

enum MaritalStatus
{
    Unmarried,
    Married
}

class Descripter
{
    public static string GetDescription(Person person)
    {
        string result5 = person switch
        {
            (Person, _, not (<= 13)) p => p.Name ?? $"{p.Name}",
            _ => person.Name ?? string.Empty
        };

        string result4 = (person, person.Age, person.Name, person.BirthDate) switch
        {
            (Person, not(<= 13), _, BirthDateInfo { DateOfBirth: { Day: > 13} }) => "Something",
            _ => person.Name ?? string.Empty
        };
        

        string result3 = person switch
        {
            Person {Age: <13, Name: not("Something")} p => $"{p.Name} is Teenager",
            Employee {Age: < 20 and >= 13 and not (100 or 200) } e  => $"{e.Name} is Teenager",
            Person p when p.Age is 100 or 200 => string.Empty,
            _ => person.Name ?? string.Empty
        };
        

        string result2 = person switch
        {
            Person p when p.Age is < 20 or >= 13 => $"{p.Name} is Teenager",
            Employee e when e.Age is < 20 and >= 13 and not(100 or 200) => $"{e.Name} is Teenager",
            Person p when p.Age is 100 or 200 => string.Empty,
            _ => string.Empty
        };
        

        switch (person)
        {
            case Employee employee:
                break;

            case Customer customer:
                break;

            case Suplier:
                break;

            case Person p when p.Age < 20 && p.Age >= 13:
                return $"{p.Name} is Teenager";
                break;

            default:
                break;
        }

        string result = person switch
        {
            Person p when p.Age < 20 && p.Age >= 13 => $"{p.Name} is Teenager",
            Employee e when e.Age < 20 && e.Age >= 13 => $"{e.Name} is Teenager",
            _ => string.Empty
        };


        if (person.GetType() == typeof(Employee) || person is Employee)
        {
            Employee employee = (Employee)person;
        }

        return $"{person.Name}, {person.Age}, {person.Gender}";
    }
}