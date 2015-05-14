using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class AccountBook
    {
        private readonly List<Bill> _bills=new List<Bill>();

        public void AttachBill(Bill bill)
        {
            _bills.Add(bill);
        }

        public void DetachBill(Bill bill)
        {
            _bills.Remove(bill);
        }

        public void AcceptReview(ReviewerVisitor visitor)
        {
            foreach (var bill in _bills)
            {
                bill.Accept(visitor);
            }
        }
    }
}
