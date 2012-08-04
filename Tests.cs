using NUnit.Framework;

namespace TDDMoney {
  [TestFixture]
  class With_currencies {
    [Test]
    public void Test_currency_name() {
      Assert.AreEqual("USD", Money.Dollar(1).Currency);
      Assert.AreEqual("CHF", Money.Franc(1).Currency);
    }

    [Test]
    public void Test_multiplication() {
      Money dollarFive = Money.Dollar(5);
      
      Assert.AreEqual(Money.Dollar(10), dollarFive.Times(2));
      Assert.AreEqual(Money.Dollar(15), dollarFive.Times(3));
    }

    [Test]
    public void Test_equality() {
      Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
      Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
      Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
    }

    [Test]
    public void Test_simple_addition() {
      Bank bank = new Bank();
      Money five = Money.Dollar(5);
      IExpression sum = five.Plus(five);
      Money reduced = bank.Reduce(sum, "USD");

      Assert.AreEqual(Money.Dollar(10), reduced);
    }
  }
}
