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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _cadastroRepository;
        
        public ClienteController(IClienteRepository cadastroRepository )
        {
            _cadastroRepository = cadastroRepository;
          
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteRequest request)
        {
            var cliente = new Cliente(request);
            
            var cadastrado = _cadastroRepository.Cadastrar(cliente);

            ClienteResponse clienteResponse = new ClienteResponse(cliente,cadastrado);
            return Ok(clienteResponse);
        }
        
    }
}
