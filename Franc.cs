namespace TDDMoney {
  class Franc : Money {
    public Franc(int amount) : base(amount, "CHF") {}

    public override Money Times(int multiplier) {
      return Money.MakeFranc(m_amount * multiplier);
    }
  }
}
