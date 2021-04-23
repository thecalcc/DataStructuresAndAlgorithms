using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; }
    }
}
