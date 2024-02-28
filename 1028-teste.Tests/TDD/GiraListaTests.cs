using _1028_testes.TDD;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _1028_teste.Tests.TDD
{
    /*
     Exemplo: Girar Lista
	    -recebe uma lista de numeros
	    -move o primeiro item para o fim
	    -retorna a nova lista     
     */

    public class GiraListaTests
    {
        [Fact]
        public void DeveMoverOPrimeiroItemParaOFinalNumaListaCom4Itens()
        {
            //Arrange
            var lista = new List<int> { 10, 15, 20, 30 };
            var gira = new GiraLista();

            //Act
            var result = gira.Girar(lista);

            //Assert
            result.Should().HaveCount(4);
            result.Should().StartWith(15);
            result.Should().EndWith(10);
        }

        [Fact]
        public void DeveMoverOPrimeiroItemParaOFinalNumaListaCom3Itens()
        {
            //Arrange
            var lista = new List<int> { 12, 18, 30 };
            var gira = new GiraLista();

            //Act
            var result = gira.Girar(lista);

            //Assert
            result.Should().HaveCount(3);
            result.Should().StartWith(18);
            result.Should().EndWith(12);
        }

        //[Fact]
        //public void DeveMoverOPrimeiroItemParaOFinalNumaListaCom5Itens()
        //{
        //    //Arrange
        //    var lista = new List<int> { 1, 2, 30, 50, 100 };
        //    var gira = new GiraLista();

        //    //Act
        //    var result = gira.Girar(lista);

        //    //Assert
        //    result.Should().HaveCount(5);
        //    result.Should().StartWith(2);
        //    result.Should().EndWith(1);
        //}

        [Fact]
        public void DeveLancarExcessaoNumaListaVazia()
        {
            //Arrange
            var lista = new List<int>();
            var gira = new GiraLista();

            //Act
            Action act = () => gira.Girar(lista);

            //Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("A lista deve conter mais de um elemento");
        }

        [Fact]
        public void DeveLancarExcessaoNumaListaCom1Elemento()
        {
            //Arrange
            var lista = new List<int> { 55 };
            var gira = new GiraLista();

            //Act
            Action act = () => gira.Girar(lista);

            //Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("A lista deve conter mais de um elemento");
        }
    }
}
