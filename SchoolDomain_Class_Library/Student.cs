// namespace SchoolDomain_Class_Library;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeGen.Core.TypeAnnotations;

namespace SchoolDomain_Class_Library;

[ExportTsClass]
public class Student
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public float Gpa { get; set; }
}

