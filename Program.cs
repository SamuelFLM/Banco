using banco.Cliente;
using banco.Conta;
using banco.Pessoa;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        Cliente cliente = new Cliente();

        Fisica p1 = new Fisica(1, "Samuel", 21, "283.123.736-02");

        Corrente c1 = new Corrente(1, 00523, 21, 5000m, "SALAME", 0.0m);

        PessoaConta pessoaContaCorrente = new PessoaConta(pessoaFisica: p1, contaCorrente: c1);

        cliente.PessoaContas.Add(pessoaContaCorrente);


        Juridica j1 = new Juridica(2, "EMPRESA EMPANADOS LTDA", "0992-2323124/00001.1");
        Poupanca poupanca = new Poupanca(2, 23341, 321342, 10000000m, "ACTIVIA", 10);

        PessoaConta pessoaJuridicaPoupanca = new PessoaConta(pessoaJuridica: j1, contaPoupanca: poupanca);

        cliente.PessoaContas.Add(pessoaJuridicaPoupanca);



        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented
        };


        string serialiarDadosCliente = JsonConvert.SerializeObject(cliente, settings);

        File.WriteAllText("clientes.json", serialiarDadosCliente);

    }
}