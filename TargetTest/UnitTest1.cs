using Moq;
using System;
using TargetInvestimentoDigital.Controllers;
using TargetInvestimentoDigital.Models;
using TargetInvestimentoDigital.Models.Contracts;
using TargetInvestimentoDigital.Repositorios;
using Xunit;

namespace TargetTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestandoClienteComNomeInvalido()
        {
            //arrange
            Mock<IClienteRepository> clienteRepositoryMock = new Mock<IClienteRepository>();
            ClienteController clienteController = new ClienteController(clienteRepositoryMock.Object);
            ClienteRequest clienteRequest = new ClienteRequest();

            clienteRequest.NomeCompleto = "25416";
            clienteRequest.CPF = "159-456-523-12";
            clienteRequest.DataDeNascimento = new DateTime(97, 11, 05);
            clienteRequest.RendaMensal = 7000;

            
            //act
            var resultado = clienteController.Post(clienteRequest);

            //assert
            clienteRepositoryMock.Verify();

        }
    }
}
