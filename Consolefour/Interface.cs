/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolefour
{
    interface ManageBankAccount
    {
        void OpenBankAccount();
        void CloseBankAccount();
    }
    interface IBankAccount
    {
        void Deposit();
        void Withdraw();
        void Balance();
    }
    class CurrentAccount : IBankAccount, ManageBankAccount
    {
        public void Balance()
        {
            Console.WriteLine("Balance in currentAccount");
        }

        public void CloseBankAccount()
        {
            Console.WriteLine("close in currentAccount");
        }

        public void Deposit()
        {
            Console.WriteLine("deposit in currentAccount");
        }

        public void OpenBankAccount()
        {
            Console.WriteLine("open in currentAccount");
        }

        public void Withdraw()
        {
            Console.WriteLine("withdraw in currentAccount");
        }
    }



    class SavingAccount : IBankAccount , ManageBankAccount
{
        public void Balance()
        {
            Console.WriteLine("balance in SavingAccount");
        }

        public void CloseBankAccount()
        {
            Console.WriteLine("close in SavingAccount");
        }

        public void Deposit()
        {
            Console.WriteLine("deposit in SavingAccount");
        }

        public void OpenBankAccount()
        {
            Console.WriteLine("open in SavingAccount");
        }

        public void Withdraw()
        {
            Console.WriteLine("withdraw in SavingAccount");
        }
    }
class Interface
{
    static void Main(string[] args)
    {
        CurrentAccount CA = new CurrentAccount();
            CA.OpenBankAccount();
        CA.Balance();
        CA.Withdraw();
        CA.Deposit();
            CA.CloseBankAccount();
        Console.WriteLine("_________________________");
        SavingAccount SA = new SavingAccount();
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
