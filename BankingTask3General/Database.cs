﻿using BankingTask3Model;
using System.Collections.Generic;

namespace BankingTask3General
{
    public class Database
    {
        public static List<Customer> customerList = new List<Customer>();
        public static List<BankAccount> accountList = new List<BankAccount>();
        public static List<Transactions> transactionsList = new List<Transactions>();
    }
}
