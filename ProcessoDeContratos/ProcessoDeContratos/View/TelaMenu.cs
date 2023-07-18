using System.Globalization;
using Entities;


namespace ProcessoDeContratos.View
{
    internal class TelaMenu
    {
        public static void Menu()
        {
            //Console.Write("Enter contract data\nNumber: ");
            //int numeroContrato = int.Parse(Console.ReadLine());

            //Console.Write("Date (dd/MM/yyyy): ");
            //DateOnly dataContrato = DateOnly.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);

            //Console.Write("Contract value: ");
            //double valorContrato = double.Parse(Console.ReadLine());

            ////Parcelas
            //Console.Write("Enter number of installments: ");
            //byte numeroParcelas = byte.Parse(Console.ReadLine());

            int numeroContrato = 8028;
            DateOnly dataContrato = new DateOnly(2018,06,25);
            double valorContrato = 600;

            Contract contract = new Contract(numeroContrato, dataContrato, valorContrato);


            
        }
    }
}
