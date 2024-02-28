using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using _1028_testes;
using _1028_testes.Services;
using Moq;
using MediatR;

namespace _1028_teste.Tests.Services
{
    public class ClienteServiceTests
    {
        private readonly Mock<IClienteRepository> clienteRepository;
        private readonly Mock<IMediator> mediatr;
        private readonly ClienteService clienteService;

        public ClienteServiceTests()
        {
            clienteRepository = new();
            mediatr = new();
            clienteService = new(clienteRepository.Object, mediatr.Object);
        }

        [Fact(DisplayName = "Adicionar Cliente Válido")]        
        public void Adicionar_Cliente_Valido()
        {
            //Arrange
            var cliente = new Cliente(Guid.NewGuid(), "Vagner", "Silva", new DateTime(1999, 1, 1), "vagner@silva.com", true, DateTime.Now);                      

            //Act
            clienteService.Adicionar(cliente);

            //Assert
            //Assert.True(cliente.EhValido());

            clienteRepository.Verify(x => x.Adicionar(cliente), Times.Once);
            mediatr.Verify(x => x.Publish(It.IsAny<ClienteEmailNotification>(), default), Times.Once);
        }

        [Fact(DisplayName = "Adicionar cliente inválido")]
        public void Adicionar_Cliente_Invalido()
        {
            //Arrange
            var cliente = new Cliente(Guid.NewGuid(), "", "Silva", new DateTime(1999, 1, 1), "vagner@silva.com", true, DateTime.Now);
            
            //Act
            clienteService.Adicionar(cliente);

            //Assert
            //Assert.True(cliente.EhValido());

            clienteRepository.Verify(x => x.Adicionar(cliente), Times.Never);
            mediatr.Verify(x => x.Publish(It.IsAny<ClienteEmailNotification>(), default), Times.Never);
        }

        [Fact(DisplayName = "Obter Clientes Ativos")]
        public void ClienteService_ObterTodosAtivos_DeveRetornarApenasClientesAtivos()
        {
            //Arrange
            var cliente1 = new Cliente(Guid.NewGuid(), "Vagner", "Silva", new DateTime(1999, 1, 1), "vagner@silva.com", true, DateTime.Now);
            var cliente2 = new Cliente(Guid.NewGuid(), "Diogenes", "Lima", new DateTime(1985, 1, 1), "diogenes@lima.com", true, DateTime.Now);

            var listaBanco = new List<Cliente>
            {
                cliente1,
                cliente2
            };            

            clienteRepository.Setup(x => x.ObterTodos())
                .Returns(listaBanco);

            //Act
            var result = clienteService.ObterTodosAtivos();

            //Assert
            result.Should().HaveCount(2);
            clienteRepository.Verify(x => x.ObterTodos(), Times.Once);
        }
    }
}
