using System;

namespace Service
{
    internal class RetornoService
    {
        public static void RetornarValores<T>(IEnumerable<T> collection) //O primeiro T funciona com o T em classe
        {
            foreach (T t in collection)
            {
                Console.WriteLine(t + " ");
            }
            Console.WriteLine();
        }
    }
}
