using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Demos
{
    /*
        While records can be mutable, they're primarily intended for supporting immutable data models.
        The record type offers the following features:

        Concise syntax for creating a reference type with immutable properties
        Built-in behavior useful for a data-centric reference type:
        Value equality
        Concise syntax for nondestructive mutation
        Built-in formatting for display
        Support for inheritance hierarchies
        Entity Framework Core, for example, doesn't support updating with immutable entity types.

        Records can be defined as classes or structs.
        A record can inherit from another record
        Record types have a compiler-generated ToString method that displays the names and values of public properties and fields.
    */

    internal class RecordDemo
    {
        public record Person(string FirstName, string LastName);

        public record class Person2
        {
            public required string FirstName { get; init; }
            public required string LastName { get; init; }
        };

        public record Person3(string FirstName, string LastName, string Id)
        {
            internal string Id { get; init; } = Id;
            internal readonly string lastName = LastName;

            public string[] PhoneNumbers { get; init; } = [];
        }

        public readonly record struct Point(double X, double Y, double Z);

        public record struct Point2
        {
            public double X { get; init; }
            public double Y { get; init; }
            public double Z { get; init; }
        }

        public record PersonWithMutableProperties
        {
            public required string FirstName { get; set; }
            public required string LastName { get; set; }
        };

        public record struct DataMeasurement(DateTime TakenAt, double Measurement);

        public record struct Point3
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
        }

        public record Point4(int X, int Y)
        {
            public double Distance => Math.Sqrt(X * X + Y * Y);
        }

        public abstract record Person4(string FirstName, string LastName);
        public record Teacher(string FirstName, string LastName, int Grade)
            : Person4(FirstName, LastName);


        public abstract record Person5(string FirstName, string LastName, string[] PhoneNumbers)
        {
            protected virtual bool PrintMembers(StringBuilder stringBuilder)
            {
                stringBuilder.Append($"FirstName = {FirstName}, LastName = {LastName}, ");
                stringBuilder.Append($"PhoneNumber1 = {PhoneNumbers[0]}, PhoneNumber2 = {PhoneNumbers[1]}");
                return true;
            }
        }

        public record Teacher2(string FirstName, string LastName, string[] PhoneNumbers, int Grade)
            : Person5(FirstName, LastName, PhoneNumbers)
        {
            protected override bool PrintMembers(StringBuilder stringBuilder)
            {
                if (base.PrintMembers(stringBuilder))
                {
                    stringBuilder.Append(", ");
                }
                ;
                stringBuilder.Append($"Grade = {Grade}");
                return true;
            }
        };
    }
}

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
