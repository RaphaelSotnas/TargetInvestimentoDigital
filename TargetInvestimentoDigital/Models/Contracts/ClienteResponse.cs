using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TargetInvestimentoDigital.Models.Contracts
{
    public class CustomerResponse
    {
        public string Id { get; set; }
        public string NameCompleto { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int CPF { get; set; }
        public Endereco EnderecoPessoal { get; set; }
        public DadosFinanceiros RendaMensal { get; set; }

        
    }
}
