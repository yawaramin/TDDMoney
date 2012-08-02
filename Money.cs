namespace TDDMoney {
  abstract class Money {
    public Money(int amount, string currency) {
      m_amount = amount;
      m_currency = currency;
    }

    public override bool Equals(object o) {
      Money money = (Money)o;

      return m_amount == money.m_amount &&
        GetType() == money.GetType();
    }

    public abstract Money Times(int multiplier);

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
