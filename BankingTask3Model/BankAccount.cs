using System;

namespace BankingTask3Model
{
    public class BankAccount
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public long AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }  

        /// <summary>
        /// This constructor is use to collect the following
        /// </summary>
        /// <param name="id"></param>
        /// <param name="initialBalance"></param>
        /// <param name="acctType"></param>
        /// <param name="accountNumber"></param>
        /// <param name="accountName"></param>
        public BankAccount(int id ,decimal initialBalance, string acctType, long accountNumber, 
            string accountName)
        {
            Id = id;
            Balance = initialBalance;
            AccountType = acctType;
            AccountNumber = accountNumber;
            AccountName = accountName;
        }
    }
}
