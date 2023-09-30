
namespace banco.Conta
{
    public abstract class Conta
    {
        public Conta() { }
        public Conta(int agencia, int numero, decimal saldo, string banco, int id)
        {
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
            Banco = banco;
            Id = id;
        }
        public int Id { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public string Banco { get; set; }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo:C2}");
        }

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else { throw new Exception("Valor não pode ser maior que saldo disponivel."); }
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

    }
}