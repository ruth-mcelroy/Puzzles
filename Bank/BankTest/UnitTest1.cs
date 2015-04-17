using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Accounts;



namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void WithdrawalUpdatesBalance()
        {
           
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount b1 = new BankAccount("0223", beginningBalance, 0);

           
            b1.Withdrawal(debitAmount);

            double actual = b1.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }


        [TestMethod]
        public void DepositUpdatesBalance()
        {

            double beginningBalance = 11.99;
            double depositAmount = 4.55;
            double expected = 16.54;
            BankAccount b1 = new BankAccount("0223", beginningBalance, 0);


            b1.Deposit(depositAmount);

            double actual = b1.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void ExceptionOverdraftExceeded()
        {
            double beginningBalance = 0;
            double overdraftLimit = 10.50;
            double withdrawalAmount = 21.00;
            BankAccount b1 = new BankAccount("1231", beginningBalance, overdraftLimit);

            b1.Withdrawal(withdrawalAmount);
        }

        [TestMethod]
        public void TransactionCountMatchTransactionHistory()
        {
            int expectedTransactionCount = 5;
            double expectedBalance = 5.0;
            BankAccount b1 = new BankAccount("0000");

            for(int i = 0; i<5; i++)
            {
                b1.Deposit(1);
            }

            Assert.AreEqual(expectedTransactionCount, b1.TransactionHistoryCount);
            Assert.AreEqual(expectedBalance, b1.Balance);
        }
    }
}
