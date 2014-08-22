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
            if (source.GetType() == typeof(Money)) return (Money) source;            Sum sum = (Sum)source;
            return sum.reduce(to);
        }    }
}
