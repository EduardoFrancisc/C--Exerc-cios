class Program
{
    //Faça um programa que calcule o volume de uma caixa d’ água cilíndrica, sendo que os comprimentos do raio e a altura são informados pelo usuário.O volume é calculado multiplicando-se Pi, ao raio ao quadrado, a altura.
    public static void Main(string[] args)
    {
        double raio, altura, volume;

        Console.WriteLine("Qual o comprimento do raio?");
        double.TryParse(Console.ReadLine(), out raio);
        Console.WriteLine("Qual a altura?");
        double.TryParse(Console.ReadLine(), out altura);

        volume = Math.PI * Math.Pow(raio, 2) * altura;

        Console.WriteLine($"O volume da caixa d'água é: {volume:F3}");
        Console.ReadKey();
    }
}