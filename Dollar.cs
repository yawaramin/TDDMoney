namespace TDDMoney {
  class Dollar : Money {
    public Dollar(int amount) : base(amount, "USD") {}

    public override Money Times(int multiplier) {
      return Money.MakeDollar(m_amount * multiplier);
    }
  }
}
