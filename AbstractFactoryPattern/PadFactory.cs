using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PadFactory:AbstractFactory
    {
        public AppleProduct CreateAppleProduct()
        {
            return new IPadProduct();
        }

        public SumSungProduct CreateSumSungProduct()
        {
            return new TabletProduct();
        }
    }
}
