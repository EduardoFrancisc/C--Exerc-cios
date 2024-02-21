using Biblioteca;
using static System.Net.Mime.MediaTypeNames;

public class Program {
    public static void MenuPadrao()
    {
        Console.Clear();
        Console.WriteLine(" Selecione uma das opções abaixo:");
        Console.WriteLine("    1 - Pesquisar Pessoa      ");
        Console.WriteLine("    2 - Adicionar nova Pessoa ");
        Console.WriteLine("    3 - Sair                  ");
    }

    public static void MenuInclusao(ICadastrarPessoa i)
    {
        double altura;
        bool deficiencia;
        DateTime dataNascimento;

        Console.Clear();
        Console.WriteLine("Qual o Nome da Pessoa que deseja adicionar?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual o Sobrenome da Pessoa que deseja adicionar?");
        string sobrenome = Console.ReadLine();
        Console.WriteLine("Qual a altura da Pessoa que deseja adicionar?");
        double.TryParse(Console.ReadLine(), out altura);
        Console.WriteLine("Qual a data de Nascimento no formato [dd/mm/yyyy]");
        DateTime.TryParse(Console.ReadLine(), out dataNascimento);
        Console.WriteLine("A Pessoa que deseja adicionar pussui alguma Deficiência? [true | false]");
        bool.TryParse(Console.ReadLine(), out deficiencia);

        Console.Clear();
        Console.WriteLine("OS DADOS ABAIXO ESTÃO CORRETOS?");
        Console.WriteLine("Nome: " + nome + " " + sobrenome);
        Console.WriteLine("Idade: " + Pessoa.CalculaIdade(dataNascimento));
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Possui deficiência: " + deficiencia);
        Console.WriteLine("Data de Nascimento: " + dataNascimento.ToString("dd/MM/yyyy"));
        string confirmacaoAdicao = Console.ReadLine();
        confirmacaoAdicao.ToLower();


        if (confirmacaoAdicao == "sim")
        {
            Console.WriteLine("Pessoa Adicionada com Sucesso!!!");
            Pessoa pessoa = new(nome, sobrenome, altura, deficiencia, dataNascimento);
            i.AdicionarPessoa(pessoa);
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Pessoa não adicionada");
            Console.ReadKey();
            Console.Clear();
            return;
        }
    }

    public static void MenuConsulta(ICadastrarPessoa i)
    {

        string pesquisa = string.Empty;
        while (pesquisa != "x" && pesquisa != "X")
        {
            Console.WriteLine("Qual nome deseja pesqusiar?");
            pesquisa = Console.ReadLine();

            Pessoa auxPessoa = i.ListaPessoa().Find(s => s.Nome.Contains(pesquisa));

            if (auxPessoa != null)
            {
                Console.WriteLine($"{auxPessoa.Nome} se encontra na lista");
                Console.WriteLine();
                Console.WriteLine("Nome: " + auxPessoa.Nome);
                Console.WriteLine("Idade: " + auxPessoa.Idade);
                Console.WriteLine("Altura: " + auxPessoa.Altura);
                Console.WriteLine("Possui deficiência: " + auxPessoa.Deficiente);
                Console.WriteLine("Data de Nascimento: " + auxPessoa.DataNascimento.ToString("dd/MM/yyyy"));

                Console.ReadKey();
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Entrada inválida");
                Console.ReadKey();
                break;
            }
        }

    }

    public static void Main(string[] args)
    {
        ICadastrarPessoa i = new CadastraPessoaEmMemoria();
        /*instanciando entidades*/

        try
        {
            while (true)
            {
                MenuPadrao();

                int decisaoMenu;
                int.TryParse(Console.ReadLine(), out decisaoMenu);

                if (decisaoMenu == 1) //Pesquisar Pessoa
                {
                    MenuConsulta(i);

                }
                else if (decisaoMenu == 2) //Adicionar nova Pessoa
                {
                    MenuInclusao(i);

                }
                else if (decisaoMenu == 3) //Sair 
                {
                    Console.WriteLine("Obrigado por usar esta Aplicação");
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada Inválida");
                }
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }}
