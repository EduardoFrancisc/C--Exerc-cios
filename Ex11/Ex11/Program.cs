class Program
{
    //Faça um programa que leia um número e mostre se o mesmo é positivo, negativo ou zero.
    public static void Main(string[] args)
    {
        float num;
        Console.WriteLine("Digite um numero");
        float.TryParse(Console.ReadLine(), out num);

        if (num == 0)
        {
            Console.WriteLine($" {num} é zero");
        }
        else if (num > 0)
        {
            Console.WriteLine($" {num} é positivo");
        }
        else if (num < 0)
        {
            Console.WriteLine($" {num} é negativo");
        }
    }
}