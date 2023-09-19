
namespace banco.Conta
{
    public class Corrente : Conta
    {
        public Corrente() { }
        public Corrente(int id, int agencia, int numero, decimal saldo, string banco, decimal taxaConta) : base(agencia, numero, saldo, banco, id)
        {
            TaxaConta = taxaConta;
        }
        public decimal TaxaConta { get; set; }
        public void CobrancaMensal()
        {
            decimal calculoTaxa = (base.Saldo * TaxaConta) + base.Saldo;
            base.Saldo = calculoTaxa;
        }
    }
}