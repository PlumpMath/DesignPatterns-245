using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class AmericaSocket:ForeignSocket
    {
        public void AcceptForeignSocket()
        {
            Console.WriteLine("You are now using American Socket");
        }
    }
}
