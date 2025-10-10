using BusinessLayer_Class_Library;
using p04_LoggingService_ClassLibrary;
using System.Runtime.ExceptionServices;
using TypeGen.Core.Logging;

namespace ServiceLayer_Class_Library
{
    public class SchoolService
    {
        static SchoolService()
        {
            AppDomain.CurrentDomain.FirstChanceException += FirstChanceHandler;
        }

        static void FirstChanceHandler(object source, FirstChanceExceptionEventArgs e)
        {
            Logger.Error(e.Exception.Message);
            Logger.Error(e.Exception.StackTrace);
        }
        public object Controller(string methodName, string[] variables)
        {
            var business = new SchoolBusiness();

            switch (methodName.ToLower())
            {
                case "createstudent":
                    string studentName = variables[0];
                    float gpa = (float) Convert.ToDouble(variables[1]);
                    return business.AddStudent(studentName, gpa);

                case "createinstructor":
                    string instructorName = variables[0];
                    return business.AddInstructor(instructorName);

                case "createcourse":
                    string CourseName = variables[0];
                    int creditHours = Convert.ToInt32(variables[1]);
                    return business.AddCourse(CourseName, creditHours);

                case "addstudenttocourse":
                    Guid studentIdAssigned = new Guid(variables[0]);
                    Guid courseIdAssigned = new Guid(variables[1]);
                    business.AddStudentToCourse(studentIdAssigned, courseIdAssigned);
                    break;

                case "addinstructortocourse":
                    Guid instructorIdAssigned = new Guid(variables[0]);
                    Guid courseIdInstructor = new Guid(variables[1]);
                    business.AddInstructorToCourse(instructorIdAssigned, courseIdInstructor);
                    break;

                case "addstudentgrade":
                    Guid studentIdGrade = new Guid(variables[0]);
                    Guid courseIdGrade = new Guid(variables[1]);
                    string grade = variables[2];
                    business.AddStudentGrade(studentIdGrade, courseIdGrade, grade);
                    break;

                case "getstudent":
                    Guid studentIdGet = new Guid(variables[0]);
                    return business.GetStudent(studentIdGet);
                    break;

                case "persistdata":
                    business.PersistData();
                    break;

                case "loaddata":
                    business.LoadData();
                    break;

            }

            return null;
            
        }

    }

    file class AdditionalService
    {
        
    }
}
