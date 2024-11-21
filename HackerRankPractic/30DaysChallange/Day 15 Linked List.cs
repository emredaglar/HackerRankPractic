using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace HackerRankPractic._30DaysChallange
{
    internal class Day_15_Linked_List
    {
        //        A Node class is provided for you in the editor.A Node object has an integer data field, , and a Node instance pointer, , pointing to another node (i.e.: the next node in the list).

        //A Node insert function is also declared in your editor.It has two parameters: a pointer, , pointing to the first node of a linked list, and an integer, , that must be added to the end of the list as a new Node object.

        //Task
        //        Complete the insert function in your editor so that it creates a new Node(pass  as the Node constructor argument) and inserts it at the tail of the linked list referenced by the parameter.Once the new node is added, return the reference to the  node.
        //        Note: The argument is null for an empty list.

        //Input Format

        //The first line contains T, the number of elements to insert.
        //Each of the next lines contains an integer to insert at the end of the list.

        //Output Format

        //Return a reference to the node of the linked list.

        //Sample Input

        //STDIN Function
        //-----   --------
        //4       T = 4
        //2       first data = 2
        //3
        //4
        //1       fourth data = 1
        //Sample Output

        //2 3 4 1
        //Explanation

        //, so your method will insert nodes into an initially empty list.
        //        First the code returns a new node that contains the data value  as the of the list.Then create and insert nodes, , and at the tail of the list.

        //LinkedListExplanation.png

        //My Solution
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }

        }
        class Solution
        {

            public static Node insert(Node head, int data)
            {
                //Complete this method
                if (head == null)
                {
                    return new Node(data);
                }
                var curr = head;
                while (curr.next != null)
                {
                    curr = curr.next;

                }
                curr.next = new Node(data);
                return head;
            }

            public static void display(Node head)
            {
                Node start = head;
                while (start != null)
                {
                    Console.Write(start.data + " ");
                    start = start.next;
                }
            }
            static void Main(String[] args)
            {

                Node head = null;
                int T = Int32.Parse(Console.ReadLine());
                while (T-- > 0)
                {
                    int data = Int32.Parse(Console.ReadLine());
                    head = insert(head, data);
                }
                display(head);
            }
        }
}
