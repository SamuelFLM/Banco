using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banco.Conta;

namespace banco.Pessoa
{
    public class PessoaConta
    {

        public PessoaConta() { }

        public PessoaConta(Fisica pessoaFisica, Corrente contaCorrente)
        {
            PessoaFisica = pessoaFisica;
            ContaCorrente = contaCorrente;
        }
        public PessoaConta(Fisica pessoaFisica, Poupanca contaPoupanca)
        {
            PessoaFisica = pessoaFisica;
            ContaPoupanca = contaPoupanca;
        }
        public PessoaConta(Juridica pessoaJuridica, Corrente contaCorrente)
        {
            PessoaJuridica = pessoaJuridica;
            ContaCorrente = contaCorrente;
        }
        public PessoaConta(Juridica pessoaJuridica, Poupanca contaPoupanca)
        {
            PessoaJuridica = pessoaJuridica;
            ContaPoupanca = contaPoupanca;
        }

        public Fisica PessoaFisica { get; set; }
        public Juridica PessoaJuridica { get; set; }
        public Corrente ContaCorrente { get; set; }
        public Poupanca ContaPoupanca { get; set; }

    }
}