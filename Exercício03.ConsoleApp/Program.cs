internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o raio: ");
        decimal raio = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe a altura: ");
        decimal altura = decimal.Parse(Console.ReadLine());

        decimal volume = 3.14m * (raio * raio) * altura;
        Console.WriteLine($"O volume do cilíndro ficou: {volume}");
    }
}