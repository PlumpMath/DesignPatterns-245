using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class AssistantProxy:Signature
    {
        private Signature _signature;

        public AssistantProxy(Signature signature)
        {
            _signature = signature;
        }

        public void Sign()
        {
            Console.WriteLine("Promote to CEO");
            _signature.Sign();
            Console.WriteLine("Send back.");
        }
    }
}
