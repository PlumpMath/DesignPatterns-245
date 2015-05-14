using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        // Intent:Decouple an abstraction from its implementation so that the two can vary independently.
        //
        // Typically the Implementor interface provides only primitive operations, 
        // and Abstraction defines higher-level operations based on these primitives.

        static void Main(string[] args)
        {
            new Rectangle(new Device1Drawing(),0,0,100,100).Draw();
            new Circle(new Device1Drawing(), 0, 0,100).Draw();

            new Rectangle(new Device2Drawing(), 0, 0, 100, 100).Draw();
            new Circle(new Device2Drawing(), 0, 0, 100).Draw();
        }
    }
}
