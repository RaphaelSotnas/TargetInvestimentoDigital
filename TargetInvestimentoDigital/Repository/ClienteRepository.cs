using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetInvestimentoDigital.Models;
using TargetInvestimentoDigital.Models.Contracts;

namespace TargetInvestimentoDigital.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        
        public bool Cadastrar(Cliente cliente)
        {
            //AplicacaoContext aplicacaoContext = new AplicacaoContext();
            //aplicacaoContext.Cliente.Add(cliente);
            //aplicacaoContext.SaveChanges();
            return true;
        }

        
    }
}
