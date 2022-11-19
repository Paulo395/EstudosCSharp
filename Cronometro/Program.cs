internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        Console.WriteLine("S = Segundo\nM = Minuto\n0 = Sair\n");
        Console.WriteLine("Quanto tempo deseja contar? Exemplo: 10m");
        string resposta = Console.ReadLine().ToLower();

        int num = int.Parse(resposta.Substring(0,resposta.Length - 1));
        string tempo = resposta.Substring(resposta.Length - 1,1);
        int mult = 1;
        
        if(tempo.Equals("m")){
            mult = 60;
        }

        if(num == 0){
            System.Environment.Exit(0);
        }

        PreStart(num*mult);
    }

    private static void PreStart(int num){
        Thread.Sleep(800);
        Console.WriteLine("Preparar!!");
        Thread.Sleep(800);
        Console.WriteLine("Vai!!");
        Thread.Sleep(800);
        Console.Clear();
        Start(num);
    }

    private static void Start(int num){
        for(int i=0;i<=num;i++){
            Console.Write("Tempo: ");
            Console.WriteLine(i);
            Thread.Sleep(800);
            Console.Clear();
        }

        Console.WriteLine("Precione qualquer tecla para reiniciar!");
        Console.ReadKey();
        Menu();
    }
}