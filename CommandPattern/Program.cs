using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        // Intent: Encapsulate a request as an object, thereby letting you parameterize clients 
        //          with different requests, queue or log requests, and support undoable operations.
        static void Main(string[] args)
        {
            RequestCommand(new Involker(),new Receiver());
        }

        private static void RequestCommand(Involker invoker,Receiver receiver)
        {
            invoker.Request(new KickCommand(receiver));
            invoker.Request(new FistCommand(receiver));
            invoker.Request(new MoveCommand(receiver));
        }
    }
}
