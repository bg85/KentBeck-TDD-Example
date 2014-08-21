using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Dollar : Money
    {
        private int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return _amount == dollar._amount;
        }
    }
}
