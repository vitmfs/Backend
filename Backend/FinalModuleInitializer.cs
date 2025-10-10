using System.Runtime.CompilerServices;

namespace p00_Backend;

internal class FinalInitializer
{
    [ModuleInitializer]
    internal static void FinalInitializer1()
    {
        InitializerModule02.InitializerMethod2();
        InitializerModule01.InitializerMethod1();
        //maybe other static methods
        
    }

}
