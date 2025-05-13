namespace oopC_
{
    public class Transaction: IComparable<Transaction>
    {
        public required decimal Amount { get; set; }
        public required DateTime Date { get; set; }

        public int CompareTo(Transaction? other)
        {
            if (other == null) return -1;
            return -Amount.CompareTo(other.Amount);
        }
    }
}