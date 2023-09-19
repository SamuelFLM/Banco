using banco.Cliente;
using banco.Conta;
using banco.Dados;
using banco.Pessoa;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Fisica p1 = new Fisica(1000, "Samuel", 21, "283.123.736-02");
        Juridica j1 = new Juridica(35, "Bruno", 45, "SOLUÇÔES LTDA", "51.124.666/0000-66");

        Corrente c1 = new Corrente(13, 00523, 21, 5000m, "SALAME", 0.0m);
        Poupanca cp1 = new Poupanca(234, 13512, 00, 10000000m, "PUDIM", 2);

        DadosConta dadosConta = new DadosConta();

        dadosConta.Correntes.Add(c1);
        dadosConta.Poupancas.Add(cp1);

        DadosPessoa dadosPessoa = new DadosPessoa();

        dadosPessoa.Fisicas.Add(p1);
        dadosPessoa.Juridicas.Add(j1);

        DadosCliente dadosCliente = new DadosCliente();

        dadosCliente.DadosContas.Add(dadosConta);
        dadosCliente.DadosPessoas.Add(dadosPessoa);

        Cliente cliente = new Cliente();

        cliente.Dados.Add(dadosCliente);

        string serialiarDadosCliente = JsonConvert.SerializeObject(cliente, Formatting.Indented);

        File.WriteAllText("clientes.json", serialiarDadosCliente);

    }
}