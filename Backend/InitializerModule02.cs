using System.Runtime.CompilerServices;

namespace p00_Backend;

internal class InitializerModule02
{
    [ModuleInitializer]
    internal static void InitializerMethod2() //They run in alphabetical order
    {
        Console.WriteLine("From InitializerMethod2");
    }

}
