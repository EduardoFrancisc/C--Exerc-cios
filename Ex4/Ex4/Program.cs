internal class Program
{
    //Faça um programa que calcule a gorjeta a ser paga de uma conta de restaurante. A gorjeta é calculada como sendo 10% do valor da conta, que deve ser informado pelo usuário.
    public static void Main(string[] args)
    {
        double totalConta, gorjeta = 0;

        Console.WriteLine("Qual foi o valor total da conta?");
        double.TryParse(Console.ReadLine(), out totalConta);

        gorjeta = totalConta * 0.10;

        Console.WriteLine("O valor da gorjeta é " + gorjeta);
        Console.ReadKey();
    }
}