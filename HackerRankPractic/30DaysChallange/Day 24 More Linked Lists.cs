﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace HackerRankPractic._30DaysChallange
{
    internal class Day_24_More_Linked_Lists
    {
        //        Task
        //        A Node class is provided for you in the editor.A Node object has an integer data field, , and a Node instance pointer, , pointing to another node (i.e.: the next node in a list).

        //A removeDuplicates function is declared in your editor, which takes a pointer to the node of a linked list as a parameter.Complete removeDuplicates so that it deletes any duplicate nodes from the list and returns the head of the updated list.

        //Note: The pointer may be null, indicating that the list is empty.Be sure to reset your pointer when performing deletions to avoid breaking the list.

        //Input Format

        //You do not need to read any input from stdin. The following input is handled by the locked stub code and passed to the removeDuplicates function:
        //The first line contains an integer, , the number of nodes to be inserted.
        //The subsequent lines each contain an integer describing the value of a node being inserted at the list's tail.

        //Constraints

        //The data elements of the linked list argument will always be in non-decreasing order.
        //Output Format

        //Your removeDuplicates function should return the head of the updated linked list.The locked stub code in your editor will print the returned list to stdout.

        //Sample Input

        //6
        //1
        //2
        //2
        //3
        //3
        //4
        //Sample Output

        //1 2 3 4 
        //Explanation

        //, and our non-decreasing list is . The values  and both occur twice in the list, so we remove the two duplicate nodes.We then return our updated (ascending) list, which is .

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

            public static Node removeDuplicates(Node head)
            {
                //Write your code here
                if (head == null)
                {
                    return head;
                }
                Node curr = head;
                while (curr.next != null)
                {
                    if (curr.data == curr.next.data)
                    {
                        curr.next = curr.next.next;
                    }
                    else
                    {
                        curr = curr.next;
                    }
                }
                return head;
            }

            public static Node insert(Node head, int data)
            {
                Node p = new Node(data);


                if (head == null)
                    head = p;
                else if (head.next == null)
                    head.next = p;
                else
                {
                    Node start = head;
                    while (start.next != null)
                        start = start.next;
                    start.next = p;

                }
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
                head = removeDuplicates(head);
                display(head);
            }
        }
    }
}