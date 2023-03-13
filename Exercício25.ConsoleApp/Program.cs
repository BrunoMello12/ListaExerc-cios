internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe um valor: ");
        int valor = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{valor} x {i} = {valor * i}");
        }
    }
}