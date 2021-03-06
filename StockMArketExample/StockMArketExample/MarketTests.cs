﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StockMarket;

namespace StockMArketExample
{
    [TestFixture]
    public class MarketTests
    {
        [Test]
        public void testMultiplication()
        {
            var five = Money.dollar(5);
            Assert.IsTrue(Money.dollar(10).Equals(five.times(2)));
            Assert.IsTrue(Money.dollar(15).Equals(five.times(3)));
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.IsFalse(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.IsTrue(Money.franc(5).Equals(Money.franc(5)));
        }

        [Test]
        public void testFrancMultiplication()
        {
            var five = Money.franc(5);
            Assert.IsTrue(Money.franc(10).Equals(five.times(2)));
            Assert.IsTrue(Money.franc(15).Equals(five.times(3)));
        }

        [Test]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.dollar(1).currency());
            Assert.AreEqual("CHF", Money.franc(1).currency());
        }

        [Test]
        public void testDifferentClassEquality()
        {
            Assert.IsTrue(new Money(10, "CHF").Equals(new Franc(10, "CHF")));
        }

        [Test]
        public void testSimpleAddition()
        {
            Money five = Money.dollar(5);
            Expression sum = five.plus(five);
            Bank bank = new Bank();
            Money reduced = bank.reduce(sum, "USD");
            Assert.IsTrue(Money.dollar(10).Equals(reduced));
        }

        [Test]
        public void testPlusReturnsSum()
        {
            Money five = Money.dollar(5);
            Expression result = five.plus(five);
            Sum sum = (Sum)result;
            Assert.IsTrue(five.Equals(sum.augend));
            Assert.IsTrue(five.Equals(sum.addend));
        }

        [Test]
        public void testReduceSum()
        {
            Expression sum = new Sum(Money.dollar(3), Money.dollar(4));
            Bank bank = new Bank();
            Money result = bank.reduce(sum, "USD");
            Assert.IsTrue(Money.dollar(7).Equals(result));
        }

        [Test]
        public void testReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.reduce(Money.dollar(1), "USD");
            Assert.IsTrue(Money.dollar(1).Equals(result));
        }

        [Test]
        public void testReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Money result = bank.reduce(Money.franc(2), "USD");
            Assert.IsTrue(Money.dollar(1).Equals(result));
        }

        [Test]
        public void testIdentityRate()
        {
            Assert.AreEqual(1, new Bank().rate("USD", "USD"));
        }

        [Test]
        public void testMixedAddition()
        {
            var fiveBucks = Money.dollar(5);
            var tenFrancs = Money.franc(10);
            var bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Money result = bank.reduce(fiveBucks.plus(tenFrancs), "USD");
            Assert.IsTrue(Money.dollar(10).Equals(result));
        }

        [Test]
        public void testSumPlusMoney()
        {
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).plus(fiveBucks);
            Money result = bank.reduce(sum, "USD");
            Assert.IsTrue(Money.dollar(15).Equals(result));
        }

        [Test]
        public void testSumTimes()
        {
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).times(2);
            Money result = bank.reduce(sum, "USD");
            Assert.IsTrue(Money.dollar(20).Equals(result));
        }
    }
}
