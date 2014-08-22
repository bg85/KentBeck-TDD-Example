using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public override Money times(int multiplier)
        {
            return Money.dollar(_amount * multiplier);
        }
    }
}
