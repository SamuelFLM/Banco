using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Pessoa
{
    public class Fisica : Pessoa
    {
        public Fisica() { }
        public Fisica(int id, string nome, byte idade, string cpf) : base(nome, idade, id)
        {
            CPF = cpf;
        }
        public string CPF { get; set; }
        public override void ValidarDados()
        {
            throw new NotImplementedException();
        }
    }
}