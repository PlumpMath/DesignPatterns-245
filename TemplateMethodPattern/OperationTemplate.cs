using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class OperationTemplate
    {
        public double TemplateMethod()
        {
            var oper1 = GetFirstOperator();
            var oper2 = GetSecondOperator();
            return Operate(oper1, oper2);
        }

        protected abstract double Operate(double oper1, double oper2);

        protected virtual double GetSecondOperator()
        {
            return 10;
        }

        protected virtual double GetFirstOperator()
        {
            return 5;
        }
    }
}
