namespace TDDMoney {
  class Money {
    public Money(int amount, string currency) {
      m_amount = amount;
      m_currency = currency;
    }

    public override string ToString() {
      return m_currency + " " + m_amount;
    }

    public override bool Equals(object o) {
      Money money = (Money)o;

      return m_amount == money.m_amount &&
        m_currency == money.m_currency;
    }

    public Money Times(int multiplier) {
      return new Money(m_amount * multiplier, m_currency);
    }

    public string Currency {
      get {
        return m_currency;
      }
    }

    public static Money MakeDollar(int amount) {
      return new Dollar(amount);
    }

    public static Money MakeFranc(int amount) {
      return new Franc(amount);
    }

    protected int m_amount;
    protected string m_currency;
  }
}
