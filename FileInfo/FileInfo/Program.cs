using System;

namespace FileInfo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Testes\TextoQualquer.txt";
            //string targetPath = @"C:\Testes\OutroTextoQualquerDeNovo.txt";

            try
            {
                //File.Copy(sourcePath, targetPath);
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