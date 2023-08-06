class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite três numeros:");
        float num1, num2, num3;

        float.TryParse(Console.ReadLine(), out num1);
        float.TryParse(Console.ReadLine(), out num2);
        float.TryParse(Console.ReadLine(), out num3);

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"O numero {num1} é maior que {num2} e {num3}");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine($"O numero {num2} é maior que {num3} e {num1}");
        }
        else
        {
            Console.WriteLine($"O numero {num3} é maior que {num2} e {num1}");
        }

        Console.ReadKey();
    }
}