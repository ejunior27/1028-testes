using _1028_testes.CodeCoverage;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _1028_teste.Tests.CodeCoverage
{
    public class CpfValidationTests
    {
        [Theory]
        [InlineData("15231766607")]
        [InlineData("78246847333")]
        [InlineData("64184957307")]
        [InlineData("21681764423")]
        [InlineData("13830803800")]
        public void Cpf_ValidarMultiplosNumero_TodosDevemSerValidos(string cpf)
        {
            //Arrange
            var cpfValidation = new CpfValidation();

            //Act & Assert
            cpfValidation.EhValido(cpf).Should().BeTrue();

        }

        [Theory]
        [InlineData("15231766")]
        [InlineData("152317661111111")]
        [InlineData("2222222222")]
        [InlineData("1111")]
        public void Cpf_ValidarMultiplosNumeros_TodosDevemSerInvalidos(string cpf)
        {
            //Arrange
            var cpfValidation = new CpfValidation();

            //Act & Assert
            cpfValidation.EhValido(cpf).Should().BeFalse();
        }
    }
}
