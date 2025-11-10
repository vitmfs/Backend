using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeExamples.Codility.Exercises
{
    public class Exercise2_2016Contest
    {
        /*
        RectangleBuilderGreaterArea

        Count the distinct rectangle sizes, of area greater than or equal to X, that can be built out of a given set of segments.

        Halfling Woolly Proudhoof is an eminent sheep herder. He wants to build a pen (enclosure) for his new flock of sheep. The pen will be rectangular and built from exactly four pieces of fence (so, the pieces of fence forming the opposite sides of the pen must be of equal length). Woolly can choose these pieces out of N pieces of fence that are stored in his barn. To hold the entire flock, the area of the pen must be greater than or equal to a given threshold X.

        Woolly is interested in the number of different ways in which he can build a pen. Pens are considered different if the sets of lengths of their sides are different. For example, a pen of size 1×4 is different from a pen of size 2×2 (although both have an area of 4), but pens of sizes 1×2 and 2×1 are considered the same.

        Write a function:

        class Solution { public int solution(int[] A, int X); }

        that, given an array A of N integers (containing the lengths of the available pieces of fence) and an integer X, returns the number of different ways of building a rectangular pen satisfying the above conditions. The function should return −1 if the result exceeds 1,000,000,000.

        For example, given X = 5 and the following array A:

          A[0] = 1
          A[1] = 2
          A[2] = 5
          A[3] = 1
          A[4] = 1
          A[5] = 2
          A[6] = 3
          A[7] = 5
          A[8] = 1


        the function should return 2. The figure above shows available pieces of fence (on the left) and possible to build pens (on the right). The pens are of sizes 1x5 and 2x5. Pens of sizes 1×1 and 1×2 can be built, but are too small in area. It is not possible to build pens of sizes 2×3 or 3×5, as there is only one piece of fence of length 3.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [0..100,000];
        X is an integer within the range [1..1,000,000,000];
        each element of array A is an integer within the range [1..1,000,000,000].

        https://app.codility.com/programmers/trainings/2/rectangle_builder_greater_area/
        */
        public static void RectangleBuilderGreaterArea()
        {
            
        }


        /*
        DwarfsRafting

        Find out how many dwarfs can fit on a raft such that it's balanced when crossing a river.

        A company of dwarfs is travelling across the New Zealand. On reaching the Clutha River the dwarfs need to get across, but recent storms have washed away the bridge. Luckily, a small ferry, in the form of a square raft, is operating.

        The raft is square and has N rows of seats, numbered from 1 to N. Each row contains N seats, labeled with consecutive letters (A, B, C, etc.). Each seat is identified by a string composed of its row number followed by its column number; for example, "9C" denotes the third seat in the 9th row.

        The raft has already been loaded with barrels in some seat positions, and other seats are already occupied by dwarfs. Our company of dwarfs may only take the remaining unoccupied seats. The ferryman wants to accommodate as many dwarfs as possible, but the raft needs to be stable when making the crossing. That is, the following conditions must be satisfied:

        the front and back halves of the raft (in terms of the rows of seats) must each contain the same number of dwarfs;
        similarly, the left and right sides of the raft (in terms of the columns of seats) must each contain the same number of dwarfs.
        You do not have to worry about balancing the barrels; you can assume that their weights are negligible.

        For example, a raft of size N = 4 is shown in the following illustration:



        Barrels are marked as brown squares, and seats that are already occupied by dwarfs are labeled d.

        The positions of the barrels are given in string S. The occupied seat numbers are given in string T. The contents of the strings are separated by single spaces and may appear in any order. For example, in the diagram above, S = "1B 1C 4B 1D 2A" and T = "3B 2D".

        In this example, the ferryman can accommodate at most six more dwarfs, as indicated by the green squares in the following diagram:



        The raft is then balanced: both left and right halves have the same number of dwarfs (four), and both front and back halves have the same number of dwarfs (also four).

        Write a function:

        class Solution { public int solution(int N, String S, String T); }

        that, given the size of the raft N and two strings S, T that describes the positions of barrels and occupied seats, respectively, returns the maximum number of dwarfs that can fit on the raft. If it is not possible to balance the raft with dwarfs, your function should return -1.

        For instance, given N = 4, S = "1B 1C 4B 1D 2A" and T = "3B 2D", your function should return 6, as explained above.

        Assume that:

        N is an even integer within the range [2..26];
        strings S, T consist of valid seat numbers, separated with spaces;
        each seat number can appear no more than once in the strings;
        no seat number can appear in both S and T simultaneously.
        In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.

        https://app.codility.com/programmers/trainings/2/dwarfs_rafting/
         */
        public static void DwarfsRafting()
        {
            
        }


        /*
        HilbertMaze

        Find the shortest path between two fields in a Hilbert maze.

        A halfling is searching for treasure hidden in a maze in the dwarfs' mine. He has a map of the maze and would like to find the shortest path to the treasure.

        The maze has a specific shape. It is placed on a square grid with M2 cells, where M = 2N+1+1 for some given size N. Each cell has coordinates (x, y), where 0 ≤ x, y < M, and can either be empty or contain a rock.

        The mazes of sizes N = 1 and N = 2 are presented in the pictures below:



        A maze of size N is constructed recursively from the layout of the maze of size N−1 (like the Hilbert curve). It contains four mazes of size N−1, each maze in one quarter. The maze in the bottom-left quarter is rotated by 90 degrees clockwise and the maze in the bottom-right quarter is rotated by 90 degrees counter-clockwise. The mazes in the top quarters are not rotated. There are three additional rocks (squares marked in green in the picture below) in the areas where the mazes intersect. The construction of the maze of size N = 3 is shown below:



        The halfling would like to reach the treasure in the smallest number of steps possible. At each step, he can move to any one of the four adjacent cells (north, south, west, east) that does not contain a rock and is not outside of the grid.

        For example, given N = 1, the halfling needs 8 steps to move from cell (2, 1) to cell (3, 4):



        Write a function:

        class Solution { public int solution(int N, int A, int B, int C, int D); }

        that, given the size of the maze N, coordinates of the halfling (A, B) and coordinates of the treasure (C, D), returns the minimum number of steps required for the halfling to reach the treasure.

        Examples
        Given N = 1, A = 2, B = 1, C = 3 and D = 4 the function should return 8, as shown above.

        Given N = 2, A = 2, B = 5, C = 6 and D = 6 the function should return 7:



        Given N = 3, A = 6, B = 6, C = 10 and D = 13 the function should return 39:



        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..25];
        A, B, C, D are integers within the range [0..2N+1];
        cells (A, B) and (C, D) do not contain rocks;
        the result will be an integer smaller than 2,147,483,647.

        https://app.codility.com/programmers/trainings/2/hilbert_maze/
         */
        public static void HilbertMaze()
        {
            
        }


        /*
        TreeProduct

        Remove at most two edges from a tree graph to maximize the product of the components' sizes.

        Elves in the forest of Glandishar are preparing for an Orc invasion. They have a network of N + 1 guard posts located on the open platforms in the treetops. The posts are numbered from 0 to N and are connected by N bridges, so that one can get from any one guard post to any other guard post in a unique way. In other words, guard posts and bridges form a tree graph.

        The Elves are afraid that if the Orcs manage to get hold of one of the guard posts, then they will have easy access to all the other guard posts. Therefore, the Elves have decided to destroy at most two bridges and split the guard posts into at most three separate areas, so that the guards can move within each area but it's not possible to move between the areas.

        In each area there will be one guard who will move from guard post to guard post during the night. If the Orcs attack, the guards will raise an alarm. However, if the Orcs manage to guess the guard post in which the guards are currently located, they may manage to take out the guards without raising the alarm. The Elves want to avoid the situation that all guard posts fail this way, by maximizing:

        X * Y * Z, if the guard posts have been divided into three areas consisting of X, Y and Z guard posts, respectively;
        X * Y, if the guard posts have been divided into two areas consisting of X and Y posts, respectively;
        N + 1, if the guard posts haven't been divided;
        depending on which option gives the largest result.

        You are given a map of the network in the form of two arrays A, B of length N. For each K (0 ≤ K < N) there is a bridge between posts A[K] and B[K].

        Write a function:

        class Solution { public String solution(int[] A, int[] B); }

        that, given two arrays A and B of N integers, returns the largest possible result. Since the result can be large, you should return it as a string.

        For example, given the following arrays:

          A[0] = 0    B[0] = 1
          A[1] = 1    B[1] = 2
          A[2] = 1    B[2] = 3
          A[3] = 3    B[3] = 4
          A[4] = 3    B[4] = 5
          A[5] = 6    B[5] = 3
          A[6] = 7    B[6] = 5


        the function should return "18" since the Elves can destroy bridges 1−3 and 3−5 (marked as dashed lines in the image above). The created areas consist of 3, 3 and 2 guard posts.

        Therefore, the result is 3 * 3 * 2 = 18. It is not possible to obtain a better result.

        Given the following arrays:

          A[0] = 0    B[0] = 1
          A[1] = 1    B[1] = 2
        the function should return "3" (it is optimal not to destroy any bridge).

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..50,000];
        each element of arrays A and B is an integer within the range [0..N];
        distance from guard post 0 to any other post is not greater than 900 bridges.

        https://app.codility.com/programmers/trainings/2/tree_product/
         */
        public static void TreeProduct()
        {
            
        }
    }


}
