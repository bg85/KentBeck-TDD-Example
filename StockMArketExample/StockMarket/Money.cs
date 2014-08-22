using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public abstract class Money {

        protected int _amount;
        protected string _currency;

        public abstract Money times(int multiplier);

        protected Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public string currency()
        {
            return _currency;
        }

        public bool Equals(object obj)
        {
            var money = (Money) obj;
            return _amount == money._amount && this.GetType() == obj.GetType();
        }

        public static Money dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Franc(amount, "CHF");
        }    }
}
