namespace TDDMoney {
  class Franc {
    public Franc(int amount) {
      m_amount = amount;
    }

    public Franc Times(int multiplier) {
      return new Franc(m_amount * multiplier);
    }

    public override bool Equals(object o) {
      return m_amount == ((Franc)o).m_amount;
    }

    private int m_amount;
  }
}
