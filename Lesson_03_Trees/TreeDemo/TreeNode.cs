using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_03_Trees.TreeDemo
{
    public class TreeNode<T>
    {
        private T value;
        private List<TreeNode<T>> children;
        private bool hasParent;

        public TreeNode(T value)
        {
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public void AddChild(TreeNode<T> child)
        {
            child.hasParent = true;
            this.children.Add(child);
        }
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }

    }
}
