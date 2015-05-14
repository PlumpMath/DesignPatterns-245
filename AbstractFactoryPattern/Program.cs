using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        // Intent: Provide an interface for creating families of related or 
        //         dependent objects without specifying their concrete classes.

        static void Main(string[] args)
        {
            AbstractFactory padFactory=new PadFactory();
            var ipadProduct=padFactory.CreateAppleProduct();
            ipadProduct.USStyle();
            var tabletProduct = padFactory.CreateSumSungProduct();
            tabletProduct.KoreaStyle();

            AbstractFactory mobileFactory=new MobileFactory();
            var iphone = mobileFactory.CreateAppleProduct();
            iphone.USStyle();
            var note = mobileFactory.CreateSumSungProduct();
            note.KoreaStyle();

        }
    }
}
