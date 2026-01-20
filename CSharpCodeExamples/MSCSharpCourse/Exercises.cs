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
