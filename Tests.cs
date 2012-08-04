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

    [Test]
    public void Plus_should_return_Sum() {
      Money five = Money.Dollar(5);
      IExpression result = five.Plus(five);
      Sum sum = (Sum)result;
      Assert.AreEqual(five, sum.Augend);
      Assert.AreEqual(five, sum.Addend);
    }

    [Test]
    public void Test_reduce_Sum() {
      IExpression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
      Bank bank = new Bank();
      Money result = bank.Reduce(sum, "USD");
      Assert.AreEqual(Money.Dollar(7), result);
    }

    [Test]
    public void Test_reduce_Money() {
      Bank bank = new Bank();
      Money result = bank.Reduce(Money.Dollar(1), "USD");
      Assert.AreEqual(Money.Dollar(1), result);
    }
  }
}
