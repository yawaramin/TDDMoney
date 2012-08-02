using NUnit.Framework;

namespace TDDMoney {
  [TestFixture]
  class With_currencies {
    [Test]
    public void Test_multiplication() {
      Dollar dollarFive = new Dollar(5);
      
      Assert.AreEqual(new Dollar(10), dollarFive.Times(2));
      Assert.AreEqual(new Dollar(15), dollarFive.Times(3));

      Franc francFive = new Franc(5);

      Assert.AreEqual(new Franc(10), francFive.Times(2));
      Assert.AreEqual(new Franc(15), francFive.Times(3));
    }

    [Test]
    public void Test_equality() {
      Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
      Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));

      Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
      Assert.IsFalse(new Franc(5).Equals(new Franc(6)));

      Assert.IsFalse(new Franc(5).Equals(new Dollar(5)));
    }
  }
}
