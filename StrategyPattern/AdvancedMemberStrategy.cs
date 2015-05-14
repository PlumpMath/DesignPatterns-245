using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class AdvancedMemberStrategy:MembershipDiscountStrategy
    {
        public double GetDiscount()
        {
            return 0.6;
        }
    }
}
