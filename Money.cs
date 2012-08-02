namespace TDDMoney {
  abstract class Money {
    public override bool Equals(object o) {
      Money money = (Money)o;

      return m_amount == money.m_amount &&
        GetType() == money.GetType();
    }

    public abstract Money Times(int multiplier);

    public static Money MakeDollar(int amount) {
      return new Dollar(amount);
    }

    public static Money MakeFranc(int amount) {
      return new Franc(amount);
    }

    protected int m_amount;
  }
}
