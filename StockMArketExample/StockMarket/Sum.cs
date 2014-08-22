using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Sum : Expression
    {
        private Money _augend;
        private Money _addend;

        public Money augend {
            get { return _augend; }
            set { _augend = value; }
        }

        public Money addend
        {
            get { return _addend; }
            set { _addend = value; }
        }

        public Sum(Money augend, Money addend)
        {
            _augend = augend;
            _addend = addend;
        }

        public Money reduce(Bank bank, String to)
        {
            int amount = augend.amount() + addend.amount();
            return new Money(amount, to);
        }
    }
}
