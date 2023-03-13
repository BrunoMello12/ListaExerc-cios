internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a altura da caixa: ");
        decimal altura = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe a largura da caixa: ");
        decimal largura = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o comprimento da caixa: ");
        decimal comprimento = decimal.Parse(Console.ReadLine());

        decimal volume = altura * largura * comprimento;
        Console.WriteLine($"O volume da caixa é: {volume}");
    }
}