using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree
{
    public class Node
    {
        public string Data { get; set; }
        public int Key { get; set; }

        public int Level;
        public List<Node>? Children
        {
            get
            {
                return new List<Node> { Next_Left, Next_Right };
            }
        }
        public Node parent { get; set; }
        public Node? Next_Left { get; set; }
        public Node? Next_Right { get; set; }
        public Node(string data, int key, Node Next_Left = default, Node Next_Right = default)
        {
            Data = data;
            Key = key;
            Level = 1;
        }
    }
}