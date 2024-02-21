class Program
{
    //Faça um programa que calcule a área de um círculo, sendo que o comprimento do raio é informado pelo usuário.A área do círculo é calculada multiplicando-se Pi ao raio ao quadrado.
    public static void Main(string[] args)
    {
        double raio, area;
        Console.WriteLine("Qual o coprimento do raio?");
        double.TryParse(Console.ReadLine(), out raio);

        area = Math.PI * Math.Pow(raio, 2);

        Console.WriteLine("A área do cirulo é: " + area);

        Console.ReadKey();
    }
}