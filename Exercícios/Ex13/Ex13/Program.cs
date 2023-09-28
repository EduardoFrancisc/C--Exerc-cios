class Program
{
    //Faça um programa que leia dois números e mostre o maior número.
    public static void Main(string[] args)
    {
        float num1, num2;
        Console.WriteLine("Digite dois numeros:");
        float.TryParse(Console.ReadLine(), out num1);
        float.TryParse(Console.ReadLine(), out num2);

        if (num1 > num2)
        {
            Console.WriteLine($"O numero {num1} é maior que {num2}");
        }
        else
        {
            Console.WriteLine($"O numero {num2} é maior que {num1}");
        }

        Console.ReadKey();
    }
}