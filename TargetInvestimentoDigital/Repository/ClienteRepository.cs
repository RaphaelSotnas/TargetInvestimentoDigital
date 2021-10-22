using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetInvestimentoDigital.Models;
using TargetInvestimentoDigital.Models.Contracts;

namespace TargetInvestimentoDigital.Repositorios
{
    public class CustomerRepository : IClienteRepository
    {
        private List<Customer> custumers = new List<Customer>();
        public bool Cadastrar(Customer request)
        {
            custumers.Add(request);
            return true;
        }

        public bool OfertaPlanoVip(Customer customer)
        {
            return true;
        }
    }
}
