using System;

namespace VotosComDictionary 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Estudos\C#\EstudosCSharp\VotosComDictionary\VotosComDictionary\Registry\Registry.txt";

            string[] strings = File.ReadAllLines(sourcePath);

            Dictionary<string,int> c = new Dictionary<string,int>();

            foreach (string s in strings)
            {
                string[] candidates = s.Split(",");

                if (!c.ContainsKey(candidates[0]))
                {
                    c.Add(candidates[0], int.Parse(candidates[1]));
                }
                else
                {
                    c[candidates[0]] += int.Parse(candidates[1]);
                }
                                
            }

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(c["Alex Blue"]); String é a chave, logo retorna apenas a quantidade de votos

        }
    }
}