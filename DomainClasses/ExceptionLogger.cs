using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    internal class ExceptionLogger
    {
        public static void AddException(Exception ex) //in all catch blocks
        {
            string filePath = @"C:\ErrorLog.txt";
            StreamWriter streamWriter = File.AppendText(filePath);
            streamWriter.WriteLine("Exception on" + DateTime.Now.ToString());
            streamWriter.WriteLine(ex.GetType().ToString());
            streamWriter.WriteLine(ex.StackTrace);
            streamWriter.WriteLine(ex.Message);
            streamWriter.Close();

            
        }
    }
}
