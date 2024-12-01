﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_22_Binary_Search_Trees
    {
        //        Task
        //The height of a binary search tree is the number of edges between the tree's root and its furthest leaf. You are given a pointer, , pointing to the root of a binary search tree. Complete the getHeight function provided in your editor so that it returns the height of the binary search tree.

        //Input Format

        //The locked stub code in your editor reads the following inputs and assembles them into a binary search tree:
        //The first line contains an integer, , denoting the number of nodes in the tree.
        //Each of the  subsequent lines contains an integer, , denoting the value of an element that must be added to the BST.

        //Output Format

        //The locked stub code in your editor will print the integer returned by your getHeight function denoting the height of the BST.

        //Sample Input

        //7
        //3
        //5
        //2
        //1
        //4
        //6
        //7
        //Sample Output

        //3
        //Explanation
        //        The input forms the following BST:

        //BST.png

        //The longest root-to-leaf path is shown below:

        //Longest RTL.png

        //There are nodes in this path that are connected by edges, meaning our BST's . Thus, we print  as our answer.

        //My Solution
        static int getHeight(Node root)
        {
            //Write your code here
            if (root == null)
            {
                return -1;
            }
            int leftHeight = getHeight(root.left);
            int rightHeight = getHeight(root.right);

            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            else
            {
                return rightHeight + 1;
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
            int height = getHeight(root);
            Console.WriteLine(height);

        }
    }
}
}
