using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeExamples.Codility.Exercises
{
    public class Exercise3_2017Contest
    {

        /*
        TennisTournament

        Given the numbers of players and available courts, calculate the maximum number of parallel tennis games.

        You are hosting a tennis tournament. P players, who will take part in the first round of this tournament, are already registered and you have reserved C tennis courts for the matches. Exactly two players play in each game and only one game can be played on each court at any given time. You want to host the maximum possible number of games starting at the same time (in order to finish the first round quickly).

        How many games can be hosted in parallel simultaneously?

        Write a function:

        class Solution { public int solution(int P, int C); }

        that, given the number of players P and the number of reserved courts C, returns the maximum number of games that can be played in parallel.

        Examples:

        1. Given P = 5 players and C = 3 available courts, the function should return 2. Two games can be played simultaneously (for instance, the first and second players can play on the first court, and the third and fourth players on the second court, and the third court will be empty because the fifth player does not have a partner to play with).

        2. Given P = 10 players and C = 3 courts, the function should return 3. At most three games can be hosted in parallel.

        Assume that:

        P and C are integers within the range [1..30,000].
        In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.
        https://app.codility.com/programmers/trainings/3/tennis_tournament/
         */
        public static int TennisTournament(int numberOfPlayers, int numberOfTennisCourts)
        {


            int numberOfPossibleGames = numberOfPlayers / 2;

            return (numberOfTennisCourts >= numberOfPossibleGames) ? numberOfPossibleGames : 0;

        }


        /*
        SocksLaundering

        From drawers containing both clean and dirty socks, choose socks to launder in order to obtain the maximum number of clean pairs of socks.

        Bob is about to go on a trip. But first he needs to take care of his supply of socks. Each sock has its own color. Bob wants to take as many pairs of clean socks as possible (both socks in the pair should be of the same color).

        Socks are divided into two drawers: clean and dirty socks. Bob has time for only one laundry and his washing machine can clean at most K socks. He wants to pick socks for laundering in such a way that after washing he will have a maximal number of clean, same-colored pairs of socks. It is possible that some socks cannot be paired with any other sock, because Bob may have lost some socks over the years.

        Bob has exactly N clean and M dirty socks, which are described in arrays C and D, respectively. The colors of the socks are represented as integers (equal numbers representing identical colors).

        For example, given four clean socks and five dirty socks:



        If Bob's washing machine can clean at most K = 2 socks, then he can take a maximum of three pairs of clean socks. He can wash one red sock and one green sock, numbered 1 and 2 respectively. Then he will have two pairs of red socks and one pair of green socks.

        Write a function:

        class Solution { public int solution(int K, int[] C, int[] D); }

        that, given an integer K (the number of socks that the washing machine can clean), two arrays C and D (containing the color representations of N clean and M dirty socks respectively), returns the maximum number of pairs of socks that Bob can take on the trip.

        For example, given K = 2, C = [1, 2, 1, 1] and D = [1, 4, 3, 2, 4], the function should return 3, as explained above.

        Assume that:

        K is an integer within the range [0..50];
        each element of arrays C and D is an integer within the range [1..50];
        C and D are not empty and each of them contains at most 50 elements.
        In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.
        https://app.codility.com/programmers/trainings/3/socks_laundering/
         */
        public static int SocksLaundering(int K, int[] C, int[] D)
        {
            int[] cleanSocks = C;
            int[] dirtySocks = D;

            int washingMachineCapacity = K;

            HashSet<int> colorsInCleanDrawer = new HashSet<int>(cleanSocks);
            HashSet<int> colorsInDirtyDrawer = new HashSet<int>(dirtySocks);

            List<int> pairsInCleanDrawer = new List<int>();
            List<int> singlesInCleanDrawer = new List<int>();

            int maximumNumberOfPairs = 0;

            int numberOfDirtySocksWashed = 0;

            foreach (int color in colorsInCleanDrawer)
            {
                // add pairs from clean drawer to the maximum number of pairs
                int numberOfSocksOfColor = cleanSocks.Count(c => c == color);
                int pairsOfColor = numberOfSocksOfColor / 2;
                maximumNumberOfPairs += pairsOfColor;

                // if there is an odd sock, search for a pair in dirty drawer and wash it if possible
                if (numberOfSocksOfColor % 2 == 1 && numberOfDirtySocksWashed < washingMachineCapacity)
                {
                    bool thereIsADirtySockOfSameColor = colorsInDirtyDrawer.Contains(color);

                    if (thereIsADirtySockOfSameColor )
                    {
                        numberOfDirtySocksWashed++;
                        maximumNumberOfPairs++;
                    }
                }
            }

            return maximumNumberOfPairs;
        }


        /*
        ArrayRecovery

        Recover a broken array using partial information in another array.

        Bob once had an array A with N elements. Each element was a positive integer not exceeding M.

        Bob wrote a program to find an array B, defined as follows.
        
        For every index J, let's find the biggest index K such that K < J and A[K] < A[J].
        
        Then set B[J] = A[K]. If there is no such index K, then set B[J] = 0.
        
        Intuitively, the J-th element of B contains the last value smaller than A[J] that appears before it, or 0 if there is no such element.

        For example, let A = [2, 5, 3, 7, 9, 6]. Then B = [0, 2, 2, 3, 7, 3]. For instance, B[5] = 3, as A[5] is 6 and the last value before A[5] smaller than 6 is 3.

        Bob computed an array B and then mistakenly deleted A. He now intends to find every valid array A from which his program would produce B. Count the number of such arrays A. Since the answer could be very big, return it modulo 109+7.

        Write a function:

        class Solution { public int solution(int[] B, int M); }

        that, given an integer M and an array B with N integers, returns the remainder from the division by 109+7 of the number of valid arrays A from which Bob would get B. You can assume that there is at least one such array.

        For example, given: M = 4, B = [0, 2, 2] the function should return 3. The possible removed arrays A were [2, 3, 3], [2, 4, 3] and [2, 4, 4].

        For the following data: M = 10, B = [0, 3, 5, 6] the function should return 4, as the possible arrays A were [3, 5, 6, 7], [3, 5, 6, 8], [3, 5, 6, 9] and [3, 5, 6, 10].

        For the following data: M = 105, B = [0, 0] there are 5000050000 possible arrays (the first element in array A can be anything in the range 1..105 and the second element can be either equal or smaller), so the function should return 49965 (as we are taking modulo 109+7).

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..100,000];
        M is an integer within the range [1..1,000,000,000];
        each element of array B is an integer within the range [0..M];
        there exists at least one valid array A from which Bob would get array B.
        https://app.codility.com/programmers/trainings/3/array_recovery/
         */
        public static int ArrayRecovery(int[] B, int M)
        {
            return 0;
        }


        /*
        DiamondsCount

        Given points on a plane, count the number of sets of four points that form regular diamonds.

        A diamond is a quadrilateral whose four sides all have the same length and whose diagonals are parallel to the coordinate axes.

        You are given N distinct points on a plane. Count the number of different diamonds that can be constructed using these points as vertices (two diamonds are different if their sets of vertices are different). Do not count diamonds whose area is empty.

        Write a function:

        class Solution { public int solution(int[] X, int[] Y); }

        that, given two arrays X and Y, each containing N integers, representing N points (where X[K], Y[K] are the coordinates of the K-th point), returns the number of diamonds on the plane.

        For example, for N = 7 points whose coordinates are specified in arrays X = [1, 1, 2, 2, 2, 3, 3] and Y = [3, 4, 1, 3, 5, 3, 4], the function should return 2, since we can find two diamonds as shown in the picture below:



        Given arrays: X = [1, 2, 3, 3, 2, 1], Y = [1, 1, 1, 2, 2, 2], the function should return 0, since there are no diamonds on the plane:



        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [4..1,500];
        each element of arrays X and Y is an integer within the range [0..N-1];
        given N points are pairwise distinct.

        https://app.codility.com/programmers/trainings/3/diamonds_count/
        */
        public static int DiamondsCount(int[] X, int[] Y)
        {
            List<double> declives = new List<double>();

            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < Y.Length; j++)
                {
                    double denominator = (X[j] - X[i]);
                    if (denominator != 0)
                    {
                        double declive = (double)(Y[j] - Y[i]) / denominator;

                        if (declive != 0 && declive != 1 && declive != -1)
                        {
                            declives.Add(declive);
                        }
                        
                    }
                    

                }

            }

            List<double> distinctDeclives = declives.Distinct().ToList();

            int numberOfDiamonds = 0;

            foreach (var item in distinctDeclives)
            {
                if (declives.Count(d => d == item) == 2 && declives.Count(d => d == -item) == 2 )
                {
                    numberOfDiamonds++;
                }
                
            }

            return numberOfDiamonds / 2;
        }


    }
}
