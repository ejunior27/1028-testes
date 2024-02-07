using _1028_testes;
using Xunit;

namespace _1028_teste.Tests
{
    public class CalculadoraTests
    {
        //Triple A
        //Arrange, Act, Assert

        //Nomenclatura de metodos de teste
        //NomeDaClasse_EstadoDoTeste_ResultadoEsperado
        //NomeDaClasse_ResultadoEsperado_EstadoDoTeste
        //EstadoDoTesteRetornoEsperado

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(1,1,2)]
        [InlineData(3,2,5)]
        [InlineData(999,1,1000)]
        [InlineData(0,2,2)]
        public void Calculadora_Somar_RetornaValoresSomados(int v1, int v2, int res)
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var result = calculadora.Somar(v1, v2);

            //Assert
            Assert.Equal(res, result);
        }        

        [Fact]
        public void Calculadora_Dividir_RetornaResultadoDivisao()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var result = calculadora.Dividir(4, 2);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Calculadora_Subtrair_ResultadoDaSubtracao()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var result = calculadora.Subtrair(4, 8);

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Calculadora_Multiplicar_ResultadoDaMultiplicacao()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var result = calculadora.Multiplicar(4, 2);

            //Assert
            Assert.Equal(8, result);
        }
    }
}
