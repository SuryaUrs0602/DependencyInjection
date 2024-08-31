using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDependencyInjectionExample
{
    public interface IAccount
    {
        void printdetails();
    }

    public class SavingAccount : IAccount
    {
        public void printdetails()
        {
            Console.WriteLine("Deatils of saving bank account");
        }
    }

    public class CurrentAccount : IAccount
    {
        public int id = 10;
        public void printdetails()
        {
            Console.WriteLine("Details of current bank account");
        }
    }

    public class Account
    {
        public void printaccount(IAccount acc)
        {
            Console.WriteLine(acc.id)
            acc.printdetails();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            IAccount sa = new SavingAccount();
            account.printaccount(sa);

            Account account1 = new Account();
            IAccount ca = new CurrentAccount();
            account1.printaccount(ca);

            Console.ReadLine();
        }
    }
}

