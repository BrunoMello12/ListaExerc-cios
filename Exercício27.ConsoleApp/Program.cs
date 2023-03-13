internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 0, num2 = 1, aux;

        Console.WriteLine("Informe um número: ");
        int inf = int.Parse(Console.ReadLine());

        for (int i = 0; i​​​​​​​ < inf; i++)
        {
            aux = num1;
            num1 = num2;
            num2 = num1 + aux;
            Console.WriteLine("{0}", num2);

        }

        
    }
}