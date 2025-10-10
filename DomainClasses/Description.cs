using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses;

//                                  T: class | struct | ClassName | InterfaceName | new()
public class Description<T> where T : class
{
    public static string Describe<T>(T obj) where T : class
    {
        if (obj.GetType() == typeof(T))
        {
            
        }
        return string.Empty;
    }
}
