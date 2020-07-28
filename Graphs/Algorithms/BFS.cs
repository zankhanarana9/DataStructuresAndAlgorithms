using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphs;

namespace Algorithms
{
    public class BFS<T> 
    {                 
        public List<Node<T>> Search(Graph<T> g) {

            bool[] isVisited = new bool[g.Nodes.Count];
            Queue<Node<T>> queue = new Queue<Node<T>>();
            List<Node<T>> result = new List<Node<T>>();
            Node<T> node = g.Nodes[0];
            isVisited[node.Index] = true;
            queue.Enqueue(node);
            while(queue.Count > 0)
            {
                Node<T> next = queue.Dequeue();
                result.Add(next);
                
                foreach(Node<T> neighbor in next.Neighbors)
                {
                    if(!isVisited[neighbor.Index])
                    {
                        isVisited[neighbor.Index] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result;
        }
    }
}
