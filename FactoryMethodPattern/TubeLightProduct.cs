using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class TubeLightProduct:LightProduct
    {
        public void TurnOn()
        {
            Console.WriteLine("TubeLight turns on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("TubeLight turns off.");
        }
    }
}
