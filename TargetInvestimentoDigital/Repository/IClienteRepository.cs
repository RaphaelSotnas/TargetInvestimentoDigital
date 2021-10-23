using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetInvestimentoDigital.Models;
using TargetInvestimentoDigital.Models.Contracts;

namespace TargetInvestimentoDigital.Repositorios
{
    public interface IClienteRepository
    {
        public bool Cadastrar(Cliente cliente);
       

    }
}
