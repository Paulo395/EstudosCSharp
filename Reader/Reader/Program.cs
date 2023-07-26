using System;
using System.Globalization;
using Entities;

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

                HashSet<Registry> set = new HashSet<Registry>();

                foreach (string s in lines)
                {
                    string[] logs = s.Split(" ");
                    DateTime dateTime = DateTime.Parse(logs[1]); //Parse reconhece padrão ISO 8601

                    set.Add(new Registry(logs[0],dateTime));
                }

                foreach(Registry registry in set)
                {
                    Console.WriteLine(registry);
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