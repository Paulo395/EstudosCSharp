using System.IO;

namespace PraticasComArquivos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sourcePath = @"C:\Estudos\C#\EstudosCSharp\PraticasComArquivos\PraticasComArquivos\src\Names.txt";
            string targetPath = @"C:\Estudos\C#\EstudosCSharp\PraticasComArquivos\PraticasComArquivos\src\Copy.txt";

            ////Forma simplificada de leitura
            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    string s = sr.ReadToEnd();

                    Console.WriteLine(s);

                }
            }
            catch (IOException)
            {
                Console.WriteLine("Deu Ruim");
            }


            ////Forma simplificada de escrita
            string? frase = Console.ReadLine();

            try
            {
                using (StreamWriter sw = new StreamWriter(targetPath))
                {
                    sw.WriteLine(frase); // Escreve apenas na primeira linha
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Deu Ruim");
            }

            //Informações de Pastas e Arquivos
            IEnumerable<string> pastas = Directory.EnumerateDirectories(@"C:\Estudos"); //Retorna um IEnumerable
            IEnumerable<string> arquivos = Directory.EnumerateFiles(@"C:\Estudos\Textos");

            Console.WriteLine("Pastas");
            foreach (string s in pastas)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Arquivos");
            foreach (string s in arquivos)
            {
                Console.WriteLine(s);
            }

            //Criar Pasta
            string sourcePath2 = @"C:\";

            Directory.CreateDirectory(sourcePath2 + "Pasta Teste");

        }
    }
}