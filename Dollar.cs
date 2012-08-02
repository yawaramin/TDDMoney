namespace TDDMoney {
  class Dollar : Money {
    public Dollar(int amount) {
      m_amount = amount;
    }

    public Dollar Times(int multiplier) {
      return new Dollar(m_amount * multiplier);
    }
  }
}
