using System;
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
    }
}
