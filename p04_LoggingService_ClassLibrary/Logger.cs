namespace p04_LoggingService_ClassLibrary
{
    public static class Logger
    {
        static StreamWriter sw;
        static Logger()
        {
            sw = new StreamWriter(@"C:\temp\log.txt");
        }

        public static void Error(string msg)
        {
            sw.WriteLine($"{DateTime.Now} - Error: {msg}");
            sw.Flush();
        }

        public static void Warning(string msg)
        {
            sw.WriteLine($"{DateTime.Now} - Warning: {msg}");
            sw.Flush();
        }

        public static void Info(string msg)
        {
            sw.WriteLine($"{DateTime.Now} - Info: {msg}");
            sw.Flush();
        }



    }
}
