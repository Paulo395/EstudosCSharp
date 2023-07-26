using System;
using Entities;

namespace TestesContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> setA = new HashSet<Product>();

            setA.Add(new Product("Tv", 500));

            Product product = new Product("Tv", 500);

            //Console.WriteLine("SetA" + setA.GetHashCode());
            //Console.WriteLine("product " + product.GetHashCode());

            Console.WriteLine(setA.Contains(product)); //Contains usa GetHashCode e Equals

        }
    }
}