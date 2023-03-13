internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o raio: ");
        decimal raio = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe a altura: ");
        decimal altura = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"O volume da lata de óleo é: {(raio * raio) * 3.14m * altura}");
    }
}