using System.Drawing;

internal class Program
{
    //Faça um programa que troque o valor de duas variáveis.Por exemplo, o programa lê n1 igual a 3 e n2 a 17, e mostra n1 igual a 17 e n2 a 3.
    public static void Main(string[] args)
    {
        int n1 = 3,n2 = 17,c=0;

        Console.WriteLine("Valores das variáveis:");
        Console.WriteLine("N1: " + n1);
        Console.WriteLine("N2: " + n2);

        c = n1;
        n1= n2;
        n2= c;

        Console.WriteLine("Novos valores das variáveis:");
        Console.WriteLine("N1: " + n1);
        Console.WriteLine("N2: " + n2);
        Console.ReadKey();


    }
}