internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a altura da caixa: ");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a largura da caixa: ");
        double largura = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o comprimento da caixa: ");
        double comprimento = double.Parse(Console.ReadLine());

        double volume = altura * largura * comprimento;
        Console.WriteLine($"O volume da caixa é: {volume}");

    }
}