using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class AddExpression:Expression
    {
        private readonly Expression _addend1;
        private readonly Expression _addend2;

        public AddExpression(Expression addend1, Expression addend2)
        {
            _addend1 = addend1;
            _addend2 = addend2;
        }

        public double Interpreter()
        {
            return _addend1.Interpreter() + _addend2.Interpreter();
        }
    }
}
