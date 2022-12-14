using System;

namespace Property_Injection
{
    public interface IAccount
    {
        void printDetails();
    }
    class CurrentAccount : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details of current account");
        }
    }

    class SavingsAccount : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details of savings account");
        }
    }

    class Account
    {
        public IAccount account { get; set; }

        public void printAccounts()
        {
            account.printDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account sa = new Account();
            sa.account = new SavingsAccount();
            sa.printAccounts();

            Account ca = new Account();
            ca.account = new CurrentAccount();
            ca.printAccounts();
        }
    }
}