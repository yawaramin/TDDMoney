namespace TDDMoney {
  class Money {
    public override bool Equals(object o) {
      return m_amount == ((Money)o).m_amount;
    }

    protected int m_amount;
  }
}
