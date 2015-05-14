using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        // Intent: Provide a surrogate or placeholder for another object to control access to it.
        //
        static void Main(string[] args)
        {
            Signature ceo=new CEO();
            Signature proxy=new AssistantProxy(ceo);
            proxy.Sign();
        }
    }
}
