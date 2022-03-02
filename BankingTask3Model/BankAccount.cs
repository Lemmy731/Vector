using System;

namespace BankingTask3Model
{
    public class BankAccount
    {
        public int Id { get; set; }
        public decimal InitialBalance { get; set; }
        public long AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }  

        public BankAccount(int id ,decimal initialBalance, string acctType, long accountNumber, 
            string accountName)
        {
            Id = id;
            InitialBalance = initialBalance;
            AccountType = acctType;
            AccountNumber = accountNumber;
            AccountName = accountName;
        }
    }
}
