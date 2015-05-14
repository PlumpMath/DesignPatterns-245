using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class CEO:Signature
    {
        public void Sign()
        {
            Console.WriteLine("CEO signed the file");
        }
    }
}
