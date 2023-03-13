
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a temperatura em graus celsius: ");
        decimal celsius = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"A conversão para fahrenheit ficou: {(celsius * 9 / 5) + 32}");
    }
}

