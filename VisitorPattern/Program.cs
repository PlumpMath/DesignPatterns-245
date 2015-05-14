using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {

        // Intent:Represent an operation to be performed on the elements 
        //        of an object structure. Visitor lets you define a new 
        //        operation without changing the classes of the elements 
        //        on which it operates.
        static void Main(string[] args)
        {
            var accountBook = InitializeAccountBook();

            accountBook.AcceptReview(new Boss());
            accountBook.AcceptReview(new CPA());
        }

        private static AccountBook InitializeAccountBook()
        {
            var accountBook = new AccountBook();
            var income = new IncomeBill {IncomeBeforeTax = 100, IncomeAfterTax = 70};
            accountBook.AttachBill(income);
            var consume = new ConsumeBill {Expense = 150};
            accountBook.AttachBill(consume);
            return accountBook;
        }
    }
}
