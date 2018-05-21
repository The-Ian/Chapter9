using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
    }
}
