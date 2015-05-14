using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class GroupLeader:Handler
    {
        public override bool Approve(double day)
        {
            if (day <= 1)
            {
                Console.WriteLine("The group is approved");
                return true;
            }
            else
            {
                Console.WriteLine("The group is OK with it. but need accelaration.");
                return DirectLeader.Approve(day);
            }
        }

        public GroupLeader(Handler directLeader) : base(directLeader)
        {
        }
    }
}
