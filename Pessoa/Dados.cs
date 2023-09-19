using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Pessoa
{
    public class DadosPessoa
    {
        public DadosPessoa() { }
        public List<Fisica> Pessoas = new List<Fisica>();
        public List<Juridica> Juridicas = new List<Juridica>();
    }
}