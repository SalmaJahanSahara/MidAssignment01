﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;

        public Bank(string name, int size)
        {
            this.bankName = name;
            myBank = new Account[size];
        }

        public string Name
        {
            set { this.Name = value; }
            get { return this.Name; }
        }
        public Account[] Accounts //returning the array
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }
        public void PrintAccountDetails()
        {
            for(int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
            }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(int accountNumber)
        {
            int flag =0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if(myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].ShowAccountInformation();
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
        public void Transaction()
        {

        }
    }
}
