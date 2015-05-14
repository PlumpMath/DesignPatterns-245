using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class TabletProduct : SumSungProduct
    {
        public void KoreaStyle()
        {
            Console.WriteLine("Sumsung's Pad style: Tablet.");
        }
    }
}
