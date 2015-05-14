using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        // Intent: Given a language, define a represention for its grammar 
        //         along with an interpreter that uses the representation 
        //         to interpret sentences in the language.
        //
        // 通常我们可以用一个类封装解释器，这样客户就可以使用10+5这样直观的写法了。
        // 如本例中的WrappedInterpreter类
        static void Main(string[] args)
        {
            CalculateWithoutEncapulate();
            CalculateWithEncapulate();

        }

        private static void CalculateWithoutEncapulate()
        {
            //10+5=15
            Expression addExpression = new AddExpression(new ValueExpression(10), new ValueExpression(5));

            //15-8=7
            Expression subExpression = new SubtractionExpression(addExpression, new ValueExpression(8));

            //15+7=22
            addExpression = new AddExpression(addExpression, subExpression);

            Console.WriteLine(addExpression.Interpreter());            
        }

        private static void CalculateWithEncapulate()
        {
            var wrapper = new WrappedInterpreter();
            Console.WriteLine(wrapper.Calculate("10+5+7-8+8"));
        }
    }
}
