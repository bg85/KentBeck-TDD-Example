﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Franc : Money
    {
        private int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc franc = (Franc)obj;
            return _amount == franc._amount;
        }
    }
}
