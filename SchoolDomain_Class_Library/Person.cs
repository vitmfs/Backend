using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDomain_Class_Library;

public class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }

    public BirthDateInfo? BirthDate { get; set; }

    public void Deconstruct(out Person person, out string? name, out int? age)
    {
        (person, name, age) = (this, this.Name, this.Age);
        //person = this;
        //name = this.Name;
        //age = this.Age;
    }
}

public class BirthDateInfo
{
    public DateTime DateOfBirth { get; set; } = DateTime.Now;
}


