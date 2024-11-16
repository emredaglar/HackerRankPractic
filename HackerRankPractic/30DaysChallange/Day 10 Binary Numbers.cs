using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_10_Binary_Numbers
    {
        //        Task
        //Given a base- integer, , convert it to binary(base-). Then find and print the base- integer denoting the maximum number of consecutive 's in 's binary representation.When working with different bases, it is common to show the base as a subscript.

        //Example

        //The binary representation of  is . In base , there are  and consecutive ones in two groups. Print the maximum, .

        //Input Format

        //A single integer, .

        //Constraints

        //Output Format

        //Print a single base- integer that denotes the maximum number of consecutive 's in the binary representation of .

        //Sample Input 1

        //5
        //Sample Output 1

        //1
        //Sample Input 2

        //13
        //Sample Output 2

        //2
        //Explanation

        //Sample Case 1:
        //The binary representation of  is , so the maximum number of consecutive 's is .

        //Sample Case 2:
        //The binary representation of  is , so the maximum number of consecutive 's is .

        //My Solution
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            var reminder = 0;
            var count = 0;
            var max = 0;

            while (n > 0)
            {

                reminder = n % 2;
                n /= 2;

                if (reminder == 1)
                {
                    count++;
                    max = Math.Max(max, count);
                }
                else
                {
                    count = 0;
                }

            }
            Console.WriteLine(max);

        }
    }
}
