using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        // Intent: Convert the interface of a class into another interface clients expect. Adapter lets classes 
        //         work together that couldn't otherwise because of incompatible interfaces.
        static void Main(string[] args)
        {
            (new Adapter(new AmericaSocket())).AcceptChinaPlugin();
            (new Adapter(new EuropeanSocket())).AcceptChinaPlugin();
        }
    }
}
