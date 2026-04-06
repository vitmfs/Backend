using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeExamples.MSCSharpCourse
{
    public static class Exercises
    {
        public static bool RecursiveFactorial(int n, out int factorial)
        {
            bool ok = true;

            // Trap negative inputs
            if (n < 0)
            {
                factorial = 0;
                ok = false;
            }

            if (n <= 1)
            {
                factorial = 1;
            }
            else
            {
                try
                {
                    int pf;

                    checked
                    {
                        ok = RecursiveFactorial(n - 1, out pf);
                        factorial = n * pf;
                    }

                }
                catch (Exception)
                {
                    // Something went wrong.
                    // Set error falg and return zero.
                    factorial = 0;
                    ok = false;
                }
            }

            return ok;
        }
    }
}

// Explain what methods are and why they are important.
// List the three ways in which data can be passed in parameters, and the associated C# keywords.
// When are local variables created and destroyed?
// What keyword should be added to a method definition if the method needs to be called from another class?
// What parts of a method are used to form the signature?
// Define the signature of a static method called Rotate that does not return a value but must #right rotate" its three integer parameters
