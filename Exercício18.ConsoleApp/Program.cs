internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o primeiro valor: ");
        float A = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo valor: ");
        float B = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o terceiro valor: ");
        float C = float.Parse(Console.ReadLine());

        if(A < B  && B < C)
        {
            Console.WriteLine($"{A}, {B}, {C}");
        }
        else if(B < C && C < A)
        {
            Console.WriteLine($"{B}, {C}, {A}");
        }
        else if(C < B && B < A)
        {
            Console.WriteLine($"{C}, {B}, {A}");
        }
        else
        {
            Console.WriteLine($"{C}, {A}, {B}");
        }
    }     
}