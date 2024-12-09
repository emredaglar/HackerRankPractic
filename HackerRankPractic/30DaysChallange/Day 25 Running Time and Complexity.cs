using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace HackerRankPractic._30DaysChallange
{
    internal class Day_25_Running_Time_and_Complexity
    {
        //        Task
        //A prime is a natural number greater than that has no positive divisors other than  and itself.Given a number, , determine and print whether it is  or.

        //Note: If possible, try to come up with a primality algorithm, or see what sort of optimizations you come up with for an algorithm. Be sure to check out the Editorial after submitting your code.

        //Input Format

        //The first line contains an integer, , the number of test cases.
        //Each of the subsequent lines contains an integer, , to be tested for primality.

        //Constraints

        //Output Format

        //For each test case, print whether  is  or on a new line.

        //Sample Input

        //3
        //12
        //5
        //7
        //Sample Output

        //Not prime
        //Prime
        //Prime
        //Explanation

        //Test Case 0: .
        // is divisible by numbers other than and itself(i.e.: , , , ), so we print on a new line.

        //Test Case 1: .
        // is only divisible  and itself, so we print  on a new line.

        //Test Case 2: .
        // is only divisible  and itself, so we print  on a new line.
        //My Solution
        class Solution
        {
            static void Main(String[] args)
            {
                /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
                int n = int.Parse(Console.ReadLine());

                for (var i = 0; i < n; i++)
                {
                    int curr = int.Parse(Console.ReadLine());
                    Console.WriteLine(IsPrime(curr) : "Prime" : "Not prime");
                }
            }
            private static bool IsPrime(int n)
            {
                if (n < 2) return false;
                if (n == 2) return true;
                if (n % 2 == 0) return false;

                int root = (int)Math.Floor(Math.Sqrt(n));

                for (var i = 3; i <= root; i += 2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
        }

    }
}
