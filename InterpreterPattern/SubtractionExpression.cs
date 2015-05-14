using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class SubtractionExpression:Expression
    {
        private readonly Expression _minuend;
        private readonly Expression _subtrahend;

        public SubtractionExpression(Expression minuend, Expression subtrahend)
        {
            _minuend = minuend;
            _subtrahend = subtrahend;
        }

        public double Interpreter()
        {
            return _minuend.Interpreter()-_subtrahend.Interpreter();
        }
    }
}
