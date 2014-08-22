using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Money {

        protected int _amount;
        protected string _currency;

        public Money(int amount, string currency)
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
            return _amount == money._amount && currency().Equals(money.currency());
        }

        public Money times(int multiplier)
        {
            return new Money(_amount * multiplier, _currency);
        }

        public static Money dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public String toString()
        {
            return _amount + " " + _currency;
        }    }
}
