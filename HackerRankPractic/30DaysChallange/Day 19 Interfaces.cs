using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_19_Interfaces
    {
        //        Task
        //The AdvancedArithmetic interface and the method declaration for the abstract divisorSum(n) method are provided for you in the editor below.

        //Complete the implementation of Calculator class, which implements the AdvancedArithmetic interface. The implementation for the divisorSum(n) method must return the sum of all divisors of.

        //Example

        //The divisors of are . Their sum is .


        //The divisors of are  and their sum is .

        //Input Format

        //A single line with an integer, .

        //Constraints
        //        Output Format

        //You are not responsible for printing anything to stdout. The locked template code in the editor below will call your code and print the necessary output.

        //Sample Input

        //6
        //Sample Output

        //I implemented: AdvancedArithmetic
        //12
        //Explanation

        //The integer  is evenly divisible by , , , and.Our divisorSum method should return the sum of these numbers, which is . The Solution class then prints on the first line, followed by the sum returned by divisorSum(which is ) on the second line.

        //My Solution
        public interface AdvancedArithmetic
        {
            int divisorSum(int n);
        }

        public class Calculator : AdvancedArithmetic
        {
            public int divisorSum(int n)
            {
                var sum = 0;

                for (var i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                return sum;

            }
        }

        class Solution
        {
            static void Main(string[] args)
            {
                int n = Int32.Parse(Console.ReadLine());
                AdvancedArithmetic myCalculator = new Calculator();
                int sum = myCalculator.divisorSum(n);
                Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
            }
        }

    }
}
