using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAcc = new BankAccount(400);

            myAcc.Deposit(300);

            var bal = myAcc.GetBalance();
            Console.WriteLine($"Balance is {bal}");

            myAcc.Withdraw(100);
            Console.WriteLine($"Balance is {myAcc.GetBalance()}");

        }
    }
}