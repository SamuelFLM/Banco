
namespace banco.Conta
{
    public class Poupanca : Conta
    {
        public Poupanca() { }
        public Poupanca(int id, int agencia, int numero, decimal saldo, string banco, decimal rendimento) : base(agencia, numero, saldo, banco, id)
        {
            Rendimento = rendimento;
        }

        public decimal Rendimento { get; set; }
        public void RendimentoMensal()
        {
            decimal calculoRendimento = base.Saldo + (Rendimento / 30);
            base.Saldo = calculoRendimento;
        }
    }
}