using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class MobileFactory:AbstractFactory
    {
        public AppleProduct CreateAppleProduct()
        {
            return new IphoneProduct();
        }

        public SumSungProduct CreateSumSungProduct()
        {
            return new NoteIIProduct();
        }
    }
}
