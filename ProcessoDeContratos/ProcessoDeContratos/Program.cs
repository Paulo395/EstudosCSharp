using Entities;
using Service;

namespace ProcessoDeContratos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateOnly d = new DateOnly(2018, 06, 25);

            Contract c = new Contract(8028, d, 600);


            ContractService contractService = new ContractService();
            contractService.GerarParcelas(c, 3);

            c.RetornarLista();
        }
    }
}