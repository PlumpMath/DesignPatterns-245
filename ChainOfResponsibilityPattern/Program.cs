using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        // Intent: Avoid coupling the sender of a request to its receiver by giving more than 
        //         one object a chance to handle the request. Chain the receiving objects 
        //         and pass the request along the chain until an object handles it.
        static void Main(string[] args)
        {
            new GroupLeader(new DepartmentLeader(new CompanyLeader())).Approve(6);
        }
    }
}
