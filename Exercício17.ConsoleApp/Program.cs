internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor A: ");
        float A = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor B: ");
        float B = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor C: ");
        float C = float.Parse(Console.ReadLine());

        if(A + B < C)
        {
            Console.WriteLine("É menor");
        }


    }
}