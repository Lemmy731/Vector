using System;
using BankingTask3General;
using BankingTask3Model;

namespace BankingTask3UI
{
    public class PrintTable
    {
        static int tableWidth = 100;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void PrintTableForAccountDetails(string name)
        {
            Console.Clear();
            PrintLine();
            PrintRow("FULL NAME", "ACCOUNT NUMBER", "ACCOUNT TYPE", "AMOUNT BALANCE");
            //PrintLine();
            foreach(BankAccount account in Database.accountList)
            {
                PrintLine();
                if (account.AccountName == name)
                {
                    PrintRow(account.AccountName, account.AccountNumber.ToString(), 
                        account.AccountType, account.Balance.ToString());
                }
            }
            PrintLine();
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber"></param>
        public void PrintTableForAccountStatement(long accountNumber)
        {
            Console.Clear();
            PrintLine();
            PrintRow("DATE", "DESCRIPTION ", "AMOUNT", "BALANCE");
            foreach (Transactions transactions in Database.transactionsList)
            {
                PrintLine();
                if (transactions.AccountNumber == accountNumber)
                {
                    PrintRow(transactions.DateTime, transactions.Description,
                        transactions.Amount.ToString(), transactions.Balance.ToString());
                }
            }
            PrintLine();
            Console.ReadLine();
        }

        private static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        private static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        private static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
