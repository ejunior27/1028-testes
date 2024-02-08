using _1028_testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _1028_teste.Tests
{
    public class AssertStringTests
    {
        [Fact]
        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Eduardo", "Junior");

            // Assert
            Assert.Equal("Eduardo Junior", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveIgnorarCase()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("eduardo", "junior");

            // Assert
            Assert.Equal("EDUARDO JUNIOR", nomeCompleto, true);
        }

        [Fact]
        
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Eduardo", "Junior");

            // Assert
            Assert.Contains("ardo", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Eduardo", "Junior");

            // Assert
            Assert.StartsWith("Edu", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveAcabarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Eduardo", "Junior");

            // Assert
            Assert.EndsWith("ior", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Eduardo", "Junior");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}
