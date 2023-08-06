class Program
{
    //Faça um programa que calcule a área de uma esfera, sendo que o comprimento do raio é informado pelo usuário. A área da esfera é calculada multiplicando-se 4 vezes Pi ao raio ao quadrado.
    public static void Main(string[] args)
    {
        double raio, area;

        Console.WriteLine("Qual o comprimento do raio da esfera?");
        double.TryParse(Console.ReadLine(), out raio);

        area = 4 * Math.PI * Math.Pow(raio, 2);

        Console.WriteLine("A área da esfera é: " + area);

        Console.ReadKey();
    }
}