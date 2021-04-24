using System;
using System.Collections.Generic;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<Person> company = new Tree<Person>();
            company.Root = new TreeNode<Person>()
            {
                Data = new Person(100, "Kliment", "CEO"),
                Parent = null
            };

            company.Root.Children = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person(1, "John Smith", "Head of Developement"),
                    Parent = company.Root
                },
                new TreeNode<Person>()
                {
                    Data = new Person(2, "Jason Born", "Head of Research"),
                    Parent = company.Root
                },
                new TreeNode<Person>()
                {
                    Data = new Person(3, "Liam Neeson", "Head of Sales"),
                    Parent = company.Root
                }
            };

            company.Root.Children[2].Children = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person(30, "Anthony Hopkis", "Sales Specialist"),
                    Parent = company.Root.Children[2]
                }
            };
        }

        static void BasicTreeExample()
        {
            Tree<int> tree = new Tree<int>();

            tree.Root = new TreeNode<int>() { Data = 100 };
            tree.Root.Children = new List<TreeNode<int>>
            {
                new TreeNode<int>() {Data = 50, Parent = tree.Root},
                new TreeNode<int>() {Data = 1, Parent = tree.Root},
                new TreeNode<int>() {Data = 150, Parent = tree.Root}
            };

            tree.Root.Children[2].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>()
                {
                    Data = 30, Parent = tree.Root.Children[2]
                }
            };
        }
    }
}
