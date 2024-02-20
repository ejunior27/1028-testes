using _1028_testes;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _1028_teste.Tests
{
    public class AssertCollectionsTests
    {
        [Fact]
        public void Funcionario_DefinirHabilidades_NaoDevePossuirHabilidadesVazias()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Eduardo", 10000);

            // Assert
            Assert.All(funcionario.Habilidades, habilidade => Assert.False(string.IsNullOrWhiteSpace(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorDevePossuirHabilidadeBasica()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Eduardo", 1000);

            // Assert
            //Assert.Contains("POO", funcionario.Habilidades);

            funcionario.Habilidades.Should().Contain("POO");
            funcionario.Habilidades.Should().HaveCountGreaterThanOrEqualTo(2);
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadeAvancada()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Eduardo", 1000);

            // Assert
            //Assert.DoesNotContain("Microservices", funcionario.Habilidades);

            funcionario.Habilidades.Should().NotContain("Microservices");            
        }
    }
}
