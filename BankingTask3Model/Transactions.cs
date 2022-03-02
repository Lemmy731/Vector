using System;
namespace BankingTask3Model
{
    public class Transactions
    {
        public int Id { get; set; }
        public decimal Amount{ get; set; }
        public long AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Description { get; set; }
        public string DateTime { get; set; }
        public string TransactionType { get; set; } 

        public Transactions(decimal amount,decimal balance,string description,
            string dateTime,string transactionType,long accountNumber)
        {
            Amount = amount;
            Balance = balance;
            Description = description;
            DateTime = dateTime;
            TransactionType = transactionType;
            AccountNumber = accountNumber;
        }
        
    }
}
