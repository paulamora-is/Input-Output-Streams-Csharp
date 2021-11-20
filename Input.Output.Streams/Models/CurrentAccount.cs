using System;
using System.Collections.Generic;
using System.Text;

namespace Input.Output.Streams.Models
{
    public class CurrentAccount
    {
        public int NumberAccount { get; }
        public int Branch { get; }
        public double Balance { get; private set; }
        public Client Holder { get; set; }

        public CurrentAccount(int branch, int numberAccount)
        {
            Branch = branch;
            NumberAccount = numberAccount;
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.", nameof(value));
            }

            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Cashout amount must be greater than zero.", nameof(value));
            }

            if (value > Balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }

            Balance += value;
        }
    }
}
