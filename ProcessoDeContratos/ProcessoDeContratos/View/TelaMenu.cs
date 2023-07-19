using Service;
using Entities;
using System.Globalization;

namespace View
{
    internal class TelaMenu
    {
        public static void Menu()
        {
            //Menu Interativo
            Console.Write("Enter contract data\nNumber: ");
            int numeroContrato = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateOnly dataContrato = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double valorContrato = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            byte numeroParcelas = byte.Parse(Console.ReadLine());

            //Automatico
            //int numeroContrato = 8028;
            //DateOnly dataContrato = new DateOnly(2018,06,25);
            //double valorContrato = 600;
            //byte numeroParcelas = 3;

            Contract contract = new Contract(numeroContrato, dataContrato, valorContrato);
            ContractService contractService = new ContractService();
            contractService.GerarParcelas(contract, numeroParcelas);

            contract.Installments();
        }
    }
}
