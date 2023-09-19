using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Pessoa
{
    public class Juridica : Pessoa
    {
        public Juridica() { }
        public Juridica(string nome, byte idade, string nomeFantasia, string cnpj) : base(nome, idade)
        {
            NomeFantasia = nomeFantasia;
            CNPJ = cnpj;
        }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public override void ValidarDados()
        {
            throw new NotImplementedException();
        }
    }
}