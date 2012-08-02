namespace TDDMoney {
  class Dollar : Money {
    public Dollar(int amount) {
      m_amount = amount;
    }

    public override Money Times(int multiplier) {
      return new Dollar(m_amount * multiplier);
    }
  }
}
