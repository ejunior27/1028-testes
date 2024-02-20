using _1028_testes;
using Xunit;

namespace _1028_teste.Tests
{
    public class AnagramaTests
    {
        [Theory(DisplayName = "Anagramas Verdadeiros", Skip = "Correção do código")]
        [Trait("Retornos verdadeiros","Anagramas reais")]
        [InlineData("amor","roma")]
        [InlineData("carro", "corar")]
        [InlineData("pedra", "padre")]
        [InlineData("1234", "4321")]        
        public void VerificarAnagrama_AnagramaVerdadeiro_RetornaVerdadeiro(string palavra1, string palavra2)
        {
            //Arrange
            var anagrama = new Anagrama();

            //Act
            bool result = anagrama.VerificarAnagrama(palavra1, palavra2);

            //Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Palavras com tamanhos diferentes", Skip = "Nova versão")]
        [Trait("Retornos falsos", "Tamanhos diferentes")]
        public void VerificarAnagrama_AnagramaComPalavrasDeTamanhosDiferentes_RetornaFalso()
        {
            //Arrange
            string palavra1 = "copo";
            string palavra2 = "xicara";

            var anagrama = new Anagrama();

            //Act
            bool result = anagrama.VerificarAnagrama(palavra1, palavra2);

            //Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Palavras com espaços")]
        [Trait("Retornos falsos", "Com espaços")]
        public void VerificarAnagrama_AnagramaComEspacosVazios_RetornaFalso()
        {
            //Arrange
            string palavra1 = "    ";
            string palavra2 = "    ";

            var anagrama = new Anagrama();

            //Act
            bool result = anagrama.VerificarAnagrama(palavra1, palavra2);

            //Assert
            Assert.False(result);
        }

        [Theory(DisplayName = "Palavras Nulas")]
        [Trait("Retornos falsos", "Palavras Nulas")]
        [InlineData(null, null)]
        [InlineData(null, "amor")]
        [InlineData("roma", null)]
        public void VerificarAnagrama_PalavrasNulas_RetornaFalso(string palavra1, string palavra2)
        {
            //Arrange
            var anagrama = new Anagrama();

            //Act
            bool result = anagrama.VerificarAnagrama(palavra1, palavra2);

            //Assert
            Assert.False(result);
        }

        [Theory(DisplayName = "Palavras com letras diferentes")]
        [Trait("Retornos falsos", "Letras diferentes")]
        [InlineData("avo","voe")]
        [InlineData("amor", "dado")]
        [InlineData("bola", "lobo")]
        public void VerificarAnagrama_PalavrasTamanhosIguaisNaoNulasLetrasDiferentes_RetornaFalso(string palavra1, string palavra2)
        {
            //Arrange
            var anagrama = new Anagrama();

            //Act
            bool result = anagrama.VerificarAnagrama(palavra1, palavra2);

            //Assert
            Assert.False(result);
        }
    }
}