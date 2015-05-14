using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class IphoneProduct:AppleProduct
    {
        public void USStyle()
        {
            Console.WriteLine("Apple's mobile style: IPhone.");
        }
    }
}
