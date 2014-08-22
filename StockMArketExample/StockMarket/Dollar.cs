using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            _amount = amount;
            _currency = "USD";
        }

        public override Money times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }
    }
}
