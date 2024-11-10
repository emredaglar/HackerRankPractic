using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace HackerRankPractic._30DaysChallange
{
    internal class Day_4_ClassInstance
    {
        //        Task
        //        Write a Person class with an instance variable, , and a constructor that takes an integer, , as a parameter.The constructor must assign to  after confirming the argument passed as  is not negative; if a negative argument is passed as , the constructor should set  to and print Age is not valid, setting age to 0.. In addition, you must write the following instance methods:

        //yearPasses() should increase the instance variable by.
        //amIOld() should perform the following conditional actions:
        //If , print You are young..
        //If  and , print You are a teenager..
        //Otherwise, print You are old..
        //To help you learn by example and complete this challenge, much of the code is provided for you, but you'll be writing everything in the future. The code that creates each instance of your Person class is in the main method. Don't worry if you don't understand it all quite yet!

        //Note: Do not remove or alter the stub code in the editor.

        //Input Format

        //Input is handled for you by the stub code in the editor.

        //The first line contains an integer, (the number of test cases), and the  subsequent lines each contain an integer denoting the  of a Person instance.

        //Constraints

        //Output Format

        //Complete the method definitions provided in the editor so they meet the specifications outlined above; the code to test your work is already in the editor.If your methods are implemented correctly, each test case will print  or lines (depending on whether or not a valid  was passed to the constructor).

        //Sample Input

        //4
        //-1
        //10
        //16
        //18
        //Sample Output

        //Age is not valid, setting age to 0.
        //You are young.
        //        You are young.
        //        You are young.
        //        You are a teenager.

        //You are a teenager.
        //You are old.

        //You are old.
        //You are old.
        //Explanation

        //Test Case 0: 
        //Because , our code must set  to and print the "Age is not valid..." message followed by the young message. Three years pass and, so we print the young message again.

        //Test Case 1: 
        //Because , our code should print that the person is young.Three years pass and, so we print that the person is now a teenager.
        //        Test Case 2: 
        //Because , our code should print that the person is a teenager. Three years pass and, so we print that the person is old.
        //        Test Case 3: 
        //Because , our code should print that the person is old.Three years pass and the person is still old at , so we print the old message again.

        //The extra line at the end of the output is supposed to be there and is trimmed before being compared against the test case's expected output. If you're failing this challenge, check your logic and review your print statements for spelling errors.

        //My Solution
        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge >= 0)
            {
                age = initialAge;
            }
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.. ");
            }
        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age = age + 1;
        }

        static void Main(String[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }
}
