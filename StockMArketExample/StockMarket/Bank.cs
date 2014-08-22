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
            return source.reduce(this, to);
        }

        public int rate(String from, String to)
        {
            return (from.Equals("CHF") & to.Equals("USD"))
                ? 2
                : 1;
        }
    }
}
