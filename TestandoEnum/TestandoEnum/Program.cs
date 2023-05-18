using System;
using System.Globalization;
using TestandoEnum.Enums;

namespace TestandoEnum // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiasDaSemana diasDaSemana = new DiasDaSemana();
            diasDaSemana = DiasDaSemana.Terça;

            Console.WriteLine(diasDaSemana);

            DateTime datas = DateTime.ParseExact("02/03/2025 17:25:22", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(datas);
        }
    }
}