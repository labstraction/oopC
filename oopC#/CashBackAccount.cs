using oopC_;

internal class CashBackAccount: BankAccount
{

    public CashBackAccount(string v, Customer c3, Employee e1): base(v, c3, e1)
    {
    }

    public override void Operate(decimal amount)
    {
        if (Balance + amount > getThreshold())
        {
            decimal cashback = amount * 0.05m;
            Transaction transaction = new Transaction
            {
                Amount = cashback,
                Date = DateTime.Now
            };
            Transactions.Add(transaction);
            base.Operate(amount);
        }

    }

}