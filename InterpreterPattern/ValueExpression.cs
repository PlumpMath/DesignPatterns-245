using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class ValueExpression:Expression
    {
        private readonly double _value;

        public ValueExpression(double value)
        {
            _value = value;
        }

        public double Interpreter()
        {
            return _value;
        }
    }
}
