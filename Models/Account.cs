﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalagring_BankRUs_EFCore.Models
{
    class Account
    {
        public int Id { get; protected set; }
        public string AccountNumber { get; protected set; }
        public decimal Balance { get; protected set; }
        public int CustomerId { get; protected set; }
        public Customer Customer { get; protected set; }

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if (amount > Balance)

                throw new ArgumentException("Amount is greater the balance");

            Balance -= amount;
        }
    }
}
