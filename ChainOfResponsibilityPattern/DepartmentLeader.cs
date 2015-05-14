using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class DepartmentLeader:Handler
    {
        public override bool Approve(double day)
        {
            if (day <= 3)
            {
                Console.WriteLine("The department is approved");
                return true;
            }
            else
            {
                Console.WriteLine("The department is OK with it. but need accelaration.");
                return DirectLeader.Approve(day);
            }
        }

        public DepartmentLeader(Handler directLeader) : base(directLeader)
        {
        }
    }
}
