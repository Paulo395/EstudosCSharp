using System;
using UpCastingDownCasting.Entities;

namespace UpCastingDownCasting // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teste UpCasting e DownCasting
            BusinessAccount ba = new BusinessAccount();

            //ba.Loan(500);
            //Console.WriteLine(ba.Balance);

            Account acc = new BusinessAccount(2, "Teste", 500, 200);

            Console.WriteLine("Account:\n" + acc);

            BusinessAccount bacc = (BusinessAccount)acc;

            Console.WriteLine("BusinessAccount:\n" + bacc);


            //Teste métodos com Virtual e Override
            Account account = new Account();

            BusinessAccount businessAccount = new BusinessAccount();

            account.Deposit(50);
            businessAccount.Deposit(50);

            account.Withdraw(10);
            businessAccount.Withdraw(10);

            Console.WriteLine(account.Balance);
            Console.WriteLine(businessAccount.Balance);
        }
    }
}