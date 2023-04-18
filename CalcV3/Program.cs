
internal class Program
{
    private static void Main(string[] args)
    {
        Operacoes calcular = new Operacoes();
        float? resposta = null;
        string? opcao;

        do{
            Console.WriteLine("Muito boa noite, urruuu");
            Console.WriteLine("Digite o 1° Valor:");
            float valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2° Valor:");
            float valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\tDigite o simbolo da operação deseja realizar:\n");
            Console.WriteLine("+\tAdição\n-\tSubtração\n/\tDivisão\n*\tMultiplicação\n");
            
            opcao = Console.ReadLine();

            switch(opcao){
                case "+":
                    resposta = calcular.Soma(valor1, valor2);
                    break;
                case "-":
                    resposta = calcular.Subtracao(valor1, valor2);
                    break;
                case "/":
                    resposta = calcular.Divisao(valor1, valor2);
                    break;
                case "*":
                    resposta = calcular.Multiplicacao(valor1, valor2);
                    break;
                default:
                    Console.WriteLine("\tComando não reconhecido.");
                    break;
            }

            if(!resposta.Equals(null)){
                Console.WriteLine("\tTotal: " + resposta + "\n");
            }
            
            Console.WriteLine("\tPressione qualquer tecla para repetir.");
            Console.ReadLine();

        }while(true);
    }
}

