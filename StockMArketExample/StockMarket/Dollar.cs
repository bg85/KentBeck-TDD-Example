﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Dollar
    {
        private int _amount;
        public int amount {
            get { return _amount; }
            set { _amount = value; }
        }

        public Dollar(int amount)
        {
        }

        public void times(int multiplier)
        {
            _amount = 5*2;
        }
    }
}