using System;
using System.Collections.Generic;
using System.Linq;
/*
 A bank holds different types of accounts for its customers: deposit accounts, 
 * loan accounts and mortgage accounts. Customers could be individuals or companies.
 * All accounts have customer, balance and interest rate (monthly based).
 * Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
 * All accounts can calculate their interest amount for a given period (in months). 
 * In the common case its is calculated as follows: number_of_months * interest_rate.
 * Loan accounts have no interest for the first 3 months if are held by individuals
 * and for the first 2 months if are held by a company.
 * Deposit accounts have no interest if their balance is positive and less than 1000.
 * Mortgage accounts have ½ interest for the first 12 months for companies and no interest 
 * for the first 6 months for individuals.Your task is to write a program to model the bank system by 
 * classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions
 * and implement the calculation of the interest functionality through overridden methods.
 */
namespace Bank
{
    class BankTest
    {
        static void Main()
        {
            //testing Deposit and with draw methods
            Deposit deposit1 = new Deposit("Pencho", Customer.Individual, 1200.00m, 6.80m, 36);
            Console.WriteLine(deposit1.ToString());
            deposit1.DepositMoney(900.00m);
            Console.WriteLine(deposit1.ToString());
            deposit1.WithDrawMoney(1800.00m);
            Console.WriteLine(deposit1.ToString());
            

            //creating an instance of all types account
            List<Account> bankAccounts = new List<Account>();
            bankAccounts.Add(new Deposit("Pencho", Customer.Individual, 800.00m, 6.80m, 12));
            bankAccounts.Add(new Deposit("Billa", Customer.Company, 12000.00m, 5.80m, 24));
            bankAccounts.Add(new Loan("Pitagor", Customer.Individual, 3000.00m, 5.80m, 48));
            bankAccounts.Add(new Loan("Demax", Customer.Company, 1000000.00m, 6.00m, 120));
            bankAccounts.Add(new Mortgage("Petrovi", Customer.Individual, 10000.00m, 6.78m, 120));
            bankAccounts.Add(new Mortgage("Nivea", Customer.Company, 100000.00m, 9.78m, 120));
            //Print input data
            foreach (var account in bankAccounts)
            {
                Console.WriteLine(account.GetType());
                Console.WriteLine("*************************");
                Console.WriteLine(account.ToString());
                Console.WriteLine("_________________________");
                Console.WriteLine();
            }
            //getInterest
            foreach (var account in bankAccounts)
            {
                Console.WriteLine(account.GetType());
                decimal interest = account.CalculateInterest(account.Client);
                Console.WriteLine("The interest of  {0}'s-account for {1} monts and interest rate {2} is {3} ",
                    account.CustomerID, account.PeriodInMonts, account.InterestRate,interest);
            }

        }
    }
}
