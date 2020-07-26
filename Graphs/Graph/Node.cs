using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Node<T>
    {
        public int Index { get; set; }
        public T Data { get; set; }
        public List<Node<T>> Neighbors { get; set; }
        public List<int> Weights { get; set; }

        public Node()
        {
            Neighbors = new List<Node<T>>();
            Weights = new List<int>();
        }

        public override string ToString()
        {
            return $"Node with index {Index} : {Data}, Neighbors {Neighbors.Count}";
        }
    }
}
