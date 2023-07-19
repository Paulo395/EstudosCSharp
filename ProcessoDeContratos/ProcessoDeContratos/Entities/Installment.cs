using System.Globalization;

namespace Entities
{
    internal class Installment
    {
        public DateOnly DataDeVencimento { get; private set; }
        public double Quantia { get; private set; }

        public Installment(DateOnly dataDeVencimento, double quatia)
        {
            DataDeVencimento = dataDeVencimento;
            Quantia = quatia;
        }

        public override string ToString()
        {
            return DataDeVencimento + " - " + Quantia.ToString(CultureInfo.InvariantCulture);
        }
    }
}
