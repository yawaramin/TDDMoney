using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TDDMoney {
  [TestFixture]
  class With_a_Dollar {
    [Test]
    public void Test_multiplication() {
      Dollar five = new Dollar(5);
      Dollar product = five.Times(2);
      
      Assert.AreEqual(10, product.Amount);
      product = five.Times(3);
      Assert.AreEqual(15, product.Amount);
    }

    [Test]
    public void Test_equality() {
      Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
      Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
    }
  }
}
