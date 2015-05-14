using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        // Intent: Define a family of algorithms, encapsulate each one, 
        //         and make them interchangeable. Strategy lets the algorithm 
        //         vary independently from clients that use it.
        static void Main(string[] args)
        {
            Console.WriteLine(new BookPrice(new AdvancedMemberStrategy(), 100).GetPrice());
        }
    }
}
