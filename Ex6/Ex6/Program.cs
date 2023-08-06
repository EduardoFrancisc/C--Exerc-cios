public class Program
{
    //Faça um programa que calcule a área de um quadrado, sendo que o comprimento do lado é informado pelo usuário. A área do quadrado é calculada elevando-se o lado ao quadrado.
    public static void Main(string[] args)
    {
        double lado, area;

        Console.WriteLine("Qual o lado do quadrado?");
        double.TryParse(Console.ReadLine(), out lado);

        area = Math.Pow(lado, 2);

        Console.WriteLine("A área do quadrado é: " + area);

        Console.ReadKey();
    }
}



