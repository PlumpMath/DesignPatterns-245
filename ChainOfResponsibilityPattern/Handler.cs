using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        protected Handler DirectLeader;

        protected Handler(Handler directLeader)
        {
            DirectLeader = directLeader;
        }

        public abstract bool Approve(double day);

    }
}
