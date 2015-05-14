using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class IPadProduct:AppleProduct
    {
        public void USStyle()
        {
            Console.WriteLine("Apple's Pad style: IPad.");
        }
    }
}
