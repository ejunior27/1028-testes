using FluentAssertions;

namespace _1028_mutantes.Tests
{
    public class PessoaTests
    {
        [Fact]
        public void Pessoa_CriacaoOk()
        {
            //Arrange & Act
            var nomeValido = "jesus wildes silva";
            var idadeValida = 33;

            var pessoa = new Pessoa(nomeValido, idadeValida);

            //Assert
            pessoa.Id.Should().NotBeEmpty();
            pessoa.Nome.Should().Be(nomeValido);
            pessoa.Idade.Should().Be(idadeValida);
        }

        [Theory]
        [InlineData(14, false)]
        [InlineData(20, true)]
        [InlineData(18, true)]
        public void TestarMaioridade(int idade, bool maior)
        {
            var pessoa = new Pessoa("fulano de tal", idade);
            var result = pessoa.EhMaiorDeIdade();

            result.Should().Be(maior);
        }

        [Theory]
        [InlineData("invalido")]
        [InlineData(null)]
        public void VerificarNomes_NomesInvalidos(string nome)
        {
            var action = () => new Pessoa(nome, 25);
            action.Should().Throw<Exception>()
                .WithMessage("Nome precisa ser composto por nome e sobrenome");
        }

        [Theory]
        [InlineData("jesus wildes silva")]
        [InlineData("fulano ciclano")]
        public void VerificarNomes_NomesValidos(string nome)
        {
            var action = () => new Pessoa(nome, 25);
            action.Should().NotThrow();
        }
    }
}