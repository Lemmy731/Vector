

namespace BankingTask3Core
{
    public class AccountType
    {
        /// <summary>
        /// The enum for account type
        /// </summary>
        public enum accountType
        {
            Savings = 1000,
            Current = 0
        }
        
        /// <summary>
        /// 
        /// </summary>
        public enum TransactionType
        {
            Deposit,
            Withdraw,
            Transfer
        }
    }
}
