using Interface;

namespace Service
{
    internal class PaypalService : ITaxService
    {
        public double Tax(double valorParcela, int numeroParcela)
        {
            valorParcela += (valorParcela / 100) * numeroParcela; //Juros Simples
            valorParcela += (valorParcela / 100) * 2.0; //Taxa de Pagamento
            return valorParcela;
        }
    }
}
