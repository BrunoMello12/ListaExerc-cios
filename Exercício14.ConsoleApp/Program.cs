internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        int totalDias = 365 * 19;
        Console.WriteLine($"{nome} você já viveu {totalDias}");


    }
}