using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_12_Inheritance
    {
        //        Task
        //You are given two classes, Person and Student, where Person is the base class and Student is the derived class. Completed code for Person and a declaration for Student are provided for you in the editor.Observe that Student inherits all the properties of Person.

        //Complete the Student class by writing the following:

        //A Student class constructor, which has  parameters:
        //A string, .
        //A string, .
        //An integer, .
        //An integer array(or vector) of test scores, .
        //A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:
        //Grading.png
        //        Input Format

        //The locked stub code in the editor reads the input and calls the Student class constructor with the necessary arguments.It also calls the calculate method which takes no arguments.

        //The first line contains, , and , separated by a space. The second line contains the number of test scores.The third line of space-separated integers describes.

        //Constraints

        //Output Format

        //Output is handled by the locked stub code. Your output will be correct if your Student class constructor and calculate() method are properly implemented.

        //Sample Input

        //Heraldo Memelli 8135627
        //2
        //100 80
        //Sample Output

        // Name: Memelli, Heraldo
        // ID: 8135627
        // Grade: O
        //Explanation

        //This student had scores to average:  and.The student's average grade is . An average grade of  corresponds to the letter grade , so the calculate() method should return the character'O'.



        //My Solution

        class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }

        class Student : Person
        {
            private int[] testScores;

            /*	
            *   Class Constructor
            *   
            *   Parameters: 
            *   firstName - A string denoting the Person's first name.
            *   lastName - A string denoting the Person's last name.
            *   id - An integer denoting the Person's ID number.
            *   scores - An array of integers denoting the Person's test scores.
            */
            // Write your constructor here

            public Student(string fn, string ln, int i, int[] sc)
            {

                firstName = fn;
                lastName = ln;
                id = i;
                testScores = sc;
            }
            /*	
            *   Method Name: Calculate
            *   Return: A character denoting the grade.
            */
            // Write your method here
            public char Calculate()
            {
                var sum = 0;

                foreach (var score in testScores)
                {
                    sum += score;
                }
                var avarage = sum / testScores.Length;
                if (avarage >= 90)
                {
                    return 'O';
                }
                else if (avarage >= 80)
                {
                    return 'E';
                }
                else if (avarage >= 70)
                {
                    return 'A';
                }
                else if (avarage >= 55)
                {
                    return 'P';
                }
                else if (avarage >= 40)
                {
                    return 'D';
                }
                else
                {
                    return 'T';
                }

            }
        }

        class Solution
        {
            static void Main()
            {
                string[] inputs = Console.ReadLine().Split();
                string firstName = inputs[0];
                string lastName = inputs[1];
                int id = Convert.ToInt32(inputs[2]);
                int numScores = Convert.ToInt32(Console.ReadLine());
                inputs = Console.ReadLine().Split();
                int[] scores = new int[numScores];
                for (int i = 0; i < numScores; i++)
                {
                    scores[i] = Convert.ToInt32(inputs[i]);
                }

                Student s = new Student(firstName, lastName, id, scores);
                s.printPerson();
                Console.WriteLine("Grade: " + s.Calculate() + "\n");
            }
        }
    }
}
