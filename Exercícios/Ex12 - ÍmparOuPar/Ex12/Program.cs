 class Program
{
    //Faça um programa que leia um número e mostre se o mesmo é par ou ímpar.
    public static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Digite um numero:");
        int.TryParse(Console.ReadLine(), out num);

        if (num%2 == 0)
        {
            Console.WriteLine($"O numero {num} é Par");
        }
        else
        {
            Console.WriteLine($"O numero {num} é Ímpar");
        }

        Console.ReadKey();
    }
}