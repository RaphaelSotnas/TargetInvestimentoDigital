using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetInvestimentoDigital.Models.Contracts;

namespace TargetInvestimentoDigital.Models
{
    public class Cliente
    {
        public Cliente(ClienteRequest request)
        {
            NomeCompleto = request.NameCompleto;
            DataDeNascimento = request.DataDeNascimento;
            CPF = request.CPF;
            EnderecoPessoal = request.EnderecoPessoal;
            RendaMensal = request.RendaMensal;
            OferecerPlanoVip(request);
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public int CPF { get; private set; }
        public Endereco EnderecoPessoal { get; private set; }
        public double RendaMensal { get; private set; }


        public bool OferecerPlanoVip(ClienteRequest request)
        {
            if(request.RendaMensal >= 6000)
            {
                return true;
            }
            return false;
        }
    }
}
