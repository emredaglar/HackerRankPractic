using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_14_Scope
    {
        //        The absolute difference between two integers, and, is written as . The maximum absolute difference between two integers in a set of positive integers, , is the largest absolute difference between any two integers in .

        //The Difference class is started for you in the editor.It has a private integer array() for storing non-negative integers, and a public integer() for storing the maximum absolute difference.

        //Task
        //Complete the Difference class by writing the following:

        //A class constructor that takes an array of integers as a parameter and saves it to the instance variable.
        //A computeDifference method that finds the maximum absolute difference between any numbers in  and stores it in the instance variable.
        //        Input Format

        //You are not responsible for reading any input from stdin.The locked Solution class in the editor reads in  lines of input.The first line contains, the size of the elements array.The second line has  space-separated integers that describe the array.
        //        Constraints

        //, where
        //        Output Format
        //        You are not responsible for printing any output; the Solution class will print the value of the instance variable.
        //        Sample Input

        //STDIN Function
        //-----   --------
        //3       __elements[] size N = 3
        //1 2 5   __elements = [1, 2, 5]
        //        Sample Output

        //4
        //Explanation

        //The scope of the array and integer is the entire class instance. The class constructor saves the argument passed to the constructor as the instance variable(where the computeDifference method can access it).

        //To find the maximum difference, computeDifference checks each element in the array and finds the maximum difference between any elements: 


        //The maximum of these differences is , so it saves the value  as the instance variable.The locked stub code in the editor then prints the value stored as , which is .

        //My Solution

        class Difference
        {
            private int[] elements;
            public int maximumDifference;

            // Add your code here
            public Difference(int[] arr)
            {
                elements = arr;
            }
            public void computeDifference()
            {
                var min = int.MaxValue;
                var max = int.MinValue;
                for (var i = 0; i < elements.Length; i++)
                {
                    min = Math.Min(min, elements[i]);
                    max = Math.Max(max, elements[i]);
                }
                maximumDifference = max - min;
            }

        } // End of Difference Class

        class Solution
        {
            static void Main(string[] args)
            {
                Convert.ToInt32(Console.ReadLine());

                int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

                Difference d = new Difference(a);

                d.computeDifference();

                Console.Write(d.maximumDifference);
            }
        }
    }
}
