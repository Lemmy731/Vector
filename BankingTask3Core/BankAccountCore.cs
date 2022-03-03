using BankingTask3General;
using BankingTask3Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingTask3Core
{
    public class BankAccountCore
    {
        private int id = 100;
         string description = "Amount deposited after opening of account";
        string transactionType = AccountType.TransactionType.Deposit.ToString();

        /// <summary>
        /// Creates account for customer
        /// </summary>
        /// <param name="accountName"></param> 
        /// <param name="initialBalance"></param>
        /// <param name="accountType"></param>
        /// <returns></returns>
        public void CreateBankAccount(string accountName, decimal initialBalance, string accountType,
            long accountNumber)
        {
            BankAccount bankAccount = new BankAccount(id, initialBalance, accountType,
                accountNumber, accountName);
            Database.accountList.Add(bankAccount);
            Transactions transactions = new Transactions(initialBalance, initialBalance, description,
                DateTime.Now.ToString(), transactionType, accountNumber);
            Database.transactionsList.Add(transactions);
            id++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetAccountType(string name)
        {
            foreach (BankAccount bankAccount in Database.accountList)
            {
                if (bankAccount.AccountName==name)
                {
                    return bankAccount.AccountType;
                }
            }
            return "No AccountType for this user";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public long GetAccountNumberByName(string name)
        {
            foreach (BankAccount bankAccount in Database.accountList)
            {
                if (bankAccount.AccountName == name)
                {
                    return bankAccount.AccountNumber;
                }
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public bool CheckAccountNumberIfExists(long accountNumber)
        {
            foreach (BankAccount bankAccount in Database.accountList)
            {
                if (bankAccount.AccountNumber == accountNumber)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <param name="accountNumber"></param>
        public void MakeWithdraw(string transactionType, decimal amount,
            string description, long accountNumber)
        {
            decimal Balance=0;
            foreach (var bankAccount in Database.accountList)
            {
                if(bankAccount.AccountNumber == accountNumber)
                {
                    Balance = bankAccount.Balance - amount;
                    bankAccount.Balance=Balance;
                }
            }
            Transactions transactions = new Transactions(amount,Balance,description,
                DateTime.Now.ToString(), transactionType, accountNumber);
            Database.transactionsList.Add(transactions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <param name="accountNumber"></param>
        public void MakeDeposit(string transactionType, decimal amount,
            string description, long accountNumber)
        {
            decimal Balance = 0;
            foreach (var bankAccount in Database.accountList)
            {
                if (bankAccount.AccountNumber == accountNumber)
                {
                    Balance = bankAccount.Balance + amount;
                    bankAccount.Balance = Balance;
                }
            }
            Transactions transactions = new Transactions(amount, Balance, description,
                DateTime.Now.ToString(), transactionType, accountNumber);
            Database.transactionsList.Add(transactions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <param name="debitAccountNumber"></param>
        /// <param name="creditAccountNumber"></param>
        public void MakeTransfer(string transactionType, decimal amount,
            string description, long debitAccountNumber, long creditAccountNumber)
        {
            decimal Balance = 0;
            foreach (var bankAccount in Database.accountList)
            {
                if (bankAccount.AccountNumber == debitAccountNumber)
                {
                    Balance = bankAccount.Balance + amount;
                    bankAccount.Balance = Balance;
                }
            }
            Transactions transactions = new Transactions(amount, Balance, description,
                DateTime.Now.ToString(), transactionType, debitAccountNumber);
            Database.transactionsList.Add(transactions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public decimal GetBalance(long accountNumber)
        {
            foreach (BankAccount bankAccount in Database.accountList)
            {
                if (bankAccount.AccountNumber == accountNumber)
                {
                    return bankAccount.Balance;
                }
            }
            return 0;
        }
    }
}
