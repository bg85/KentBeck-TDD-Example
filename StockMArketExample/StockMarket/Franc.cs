using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Franc : Money
    {
        private string _currency;

        public Franc(int amount)
        {
            _amount = amount;
            _currency = "CHF";
        }

        public override Money times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override string currency()
        {
            return _currency;
        }
    }
}
