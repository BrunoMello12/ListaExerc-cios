internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o raio: ");
        decimal raio = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"O volume da esfera ficou: {4 / 3 * (raio * raio * raio) * 3.14m}");
    }
}