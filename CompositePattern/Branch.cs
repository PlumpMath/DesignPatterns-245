using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Branch:NodeComponent
    {
        private readonly List<NodeComponent> _nodes = new List<NodeComponent>();

        public Branch(string nodeName)
            : base(nodeName)
        {
        }

        public override void PresentSelf()
        {
            PrintCurrentNodeInformation();
            foreach (var node in _nodes)
            {
                node.PresentSelf();
            }
        }

        private void PrintCurrentNodeInformation()
        {
            Console.WriteLine("I am a node, My node name is {0}", NodeName);
            Console.WriteLine("I have following nodes:");
            var sb = new StringBuilder();
            foreach (var node in _nodes)
            {
                if (sb.Length > 0)
                    sb.Append(",");
                sb.Append(node.NodeName);
            }
            Console.WriteLine(sb.ToString());
        }

        public override void Add(NodeComponent node)
        {
            _nodes.Add(node);
        }

        public override void Remove(NodeComponent node)
        {
            _nodes.Remove(node);
        }


    }
}
