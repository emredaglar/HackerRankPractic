using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace HackerRankPractic._30DaysChallange
{
    internal class Day_6__Let_s_Review
    {
        //        Task
        //Given a string, , of length  that is indexed from  to , print its even-indexed and odd-indexed characters as  space-separated strings on a single line(see the Sample below for more detail).

        //Note:  is considered to be an even index.

        //Example


        //Print abc def

        //Input Format

        //The first line contains an integer, (the number of test cases).
        //Each line  of the  subsequent lines contain a string, .

        //Constraints

        //Output Format

        //For each String(where ), print 's even-indexed characters, followed by a space, followed by 's odd-indexed characters.
        //        Sample Input

        //2
        //Hacker
        //        Rank
        //Sample Output

        //Hce akr
        //Rn ak
        //Explanation

        //Test Case 0: 






        //The even indices are, , and , and the odd indices are , , and.We then print a single line of space-separated strings; the first string contains the ordered characters from 's even indices (), and the second string contains the ordered characters from 's odd indices().

        //Test Case 1: 




        //The even indices are  and , and the odd indices are and.We then print a single line of  space-separated strings; the first string contains the ordered characters from 's even indices (), and the second string contains the ordered characters from 's odd indices().

        //My Solution
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine(); 
                string evenIndexedChars = "";
                string oddIndexedChars = "";

                for (int j = 0; j < input.Length; j++)
                {
                    if (j % 2 == 0) 
                        evenIndexedChars += input[j];
                    else 
                        oddIndexedChars += input[j];
                }

                Console.WriteLine($"{evenIndexedChars} {oddIndexedChars}");
            }
        }
    }
}
