using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetInvestimentoDigital.Models;
using TargetInvestimentoDigital.Models.Contracts;
using TargetInvestimentoDigital.Repositorios;

namespace TargetInvestimentoDigital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _cadastroRepository;
        public CustomerController(ICustomerRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CustomerRequest request)
        {
            var customer = new Customer(request);
            _cadastroRepository.Cadastrar(customer);

            

            var response = CreateResponse(customer);
            return Ok(response);
        }

        
        private static CustomerResponse CreateResponse(Customer customer)
        {
            CustomerResponse response = new CustomerResponse()
            {
                Id = customer.IdExterno,
                NameCompleto = customer.NomeCompleto,
                DataDeNascimento = customer.DataDeNascimento,
                CPF = customer.CPF,
                EnderecoPessoal = customer.EnderecoPessoal,
                RendaMensal = customer.RendaMensal
            };
            return (response);
        }
    }
}
