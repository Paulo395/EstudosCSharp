using System;
using Entities;

namespace HashCodeEquals // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client("Maria", "Jão");

            Client b = new Client("Maria", "Jão");

            //Console.WriteLine(a.GetHashCode().Equals(b.GetHashCode())); //Funciona com os dois
            Console.WriteLine(a.Equals(b));

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
        }
    }
}