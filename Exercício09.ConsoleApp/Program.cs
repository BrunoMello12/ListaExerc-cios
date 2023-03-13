internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("informe a primeira nota: ");
        decimal n1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("informe a segunda nota: ");
        decimal n2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("informe a terceira nota: ");
        decimal n3 = decimal.Parse(Console.ReadLine());

        decimal mediaHarmonica = 3 / (1 / n1 + 1 / n2 + 1 / n3);
        Console.WriteLine($"A média harmônica ficou: {mediaHarmonica}");
        
    }
}