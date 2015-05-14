using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        // Intent: Compose objects into tree structures to represent part-whole hierarchies. 
        //         Composite lets clients treat individual objects and compositions of objects 
        //         uniformly.
        static void Main(string[] args)
        {  
            NodeComponent leaf1=new Leaf("Leaf 1");
            NodeComponent leaf2=new Leaf("Leaf 2");
            NodeComponent leaf3 = new Leaf("Leaf 3");
            NodeComponent leaf4 = new Leaf("Leaf 4");
            NodeComponent branch1 = new Branch("Branch Low");
            branch1.Add(leaf1);
            branch1.Add(leaf2);

            NodeComponent branch2 = new Branch("Branch High");
            branch2.Add(branch1);
            branch2.Add(leaf3);

            NodeComponent root=new Branch("Root");
            root.Add(branch2);
            root.Add(leaf4);

            root.PresentSelf();

        }
    }
}
