using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class CPA:ReviewerVisitor
    {
        public void Review(ConsumeBill bill)
        {
            var comments = bill.Expense > 100 ? 
                "From CPA: Alert: so many money consumed" : "From CPA: I am fine with it.";
            Console.WriteLine(comments);
        }

        public void Review(IncomeBill bill)
        {
            var comments = bill.IncomeBeforeTax - bill.IncomeAfterTax < 50
                ? "From CPA: This amount is not reasonable"
                : "From CPA: I am fine with it.";
            Console.WriteLine(comments);
        }
    }
}
