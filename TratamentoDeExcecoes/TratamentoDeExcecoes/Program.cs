using System;

namespace TratamentoDeExcecoes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //try
                //{
                //    int num = int.Parse(Console.ReadLine());
                //}
                //catch (FormatException e)
                //{
                //    Console.WriteLine("Deu ruim " + e.Message);
                //}
                ////catch (NullReferenceException e)
                ////{
                ////    Console.WriteLine("Está Null!?");
                ////}
                //catch
                //{
                //    Console.WriteLine("Generico");
                //}

                string? input = Console.ReadLine();

                int num = 0;

                if (input != null) int.TryParse(input, out num);

                Console.WriteLine(num);
            }

        }
    }
}