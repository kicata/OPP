using System;
using System.Linq;


namespace Bank
{
    class Deposit:Account,IDeposit
    {

        //Constructor
        public Deposit(string customerID, Customer client, decimal balance, decimal interestRate, int periodInMonts)
            : base(customerID, client, balance, interestRate, periodInMonts)
        {
        }
        //Methods
        public void DepositMoney(decimal amount)
        {
            decimal balance = this.Balance;
            balance += amount;
            this.Balance = balance;
        }
        public void WithDrawMoney(decimal amount)
        {
            decimal balance = this.Balance;
            balance -= amount;
            this.Balance = balance;
        }
        public  override decimal CalculateInterest(Customer client)
        {
            decimal balance = this.Balance;
            if (balance>0 && balance<1000)
            {
                return 0;
            }
            else
            {
                int numOfMonts = this.PeriodInMonts;

                decimal interest = numOfMonts * this.InterestRate;

                return interest;
            }

        }
    }
}
