using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeExamples.Tools
{
    public class Tools
    {
        public static void PrintBidimensionalMatrix(int[,] matrix)
        {
            int sideLength = matrix.GetLength(0);

            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write($"{matrix[i, j],3}|");
                    //Thread.Sleep(3);
                }

                Console.Write("\n");
            }
        }
        public static Dictionary<string, int> GetTextSummary(string[] words)
        {
            Dictionary<string, int> summary = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string key = word.ToString().ToLower();
                if (summary.ContainsKey(key))
                {
                    summary[key]++;
                }
                else
                {
                    summary[key] = 1;
                }
            }

            return summary;
        }

        public static Dictionary<string, int> GetStringSummary(string str)
        {
            Dictionary<string, int> summary = new Dictionary<string, int>();

            foreach (char c in str)
            {
                string key = c.ToString();
                if (summary.ContainsKey(key))
                {
                    summary[key]++;
                }
                else
                {
                    summary[key] = 1;
                }
            }

            return summary;
        }

        //Chapter 18 Exercise 1
        public static Dictionary<string, int> GetArraySummary(int[] arr)
        {
            Dictionary<string, int> summary = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                string key = arr[i].ToString();
                if (summary.ContainsKey(key))
                {
                    summary[key]++;
                }
                else
                {
                    summary[key] = 1;
                }
            }

            return summary;
        }
    }
}
