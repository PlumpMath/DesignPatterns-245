using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Involker
    {
        public void Request(Command command)
        {
            command.Execute(); 
        }
    }
}
