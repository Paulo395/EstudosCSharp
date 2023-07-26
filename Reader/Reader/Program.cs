using System;
using System.Globalization;
using Entites;

namespace Reader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"C:\\Estudos\\C#\\EstudosCSharp\\Reader\\Reader\\Log\\Logs.txt";

                string[] lines = File.ReadAllLines(sourcePath);

                string[] logs = new string[2];

                HashSet<string> set = new HashSet<string>();

                foreach (string s in lines)
                {
                    logs = s.Split(" ");
                    set.Add(logs[0]);
                }

                Console.WriteLine("Total users: " + set.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deu ruim");
            }

        }
    }
}