using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_23_BST_Level_Order_Traversal
    {
        //        Task
        //A level-order traversal, also known as a breadth-first search, visits each level of a tree's nodes from left to right, top to bottom. You are given a pointer, , pointing to the root of a binary search tree. Complete the levelOrder function provided in your editor so that it prints the level-order traversal of the binary search tree.

        //Hint: You'll find a queue helpful in completing this challenge.

        //Function Description

        //Complete the levelOrder function in the editor below.

        //levelOrder has the following parameter:
        //- Node pointer root: a reference to the root of the tree

        //Prints
        //- Print node.data items as space-separated line of integers. No return value is expected.

        //Input Format

        //The locked stub code in your editor reads the following inputs and assembles them into a BST:
        //The first line contains an integer, (the number of test cases).
        //The subsequent lines each contain an integer, , denoting the value of an element that must be added to the BST.

        //Constraints



        //Output Format

        //Print the value of each node in the tree's level-order traversal as a single line of  space-separated integers.

        //Sample Input

        //6
        //3
        //5
        //4
        //7
        //2
        //1
        //Sample Output

        //3 2 5 1 4 7 
        //Explanation
        //        The input forms the following binary search tree:
        //BST.png

        //We traverse each level of the tree from the root downward, and we process the nodes at each level from left to right.The resulting level-order traversal is , and we print these data values as a single line of space-separated integers.

        //My Solution
        class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }
        class Solution
        {

            static void levelOrder(Node root)
            {
                //Write your code here
                if (root == null)
                {
                    return;
                }
                var q = new Queue<Node>();
                q.Enqueue(root);

                while (q.Count != 0)
                {
                    Node curr = q.Dequeue();
                    Console.Write(curr.data + " ");
                    if (curr.left != null)
                    {
                        q.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        q.Enqueue(curr.right);
                    }
                }
            }

            static Node insert(Node root, int data)
            {
                if (root == null)
                {
                    return new Node(data);
                }
                else
                {
                    Node cur;
                    if (data <= root.data)
                    {
                        cur = insert(root.left, data);
                        root.left = cur;
                    }
                    else
                    {
                        cur = insert(root.right, data);
                        root.right = cur;
                    }
                    return root;
                }
            }
            static void Main(String[] args)
            {
                Node root = null;
                int T = Int32.Parse(Console.ReadLine());
                while (T-- > 0)
                {
                    int data = Int32.Parse(Console.ReadLine());
                    root = insert(root, data);
                }
                levelOrder(root);

            }
        }
    }
