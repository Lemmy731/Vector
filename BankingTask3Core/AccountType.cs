

namespace BankingTask3Core
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountType
    {
        public enum accountType
        {
            Savings = 1000,
            Current = 0
        }
        
        public enum TransactionType
        {
            Deposit,
            Withdraw,
            Transfer
        }
    }
}
