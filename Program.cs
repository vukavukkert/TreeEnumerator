using System.Collections.Generic;
using Tree;

Trees tree = new Trees();

tree.Add("A", 10); //root
tree.Add("B", 9); //root --> left
tree.Add("F", 2); //root --> left --> left
tree.Add("C", 11); // root --> right
tree.Add("D", 12); // root --> right --> right

foreach (Node node in tree)
{
    Console.WriteLine($"Point:{node.Data}, Weight: {node.Key}, level: {node.Level}");
}

