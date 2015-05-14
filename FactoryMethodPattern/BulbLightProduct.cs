using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class BulbLightProduct:LightProduct
    {
        public void TurnOn()
        {
            Console.WriteLine("BulbLight turns on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("BulbLight turns off.");
        }
    }
}
