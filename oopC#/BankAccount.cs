namespace oopC_
{
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreationDate { get; set; }
        public Employee Employee { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in Transactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }

        public BankAccount(string accountNumber, Customer customer, Employee employee)
        {
            AccountNumber = accountNumber;
            Customer = customer;
            CreationDate = DateTime.Now;
            Employee = employee;
            Transactions = [];
        }

        protected decimal getThreshold()
        {
            decimal threshold = 0;
            if (Customer is VipCustomer vipCustomer)
            {
                threshold = -vipCustomer.NegativeThreshold;
            }
            return threshold;
        }

        public virtual void Operate(decimal amount)
        {


            if (Balance + amount >= getThreshold())
            {
                Transaction transaction = new Transaction
                {
                    Amount = amount,
                    Date = DateTime.Now
                };
                Transactions.Add(transaction);
            }



        }

        public string generateReport()
        {
            string report = "Account Number: " + AccountNumber + "\n";
            report += "Customer: " + Customer.ToString() + "\n";
            report += "Creation Date: " + CreationDate.ToString("dd/MM/yyyy") + "\n";
            report += "Employee: " + Employee.ToString() + "\n";
            report += "Balance: " + Balance.ToString("C") + "\n";
            report += "Transactions:\n";
            foreach (var transaction in Transactions)
            {
                report += transaction.Date.ToString("dd/MM/yyyy") + ": " + transaction.Amount.ToString("C") + "\n";
            }
            return report;
        }
    }
}
