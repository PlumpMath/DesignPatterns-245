using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Boss:ReviewerVisitor
    {
        public void Review(ConsumeBill bill)
        {
            var comments = bill.Expense > 100 ? 
                "From Boss: This amount is not allowed" : "From Boss: I am fine with it.";
            Console.WriteLine(comments);
        }

        public void Review(IncomeBill bill)
        {
            var comments = bill.IncomeBeforeTax - bill.IncomeAfterTax > 50 ?
                "From Boss: This amount is not allowed" : "From Boss: I am fine with it.";
            Console.WriteLine(comments);
        }
    }
}
