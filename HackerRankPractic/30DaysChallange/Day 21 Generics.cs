using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace HackerRankPractic._30DaysChallange
{
    internal class Day_21_Generics
    {
        //        Task
        //        Write a single generic function named printArray; this function must take an array of generic elements as a parameter(the exception to this is C++, which takes a vector). The locked Solution class in your editor tests your function.
        //        Note: You must use generics to solve this challenge.Do not write overloaded functions.
        //        Input Format

        //The locked Solution class in your editor will pass different types of arrays to your printArray function.
        //        Constraints

        //You must have exactly  function named printArray.
        //Output Format

        //Your printArray function should print each element of its generic array parameter on a new line.

        //My Solution
        class Printer
        {

            /**
            *    Name: PrintArray
            *    Print each element of the generic array on a new line. Do not return anything.
            *    @param A generic array
            **/
            // Write your code here
            public static void PrintArray<T>(T[] arr)
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }


            static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] intArray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    intArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                n = Convert.ToInt32(Console.ReadLine());
                string[] stringArray = new string[n];
                for (int i = 0; i < n; i++)
                {
                    stringArray[i] = Console.ReadLine();
                }

                PrintArray<Int32>(intArray);
                PrintArray<string>(stringArray);
            }
        }
    }
}
