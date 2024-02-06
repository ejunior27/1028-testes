using _1028_testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [Fact]
        public void Calculadora_Somar_RetornaValoresSomados()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var result = calculadora.Somar(2, 2);

            //Assert
            Assert.Equal(4, result);
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
