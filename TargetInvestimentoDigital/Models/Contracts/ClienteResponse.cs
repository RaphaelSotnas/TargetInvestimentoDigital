using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetInvestimentoDigital.Models.Contracts
{
    public class ClienteResponse
    {
        public ClienteResponse(Cliente cliente, bool cadastrado)
        {
            CPF = cliente.CPF;
            DataDeNascimento = cliente.DataDeNascimento;
            EnderecoPessoal = cliente.EnderecoPessoal;
            NomeCompleto = cliente.NomeCompleto;
            RendaMensal = cliente.RendaMensal;
            OferecerPlanoVip = cliente.OferecerPlanoVip();
            Cadastrado = cadastrado;

        }



        public string NomeCompleto { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string CPF { get; set; }
        public Endereco EnderecoPessoal { get; set; }
        public double RendaMensal { get; set; }
        public bool Cadastrado { get; set; }
        public bool OferecerPlanoVip { get; set; }
    }
}
