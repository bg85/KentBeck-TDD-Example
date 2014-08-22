﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            _amount = amount;
        }

        public override Money times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override string currency()
        {
            return "CHF";
        }
    }
}
