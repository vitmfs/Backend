using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    partial class Student
    {
        public const string BaseUrl = "http://www.example.com";
        public const string ApiUrl = $"{BaseUrl}/api";
        public int RollNumber { get; set; }
        public List<int> Marks { get; set; }
        internal partial int DoSomething()
        {
            return 0;
        }
    }

    class Teacher
    {
        public static int MinPassMarksStatic { get; set; } = 35;
        public void GetMarksOfPassedSubjects()
        {
            Student student = new Student()
            {
                RollNumber = 1,
                Marks = new List<int>() { 34, 10, 50, 78, 40 }
            };

            IEnumerable<int> passedSubjectMarks = student.Marks.Where(static (int n) => { //independent of the objects; can't access object variables
                if (n >= MinPassMarksStatic)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }
    }
}
