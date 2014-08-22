using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public override Money times(int multiplier)
        {
            return Money.franc(_amount * multiplier);
        }
    }
}
