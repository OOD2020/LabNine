/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Lab Nine 2020
 * 
 * ############################# */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNine;

namespace UnitTestProject1
{
    [TestClass]
    public class UNIT_TEST_1
    {
        [TestMethod]
        public void TestDeposit()
        {
            //ARRANGE - set up 
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 200m;

            //ACT - run the code 
            acc1.Deposit(200m);
            //ASSERT - check the results
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestMultipleDeposits()
        {
            //ARRANGE - set up 
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 200m;

            //ACT - run the code 
            acc1.Deposit(100m);
            acc1.Deposit(60m);
            acc1.Deposit(40m);
            //ASSERT - check the results
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }

        [TestMethod]
        public void TestNewAccountHasZeroBalance()
        {
            //ARRANGE - set up 
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 0m;

            //ACT - run the code 

            //ASSERT - check the results
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestWithdraw_Sufficient_Funds()
        {
            //ARRANGE - set up 
            BankAccount acc1 = new BankAccount();
            acc1.Deposit(200m);
            decimal expectedBalance = 100m;

            //ACT - run the code 
            acc1.Withdraw(100m);
            //ASSERT - check the results
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void Test_WithdrawInsufficient_Funds()
        {
            //ARRANGE - set up 
            BankAccount acc1 = new BankAccount();
            acc1.Deposit(100m);
            decimal expectedBalance = 100m;

            //ACT - run the code 
            acc1.Withdraw(100m);
            //ASSERT - check the results
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void Test_Withdraw_Sufficient_Funds_with_Overdraft()
        {

            //ARRANGE - set up 
            BankAccount acc1 = new BankAccount();
            acc1.OverdraftLimit = 200m;
            decimal expectedBalance = -100m;

            //ACT - run the code 
            acc1.Withdraw(100m);
            //ASSERT - check the results
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void Test_Withdraw_Insufficient_Funds_with_Overdraft()
        {

            //ARRANGE - set up 
            BankAccount acc1 = new BankAccount();
            acc1.OverdraftLimit = 200m;
            decimal expectedBalance = 0m;

            //ACT - run the code 
            acc1.Withdraw(300m);
            //ASSERT - check the results
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
    }
}
