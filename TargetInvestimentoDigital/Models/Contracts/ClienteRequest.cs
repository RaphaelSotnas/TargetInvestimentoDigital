using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TargetInvestimentoDigital.Models.Contracts
{
    public class CustomerRequest
    {
        [Required]
        public string NameCompleto { get; set; }
        [Required]
        public DateTime DataDeNascimento { get; set; }
        [Required]
        public int CPF { get; set; }
        [Required]
        public Endereco EnderecoPessoal { get; set; }
        [Required]
        public DadosFinanceiros RendaMensal { get;  set; }
    }
}
