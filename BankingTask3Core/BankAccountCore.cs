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
        private static string description = "Amount deposited after opening of account";
        private static string transactionType = "deposit";

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
            Transactions transactions = new Transactions(initialBalance, initialBalance,
                DateTime.Now.ToString(),description,transactionType,accountNumber);
            Database.accountList.Add(bankAccount);
            Database.transactionsList.Add(transactions);
            id++;
        }

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
    }
}
