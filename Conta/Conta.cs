
namespace banco.Conta
{
    public abstract class Conta
    {
        public Conta() { }
        public Conta(int agencia, int numero, decimal saldo, string banco)
        {
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
            Banco = banco;
        }
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
            if (Saldo >= valor) => Saldo -= valor;
            else => throw new Exception("Valor não pode ser maior que saldo disponivel.")
        }

        public Depositar(decimal valor)
        {
            Saldo += valor;
        }

    }
}