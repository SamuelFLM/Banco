using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banco.Pessoa;
using banco.Conta;
using Newtonsoft.Json;

namespace banco.Dados
{
    public class DadosCliente
    {
        public DadosCliente() { }
        [JsonProperty("Pessoa")]
        public List<DadosPessoa> DadosPessoas = new List<DadosPessoa>();
        [JsonProperty("Conta")]
        public List<DadosConta> DadosContas = new List<DadosConta>();
    }
}