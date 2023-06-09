
namespace Caluladora.Operacoes
{
    public class Operacoes
    {
        static double Calculos(char type, double n1, double n2)
        {
            double result;

            switch (type)
            {
                case "+":
                    result = calcular.Soma(valor1, valor2);
                    break;
                case "-":
                    result = calcular.Subtracao(valor1, valor2);
                    break;
                case "/":
                    result = calcular.Divisao(valor1, valor2);
                    break;
                case "*":
                    result = calcular.Multiplicacao(valor1, valor2);
                    break;
                default:
                    Console.WriteLine("\tComando não reconhecido.");
                    break;
            }

            return result;
        }

    }
}
