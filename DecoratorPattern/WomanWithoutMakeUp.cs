using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class WomanWithoutMakeUp:Woman
    {
        public void Decorate()
        {
            Console.WriteLine("I don't have any Makeup");
        }
    }
}
