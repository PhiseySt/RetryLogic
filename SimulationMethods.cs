namespace RetryLogic;

public class SimulationMethods
{
    public static void FirstSimulationMethod()
    {
        const int forbiddenNumber = 3;

        Console.Write("Write a number: ");
        var number = int.Parse(Console.ReadLine() ?? "0");

        if (number == forbiddenNumber)
            throw new ArgumentException($"The generated number must be different from {forbiddenNumber}");

        Console.Write("Not Equal");
    }

    public static int SecondSimulationMethod()
    {
        const int forbiddenNumber = 3;

        Console.Write("Write a number: ");
        var number = int.Parse(Console.ReadLine() ?? "0");

        if (number == forbiddenNumber)
            throw new ArgumentException($"The generated number must be different from {forbiddenNumber}");

        Console.Write("Not Equal");

        return number;
    }
}