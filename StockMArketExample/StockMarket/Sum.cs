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
        private Expression _addend;

        public Money augend {
            get { return _augend; }
            set { _augend = value; }
        }

        public Expression addend
        {
            get { return _addend; }
            set { _addend = value; }
        }

        public Sum(Money augend, Expression addend)
        {
            _augend = augend;
            _addend = addend;
        }

        public Money reduce(Bank bank, String to)
        {
            int amount = _augend.reduce(bank, to).amount() + _addend.reduce(bank,
                to).amount();
            return new Money(amount, to);
        }

        public Expression plus(Expression addend)
        {
            return null;
        }

    }
}
