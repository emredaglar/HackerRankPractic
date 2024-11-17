using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_11_2D_Arrays
    {
        //        Context
        //Given a  2D Array, :

        //1 1 1 0 0 0
        //0 1 0 0 0 0
        //1 1 1 0 0 0
        //0 0 0 0 0 0
        //0 0 0 0 0 0
        //0 0 0 0 0 0
        //We define an hourglass in  to be a subset of values with indices falling in this pattern in 's graphical representation:

        //a b c
        //  d
        //e f g
        //There are hourglasses in , and an hourglass sum is the sum of an hourglass' values.

        //Task
        //Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.
        //        Example

        //In the array shown above, the maximum hourglass sum is  for the hourglass in the top left corner.

        //Input Format

        //There are lines of input, where each line contains  space-separated integers that describe the 2D Array.

        //Constraints

        //Output Format

        //Print the maximum hourglass sum in .

        //Sample Input

        //1 1 1 0 0 0
        //0 1 0 0 0 0
        //1 1 1 0 0 0
        //0 0 2 4 4 0
        //0 0 0 2 0 0
        //0 0 1 2 4 0
        //Sample Output

        //19
        //Explanation

        // contains the following hourglasses:

        //1 1 1   1 1 0   1 0 0   0 0 0
        //  1       0       0       0
        //1 1 1   1 1 0   1 0 0   0 0 0

        //0 1 0   1 0 0   0 0 0   0 0 0
        //  1       1       0       0
        //0 0 2   0 2 4   2 4 4   4 4 0

        //1 1 1   1 1 0   1 0 0   0 0 0
        //  0       2       4       4
        //0 0 0   0 0 2   0 2 0   2 0 0

        //0 0 2   0 2 4   2 4 4   4 4 0
        //  0       0       2       0
        //0 0 1   0 1 2   1 2 4   2 4 0
        //The hourglass with the maximum sum () is:

        //2 4 4
        //  2
        //1 2 4

        //My Solution
        public static void Main(string[] args)
        {

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            MaxHourGlass(arr);
        }

        private static void MaxHourGlass(List<List<int>> arr)
        {

            var curr = 0;
            var max = int.MinValue;

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    curr = arr[i][j] + arr[i][i + 1] + arr[i][j + 2] +
                                    arr[i + 1][j + 1] +
                         arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    max = Math.Max(max, curr);
                }
            }
            Console.WriteLine(max);
        }
    }
}
