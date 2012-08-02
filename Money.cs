namespace TDDMoney {
  class Money {
    public override bool Equals(object o) {
      Money money = (Money)o;

      return m_amount == money.m_amount &&
        GetType() == money.GetType();
    }

    protected int m_amount;
  }
}
