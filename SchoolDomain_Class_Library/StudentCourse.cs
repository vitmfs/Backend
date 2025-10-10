using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeGen.Core.TypeAnnotations;

namespace SchoolDomain_Class_Library
{
    [ExportTsClass]
    public class StudentCourse
    {
        public required Student Student { get; set; }
        public required Course Course { get; set; }

        public string? Grade { get; set; }

        public bool IsDirty { get; set; } = false;
    }
}
