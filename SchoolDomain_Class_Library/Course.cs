using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeGen.Core.TypeAnnotations;

namespace SchoolDomain_Class_Library
{
    [ExportTsClass]
    public class Course
    {
        public Guid Id { get; set; }
        public required string CourseName { get; set; }
        public int CreditHours { get; set; }

        public Instructor Instructor { get; set; }

        public bool IsDirty { get; set; } = false;
    }
}
