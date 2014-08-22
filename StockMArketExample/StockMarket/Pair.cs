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

        public override bool Equals(object obj)
        {
            Pair pair = (Pair) obj;
            return _from.Equals(pair._from) & _to.Equals(pair._to);
        }

        public override int GetHashCode()
        {
            return _from.Length + _to.Length;
        }

        public int hashCode()
        {
            return 0;
        }
    }
}
