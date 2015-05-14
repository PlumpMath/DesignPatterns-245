using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MoveCommand:Command
    {
        public MoveCommand(Receiver machine) : base(machine)
        {
        }

        public override void Execute()
        {
            Machine.Move();
        }
    }
}
