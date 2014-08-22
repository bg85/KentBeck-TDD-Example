using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Bank
    {
        private Hashtable rates = new Hashtable();
        
        public Money reduce(Expression source, String to)
        {
            return source.reduce(this, to);
        }

        public int rate(String from, String to)
        {
            int rate = (int)rates[new Pair(from, to)];
            return rate;        }

        public void addRate(String from, String to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }
    }
}
