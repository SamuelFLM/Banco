using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banco.Conta;
using banco.Pessoa;
using Newtonsoft.Json;

namespace banco.Cliente
{
    public class Cliente
    {
        public Cliente() { }
        [JsonProperty("Cliente")]
        public List<PessoaConta> PessoaContas { get; set; } = new List<PessoaConta>();
    }
}