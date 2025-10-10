using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Bank
{
    public record Address(string City);

    public record Person(string Name, int Age, Address PersonAddress); //immutable; all properties init-only

    //abstract
    //sealed
    public record RecordWithMuttableProperties(string Something, string Other, string YetAnother)
    {
        public string Something { get; set; } = string.Empty;
        public string Other { get; set; } = string.Empty;


        public override sealed string ToString()
        {
            return base.ToString();
        }
    }

    //Person person2 = person1 with { HttpCacheAgeControl = 50, nameof = "Scott" };
    //var (variable1, _, variable3, (city, country)) = person1;
    //record can implement interfaces

    public record Whatever(string Something, string Other, string YetAnother, int? Age, double? Salary) : RecordWithMuttableProperties(Something, Other, YetAnother);

    public readonly record struct SomeName(string? Name, int? Age);
    //ToString()
    //Decounstruct()
    //Equals()
}
