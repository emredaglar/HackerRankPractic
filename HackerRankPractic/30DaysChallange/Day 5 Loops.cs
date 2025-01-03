﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_5_Loops
    {
        //        Task
        //Given an integer, , print its first  multiples.Each multiple(where ) should be printed on a new line in the form: n x i = result.

        //Example

        //The printout should look like this:

        //3 x 1 = 3
        //3 x 2 = 6
        //3 x 3 = 9
        //3 x 4 = 12
        //3 x 5 = 15
        //3 x 6 = 18
        //3 x 7 = 21
        //3 x 8 = 24
        //3 x 9 = 27
        //3 x 10 = 30
        //Input Format

        //A single integer, .

        //Constraints
        //        Output Format

        //Print  lines of output; each line(where ) contains the  of  in the form:
        //n x i = result.

        //Sample Input

        //2
        //Sample Output

        //2 x 1 = 2
        //2 x 2 = 4
        //2 x 3 = 6
        //2 x 4 = 8
        //2 x 5 = 10
        //2 x 6 = 12
        //2 x 7 = 14
        //2 x 8 = 16
        //2 x 9 = 18
        //2 x 10 = 20


        //My Solution 
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
