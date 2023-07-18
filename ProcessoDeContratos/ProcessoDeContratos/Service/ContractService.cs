using Entities;

namespace Service
{
    internal class ContractService
    {
        public void GerarParcelas(Contract contract, byte numeroParcelas)
        {
            
            for (int i = 0; i < numeroParcelas; i++)
            {
                double valorParcela = contract.ValorTotal / numeroParcelas;
                valorParcela += valorParcela * (1.0 / 100); //Juros Simples
                valorParcela += valorParcela * (2.0 / 100); //Taxa de Pagamento

                Installment intallment = new Installment(valorParcela);

                contract.AdicionarParcela(intallment);
            }
        }
    }
}
