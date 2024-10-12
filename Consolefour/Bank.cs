using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolefour
{
    interface IBankAccount
    {
        bool Deposit(double amount);
        bool Withdraw(double amount);
        double Balance();
    }
    public class SavingAccount:IBankAccount
    {
        private double _balance;
        private double _perDayLimit;
        public bool Deposit(double amount)
        {
           this._balance = this._balance + amount;
            return true;
        }
        public bool Withdraw(double amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("insufficient Balance");
                return false;
            }
            else if ((_perDayLimit + amount) > 5000)
            {
                Console.WriteLine("withdrawal Attempt failed");
                return false;
            }
            else
            {
                _balance = _balance - amount;
                _perDayLimit += amount;
                Console.WriteLine("Successfully Withdrawal : {0}", amount);
                return true;
            }
        }
        public double Balance()
        {
            return this._balance;
        }
    }

    public class CurrentAccount : IBankAccount
    {
        private double _balance;
        public bool Deposit(double amount)
        {
            this._balance = this._balance + amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("insufficient Balance");
                return false;
            }
            
            else
            {
                _balance = _balance - amount;
                Console.WriteLine("Successfully Withdrawal : {0}", amount);
                return true;
            }
        }
        public double Balance()
        {
            return this._balance;
        }
    }


    class Bank
    {
        static void Main(string[] args)
        { 
            char opt;
            Console.WriteLine("1- saving Account:");
            Console.WriteLine("2_Current Account:");
            Console.WriteLine("select Account type:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            { case 1:
                    SavingAccount savingAccont = new SavingAccount();
                    do
                    {
                        Console.WriteLine("1- saving Account:");
                        Console.WriteLine("1- deposit:");
                        Console.WriteLine("2_withdrawal:");
                        Console.WriteLine("3- Balance:");
                        Console.WriteLine("select the operation:");
                        int ch = int.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("Enter Amount that you wanted to Depsit:");
                                savingAccont.Deposit(double.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                Console.WriteLine("Enter Amount that you wanted to Withdrawal :");
                                savingAccont.Withdraw(double.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                Console.WriteLine("Enter Amount that you wanted to Balance:" + savingAccont.Balance());
                                break;
                            default:
                                Console.WriteLine("invalid Operation Type!!");
                                break;
                        }
                        Console.WriteLine("do you wish to countinue?(yes/No): ");
                        opt = char.Parse(Console.ReadLine());
                    } while (opt == 'Y' || opt == 'y');
                    break;
                case 2:
                    CurrentAccount currentAccount = new CurrentAccount();
                    do { 
                    Console.WriteLine("2-  current Account:");
                    Console.WriteLine("1- deposit:");
                    Console.WriteLine("2_withdrawal:");
                    Console.WriteLine("3- Balance:");
                    Console.WriteLine("select the operation:");
                    int ch1 = int.Parse(Console.ReadLine());
                        switch (ch1)
                        {
                            case 1:
                                Console.WriteLine("Enter Amount that you wanted to Depsit:");
                                currentAccount.Deposit(double.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                Console.WriteLine("Enter Amount that you wanted to Withdrawal :");
                                currentAccount.Withdraw(double.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                Console.WriteLine("Enter Amount that you wanted to Balance:" + currentAccount.Balance());
                                break;
                            default:
                                Console.WriteLine("invalid Operation Type!!");
                                break;
                        }             
                     Console.WriteLine("do you wish to countinue?(yes/No): ");
                        opt = char.Parse(Console.ReadLine());
                    } while (opt == 'Y' || opt == 'y');
                    break;
                default:
                    Console.WriteLine("invalid Operation Type choose 1 or 2!!");
                    break;
            }


            Console.ReadLine();

        }
    }
}
