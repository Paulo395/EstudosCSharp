using System;

namespace FileInfo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string sourcePath = @"C:\Testes\TextoQualquer.txt";

            try
            { 

                //for (int i = 0; i < 5; i++)
                //{
                //    int num = random.Next(0, 100);
                //    string targetPath = @"C:\Testes\OutroTextoQualquer" + num + ".txt";
                //    File.Copy(sourcePath, targetPath);
                //}
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Deu ruim " + ex.Message);
            }

        }
    }
}