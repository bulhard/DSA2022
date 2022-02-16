using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_03_Trees.TreeDemo
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }
        public TreeNode<T> Root
        {
            get { return this.root; }
        }
    }
}
