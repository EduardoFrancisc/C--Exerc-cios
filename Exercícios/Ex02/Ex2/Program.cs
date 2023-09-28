internal class Program
{
    //Faça um programa para calcular a média de duas notas digitadas pelo usuário.
    public static void Main(string[] args)
    {
        float nota1, nota2, media;

        Console.WriteLine("Digite duas notas:");
        float.TryParse(Console.ReadLine(), out nota1);
        float.TryParse(Console.ReadLine(), out nota2);

        media = (nota1 + nota2) / 2;

        Console.WriteLine("A média das notas é: " + media);


        Console.ReadKey();
    }
}