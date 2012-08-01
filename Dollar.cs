using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDMoney {
  class Dollar {
    public Dollar(int amount) {
      Amount = amount;
    }

    public Dollar Times(int multiplier) {
      return new Dollar(Amount * multiplier);
    }

    public override bool Equals(object o) {
      return Amount == ((Dollar)o).Amount;
    }

    public int Amount { get; set; }

    static void Main() {
    }
  }
}
