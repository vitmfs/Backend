using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace p03_DataAccessLayer_Class_Library
{
    internal class FileWriter
    {
        public Task WriteFile(string fileName, string data)
        {
            StreamWriter writer = new StreamWriter(fileName);
            Task writerTask = writer.WriteAsync(data);
            writer.Close();

            return writerTask;
        }
    }

    internal class FileReader
    {
        public Task<string> ReadFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            Task<string> readerTask = reader.ReadToEndAsync();
            reader.Close();

            return readerTask;
        }

        public static void WriteThenRead()
        {
            string fileName = @"c:\output.txt";
            FileWriter fileWriter = new FileWriter();
            FileReader fileReader = new FileReader();

            Task writerTask = fileWriter.WriteFile(fileName, "Something");
            writerTask.Wait();
            Console.WriteLine("File written.");

            Task<string> readerTask = fileReader.ReadFile(fileName);
            readerTask.Wait(); //Block the current thread until the read operation is completed.
            Console.WriteLine("File read.");

            Console.WriteLine($"\nFile content: {readerTask.Result}");

        }
    }
}
   
