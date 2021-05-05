using System;
using Xunit;

namespace Demo.Teste
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Calculadora_Retorna_ValorSoma()
        {
            //arrange
            var calculadora = new Calculadora();

            //act
            var resultado = calculadora.Somar(2, 2);

            //assert
            Assert.Equal(4, resultado);
        }
    }
}
