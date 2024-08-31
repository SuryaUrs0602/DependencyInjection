using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public interface IAccount
    {
        void printDetails();
    }

    public class SavingAccount : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("This is Saving bank account");
        }
    }

    public class CurrentAccount : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("This is Current bank account");
        }

    }

    public class Account
    {
        private IAccount _account;

        public Account(IAccount account)
        {
            _account = account;
        }

        public void printAccounts()
        {
            _account.printDetails();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount ca = new CurrentAccount();
            Account account1 = new Account(ca);
            account1.printAccounts();

            IAccount sa = new SavingAccount();
            Account account2 = new Account(sa);
            account2.printAccounts();

            Console.ReadLine();
        }
    }
}
