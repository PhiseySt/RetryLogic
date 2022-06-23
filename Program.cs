using Polly;

namespace RetryLogic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Retry Logic using Action");
        Executor.Execute(SimulationMethods.FirstSimulationMethod, 3);

        Console.WriteLine();

        Console.WriteLine("Retry Logic using Func");
        var result = Executor.Execute(SimulationMethods.SecondSimulationMethod, 3);

        Console.WriteLine();

        Console.WriteLine("Retry Logic using Polly and Action");
        Policy
            .Handle<ArgumentException>()
            .Retry(3)
            .Execute(SimulationMethods.FirstSimulationMethod);

        Console.WriteLine("Retry Logic using Polly and Func");
        var resultPolly = Policy
            .Handle<ArgumentException>()
            .Retry(3)
            .Execute(SimulationMethods.SecondSimulationMethod);

        Console.WriteLine("Press <ENTER> to close the application");

        Console.ReadLine();
    }
}