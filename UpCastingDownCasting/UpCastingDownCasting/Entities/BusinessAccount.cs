using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastingDownCasting.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; private set; } = 500;

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount < LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("The requested amount exceeds your loan limit!");
            }
        }

        //public override void Frase()
        //{
        //    base.Frase();
        //    Console.WriteLine("Frase businessAccount, putx");
        //}

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); 
            Balance -= 5;
        }

        public override string ToString()
        {
            return "Number: " + Number + "\n" +
                   "Holder: " + Holder + "\n" +
                   "Balance: " + Balance + "\n" +
                   "LoanLimit: " + LoanLimit + "\n";
        }
    }
}
