using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Installment
    {
        public DateOnly DataDeVencimento { get; private set; }
        public double Quantia { get; private set; }

        //public Installment(DateOnly dataDeVencimento)
        //{
        //    DataDeVencimento = dataDeVencimento;
        //}

        public Installment(double quatia)
        {
            Quantia = quatia;
        }

        public override string ToString()
        {
            return "Installments:\n";
        }
    }
}
