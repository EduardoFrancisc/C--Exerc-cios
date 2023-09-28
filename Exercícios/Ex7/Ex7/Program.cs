class Program
{
    //Faça um programa que calcule a área de um retângulo, sendo que os comprimentos da altura e da base são informados pelo usuário.A área do retângulo é calculada multiplicando-se a altura pela base.
    public static void Main(string[] args)
    {
        double altura, comprimento, area;

        Console.WriteLine("Qual a altura do retângulo?");
        double.TryParse(Console.ReadLine(),out altura);
        Console.WriteLine("Qual o comprimento do retângulo?");
        double.TryParse(Console.ReadLine(), out comprimento);

        area = altura * comprimento;

        Console.WriteLine("A área do retângulo é: " + area);

        Console.ReadKey();
    }
}