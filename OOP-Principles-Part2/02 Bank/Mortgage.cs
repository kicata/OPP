using System;
using System.Linq;

namespace Bank
{
    class Mortgage:Account,IDeposit
    {
        //constructor
        public Mortgage(string customerID, Customer client, decimal balance, decimal interestRate, int periodInMonts)
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
            decimal numOfMonts=this.PeriodInMonts;
            if (client == Customer.Individual)
            {
                numOfMonts -= 6;
            }
            else
            {
                if (numOfMonts>12)
                {
                    //more than 12 monts mortgage
                    decimal currentNumOfMonts = 0;
                    for (int i = 1; i <= numOfMonts; i++)
                    {
                        if (i<=12)
                        {
                            currentNumOfMonts += 0.5m; 
                        }
                        currentNumOfMonts++;
                    }
                    numOfMonts = currentNumOfMonts;
                }
                else
                {
                    //only 1 year mortgage
                    numOfMonts /= 2;
                }
               
            }
            decimal interest= numOfMonts * this.InterestRate;
            
            return interest;
        }

    }
}
