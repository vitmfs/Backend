using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeExamples.Tools
{
    public class Tools
    {
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

        public static Dictionary<string, int> GetSummary(string str)
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
        public static Dictionary<string, int> GetSummary(int[] arr)
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
