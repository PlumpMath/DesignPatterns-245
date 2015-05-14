using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class WrappedInterpreter
    {
        public double Calculate(string expression)
        {
            return ChangeStrToExpression(expression).Interpreter();
        }

        private Expression ChangeStrToExpression(string expression)
        {
            return !ContainsOperations(expression) ? 
                new ValueExpression(Double.Parse(expression)) : 
                HandleExpressionWithOperation(expression);
        }

        private Expression HandleExpressionWithOperation(string expression)
        {
            Expression exp = new ValueExpression(0);
            var characters = expression.ToCharArray();
            for (var i = 0; i < characters.Length; i++)
            {
                var exp1 = expression.Substring(0, i);
                var exp2 = expression.Substring(i + 1);
                switch (characters[i])
                {
                    case '+':
                        exp = new AddExpression(ChangeStrToExpression(exp1), ChangeStrToExpression(exp2));
                        break;
                    case '-':
                        exp = new SubtractionExpression(ChangeStrToExpression(exp1), ChangeStrToExpression(exp2));
                        break;
                    default:
                        break;
                }
            }
            return exp;
        }

        private bool ContainsOperations(string expression)
        {
            return expression.Contains('+') || expression.Contains('-');
        }
    }
}
