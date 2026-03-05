using CSharpCodeExamples.Tools;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpCodeExamples.FundamentalsOfComputerProgrammingWithCSharp
{
    public class Exercises
    {
        //
        /*
            1. Write a program, which prints a square spiral matrix beginning from
            the number 1 in the upper right corner and moving clockwise.Examples
            for N=3 and N = 4
        */
        public static int[,] SquareSpiralMatrix(int sideLength)
        {
            int[,] matrix = new int[sideLength, sideLength];
            

            int originalSideLength = sideLength;


            int shiftToInterior = 0;
            int startingNumber = 1;

            int[,] FillRightBottomLeftTopExterior(int[,] matrix, int number, int shiftToInterior, int originalSideLength)
            {
                

                if (originalSideLength == 1)
                {
                    matrix[0, 0] = number;
                    return matrix;
                }

                if (originalSideLength == 2)
                {
                    matrix[0, 1] = number;
                    matrix[1, 1] = number + 1;
                    matrix[1, 0] = number + 2;
                    matrix[0, 0] = number + 3;
                    return matrix;
                }

                int lastIndex = (originalSideLength - 1) - shiftToInterior;

                //starting point (top right position)
                int rowIndex = (lastIndex - lastIndex) + shiftToInterior;
                int columnIndex = (lastIndex) - shiftToInterior;


                //exterior right column (x increases)
                for (int x = rowIndex; x <= columnIndex; x++)
                {
                    matrix[x, columnIndex] = number++;
                }


                //exterior bottom row (y decreases)
                rowIndex = lastIndex - shiftToInterior;
                columnIndex = (lastIndex - 1) - shiftToInterior;
                for (int y = columnIndex; y >= 0; y--)
                {
                    if (y >= 0)
                    {
                        matrix[rowIndex, y] = number++;
                    }
                    

                }

                
                //exterior left column (x decreases)
                rowIndex = (lastIndex - 1);
                columnIndex = 0;
                
                
                for (int x = rowIndex; x > 0; x--)
                {

                    if (x >= 0)
                    {
                        matrix[x, columnIndex] = number++;
                    }
                }
                matrix[0, 0] = number++;
                

                //exterior top row (y increases)
                rowIndex = (lastIndex - lastIndex) + shiftToInterior;
                columnIndex = (lastIndex - (lastIndex - 1)) + shiftToInterior;
                for (int y = columnIndex; y <= (lastIndex - 1) - shiftToInterior; y++)
                {
                    if (y > (sideLength - 2) - shiftToInterior)
                    {
                        break;
                    }
                    matrix[rowIndex, y] = number++;
                }
                

                return matrix;
            }

            int numberOfRings = sideLength / 2;

            for (int i = 0; i < 1; i++)
            {
                matrix = FillRightBottomLeftTopExterior(matrix, startingNumber, i, originalSideLength);
                //originalSideLength -= 2;
            }



            //matrix = FillRightBottomLeftTopExterior(matrix, startingNumber, 1);



            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(matrix[i, j] + "|");
                    
                }

                Console.Write("\n");
            }


            return matrix;

        }
        //Chapter 18 Exercise 3
        /*
            3. Write a program that counts how many times each word from a given
            text file words.txt appears in it.The result words should be ordered by
            their number of occurrences in the text.
            Example: "This is the TEXT. Text, text, text – THIS TEXT! Is
            this the text?"
        */
        public static Dictionary<string, int> CountEachWord(string str)
        {
            str ??= "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";


            Dictionary<string, int> GetTextSummary(string[] words)
            {
                words ??= str.Split(new char[] { ' ', '.', ',', '!', '?', '–' }, StringSplitOptions.RemoveEmptyEntries);

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

        
            Dictionary<string, int> summary = GetTextSummary(str.Split(new char[] { ' ', '.', ',', '!', '?', '–' }, StringSplitOptions.RemoveEmptyEntries));

            summary = summary.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            return summary;
        }

        //Chapter 18 Exercise 2
        /*
            2. Write a program to remove from a sequence all the integers, 
            which appear odd number of times.For instance, for the sequence {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6}
            the output would be {5, 3, 3, 5}.
        */
        public static List<int> RemoveAllAppearingOddNumberOfTimes(int[] arr)
        {
            arr ??= [4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6];

            Dictionary<string, int> summary = GetSummary(arr);

            List<int> result = new List<int>();
            for (int i = 0; i < summary.Keys.Count; i++)
            {
                if (summary[summary.Keys.ElementAt(i)] % 2 == 0)
                {
                    result.Add(int.Parse(summary.Keys.ElementAt(i)));
                }
            }
            return result;
        }

        //Chapter 18 Exercise 1
        /*
            1. Write a program that counts, in a given array of integers, the number of
            occurrences of each integer.
            Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
            2  2 times 3  4 times 4  3 times
        */
        public static Dictionary<string, int> GetSummary(int[] arr)
        {
            arr ??= [3, 4, 4, 2, 3, 3, 4, 3, 2];

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
