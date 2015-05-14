using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter:TargetChinaSocket
    {
        private readonly ForeignSocket _foreignSocket;

        public Adapter(ForeignSocket usSocket)
        {
            _foreignSocket = usSocket;
        }
        public void AcceptChinaPlugin()
        {
            _foreignSocket.AcceptForeignSocket();
        }
    }
}
