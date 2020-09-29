using System;

namespace WerkcollegeTweeLib
{
    public class Account
    {
        public Account(string iBAN, double balance, double interest)
        {
            this.iban = iBAN;
            this.balance = balance;
            this.creationDate = DateTime.Now;
            this.interest = interest;
        }

        private string iban { get; set; }
        private double balance { get; set; }
        private DateTime creationDate { get; set; }
        private double interest { get; set; }

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if ((balance - amount) > -1000)
            {
                balance -= amount;
            }
            else
            {
                throw new Exception("Balance too low, maximum overdraft of 1000");
            }

        }

        public override string ToString()
        {
            return $"Account: { iban } with balance { balance } generating { interest }% interest made on { creationDate }";
        }

    }
}
