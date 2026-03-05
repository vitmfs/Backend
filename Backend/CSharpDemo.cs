using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//24000
namespace p00_Backend
{
    interface IMyInterface
    {
        void MyDerivedMethod();
    }

    //public
    //protected
    //internal
    //protected internal
    //private
    //private protected
    public class MyClass
    {
        public bool     MyBooleanProperty { get; init; }
        public byte     MyByteProperty { get; set; }
        public sbyte    MySByteProperty { get; set; }

        public char     MyCharProperty { get; set; }
        public decimal  MyDecimalProperty { get; set; }
        public double   MyDoubleProperty { get; set; }
        public float    MyFloatProperty { get; set; }
        public int      MyIntProperty { get; set; }
        public uint     MyUIntProperty { get; set; }
        public long     MyLongProperty { get; set; }
        public ulong    MyULongProperty { get; set; }
        public short    MyShortProperty { get; set; }
        public ushort   MyUShortProperty { get; set; }

        public object?  MyObjectProperty { get; set; }
        public string   MyStringProperty { get; set; } = string.Empty;
        public dynamic? MyDynamicProperty { get; set; }

        public (bool, byte, sbyte, char, decimal, double, float, int, uint, long, ulong, short, ushort, object, string, dynamic) MyTupleProperty { get; set; }

        public required string  MyRequiredProperty { get; set; }
        public string?          MyNullableProperty { get; set; }

        public static void MyStaticMethod()
        {

        }

        public static async Task MyStaticMethodAsync()
        {
            await Task.Delay(5000);
            Console.WriteLine("Hello World From Async Method!");
        }

        

        public static void TestMyClass()
        {

        }

        public static void SwitchDemo()
        {
            //24600 24508
        }

        public void MyMethod(out string fname)
        {
            fname = "John";
            System.Console.WriteLine("MyMethod Called!");
        }

        static (string Name, int Age, string City) GetPersonInfo()
        {
            return ("Alice", 30, "Seattle");
        }

        public virtual void DoWork()
        {
            Console.WriteLine("Doing work in MyClass");
        }
    }

    public class MyDerivedClass : MyClass, IMyInterface
    {
        public void MyDerivedMethod()
        {
            Console.WriteLine("MyDerivedMethod Called!");
        }

        public override void DoWork()
        {
            Console.WriteLine("Doing work in MyDerivedClass");
            base.DoWork();
        }
    }

    class MyGenericClass<T>
    {
        public T MyProperty { get; set; }
        public T[] MyArrayProperty { get; set; } = Array.Empty<T>();

        public MyGenericClass(T value)
        {
            MyProperty = value;
        }
    }

    public struct MyStruct
    {
        public string Name;
        public int Age;
        public MyStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    enum MyEnum
    {
        Value1,
        Value2,
        Value3
    }

    public record MyRecord(string FirstName, string LastName);

    delegate void MyDelegate();

}
