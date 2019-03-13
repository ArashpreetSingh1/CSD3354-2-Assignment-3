using System;
using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Student Name:- Arashpreet Singh Student Id:- C0727466
//student Name:- Navjot Singh Gill Student Id:- C0726409
// CSD 3354 Section 2
//Assignment 3
//March 13-2019

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    { 
       [TestMethod]
       public void Debit_WithValidAmount_UpdateBalance()
       {
             //Arrange
             double beginningBalance = 11.99;
             double debitAmount = 4.55;
             double expected = 7.44;
             BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

             //Act
             account.Debit(debitAmount);
             //aaa
             //Assert
             double actual = account.Balance;
             Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
       }
    
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 10.00;
            BankAccount account = new BankAccount("MR. Bryan Walton", beginningBalance);
            account.Debit(debitAmount);
            //Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
       
    }

}

