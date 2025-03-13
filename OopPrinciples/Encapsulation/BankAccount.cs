using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OopPrinciples.Encapsulation
{
    class BankAccount
    {
        private decimal balance;


        public BankAccount([Optional] decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance
        {
            get => balance;

            set => balance = value >= 0 ? value : throw new ArgumentException("Value cannot be negative");
        }

        public void Deposit(decimal amount)
        {
            if (amount<=0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }

            this.balance += amount; 
        }

        public void withDraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            else if (amount > this.balance)
            {
                throw new InvalidOperationException("Insufficient funds");

            }

            this.balance -= amount;
        }


    }
}
