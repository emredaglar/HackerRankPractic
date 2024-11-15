using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace HackerRankPractic._30DaysChallange
{
	internal class Day_9_Recursion_3
	{
		//		Recursive Method for Calculating Factorial

		//Function Description
		//Complete the factorial function in the editor below.Be sure to use recursion.
		//		factorial has the following paramter:

		//int n: an integer
		//Returns
		//		int: the factorial of
		//Note: If you fail to use recursion or fail to name your recursive function factorial or Factorial, you will get a score of.

		//Input Format

		//A single integer,  (the argument to pass to factorial).

		//Constraints

		//Your submission must contain a recursive function named factorial.
		//Sample Input

		//3
		//Sample Output

		//6
		//Explanation

		//Consider the following steps.After the recursive calls from step 1 to 3, results are accumulated from step 3 to 1.

		//My Solution
		public static int factorial(int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			return n * factorial(n - 1);

		}

	}

	class Solution
	{
		public static void Main(string[] args)
		{
			TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

			int n = Convert.ToInt32(Console.ReadLine().Trim());

			int result = Result.factorial(n);

			textWriter.WriteLine(result);

			textWriter.Flush();
			textWriter.Close();
		}
	}
}
}
