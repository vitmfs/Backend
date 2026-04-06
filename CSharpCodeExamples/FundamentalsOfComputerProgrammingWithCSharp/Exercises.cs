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
        public static void PrintMatrix(int[,] matrix)
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

        #region Chapter 26 Topic 3
        /*
            With a given number N (input from the keyboard) generate and print a
            square matrix containing the numbers from 0 to N2-1, located as a
            spiral beginning from the center of the matrix and moving clockwise starting
            downwards (look at the examples).
            Sample output for N=3 and N=4:
        */
        public static int[,] SpiralMatrix(int sideLength)
        {
            int[,] matrix = new int[sideLength, sideLength];

            
            int lastIndex = sideLength - 1;


            // determine the center of the matrix
            bool isSideLengthEven = sideLength % 2 == 0;
            int centerX = isSideLengthEven ? lastIndex / 2 : lastIndex / 2;
            int centerY = isSideLengthEven ? (lastIndex / 2) + 1 : lastIndex / 2;

            // the number of cycles of filling the matrix
            // is equal to the side length of the matrix
            int fillingCycles = sideLength;

            const int startingNumber = 0;
            int currentNumber = startingNumber;
            int x = centerX;
            int y = centerY;
            

            for ( int currentFillingCycle = 1; currentFillingCycle <= fillingCycles; currentFillingCycle++)
            {
                //Console.WriteLine($"Start of Filling cycle: {currentFillingCycle}");
                //Console.WriteLine($"At the start of the filling cycle:{x} {y}");
                // when the current filling cycle is odd, like the first one,
                // we exit from the bottom right,
                // otherwise we exit from the top left
                bool isCurrentFillingCycleOdd = (currentFillingCycle % 2) == 1;

                if (isCurrentFillingCycleOdd)
                {
                    

                    if (currentFillingCycle == 1)
                    {
                        matrix[x, y] = currentNumber++;
                        
                        continue;
                    }

                    
                    // we add currentFillingCycle number of integers to the top
                    // and currentFillingCycle -1 number of integers to the right

                    for (int i = 1; i <= currentFillingCycle; i++)
                    {
                        bool lastOneOfRow = i == currentFillingCycle;
                        if (!lastOneOfRow)
                        {
                            matrix[x, y++] = currentNumber++;
                        }
                        else
                        {
                            matrix[x, y] = currentNumber++;
                        }
                    }
                    //Console.WriteLine($"Inside Odd:{x} {y}");
                    x = x + 1;

                    
                    for (int j = 1; j <= currentFillingCycle - 1; j++)
                    {
                        bool lastOneOfColumn = j == currentFillingCycle;
                        if (!lastOneOfColumn)
                        {
                            matrix[x++, y] = currentNumber++;
                        }
                        else
                        {
                            matrix[x, y] = currentNumber++;
                        }
                    }
                    


                }
                else
                {

                    // put the "cursor" below
                    if (currentFillingCycle == 2)
                    {
                        x = x + 1;
                    }
                    


                    // we add currentFillingCycle number of integers to the bottom
                    // and currentFillingCycle -1 number of integers to the left
                    for (int i = 1; i <= currentFillingCycle; i++)
                    {
                        bool lastOneOfRow = i == currentFillingCycle;
                        if (!lastOneOfRow)
                        {
                            matrix[x, y--] = currentNumber++;
                        }
                        else
                        {
                            matrix[x, y] = currentNumber++;
                        }
                        
                    }

                    // put the "cursor" above
                    x = x - 1;
                    
                    
                    

                    for (int j = 1; j <= currentFillingCycle - 1; j++)
                    {
                        bool lastOneOfColumn = j == currentFillingCycle;
                        if (!lastOneOfColumn)
                        {
                            matrix[x--, y] = currentNumber++;
                        }
                        else
                        {
                            matrix[x, y] = currentNumber++;
                        }

                    }
                    


                    //x = x < 0 ? 0 : x;

                }

            }

            PrintMatrix(matrix);

            return matrix;

        }


        #endregion


        #region Chapter 26 Exercise 1
        /*
            1. Write a program, which prints a square spiral matrix beginning from
            the number 1 in the upper right corner and moving clockwise.Examples
            for N=3 and N = 4
        */
        public static int[,] SquareSpiralMatrix(int sideLength)
        {
            int[,] matrix = new int[sideLength, sideLength];


            int originalSideLength = sideLength;


            int[,] FillRightBottomLeftTopExterior(int[,] matrix, int number, int shiftToInterior, int originalSideLength, out int lastNumber)
            {


                if (originalSideLength == 1)
                {
                    matrix[0, 0] = number;
                    lastNumber = number;
                    return matrix;
                }

                if (originalSideLength == 2)
                {
                    matrix[0, 1] = number;
                    matrix[1, 1] = number + 1;
                    matrix[1, 0] = number + 2;
                    matrix[0, 0] = number + 3;
                    lastNumber = number;
                    return matrix;
                }

                int firstIndex = shiftToInterior;
                int lastIndex = (originalSideLength - 1) - shiftToInterior;

                // starting point (top right position)
                int rowIndex = firstIndex;
                int columnIndex = lastIndex;

                // exterior right column (x increases)
                // column index does not change
                int firstRowIndex = rowIndex;
                int lastRowIndex = lastIndex;


                for (int x = firstRowIndex; x <= lastRowIndex; x++)
                {
                    matrix[x, columnIndex] = number++;
                }


                // exterior bottom row (y decreases)
                // row index does not change
                rowIndex = lastIndex;
                int firstColumnIndex = lastIndex - 1;
                int lastColumnIndex = firstIndex;

                for (int y = firstColumnIndex; y >= lastColumnIndex; y--)
                {
                    if (y >= 0)
                    {
                        matrix[rowIndex, y] = number++;
                    }
                }


                // exterior left column (x decreases)
                // column index does not change
                columnIndex = firstIndex;
                firstRowIndex = lastIndex - 1;
                lastRowIndex = firstIndex;

                for (int x = firstRowIndex; x >= lastRowIndex; x--)
                {

                    if (x >= 0)
                    {
                        matrix[x, columnIndex] = number++;
                    }
                }

                // exterior top row (y increases)
                // row index does not change
                rowIndex = shiftToInterior;
                firstColumnIndex = firstIndex + 1;
                lastColumnIndex = lastIndex - 1;

                for (int y = firstColumnIndex; y <= lastColumnIndex; y++)
                {
                    matrix[rowIndex, y] = number++;
                }

                lastNumber = number;
                return matrix;
            }

            int numberOfRings = (originalSideLength == 2 || originalSideLength == 3) ? 2 : originalSideLength - 2;

            int startingNumber = 1;
            for (int i = 0; i < numberOfRings; i++)
            {
                int lastNumber;

                matrix = FillRightBottomLeftTopExterior(matrix, startingNumber, i, originalSideLength, out lastNumber);
                startingNumber = lastNumber;
            }

            PrintMatrix(matrix);

            return matrix;

        }
        #endregion

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
