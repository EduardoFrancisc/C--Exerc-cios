public class Program
{
    //Faça um programa que calcule o novo valor de um salário a partir de um valor percentual de reajuste. O valor atual do salário e o valor percentual do reajuste devem ser informados pelo usuário como, por exemplo, 7,3%.
    public static void Main(string[] args)
    {
        float salario, percentual, novoSalario, ajuste;
        String controle;

        Console.WriteLine("Qual o atual valor do salário?");
        float.TryParse(Console.ReadLine(), out salario);


        Console.WriteLine("Qual o percentual do ajuste para o salário?");
        float.TryParse(Console.ReadLine(), out percentual);

        Console.WriteLine("Acréscimo(+) ou Decréscimo(-)?");
        controle = Console.ReadLine();

        ajuste = (percentual / 100) * salario;

        switch (controle)
        {
            case "+":
                novoSalario = salario + ajuste;
                Console.WriteLine("O novo salário é: " + novoSalario);
                break;
            case "-":
                novoSalario = salario - ajuste;
                Console.WriteLine("O novo salário é: " + novoSalario);
                break;
            default:
                Console.WriteLine("Entrada inválida");
                 return;
        }
        Console.ReadKey();
    }

}