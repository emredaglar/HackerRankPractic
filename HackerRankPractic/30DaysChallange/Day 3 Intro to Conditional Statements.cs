using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_3_Intro_to_Conditional_Statements
    {
        //        Objective
        //In this challenge, we learn about conditional statements.Check out the Tutorial tab for learning materials and an instructional video.

        //Task
        //Given an integer, , perform the following conditional actions:

        //If  is odd, print Weird
        //If  is even and in the inclusive range of  to , print Not Weird
        //If  is even and in the inclusive range of  to , print Weird
        //If  is even and greater than, print Not Weird
        //Complete the stub code provided in your editor to print whether or not  is weird.

        //Input Format

        //A single line containing a positive integer, .

        //Constraints

        //Output Format

        //Print Weird if the number is weird; otherwise, print Not Weird.

        //Sample Input 0

        //3
        //Sample Output 0

        //Weird
        //Sample Input 1

        //24
        //Sample Output 1

        //Not Weird
        //Explanation

        //Sample Case 0: 
        // is odd and odd numbers are weird, so we print Weird.

        //Sample Case 1: 
        // and  is even, so it is not weird.Thus, we print Not Weird.

        //My Solution
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            string result = (N % 2 != 0 || (N >= 6 && N <= 20)) ? "Weird" : "Not Weird";

            Console.WriteLine(result);

        }
    }
}
