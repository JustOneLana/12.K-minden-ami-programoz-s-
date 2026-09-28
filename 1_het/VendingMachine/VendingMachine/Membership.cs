using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Membership
    {
        private Member _Owner;
        public Member Owner { get { return _Owner; } set { _Owner = value; } }
        private int _MonthlyPrice;
        public int MonthlyPrice { get { return _MonthlyPrice; } set { _MonthlyPrice = value; } } 
        private int _months;
        public int Months { get { return _months; } set { _months = value; } }

        public Membership(Member owner, int monthlyPrice, int months)
        {
            _Owner = owner;
            _MonthlyPrice = monthlyPrice;
            _months = months;
        }
        public int TotalCost(Member mem)
        {
            if (mem.isStudent)
            {
                
            }
            return _MonthlyPrice + _months;
           
        }
    }
}
