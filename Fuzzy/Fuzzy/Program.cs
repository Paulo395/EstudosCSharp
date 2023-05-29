using Accord.Fuzzy;
using Accord.Fuzzy.Membership;

class Program
{
    static void Main(string[] args)
    {
        // Criação das variáveis linguísticas
        //LinguisticVariable temperature = new LinguisticVariable("Temperature", 0, 100);
        //temperature.AddLabel("Low", new TrapezoidalFunction(0, 0, 20, 30));
        //temperature.AddLabel("Medium", new TrapezoidalFunction(25, 35, 45, 55));
        //temperature.AddLabel("High", new TrapezoidalFunction(50, 60, 100, 100));

        //LinguisticVariable fanSpeed = new LinguisticVariable("FanSpeed", 0, 10);
        //fanSpeed.AddLabel("Low", new TrapezoidalFunction(0, 0, 3, 4));
        //fanSpeed.AddLabel("Medium", new TrapezoidalFunction(3, 5, 7, 8));
        //fanSpeed.AddLabel("High", new TrapezoidalFunction(7, 8, 10, 10));

        //// Definição das regras fuzzy
        //FuzzyRule rule1 = new FuzzyRule(
        //    new FuzzySet[] { temperature["Low"] },
        //    new FuzzySet[] { fanSpeed["High"] }
        //);

        //FuzzyRule rule2 = new FuzzyRule(
        //    new FuzzySet[] { temperature["Medium"] },
        //    new FuzzySet[] { fanSpeed["Medium"] }
        //);

        //FuzzyRule rule3 = new FuzzyRule(
        //    new FuzzySet[] { temperature["High"] },
        //    new FuzzySet[] { fanSpeed["Low"] }
        //);

        //// Criação do motor de inferência
        //InferenceSystem IS = new InferenceSystem(temperature, fanSpeed);
        //IS.NewRule(rule1);
        //IS.NewRule(rule2);
        //IS.NewRule(rule3);

        //// Definição da temperatura atual
        //double currentTemperature = 35;

        //// Cálculo da saída (velocidade do ventilador)
        //double fanSpeedValue = IS.Evaluate(currentTemperature);

        //// Exibição do resultado
        //Console.WriteLine("Current Temperature: " + currentTemperature);
        //Console.WriteLine("Fan Speed: " + fanSpeedValue);


    }
}
