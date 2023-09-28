internal class Ex17
{
    //Faça um programa que leia um caractere e informe se o mesmo é uma vogal ou não.
    private static void Main(string[] args)
    {
        string caracter;

        Console.WriteLine("Escreva uma letra");
        caracter = Console.ReadLine().ToUpper();

        if (caracter == "A" || caracter == "E" || caracter == "I" || caracter == "O" || caracter == "U")
        {
            Console.WriteLine("Letra " + caracter + " é uma vogal.");
        }
        else
        {
            Console.WriteLine("Este Caracter não é uma vogal.");
        }
        Console.ReadKey();
    }
}