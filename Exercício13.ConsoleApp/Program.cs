internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de pães: ");
        int paes = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a quantidade de broas: ");
        int broas = int.Parse(Console.ReadLine());

        decimal totalPaes = paes * 0.12m;
        decimal totalBroas = broas * 1.50m;
        decimal total = totalPaes + totalBroas;
        decimal poupanca = total * 10 / 100;
        Console.WriteLine($"O total arrecado foi: {total}");
        Console.WriteLine($"O total para guardar na poupança foi: {poupanca}");
    }
}