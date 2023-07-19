using Entities;

namespace Service
{
    internal class ContractService
    {
        public void GerarParcelas(Contract contract, byte numeroParcelas)
        {
            DateOnly data = contract.DataContrato;

            for (int i = 0; i < numeroParcelas; i++)
            {
                double valorParcela = contract.ValorTotal / numeroParcelas;
                PaypalService paypalService = new PaypalService();
                valorParcela = paypalService.Tax(valorParcela, i+1);

                data = data.AddMonths(1);
                Installment intallment = new Installment(data,valorParcela);

                contract.AdicionarParcela(intallment);
            }
        }
    }
}
