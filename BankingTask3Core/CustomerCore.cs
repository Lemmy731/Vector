using BankingTask3General;
using BankingTask3Model;

namespace BankingTask3Core
{
    public class CustomerCore
    {
        Customer customerInput;
        private int id = 001;
        public long accountNumber = 1211010120;
        private const string emptyList = "Empty storage please create account";
        private const string accountFound = "Account found";
        private const string accountNotFound = "Account not found please create account";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Login(string email,string password)
        {
            if (Database.customerList == null)
                return emptyList;
            else
            {
                var verify=Database.customerList.Exists(
                    user => user.Email == email && user.PassWord == password);
                if (verify)
                {
                    return accountFound;
                }
                else
                    return accountNotFound;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="acctType"></param>
        /// <param name="phoneNumber"></param>
        public void CustomerRegistration(string fullname, string email, string password,string acctType, string phoneNumber)
        {

            customerInput = new Customer(id,fullname,email, password, acctType, phoneNumber);
            Database.customerList.Add(customerInput);

            id++;
            accountNumber++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetName(string email,string password)
        {
            string name = string.Empty;
            foreach(var user in Database.customerList)
            {
                if(user.Email.Equals(email) && user.PassWord.Equals(password))
                {
                    name=user.FullName;
                }
            }
            return name;
        }
    }
}
