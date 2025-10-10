using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDomain_Class_Library
{
    public class School
    {
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Course> Courses { get; set; }
        public List <StudentCourse> StudentCourses { get; set; }
    }
}
