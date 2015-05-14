using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        // Intent: Attach additional responsibilities to an object dynamically. 
        //         Decorators provide a flexible alternative to subclassing for extending functionality.
        static void Main(string[] args)
        {
            new LipStickingWoman(new ThrushingWoman(new PermingWoman(new WomanWithoutMakeUp()))).Decorate();
        }
    }
}
