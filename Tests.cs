using NUnit.Framework;

namespace TDDMoney {
  [TestFixture]
  class With_currencies {
    [Test]
    public void Test_currency_name() {
      Assert.AreEqual("USD", Money.MakeDollar(1).Currency);
      Assert.AreEqual("CHF", Money.MakeFranc(1).Currency);
    }

    [Test]
    public void Test_multiplication() {
      Money dollarFive = Money.MakeDollar(5);
      
      Assert.AreEqual(Money.MakeDollar(10), dollarFive.Times(2));
      Assert.AreEqual(Money.MakeDollar(15), dollarFive.Times(3));
    }

    [Test]
    public void Test_equality() {
      Assert.IsTrue(Money.MakeDollar(5).Equals(Money.MakeDollar(5)));
      Assert.IsFalse(Money.MakeDollar(5).Equals(Money.MakeDollar(6)));
      Assert.IsFalse(Money.MakeFranc(5).Equals(Money.MakeDollar(5)));
    }
  }
}
