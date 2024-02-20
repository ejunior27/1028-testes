using _1028_testes;
using Xunit;
using FluentAssertions;

namespace _1028_teste.Tests
{
    public class AssertNullBoolTests
    {
        [Fact]
        public void Funcionario_Nome_NaoDeveSerNuloOuVazio()
        {
            // Arrange & Act
            var funcionario = new Funcionario("", 1000);

            // Assert
            //Assert.False(string.IsNullOrEmpty(funcionario.Nome));

            funcionario.Nome.Should().NotBeNullOrEmpty();            
        }

        [Fact]
        public void Funcionario_Apelido_NaoDeveTerApelido()
        {
            // Arrange & Act
            var funcionario = new Funcionario("Eduardo", 1000);

            // Assert
            //Assert.Null(funcionario.Apelido);

            funcionario.Apelido.Should().BeNull();

            // Assert Bool
            //Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
            //Assert.False(funcionario.Apelido?.Length > 0);

            funcionario.Apelido.Should().BeNullOrEmpty();
            //funcionario.Apelido.Should().NotBeNullOrEmpty();
        }
    }    
}
