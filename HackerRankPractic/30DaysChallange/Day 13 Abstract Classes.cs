using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_13_Abstract_Classes
    {
        //        Task
        //Given a Book class and a Solution class, write a MyBook class that does the following:

        //Inherits from Book
        //Has a parameterized constructor taking these parameters:
        //string
        //string
        //int
        //Implements the Book class' abstract display() method so it prints these  lines:
        //, a space, and then the current instance's .
        //, a space, and then the current instance's .
        //, a space, and then the current instance's .
        //Note: Because these classes are being written in the same file, you must not use an access modifier(e.g.: ) when declaring MyBook or your code will not execute.

        //Input Format

        //You are not responsible for reading any input from stdin.The Solution class creates a Book object and calls the MyBook class constructor(passing it the necessary arguments). It then calls the display method on the Book object.

        //Output Format

        //The method should print and label the respective, , and  of the MyBook object's instance (with each value on its own line) like so:

        //Title: $title
        //Author: $author
        //Price: $price
        //Note: The  is prepended to variable names to indicate they are placeholders for variables.

        //Sample Input

        //The following input from stdin is handled by the locked stub code in your editor:

        //The Alchemist
        //Paulo Coelho
        //248
        //Sample Output

        //The following output is printed by your display() method:

        //Title: The Alchemist
        //Author: Paulo Coelho
        //Price: 248

        //MySolution
        abstract class Book
        {

            protected String title;
            protected String author;

            public Book(String t, String a)
            {
                title = t;
                author = a;
            }
            public abstract void display();


        }

        //Write MyBook class
        class MyBook : Book
        {
            private int price;
            public MyBook(string title, string author, int myPrice) : base(title, author)
            {
                price = myPrice;
            }
            public override void display()
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Price: " + price);
            }
        }

        class Solution
        {
            static void Main(String[] args)
            {
                String title = Console.ReadLine();
                String author = Console.ReadLine();
                int price = Int32.Parse(Console.ReadLine());
                Book new_novel = new MyBook(title, author, price);
                new_novel.display();
            }
        }
    }
}
