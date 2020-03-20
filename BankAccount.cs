using System;

namespace BankingDomain
{
       public enum AccountType { Standard, Gold}
    public class BankAccount
    {

        private decimal currentBalance = 5000M;
        public AccountType TypeOfAccount = AccountType.Standard;
        public decimal GetBalance()
        {
            return currentBalance;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if(amountToWithdraw > currentBalance)
            {
                throw new OverdraftException();
            }
            else
            {
                currentBalance -= amountToWithdraw;
            }
        }

        public void Deposit(decimal amountToDeposit)
        {
            currentBalance += amountToDeposit;
        }
    }
}