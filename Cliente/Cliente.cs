using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banco.Conta;
using banco.Dados;
using Newtonsoft.Json;

namespace banco.Cliente
{
    public class Cliente
    {
        [JsonProperty("Cliente")]
        public List<DadosCliente> Dados = new List<DadosCliente>();
    }
}