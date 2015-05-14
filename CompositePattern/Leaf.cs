using System;

namespace CompositePattern
{
    public class Leaf:NodeComponent
    {
        public Leaf(string nodeName)
            : base(nodeName)
        {
        }
        public override void PresentSelf()
        {
            Console.WriteLine("My node name is {0}. I am a Leaf.",NodeName);
        }

        public override void Add(NodeComponent node)
        {
        }

        public override void Remove(NodeComponent node)
        {
        }
    }
}