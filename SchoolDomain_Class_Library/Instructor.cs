using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeGen.Core.TypeAnnotations;

namespace SchoolDomain_Class_Library
{
    [ExportTsClass]
    public class Instructor
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}
