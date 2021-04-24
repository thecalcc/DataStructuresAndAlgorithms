using System;
using System.Collections.Generic;
using System.Text;
using Trees;

namespace BinaryTree
{
    public class BinaryTreeNode<T> : Trees.TreeNode<T>
    {
        public BinaryTreeNode() => Children =
            new List<Trees.TreeNode<T>>() { null, null };

        public BinaryTreeNode<T> Parent { get; set; }

        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children[0];}
            set { Children[1] = value; }            
        }

        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }

        public int newGetHeight()
        {
            int height = 1;
            BinaryTreeNode<T> current = this;

            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }

            return height;
        }
    }
}
