using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetInvestimentoDigital.Models.Contracts;

namespace TargetInvestimentoDigital.Models
{
    public class Customer
    {
        public Customer(CustomerRequest request)
        {
            var random = new Random();
            IdExterno = "cus_" + random.Next(123);
            NomeCompleto = request.NameCompleto;
            DataDeNascimento = request.DataDeNascimento;
            CPF = request.CPF;
            EnderecoPessoal = request.EnderecoPessoal;
            RendaMensal = request.RendaMensal;
        }

        public int Id { get; }
        public string IdExterno { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int CPF { get; set; }
        public Endereco EnderecoPessoal { get; private set; }
        public DadosFinanceiros RendaMensal { get; private set; }

    }
}
