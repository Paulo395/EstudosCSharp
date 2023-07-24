using System;

namespace HashSetSortedSet // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> set = new HashSet<String>();

            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("d");
            set.Add("d"); //Não Vai!

            foreach(String s in set)
            {
                Console.WriteLine(s);
            }

            if(set.Contains("j")) Console.WriteLine("Sim");

            Console.WriteLine(set);
        }
    }
}