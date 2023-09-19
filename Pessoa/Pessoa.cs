
namespace banco.Pessoa
{
    public abstract class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, byte idade)
        {
            Nome = nome;
            Idade = idade;
        }
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