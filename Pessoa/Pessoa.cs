
namespace banco.Pessoa
{
    public abstract class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, byte idade, int id)
        {
            Nome = nome;
            Idade = idade;
            Id = id;
        }
        public int Id { get; set; }
        public string _nome;
        public byte _idade;
        public string Nome
        {
            get => _nome;
            set
            {
                if (value != "" && value.Length < 255)
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("Não foi possivel armazena Nome.");
                }
            }
        }
        public byte Idade
        {
            get => _idade;
            set
            {
                if (value > 0 && value <= 120)
                {
                    _idade = value;
                }
                else
                {
                    throw new Exception("Não foi possivel armazena idade.");
                }
            }
        }

        public abstract void ValidarDados();

    }
}