using System.IO;
using Newtonsoft.Json;
using SchoolDomain_Class_Library;

namespace DataAccessLayer_Class_Library
{
    public class SchoolData
    {
        static School School;

        static SchoolData()
        {
            School = new School();
            School.Students = new List<Student>();
            School.Instructors = new List<Instructor>();
            School.Courses = new List<Course>();
            School.StudentCourses = new List<StudentCourse>();
            
        }
        public Guid CreateSudent(Student student)
        {
            student.Id = Guid.NewGuid(); ;
            School.Students.Add(student);
            return student.Id;


        }
        public Guid CreateInstructor(Instructor instructor)
        {
            instructor.Id = Guid.NewGuid(); ;
            School.Instructors.Add(instructor);
            return instructor.Id;

        }
        public Guid SaveCourse(Course course)
        {
            if (course.IsDirty)
            {
                for (int i = 0; i < School.Courses.Count; i++)
                {
                    if (School.Courses[i].Id == course.Id)
                    {
                        course.IsDirty = false;
                        School.Courses[i] = course;
                        return course.Id; ;
                    }
                }
            }
            course.Id = Guid.NewGuid(); ;
            School.Courses.Add(course);
            return course.Id;

        }

        public void SaveStudentCourse(StudentCourse studentCourse)
        {
            if (studentCourse.IsDirty)
            {
                for (int i = 0; i < School.StudentCourses.Count; i++)
                {
                    if (School.StudentCourses[i].Student.Id == studentCourse.Student.Id
                        && School.StudentCourses[i].Course.Id == studentCourse.Course.Id)
                    {
                        studentCourse.IsDirty = false;
                        School.StudentCourses[i] = studentCourse;
                        return;
                    }
                }
            }
            School.StudentCourses.Add(studentCourse);

        }

        public Student GetStudentById(Guid id)
        {
            return School.Students.FirstOrDefault((student) => student.Id == id);
        }

        public Instructor GetInstructorById(Guid id)
        {
            return School.Instructors.FirstOrDefault((instructor) => instructor.Id == id);
        }

        public Course GetCourseById(Guid id)
        {
            return School.Courses.FirstOrDefault((c) => c.Id == id);
        }

        public StudentCourse GetStudentCourseById(Guid studentId, Guid courseId)
        {
            return School.StudentCourses.FirstOrDefault((sc) => sc.Student.Id == studentId && sc.Course.Id == courseId);
        }

        public void PersistDataStore()
        {
            var schoolJson = JsonConvert.SerializeObject(School);
            using (var sw = new StreamWriter(@"C:\temp\school-data.txt"))
            {
                sw.WriteLine(schoolJson);
            }
        }

        public void LoadData()
        {
            string schoolJson = string.Empty;
            using (var sr = new StreamReader(@"C:\temp\school-data.txt"))
            {
                schoolJson = sr.ReadLine();
            }
            School = (School) JsonConvert.DeserializeObject(schoolJson, typeof(School));

        }

    }
}
