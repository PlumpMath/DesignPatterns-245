using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class BookPrice
    {
        private readonly MembershipDiscountStrategy _membershipDiscount;
        private readonly double _originalPrice;

        public BookPrice(MembershipDiscountStrategy membershipDiscount, double originalPrice)
        {
            _membershipDiscount = membershipDiscount;
            _originalPrice = originalPrice;
        }

        public double GetPrice()
        {
            return _originalPrice*_membershipDiscount.GetDiscount();
        }
    }
}
