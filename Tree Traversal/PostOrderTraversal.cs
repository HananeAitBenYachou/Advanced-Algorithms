using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ProblemSolving
{ 
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> LeftChild { get;  set; }
        public BinaryTreeNode<T> RightChild { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; private set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T value)
        {
            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>(value);

            if(Root == null)
            {
                Root = newNode;
                return;
            }

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

            queue.Enqueue(Root);
            
            while(queue.Count > 0)
            {
                BinaryTreeNode<T> currentNode = queue.Dequeue();

                if(currentNode.LeftChild == null)
                {
                    currentNode.LeftChild = newNode;
                    return;
                }

                else
                {
                    queue.Enqueue(currentNode.LeftChild);
                }

                if (currentNode.RightChild == null)
                {
                    currentNode.RightChild = newNode;
                    return;
                }

                else
                {
                    queue.Enqueue(currentNode.RightChild);
                }
            }
        }

        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(BinaryTreeNode<T> root, int space)
        {
            int COUNT = 10;  // Distance between levels to adjust the visual representation
            if (root == null)
                return;


            space += COUNT;
            PrintTree(root.RightChild, space); // Print right subtree first, then root, and left subtree last


            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(root.Value); // Print the current node after space


            PrintTree(root.LeftChild, space); // Recur on the left child
        }

        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            /*
              PostOrder Traversal visits the current node after its child nodes. 
              The process for PostOrder Traversal is:


                - Recursively perform PostOrder Traversal of the left subtree.
                - Recursively perform PostOrder Traversal of the right subtree.
                - Visit the current node.
           */

            if (node != null)
            {
                PostOrderTraversal(node.LeftChild);
                PostOrderTraversal(node.RightChild);
                Console.Write(node.Value + " ");
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();
        }
    }

    internal class Program
    {       
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();
            Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9\n");

            binaryTree.Insert(5);
            binaryTree.Insert(3);
            binaryTree.Insert(8);
            binaryTree.Insert(1);
            binaryTree.Insert(4);
            binaryTree.Insert(6);
            binaryTree.Insert(9);

            binaryTree.PrintTree();

            Console.WriteLine("\nPostorder Traversal (Left SubTree - Right SubTree - Current):");
            binaryTree.PostOrderTraversal();

            Console.ReadKey();
        }

    }
}
