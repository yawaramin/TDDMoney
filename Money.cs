namespace TDDMoney {
  class Money : IExpression {
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

    public static Money Dollar(int amount) {
      return new Money(amount, "USD");
    }

    public static Money Franc(int amount) {
      return new Money(amount, "CHF");
    }

    public IExpression Plus(Money addend) {
      return new Money(m_amount + addend.m_amount, m_currency);
    }

    protected int m_amount;
    protected string m_currency;
  }
}
