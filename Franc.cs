namespace TDDMoney {
  class Franc : Money {
    public Franc(int amount) {
      m_amount = amount;
    }

    public Franc Times(int multiplier) {
      return new Franc(m_amount * multiplier);
    }
  }
}
