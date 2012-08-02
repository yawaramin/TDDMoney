using NUnit.Framework;

namespace TDDMoney {
  [TestFixture]
  class With_a_Dollar {
    [Test]
    public void Test_multiplication() {
      Dollar five = new Dollar(5);
      
      Assert.AreEqual(new Dollar(10), five.Times(2));
      Assert.AreEqual(new Dollar(15), five.Times(3));
    }

    [Test]
    public void Test_equality() {
      Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
      Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
    }
  }

  [TestFixture]
  class With_a_Franc {
    [Test]
    public void Test_multiplication() {
      Franc five = new Franc(5);

      Assert.AreEqual(new Franc(10), five.Times(2));
      Assert.AreEqual(new Franc(15), five.Times(3));
    }

    [Test]
    public void Test_equality() {
      Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
      Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
    }
  }
}
