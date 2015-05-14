using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class Command
    {
        protected Receiver Machine;

        protected Command(Receiver machine)
        {
            Machine = machine;
        }

        public abstract void Execute();
    }
}
