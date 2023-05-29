using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastingDownCasting.Entities
{
    internal class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; } = "";
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //public virtual void Frase()
        //{
        //    Console.WriteLine("Frase Account, ouxxi");
        //}

        public override string ToString()
        {
            return "Number: " + Number + "\n" +
                   "Holder: " + Holder + "\n" +
                   "Balance: " + Balance + "\n";
        }
    }
}
