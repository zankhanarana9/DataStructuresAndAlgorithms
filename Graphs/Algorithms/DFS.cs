using Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class DFS<T>
    {
        public List<Node<T>> Search(Graph<T> g)
        {
            bool[] isVisited = new bool[g.Nodes.Count];

            Stack<Node<T>> stack = new Stack<Node<T>>();
            List<Node<T>> result = new List<Node<T>>();
            Node<T> node = g.Nodes[0];
            stack.Push(node);
            isVisited[node.Index] = true;

            while(stack.Count > 0)
            {
                Node<T> next = stack.Pop();
                result.Add(next);
                foreach(Node<T> neighbor in next.Neighbors)
                {
                    if(!isVisited[neighbor.Index])
                    {
                        isVisited[neighbor.Index] = true;
                        stack.Push(neighbor);
                    }
                }
            }            
            return result;
        }
    }
}
