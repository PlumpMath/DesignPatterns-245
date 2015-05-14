using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        // Intent: Define the skeleton of an algorithm in an operation, 
        //         deferring some steps to subclasses. Template Method 
        //         lets subclasses redefine certain steps of an algorithm 
        //         without changing the algorithm's structure.
        static void Main(string[] args)
        {
            Console.WriteLine(new AddOperation().TemplateMethod());
            Console.WriteLine(new MultiplyOperation().TemplateMethod());

        }
    }
}
