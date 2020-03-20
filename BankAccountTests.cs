using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class BankAccountTests
    {
        BankAccount account;

        public BankAccountTests()
        {
            account = new BankAccount();
        }

        [Fact]
        public void NewAccountHasCorrectBalance()
        {
            decimal currentBalance = account.GetBalance();

            Assert.Equal(5000M, currentBalance);
        }

        [Fact]
        public void WithdrawalDecreasedTheBalance()
        {
            //Arrange
            var openingBalance = account.GetBalance();
            var amountToWithdraw = 1M;

            //Act
            account.Withdraw(amountToWithdraw);

            //Assert
            Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
        }

        [Fact]
        public void DepositIncreasesBalance()
        {
            //Arrange
            var openingBalance = account.GetBalance();
            var amountToDeposit = 1M;

            //Act
            account.Deposit(amountToDeposit);

            //Assert
            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
        }

        [Fact]
        public void OverdraftDoesNotDecreaseBalance()
        {
            var openingBalance = account.GetBalance();

            try
            {
                account.Withdraw(openingBalance + 1);
            }
            catch (Exception)
            {
                // gulp!
            }

            Assert.Equal(openingBalance, account.GetBalance());  
        }

        [Fact]
        public void OverdraftThrowsAnException()
        {
            Assert.Throws<OverdraftException>(
                () => account.Withdraw(account.GetBalance() + 1)
                );
        }
    }
}

