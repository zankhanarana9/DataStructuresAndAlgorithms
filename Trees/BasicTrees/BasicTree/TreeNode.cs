﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTree
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> currentNode = this;
            while(currentNode.Parent != null)
            {
                height++;
                currentNode = currentNode.Parent;
            }
            return height;
        }
    }
}
