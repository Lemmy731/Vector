using System;
using System.Text.RegularExpressions;

namespace BankingTask3General
{
    public class Validation
    {
        private string NameRegex = @"^[A-Z]{1}[A-Za-z]{2,}$";
        private string PhoneRegex = @"^[0-9]{11}$";
        private string PasswordRegex = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
        private string EmailRegex = @"^[A-Za-z0-9]+[.+-_]{0,1}[A-Za-z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckNameInput(string name)
        {
            return Regex.IsMatch(name, NameRegex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckPasswordInput(string password)
        {
            bool ret =  Regex.IsMatch(password, PasswordRegex);
            return ret; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckEmailInput(string name)
        {
            return Regex.IsMatch(name, EmailRegex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public bool CheckPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.ToString().Length < 11 || phoneNumber.ToString().Length > 11)
                return false;
            return Regex.IsMatch(phoneNumber, PhoneRegex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public (bool isDecimal, decimal Amount) CheckAmount(string amount)
        {
            return (decimal.TryParse(amount, out decimal value),value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public (bool isLong, long Account) CheckAccountNumber(string account)
        { 
            return (long.TryParse(account, out long value), value);
        }
    }
}
