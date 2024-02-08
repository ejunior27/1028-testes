using _1028_testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _1028_teste.Tests
{
    public class MediaNotasTests
    {
        [Fact]
        public void MediaNotas_CalculaMedia_RetornaAlunoAprovadoSemRecuperacao()
        {
            //Arrange
            List<decimal> notas = new() { 7, 8, 9, 10 };
            var mediaNotas = new MediaNotas();

            //Act
            var result = mediaNotas.CalculaMedia(notas, 0);

            //Assert
            Assert.Contains("Parabéns, você foi aprovado! Sua média é: 8,5", result);            
        }

        [Fact]
        public void MediaNotas_CalculaMedia_RetornaAprovadoComRecuperacao()
        {
            //Arrange
            List<decimal> notas = new() { 6, 4, 7, 6 };
            var mediaNotas = new MediaNotas();
            decimal recuperacao = 10;

            //Act
            var result = mediaNotas.CalculaMedia(notas, recuperacao);

            //Assert
            Assert.Contains("Parabéns! Você foi aprovado na recuperação!", result);
            Assert.EndsWith("7,875", result);
        }

        [Fact]
        public void MediaNotas_CalculaMedia_RetornaReprovadoComRecuperacao()
        {
            //Arrange
            List<decimal> notas = new() { 6, 4, 7, 6 };
            var mediaNotas = new MediaNotas();
            decimal recuperacao = 5;

            //Act
            var result = mediaNotas.CalculaMedia(notas, recuperacao);

            //Assert
            Assert.StartsWith("Infelizmente você não foi aprovado na recuperação :(", result);
            Assert.EndsWith("5,375", result);
        }

        [Fact]
        public void MediaNotas_CalculaMedia_RetornaReprovadoSemRecuperacao()
        {
            //Arrange
            List<decimal> notas = new() { 6, 4, 7, 6 };
            var mediaNotas = new MediaNotas();            

            //Act
            var result = mediaNotas.CalculaMedia(notas, null);

            //Assert
            Assert.StartsWith("Infelizmente você não foi aprovado na recuperação :(", result);
            Assert.EndsWith("5,75", result);
        }
    }
}
