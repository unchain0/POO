#pragma warning disable CS8618

using _146._Exercício_proposto__exceções_.Entities.AccountExceptions;

namespace _146._Exercício_proposto__exceções_.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new AccountException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
