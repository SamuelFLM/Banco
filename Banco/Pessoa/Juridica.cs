using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Pessoa
{
    public class Juridica : Pessoa
    {
        public Juridica() { }
        public Juridica(int id, string nome, string cnpj) : base(nome, id)
        {
            CNPJ = cnpj;
        }
        public string CNPJ { get; set; }
        public override void ValidarDados()
        {
            throw new NotImplementedException();
        }
    }
}