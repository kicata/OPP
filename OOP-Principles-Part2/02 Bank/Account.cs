using System;
using System.Linq;


namespace Bank
{
    public enum Customer
    { 
        Individual, Company
    }

    public abstract class Account
    {
        //Fields
        private decimal balance;
        private decimal interestRate;
        private Customer client;
        private int periodInMonts;
        private string  customerID;

        public string  CustomerID
        {
           get
            {
                return customerID;
            }
            protected set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                customerID = value;
            }
        }

        public int PeriodInMonts
        {
            get
            {
                return periodInMonts;
            }
            protected set
            {
                if (periodInMonts <= 0)
                {
                    throw new ArgumentException("periodInMonts must be > 0 ");
                }
                periodInMonts = value;
            }
        }
        //Property
        public Customer Client
        {
            get { return client; }
            set { client = value; }
        }
        public decimal  InterestRate
        {
            get
            {
                return interestRate;
            }
            protected set
            {
                if (interestRate <= 0)
                {
                    throw new ArgumentException("interestRate must be > 0 ");
                }
                interestRate = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            protected set
            {
                if (balance <= 0)
                {
                    throw new ArgumentException("interestRate must be > 0 ");
                }
                balance = value;
            }
        }
        //Constructor
        public Account(string customerID, Customer client, decimal balance, decimal interestRate, int periodInMonts)
        {
            this.CustomerID = customerID;
            this.client = client;
            this.balance = balance;
            this.interestRate = interestRate;
            this.periodInMonts = periodInMonts;

        }

        public abstract decimal CalculateInterest(Customer client);
        public override string ToString()
        {
            return "Account: " + customerID + "\nType:" + client + "\naccountBalance: "
                + balance+"lv." + "\nIntRate: " + interestRate+"%" + "\nPeriod: " + periodInMonts+" monts";
                
        }
        
    }
}
