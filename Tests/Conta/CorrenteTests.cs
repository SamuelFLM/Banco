using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using banco.Conta;

namespace Tests.Conta
{
    public class CorrenteTests
    {
        private Corrente _corrente;
        public CorrenteTests()
        {
            _corrente = new Corrente();
        }

        [Fact]
        public void TestaValorDaTaxaMensalERetornar()
        {
            // Given
            _corrente.Saldo = 20m;
            _corrente.TaxaConta = 0.1m;
            // When
            var saldoEsperado = (_corrente.Saldo * _corrente.TaxaConta) + _corrente.Saldo;
            _corrente.CobrancaMensal();
            // Then
            Assert.Equal(saldoEsperado, _corrente.Saldo);
        }
    }
}