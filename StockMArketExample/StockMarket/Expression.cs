using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public interface Expression
    {
        Money reduce(Bank bank, String to);
        Expression plus(Expression addend);    }
}
