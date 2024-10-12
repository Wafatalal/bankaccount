/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolefour
{
abstract class ManageBankAccount
    {
        public void message(){
            Console.WriteLine("welcome to bank !!");
            }
        public abstract void OpenBankAccount();
        public abstract void CloseBankAccount();
    }
    abstract class BankAccount : ManageBankAccount
    {
        public abstract void Deposit();
        public abstract void Withdraw();
        public abstract void Balance();

    }
    class SavingAccount : BankAccount
    {
        public override void Deposit()
        {
            Console.WriteLine("deposit in saving Account");
        }
        public override void Withdraw()
        {
            Console.WriteLine("withdraw in saving Account");
        }
        public override void Balance()
        {
            Console.WriteLine("balance in saving Account");
        }

        public override void OpenBankAccount()
        {
            Console.WriteLine("open bank account in saving Account");
        }

        public override void CloseBankAccount()
        {
            Console.WriteLine("close bank account in saving Account");
        }
    }
    class CurrentAccount : BankAccount
    {
        public override void Deposit()
        {
            Console.WriteLine("deposit in CurrentAccount");
        }
        public override void Withdraw()
        {
            Console.WriteLine("withdraw in CurrentAccount");
        }
        public override void Balance()
        {
            Console.WriteLine("balance in CurrentAccount");
        }
        public override void OpenBankAccount()
        {
            Console.WriteLine("open bank account in current Account");
        }

        public override void CloseBankAccount()
        {
            Console.WriteLine("close bank account in current Account");
        }

    }
    class Abetract
    {
        static void Main(string[] args)
        {
            CurrentAccount CA = new CurrentAccount();
            CA.message();
            CA.OpenBankAccount();
            CA.Balance();
            CA.Withdraw();
            CA.Deposit();
            CA.CloseBankAccount();
            SavingAccount SA = new SavingAccount();
            SA.message();
            SA.OpenBankAccount();
            SA.Balance();
            SA.Withdraw();
            SA.Deposit();
            SA.CloseBankAccount();

            Console.ReadLine();
        }
    }
}
*/