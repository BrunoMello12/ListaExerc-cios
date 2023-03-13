using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        int soma = 0;
        for(int i=1; i <= 500; i++)
        {
            if(i% 2 != 0 && i % 3 == 0)
            {
                soma += i;
            }
        }
        Console.WriteLine($"A soma dos número é: {soma}");
    }
}