using System.Runtime.CompilerServices;

namespace p00_Backend;

internal class InitializerModule01
{
    //internal
    //protected internal
    //public
    [ModuleInitializer]
    internal static void InitializerMethod1()
    {
        Console.WriteLine("From InitializerMethod1");
    }

}
