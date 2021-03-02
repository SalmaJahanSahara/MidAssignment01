using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Bank
    {
        private string bankName;
        private Account[] accounts;

        public Bank(string name, int size)
        {
            this.bankName = name;
            accounts = new Account[size];
        }

        public string Name
        {
            set { this.Name = value; }
            get { return this.Name; }
        }
        public Account[] Accounts //returning the array
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }
        public void PrintAccountDetails()
        {
            for(int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].ShowAccountInformation();
            }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
        public void RemoveAccount(int accountNumber)
        {
            int flag =0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if(accounts[i].AccountNumber == accountNumber)
                {
                    accounts[i].ShowAccountInformation();
                    flag = 0;
                    break;
                }
                else 
                {
                    flag = 1;
                }

                //accounts[i].ShowAccountInformation();
            }
            if (flag == 1)
                Console.WriteLine("Account Not Found");
        }
    }
}
