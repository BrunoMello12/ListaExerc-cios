internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o seu salário: ");
        decimal salario = decimal.Parse(Console.ReadLine());

        decimal aumento = salario + (salario * 15 / 100);
        decimal salarioFinal = aumento - (salario * 8 / 100);
        Console.WriteLine($"Salário inicial: {salario}");
        Console.WriteLine($"Salário com aumento: {aumento}");
        Console.WriteLine($"Salário final: {salarioFinal}");

    }
}