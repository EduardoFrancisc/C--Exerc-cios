class Ex16
{
    //Faça um programa que leia uma opção de um menu sendo [1] Soma, [2] Subtração, [3] Multiplicação e [4] Divisão. Se a opção for válida, o programa deverá ler os operandos, realizar a operação e mostrar o resultado. Caso contrário, o programa deverá exibir uma mensagem de operação inválida.
    public static void Menu()
    {
        Console.WriteLine(" ------------------------- ");
        Console.WriteLine("|     SOMA         (+)    |");
        Console.WriteLine("|     SUBTRAÇÃO    (-)    |");
        Console.WriteLine("|     MULTIPLICAÇÃO(*)    |");
        Console.WriteLine("|     DIVISÃO      (/)    |");
        Console.WriteLine("|     SAIR         (X)    |");
        Console.WriteLine(" ------------------------- ");
        Console.WriteLine("QUAL OPERAÇÃO DESEJA USAR?");
    }
    public static void Calculos(string operacao)
    {
        int num1, num2, resultado;

        Console.WriteLine("DIGITE DOIS NUMEROS:");
        int.TryParse(Console.ReadLine(), out num1);
        int.TryParse(Console.ReadLine(), out num2);

        if (operacao == "+")
        {
            resultado = num1 + num2;
            Console.WriteLine($"{num1}{operacao}{num2} = {resultado}");
        }
        else if (operacao == "-")
        {
            resultado = num1 - num2;
            Console.WriteLine($"{num1}{operacao}{num2} = {resultado}");
        }
        else if (operacao == "*")
        {
            resultado = num1 * num2;
            Console.WriteLine($"{num1}{operacao}{num2} = {resultado}");
        }
        else if (operacao == "/")
        {
            resultado = num1 / num2;
            Console.WriteLine($"{num1}{operacao}{num2} = {resultado}");
        }
        else
        {
            Console.WriteLine("OPERAÇÃO INVÁLIDA");
        }
    }

    public static void Main(string[] args)
    {
        try
        {
            string operacao;

            while (true)
            {

                Menu();
                operacao = Console.ReadLine().ToUpper();

                if (operacao == "X")
                {
                    Console.WriteLine("Obrigado por usar esta calculadora.");
                    break;
                }

                Calculos(operacao);
                Console.ReadKey();
                Console.Clear();
            }
        }

        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            //outras trativas
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("o valor máximo permitido é: " + int.MaxValue);
            //outras trativas
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Não existe divisão por zero. Saindo do programa.");
            //outras trativas
        }
    }
}