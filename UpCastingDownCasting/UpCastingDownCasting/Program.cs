using System;
using UpCastingDownCasting.Entities;

namespace UpCastingDownCasting // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BusinessAccount ba = new BusinessAccount();

            //ba.Loan(500);
            //Console.WriteLine(ba.Balance);

            Account acc = new BusinessAccount(2,"Teste",500,200);

            Console.WriteLine("Account:\n" + acc);

            BusinessAccount bacc = (BusinessAccount)acc;

            Console.WriteLine("BusinessAccount:\n" + bacc);


        }
    }
}