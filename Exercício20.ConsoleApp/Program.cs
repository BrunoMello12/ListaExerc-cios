internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe um valor: ");
        double valor = double.Parse(Console.ReadLine());

        if(valor % 2 == 1 )
        {
            Console.WriteLine("É ímpar");
        }
        else
        {
            Console.WriteLine("É par");
        }
    }
}