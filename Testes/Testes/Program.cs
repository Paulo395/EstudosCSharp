namespace Testes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sourcePath = @"C:\Estudos\C#\EstudosCSharp\Testes\Testes\src\padrao.csv";
            var data = File.ReadAllText(sourcePath);

            char[] charArray = data.ToCharArray();

            foreach (char c in charArray )
            {
                Console.Write(c);
            }
        }
    }
}