using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TargetInvestimentoDigital.Models.Contracts
{
    public class ClienteRequest
    {
        [Required]
        public string NomeCompleto { get; set; }
        [Required]
        public DateTime DataDeNascimento { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public Endereco EnderecoPessoal { get; set; }
        [Required]
        public double RendaMensal { get; set; }
    }
}
