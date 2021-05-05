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

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        [InlineData(6,7,13)]     
        public void Calculadora_Retorna_ValorSomaCorretos(int v1, int v2, int total)
        {
            //arrange
            var calculadora = new Calculadora();

            //act
            var resultado = calculadora.Somar(v1, v2);

            //assert
            Assert.Equal(total, resultado);
        }
    }
}
