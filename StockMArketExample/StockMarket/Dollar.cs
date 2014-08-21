using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Dollar
    {
        private int _amount;
        public int amount {
            get { return _amount; }
            set { _amount = value; }
        }

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }
    }
}
