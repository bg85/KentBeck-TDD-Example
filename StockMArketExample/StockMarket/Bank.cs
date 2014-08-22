using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Bank
    {
        public Money reduce(Expression source, String to)
        {
            Sum sum = (Sum)source;
            int amount = sum.augend.amount() + sum.addend.amount();
            return new Money(amount, to);
        }    }
}
