using System;
using BankingTask3Model;
using BankingTask3General;
namespace BankingTask3Core
{
    public class TransactionCore
    {
        private long CreditAccountNumber;
        public void MakeWithdraw(string transactionType,decimal amount,
            string description,long accountNumber)
        {
            Transactions transactions =new Transactions(amount,-amount,description,
                DateTime.Now.ToString(),transactionType,accountNumber);
            Database.transactionsList.Add(transactions);
        }

        public void MakeDeposit(string transactionType, decimal amount,
            string description, long accountNumber)
        {
            Transactions transactions = new Transactions(amount, +amount, description,
                DateTime.Now.ToString(), transactionType,accountNumber);
            Database.transactionsList.Add(transactions);
        }

        public void MakeTransfer(string transactionType, decimal amount,
            string description, long debitAccountNumber,long creditAccountNumber)
        {
            CreditAccountNumber = creditAccountNumber;
            Transactions transactions = new Transactions(amount, -amount, description,
                DateTime.Now.ToString(), transactionType, debitAccountNumber);
            Database.transactionsList.Add(transactions);
        }

        public decimal GetBalance(long accountNumber)
        {
            foreach (Transactions transaction in Database.transactionsList)
            {
                if (transaction.AccountNumber == accountNumber)
                {
                    return transaction.Balance;
                }
            }
            return 0;
        }
    }
}
