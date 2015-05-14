using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class AddOperation:OperationTemplate
    {
        protected override double Operate(double oper1, double oper2)
        {
            return oper1 + oper2;
        }
    }
}
