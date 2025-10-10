using DataAccessLayer_Class_Library;
using SchoolDomain_Class_Library;

namespace BusinessLayer_Class_Library
{
    public class SchoolBusiness
    {
        public Guid AddStudent(string name, float gpa)

        {
            var student = new Student
            {
                Name = name,
                Gpa = gpa
            };

            var data = new SchoolData();
            return data.CreateSudent(student);
        }


        public Guid AddInstructor(string name)

        {
            var instructor = new Instructor
            {
                Name = name
            };

            var data = new SchoolData();
            return data.CreateInstructor(instructor);
        }

        public Guid AddCourse(string courseName, int creditHours)

        {
            var course = new Course
            {
                CourseName = courseName,
                CreditHours = creditHours
            };

            var data = new SchoolData();
            return data.SaveCourse(course);
        }

        public void AddStudentToCourse(Guid studentId, Guid courseId)
        {
            var data = new SchoolData();

            var studentCourse = new StudentCourse
            {
                Student = data.GetStudentById(studentId),
                Course = data.GetCourseById(courseId)
            };
            data.SaveStudentCourse(studentCourse);
        }

        public void AddInstructorToCourse(Guid instructorId, Guid courseId)
        {
            var data = new SchoolData();
            var course = data.GetCourseById(courseId);
            var instructor = data.GetInstructorById(instructorId);
            course.Instructor = instructor;
            course.IsDirty = true;
            data.SaveCourse(course);
        }

        public void AddStudentGrade(Guid studentId, Guid courseId, string grade)
        {
            var data = new SchoolData();
            var studentCourse = data.GetStudentCourseById(studentId, courseId);
            studentCourse.Grade = grade;
            studentCourse.IsDirty = true;
            data.SaveStudentCourse(studentCourse);
        }

        public Student GetStudent(Guid stundentId)
        {
            var data = new SchoolData();
            return data.GetStudentById(stundentId);
        }

        public void PersistData()
        {
            var data = new SchoolData();
            data.PersistDataStore();
        }

        public void LoadData()
        {
            var data = new SchoolData();
            data.LoadData();
        }


    }

}
