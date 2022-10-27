// Example of Tightly Coupled
/*
using System;

namespace Constructor_Injection
{
    class CurrentAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details of current account");
        }
    }

    class SavingsAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details of savings account");
        }
    }
    
    class Account
    {
        CurrentAccount ca= new CurrentAccount();

        SavingsAccount sa= new SavingsAccount();

        public void printAccounts()
        {
            ca.printDetails();
            sa.printDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.printAccounts();
        }
    }
}
*/

// Dependency Injection through Constructor Injection

using System;

namespace Constructor_Injection
{
    public interface IAccount
    {
        void printDetails();
    }
    
    class CurrentAccount: IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details of current account");
        }
    }

    class SavingsAccount: IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details of savings account");
        }
    }

    class Account
    {
        private IAccount account;

        public Account(IAccount account)
        {
            this.account = account;
        }

        public void printAccounts()
        {
            account.printDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAccount ca = new CurrentAccount();
            Account a = new Account(ca);
            a.printAccounts();

            IAccount sa = new SavingsAccount();
            Account a1 = new Account(sa);
            a1.printAccounts();
        }
    }
}