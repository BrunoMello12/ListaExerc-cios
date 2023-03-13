internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o seu peso: ");
        float peso = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a sua altura: ");
        float altura = float.Parse(Console.ReadLine());

        float imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if(imc >= 18.5 && imc <= 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if(imc > 25 && imc <= 30)
        {
            Console.WriteLine("Acima do peso");
        }
        else
        {
            Console.WriteLine("Obeso");
        }
    }
}