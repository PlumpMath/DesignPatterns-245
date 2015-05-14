using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class NodeComponent
    {
        public readonly string NodeName;

        protected NodeComponent(string nodeName)
        {
            NodeName = nodeName;
        }

        public abstract void PresentSelf();
        public abstract void Add(NodeComponent node);
        public abstract void Remove(NodeComponent node);
    }
}
