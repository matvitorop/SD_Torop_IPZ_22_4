using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class NodeIterator : IIterator
    {
        private Queue<LightNode> breadthFirstQueue;
        private Stack<LightNode> depthFirstStack;

        public NodeIterator(LightNode root)
        {
            breadthFirstQueue = new Queue<LightNode>();
            depthFirstStack = new Stack<LightNode>();

            TraverseDepthFirst(root);
            TraverseBreadthFirst(root);
        }

        private void TraverseDepthFirst(LightNode node)
        {
            if (node == null)
                return;

            depthFirstStack.Push(node);

            if (node is LightElementNode)
            {
                LightElementNode elementNode = (LightElementNode)node;
                foreach (var child in elementNode.children)
                {
                    TraverseDepthFirst(child);
                }
            }
        }

        private void TraverseBreadthFirst(LightNode node)
        {
            if (node == null)
                return;

            Queue<LightNode> queue = new Queue<LightNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                breadthFirstQueue.Enqueue(current);

                if (current is LightElementNode)
                {
                    LightElementNode elementNode = (LightElementNode)current;
                    foreach (var child in elementNode.children)
                    {
                        queue.Enqueue(child);
                    }
                }
            }
        }

        public bool HasNext()
        {
            return breadthFirstQueue.Count > 0;
        }

        public LightNode Next()
        {
            return breadthFirstQueue.Dequeue();
        }

        public IEnumerable<LightNode> TraverseDepthFirst()
        {
            while (depthFirstStack.Count > 0)
            {
                yield return depthFirstStack.Pop();
            }
        }

        public IEnumerable<LightNode> TraverseBreadthFirst()
        {
            while (breadthFirstQueue.Count > 0)
            {
                yield return breadthFirstQueue.Dequeue();
            }
        }
    }
}
