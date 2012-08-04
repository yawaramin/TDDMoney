namespace TDDMoney {
  interface IExpression {
    Money Reduce(Bank bank, string to);
  }

  class Sum : IExpression {
    public Sum(Money augend, Money addend) {
      Augend = augend;
      Addend = addend;
    }

    public Money Reduce(Bank bank, string to) {
      int amount = Augend.Amount + Addend.Amount;
      return new Money(amount, to);
    }

    public Money Augend { get; set; }
    public Money Addend { get; set; }
  }
}
