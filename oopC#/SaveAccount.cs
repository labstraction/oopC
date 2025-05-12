using oopC_;

internal class SaveAccount: BankAccount
{


    public SaveAccount(string v, Customer c2, Employee e1) : base(v, c2, e1)
    {
    }


    public override void Operate(decimal amount)
    {
        if (Balance + amount > getThreshold())
        {
            if (amount > 0)
            {
                decimal interest = amount * 0.02m;
                Transaction transaction = new Transaction
                {
                    Amount = interest,
                    Date = DateTime.Now
                };
                Transactions.Add(transaction);
            }
            else
            {
                decimal penalty = amount * 0.03m;
                Transaction transaction = new Transaction
                {
                    Amount = penalty,
                    Date = DateTime.Now
                };
                Transactions.Add(transaction);
            }
            base.Operate(amount);
        }
    }
}