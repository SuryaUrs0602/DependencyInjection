using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDependencyInjectionExample
{
    public interface IAccount
    {
        void printdetails();
    }

    public class SavingAccount : IAccount
    {
        public void printdetails()
        {
            Console.WriteLine("Saving bank account details...");
        }
    }

    public class CurrentAccount : IAccount 
    {
        public void printdetails()
        {
            Console.WriteLine("Current bank account details...");
        }
    }

    public class Account
    {
        public IAccount acc { get; set; }

        public void printaccount()
        {
            acc.printdetails();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.acc = new SavingAccount();
            account.printaccount();

            Account account2 = new Account();
            account2.acc = new CurrentAccount();
            account2.printaccount();

            Console.ReadLine();
        }
    }
}
