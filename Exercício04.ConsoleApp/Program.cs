internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o km inicial: ");
        decimal kmI = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o km final: ");
        decimal kmF = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o consumo de combustivel (em litros): ");
        decimal gasolina = decimal.Parse(Console.ReadLine());

        decimal consumoMedio = gasolina/(kmF - kmI);

        Console.WriteLine($"O consumo médio foi: {consumoMedio}");
    }
}