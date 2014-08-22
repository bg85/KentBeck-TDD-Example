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
            : base(amount, currency)
        {
        }

        public override Money times(int multiplier)
        {
            return new Money(_amount * multiplier, _currency);
        }
    }
}
