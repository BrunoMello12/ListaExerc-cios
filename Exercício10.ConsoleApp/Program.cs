internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a primeira nota: ");
        decimal n1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota: ");
        decimal n2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso da prova 1: ");
        decimal p1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso da prova 2: ");
        decimal p2 = decimal.Parse(Console.ReadLine());

        decimal mediaFinal = (n1 * p1) + (n2 * p2) / (p1 + p2);
        Console.WriteLine($"A média final ficou: {mediaFinal}");

    }
}