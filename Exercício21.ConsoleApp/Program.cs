internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o primeiro valor: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double result = 0;

        if(v1 == v2)
        {
            result = v1 + v2;
        }
        else
        {
            result = v1 * v2;
        }

        Console.WriteLine($"O resultado foi: {result}");
    }
}