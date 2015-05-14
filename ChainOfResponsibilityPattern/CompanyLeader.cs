using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class CompanyLeader:Handler
    {
        public override bool Approve(double day)
        {
            Console.WriteLine("The company is approved.");
            return true;
        }

        public CompanyLeader() : base(null)
        {
        }
    }
}
