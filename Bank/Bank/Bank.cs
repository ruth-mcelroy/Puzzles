using System;

namespace Accounts
{
    public class BankAccount
    {
        String accountNumber;
        static String sortCode = "99-34-01";
        double balance;
        double overdraftLimit; // private fields. initialised in constructor and refered to in methods
        String[] transactionHistory = new String[500];
        int transactionHistoryCount = 0;
        
        public String AccountNumber
        {
            get { return accountNumber; }
        }
        
        public String SortCode
        {
            get { return sortCode; }
        }
        
        public double Balance
        {
            get { return balance; }
        }
        public int TransactionHistoryCount
        {
            get { return transactionHistoryCount; }
        }
        public double OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }
        
        public BankAccount(String accountNumber, double balance, double overdraftLimit) //constructor
        {

            this.accountNumber = accountNumber;
            this.balance = balance;
            this.overdraftLimit = overdraftLimit;
        }
        public BankAccount(String accountNumber)
            : this(accountNumber, 0, 0)
        { }


        public override string ToString()
        {
            return "Sort Code: " + SortCode + "   Account Number: " + AccountNumber + "   Balance: " + Balance + "   Overdraft Limit: " + OverdraftLimit;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
            transactionHistory[transactionHistoryCount] = "Deposit: " + amount + "   New Balance: " + Balance;
            transactionHistoryCount++;
        }


        public void Withdrawal(double amount)
        {
            if ((balance - amount) < (0 - overdraftLimit))
            {
                throw new Exception("Your account balance is too low");
            }
            else
            {
                balance = balance - amount;
                transactionHistory[transactionHistoryCount] = "Withdrawal: " + amount + "   New Balance: " + balance;
                transactionHistoryCount++;
            }
        }



    }
}
