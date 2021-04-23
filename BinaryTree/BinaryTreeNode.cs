using System;
using System.Collections.Generic;
using System.Text;
using Trees;

namespace BinaryTree
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        public BinaryTreeNode() => Children =
            new List<TreeNode<T>>() { null, null };

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
    }
}
