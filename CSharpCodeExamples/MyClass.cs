namespace CSharpCodeExamples
{
    //internal  static      class   MyClass
    //public    abstract
    //          sealed
    //          partial
    internal class MyClass
    {
        //private               static      type    fieldName
        //protected             const
        //private protected     readonly
        //internal
        //protected internal
        //public
        public static float gravity = 9.8f;
        public const double PI = 3.14; // must be initialized inline

        //                                      default (no keyword)
        //                                      ref
        //                                      out
        //                                      in
        //                                      params
        public static void ExampleStaticMethodOne(
            ref int x, // two way communication
            in int y, // parameter becomes read only
            out int z // good for returning several values,
            //params string[] words
        )
        {
            z = 0;
            // ref returns
        }

        public static void ExampleStaticMethodTwo(params string[] words) // has to be last parameter
        {
            int x = 3;
            int y = 5;
            int z = 4;
            ExampleStaticMethodOne(y: in y, x: ref x, z: out z);

            string one = words[0];

            string s = ConcatenateParams(words);

            // Local Function example, no support for modifiers
            string ConcatenateParams(params string[] words)
            {
                return words.ToString() ?? string.Empty;
            }

            // can't access containing method variables
            static string DoSomethingInsideMethod(params string[] words)
            {
                return words.ToString() ?? string.Empty;
            }


        }

        public static void ExampleStaticMethodThree()
        {
            ExampleStaticMethodTwo("one", "two", "three");

        }

        public double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        protected string _field1;
        protected readonly string dateOfCreation;


        public MyClass()
        {
            _field1 = string.Empty;
            dateOfCreation = DateTime.Now.ToShortDateString();

        }

        public string GetField1Value()
        {
            return _field1;
        }

        public void SetField1Value(string value)
        {
            _field1 = value;
        }

        //private               static      returnType MethodName(int parameter1, ...)
        //protected             virtual
        //private protected     abstract
        //internal              override
        //protected internal    new
        //public                partial
        //                      sealed
        public void ExampleInstanceMethod(int parmam1 = 5)
        {
        
        }
    }

    internal class MyOtherClass : MyClass
    {
        private string GetBaseClassField1Value()
        {
            return this._field1;
        }
        
    }
}
/*
Access              Same    Child classes   Other classes   Child classes   Other classes
Modifier            class   same assembly   same assembly   other assembly  other assembly

private             Yes         No              No              No              No
protected           Yes         Yes             No              Yes             No
private protected   Yes         Yes             No              No              No
internal            Yes         Yes             Yes             No              No
protected internal  Yes         Yes             Yes             Yes             No
public              Yes         Yes             Yes             Yes             Yes
*/

