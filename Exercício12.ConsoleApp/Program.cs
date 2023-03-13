internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a largura do terreno: ");
        decimal largura = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o comprimento do terreno: ");
        decimal comprimento = decimal.Parse(Console.ReadLine());

        decimal area = largura * comprimento;
        Console.WriteLine($"A área do terreno é: {area}m²");
    }
}