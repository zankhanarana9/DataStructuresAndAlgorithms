using BinaryTree.Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<QuizItem> tree =GetTree();
            BinaryTreeNode<QuizItem> node = tree.Root;

            while(node != null)
            {
                if(node.Left != null || node.Right != null)
                {
                    Console.Write(node.Data.Text);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Y:
                            WriteAnswer(" Yes");
                            node = node.Left;
                            break;
                        case ConsoleKey.N:
                            WriteAnswer(" No");
                            node = node.Right;
                            break;
                    }
                } else
                {
                    WriteAnswer(node.Data.Text);
                    node = null;
                }
            }
        }

        private static BinaryTree<QuizItem> GetTree()
        {
            BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();
            tree.Root = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Do you have experience in developing application?"),                
                Parent = null
            };

            tree.Root.Left = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Have you worked as a developer for  more than 5 years?"),
                Parent = tree.Root
            };

            tree.Root.Right = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Have you completed the university?"),
                Parent = tree.Root
            };

            tree.Root.Left.Left = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Apply as a senior developer!"),
                Parent = tree.Root.Left
            };

            tree.Root.Left.Right = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Apply as a middle develoepor!"),
                Parent = tree.Root.Right
            };

            tree.Root.Right.Left = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Apply as a junior developer!"),
                Parent = tree.Root.Right
            };

            tree.Root.Right.Right = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Will you find some time during the semester?"),
                Parent = tree.Root.Right
            };

            tree.Root.Right.Right.Left = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Apply for our long-time internship program!"),
                Parent = tree.Root.Right.Right
            };

            tree.Root.Right.Right.Right = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Apply for summer internship program"),
                Parent = tree.Root.Right.Right
            };
            
            return tree;

        }

        static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
