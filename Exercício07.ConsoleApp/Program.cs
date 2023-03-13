internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o salario base: ");
        decimal salarioBase = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o total de vendas: ");
        decimal totalVendas = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe a comissão a ser aplicada sobre as vendas (em % ): ");
        decimal comissao = decimal.Parse(Console.ReadLine());

        decimal salarioTotal = salarioBase + (totalVendas * (salarioBase*comissao/100));
        Console.WriteLine($"O salario total ficou: {salarioTotal}");
    }
}