using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_16_Exceptions___String_to_Integer
    {
        //        Task
        //        Read a string, , and print its integer value; if  cannot be converted to an integer, print Bad String.
        //        Note: You must use the String-to-Integer and exception handling constructs built into your submission language. If you attempt to use loops/conditional statements, you will get a  score.

        //Input Format

        //A single string, .

        //Constraints

        //, where  is the length of string .
        // is composed of either lowercase letters () or decimal digits ().
        //Output Format

        //Print the parsed integer value of, or Bad String if  cannot be converted to an integer.

        //Sample Input 0

        //3
        //Sample Output 0

        //3
        //Sample Input 1

        //za
        //Sample Output 1

        //Bad String
        //Explanation

        //Sample Case contains an integer, so it should not raise an exception when we attempt to convert it to an integer. Thus, we print the.
        //Sample Case  does not contain any integers, so an attempt to convert it to an integer will raise an exception.Thus, our exception handler prints Bad String.


        //My Solution
        public static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                var i = int.Parse(S);
                Console.WriteLine(i);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
        }
}
