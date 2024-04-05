using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class BankAccount
    {
        protected string AccountNumber;
        protected string AccountHolderName;
        protected decimal Balance;

        public BankAccount(string AccountNumber,string AccountHolderName,decimal Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
            this.Balance = Balance;
        }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public void DisplayBalance()
        {
            Console.WriteLine($"Display current Balance : {Balance}");
        }
    }
    public class SavingsAccount : BankAccount
    {
        private const decimal InterestRate = 0.07m;

        public SavingsAccount(string AccountNumber,string AccountHolderName, decimal Balance) : base(AccountNumber,AccountHolderName,Balance)
        {
            
        }
        public override void Deposit(decimal amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Savings Account Deposit Amount:{Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            Balance = Balance - amount;
            Console.WriteLine($"Savings Account Withdraw Amount:{Balance}");
        }
        public void AddInterest()
        {
            decimal Interest = Balance * InterestRate;
            Balance = Balance+Interest;
            Console.WriteLine($"Interest {Interest} is added to the amount{Balance}");
        }
    }
    public class CurrentAccount : BankAccount
    {
        private decimal OverDraftLimit;

        public CurrentAccount(string AccountNumber,string AccountHolderName, decimal Balance,decimal OverDraftLimit) : base(AccountNumber, AccountHolderName, Balance)
        {
            this.OverDraftLimit = OverDraftLimit;
        }
        public override void Deposit(decimal amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Current Account Deposit Amount:{Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > OverDraftLimit)
            {
                Console.WriteLine("Withdrawal amount exceeds overdraft limit.");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine($"Current Account Withdraw Amount:{Balance}");
            }
        }
    }
}
