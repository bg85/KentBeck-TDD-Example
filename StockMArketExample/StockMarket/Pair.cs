using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Pair
    {
        private string _from;
        private string _to;

        public Pair(string from, string to)
        {
            _from = from;
            _to = to;
        }

        public bool equals(object obj)
        {
            Pair pair = (Pair) obj;
            return _from.Equals(pair._from) & _to.Equals(pair._to);
        }

        public int hashCode()
        {
            return 0;
        }
    }
}
