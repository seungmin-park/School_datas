using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_201844050_박승민
{
    class Account
    {
        bool Active
        {
            get;
            set;
        }

        long Balance
        {
            get;
            set;
        }

        string Customer
        {
            get;
            set;
        }

        string Number
        {
            get;
            set;
        }

        DateTime OpenDate
        {
            get;
            set;
        }

        public Account(string number, string customer, long balance)
        {
            this.Number = number;
            this.Customer = customer;
            this.Balance = balance;
        }

        public bool Deposit(long money)
        {
            return false;
        }

        public virtual bool Expire(out long money)
        {
            money = 0;
            return false;
        }

        public string Info()
        {
            return string.Empty;
        }

        public virtual bool Withdraw(long money)
        {
            return false;
        }
    }
}
