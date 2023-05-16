using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree
{
    public class BinaryTreeEnumerator : IEnumerator<Node>
    {
        Stack<Node> stack;
        Stack<Node> Nodes;
        public Node Current { get; set; }
        object IEnumerator.Current => Current;
        bool firstitem = true;
        public void walking(Node _current)
        {
            if (stack.Count == 0)
            {
                Nodes = ReverseStack(Nodes);
                return;
            }
            foreach (var child in _current.Children)
            {
                if (child != null)
                {
                    if (!stack.Contains(child))
                    {
                        stack.Push(child);
                        stack = ReverseStack(stack);
                    }
                }
            }
            if (!Nodes.Contains(_current))
            {
                Nodes.Push(_current);
            }
            firstitem = false;
            _current = stack.Pop();
            walking(_current);
        }

        public Stack<Node> ReverseStack(Stack<Node> stack)
        {
            Stack<Node> temp = new Stack<Node>();
            while (stack.Count > 0)
            {
                Node element = stack.Pop();
                temp.Push(element);
            }

            return temp;
        }

        public BinaryTreeEnumerator(Node root)
        {
            Current = root;
            stack = new Stack<Node>();
            stack.Push(root);
            Nodes = new Stack<Node>();
            walking(root);
        }
        public bool MoveNext()
        {
            if (Nodes.Count != 0)
            {
                Current = Nodes.Pop();
                return true;
            }
            return Nodes.Count > 0;
        }

        public void Dispose()
        {

        }

        public void Reset()
        {

        }
    }
}