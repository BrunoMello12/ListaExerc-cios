internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a temperatura em fahrenheit: ");
        decimal temp = decimal.Parse(Console.ReadLine());

        decimal tempFinal = (temp - 32) * 5 / 9;
        Console.WriteLine($"A conversão para ceusius ficou: {tempFinal}");
    }
}