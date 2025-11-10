using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeExamples.Codility.Exercises
{
    public class Exercise1_2015Contest
    {
        /*
        LongestPassword

        Given a string containing words, find the longest word that satisfies specific conditions.

        You would like to set a password for a bank account. However, there are three restrictions on the format of the password:

        it has to contain only alphanumerical characters (a−z, A−Z, 0−9);
        there should be an even number of letters;
        there should be an odd number of digits.
        You are given a string S consisting of N characters. String S can be divided into words by splitting it at, and removing, the spaces. The goal is to choose the longest word that is a valid password. You can assume that if there are K spaces in string S then there are exactly K + 1 words.

        For example, given "test 5 a0A pass007 ?xy1", there are five words and three of them are valid passwords: "5", "a0A" and "pass007". Thus the longest password is "pass007" and its length is 7. Note that neither "test" nor "?xy1" is a valid password, because "?" is not an alphanumerical character and "test" contains an even number of digits (zero).

        Write a function:

        class Solution { public int solution(string S); }

        that, given a non-empty string S consisting of N characters, returns the length of the longest word from the string that is a valid password. If there is no such word, your function should return −1.

        For example, given S = "test 5 a0A pass007 ?xy1", your function should return 7, as explained above.

        Assume that:

        N is an integer within the range [1..200];
        string S consists only of printable ASCII characters and spaces.
        In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.

        https://app.codility.com/programmers/trainings/1/longest_password/
         */
        public static void LongestPassword()
        {
            Console.WriteLine("LongestPassword");
        }

        /*
        FloodDepth

        Find the maximum depth of water in mountains after a huge rainfall.

        You are helping a geologist friend investigate an area with mountain lakes. A recent heavy rainfall has flooded these lakes and their water levels have reached the highest possible point. Your friend is interested to know the maximum depth in the deepest part of these lakes.

        We simplify the problem in 2-D dimensions. The whole landscape can be divided into small blocks and described by an array A of length N. Each element of A is the altitude of the rock floor of a block (i.e. the height of this block when there is no water at all). After the rainfall, all the low-lying areas (i.e. blocks that have higher blocks on both sides) are holding as much water as possible. You would like to know the maximum depth of water after this entire area is flooded. You can assume that the altitude outside this area is zero and the outside area can accommodate infinite amount of water.

        For example, consider array A such that:

            A[0] = 1
            A[1] = 3
            A[2] = 2
            A[3] = 1
            A[4] = 2
            A[5] = 1
            A[6] = 5
            A[7] = 3
            A[8] = 3
            A[9] = 4
            A[10] = 2
        The following picture illustrates the landscape after it has flooded:



        The gray area is the rock floor described by the array A above and the blue area with dashed lines represents the water filling the low-lying areas with maximum possible volume. Thus, blocks 3 and 5 have a water depth of 2 while blocks 2, 4, 7 and 8 have a water depth of 1. Therefore, the maximum water depth of this area is 2.

        Write a function:

        class Solution { public int solution(int[] A); }

        that, given a non-empty array A consisting of N integers, returns the maximum depth of water.

        Given array A shown above, the function should return 2, as explained above.

        For the following array:

            A[0] = 5
            A[1] = 8
        the function should return 0, because this landscape cannot hold any water.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [1..100,000,000].

        https://app.codility.com/programmers/trainings/1/flood_depth/
         */
        public static void FloodDepth()
        {
            
        }

        /*
        SlalomSkiing

        Given a sequence, find the longest subsequence that can be decomposed into at most three monotonic parts.

        You are a skier participating in a giant slalom. The slalom track is located on a ski slope, goes downhill and is fenced by barriers on both sides. The barriers are perpendicular to the starting line located at the top of the slope. There are N slalom gates on the track. Each gate is placed at a distinct distance from the starting line and from the barrier on the right-hand side (looking downhill).

        You start from any place on the starting line, ski down the track passing as many gates as possible, and finish the slalom at the bottom of the slope. Passing a gate means skiing through the position of the gate.

        You can ski downhill in either of two directions: to the left or to the right. When you ski to the left, you pass gates of increasing distances from the right barrier, and when you ski to the right, you pass gates of decreasing distances from the right barrier. You want to ski to the left at the beginning.

        Unfortunately, changing direction (left to right or vice versa) is exhausting, so you have decided to change direction at most two times during your ride. Because of this, you have allowed yourself to miss some of the gates on the way down the slope. You would like to know the maximum number of gates that you can pass with at most two changes of direction.

        The arrangement of the gates is given as an array A consisting of N integers, whose elements specify the positions of the gates: gate K (for 0 ≤ K < N) is at a distance of K+1 from the starting line, and at a distance of A[K] from the right barrier.

        For example, consider array A such that:

          A[0] = 15
          A[1] = 13
          A[2] = 5
          A[3] = 7
          A[4] = 4
          A[5] = 10
          A[6] = 12
          A[7] = 8
          A[8] = 2
          A[9] = 11
          A[10] = 6
          A[11] = 9
          A[12] = 3


        The picture above illustrates the example track with N = 13 gates and a course that passes eight gates. After starting, you ski to the left (from your own perspective). You pass gates 2, 3, 5, 6 and then change direction to the right. After that you pass gates 7, 8 and then change direction to the left. Finally, you pass gates 10, 11 and finish the slalom. There is no possible way of passing more gates using at most two changes of direction.

        Write a function:

        class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers, describing the positions of the gates on the track, returns the maximum number of gates that you can pass during one ski run.

        For example, given the above data, the function should return 8, as explained above.

        For the following array A consisting of N = 2 elements:

          A[0] = 1
          A[1] = 5
        the function should return 2.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [1..1,000,000,000];
        the elements of A are all distinct.

        https://app.codility.com/programmers/trainings/1/slalom_skiing/
         */
        public static void SlalomSkiing()
        {
            
        }
    }
}
