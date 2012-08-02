using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDMoney {
  class Dollar {
    public Dollar(int amount) {
      m_amount = amount;
    }

    public Dollar Times(int multiplier) {
      return new Dollar(m_amount * multiplier);
    }

    public override bool Equals(object o) {
      return m_amount == ((Dollar)o).m_amount;
    }

    private int m_amount;

    static void Main() {
    }
  }
}
