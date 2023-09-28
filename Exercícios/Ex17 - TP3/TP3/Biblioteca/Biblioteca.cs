namespace Biblioteca
{
    public interface ICadastrarPessoa
    {
        void AdicionarPessoa(Pessoa pessoa);
        List<Pessoa> ListaPessoa();
    }
    public class Pessoa
    {
        private string _nome { get; set; }
        private string _sobrenome { get; set; }
        private int _idade { get; set; }
        private double _altura { get; set; }
        private DateTime _dataNascimento { get; set; }
        private bool _deficiente { get; set; }

        public Pessoa(string nome, string sobrenome, double altura, bool deficiente, DateTime dataNascimento)
        {
            _nome = nome + " " + sobrenome;
            _altura = altura;
            _dataNascimento = dataNascimento;
            _deficiente = deficiente;
        }

        public Pessoa()
        {
        }

        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
        }
        public double Altura
        {
            get { return _altura; }
        }
        public int Idade
        {
            get { return CalculaIdade(_dataNascimento); }
        }
        public string Nome
        {
            get { return _nome; }
        }
        public bool Deficiente
        {
            get { return _deficiente; }
        }

        //Método que calcula a idade
        public static int CalculaIdade(DateTime dataNascimto)
        {
            int age = 0;

            return DateTime.Now.Year - dataNascimto.Year;
        }
    }
    public class CadastraPessoaEmMemoria : ICadastrarPessoa
    {
        private List<Pessoa> _listPessoa;
        public CadastraPessoaEmMemoria()
        {
            _listPessoa = new List<Pessoa>();
        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            _listPessoa.Add(pessoa);
        }

        public List<Pessoa> ListaPessoa()
        {
            return _listPessoa;
        }
    }
}