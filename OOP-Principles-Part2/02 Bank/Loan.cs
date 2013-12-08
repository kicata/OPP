using System;
using System.Linq;


namespace Bank
{
    class Loan:Account,IDeposit
    {
        public Loan(string customerID, Customer client, decimal balance, decimal interestRate, int periodInMonts)
            : base(customerID, client, balance, interestRate, periodInMonts)
        {
        }
        //methods
        public void DepositMoney(decimal amount)
        {
            decimal balance = this.Balance;
            balance += amount;
            this.Balance = balance;
        }

        public override decimal CalculateInterest(Customer client)
        {
            int numOfMonts = this.PeriodInMonts;
            if (client == Customer.Individual)
            {
                numOfMonts -= 3;
            }
            else
            {
                numOfMonts -= 2;
            }
            decimal interest = numOfMonts * this.InterestRate;
            return interest;
        }
    }
}
