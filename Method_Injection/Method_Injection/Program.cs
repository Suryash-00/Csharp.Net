using System;

namespace Method_Injection
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
        public void printAccounts(IAccount account)
        {
            account.printDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account sa= new Account();
            sa.printAccounts(new SavingsAccount());

            Account ca = new Account();
            ca.printAccounts(new CurrentAccount());
        }
    }
}
