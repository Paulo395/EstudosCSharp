
namespace Entities
{
    internal class Contract
    {
        public int NumeroContrato { get; private set; }
        public DateOnly DataContrato { get; private set; }
        public double ValorTotal { get; private set; }
        public List<Installment> Installment;

        public Contract(int numero, DateOnly data, double valorTotal)
        {
            NumeroContrato = numero;
            DataContrato = data;
            ValorTotal = valorTotal;
            Installment = new List<Installment>();
        }

        public void AdicionarParcela(Installment installment)
        {
            Installment.Add(installment);
        }

        public void Installments()
        {
            Console.WriteLine("Installments: ");
            foreach (Installment installment in Installment)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
