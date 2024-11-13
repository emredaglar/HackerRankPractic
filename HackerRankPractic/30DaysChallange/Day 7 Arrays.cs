using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_7_Arrays
    {
        //        Task
        //Given an array, , of  integers, print 's elements in reverse order as a single line of space-separated numbers.

        //Example


        //Print 4 3 2 1. Each integer is separated by one space.

        //Input Format

        //The first line contains an integer, (the size of our array).
        //The second line contains  space-separated integers that describe array 's elements.

        //Constraints

        //Constraints

        //, where  is the integer in the array.
        //Output Format

        //Print the elements of array  in reverse order as a single line of space-separated numbers.

        //Sample Input

        //4
        //1 4 3 2
        //Sample Output

        //2 3 4 1

        //My Solution
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            arr.Reverse();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
