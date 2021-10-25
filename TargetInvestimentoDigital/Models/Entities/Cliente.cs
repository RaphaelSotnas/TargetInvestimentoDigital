using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetInvestimentoDigital.Models.Contracts;

namespace TargetInvestimentoDigital.Models
{
    public class Cliente
    {
        List<string> erros = new List<string>();
        public Cliente(ClienteRequest request)
        {
            if (NomeCompletoEhValido(request.NomeCompleto))
            {
                NomeCompleto = request.NomeCompleto;
            }
            else
            {
                erros.Add("Nome é inválido");
            }
            
            if (DataDeNascimentoEhValido(request.DataDeNascimento))
            {
                DataDeNascimento = request.DataDeNascimento;
            }
            else
            {
                erros.Add("Data de Nascimento inválida");
            }
            
            if (CpfEhValido(request.CPF))
            {
                CPF = request.CPF;
            }
            else
            {
                erros.Add("CPF inválido");
            }

            if (EnderecoPessoalEhValido(request.EnderecoPessoal))
            {

                EnderecoPessoal = request.EnderecoPessoal;
            }
            else
            {
                erros.Add("Endereço Pessoal inválido");
            }

            if (RendaMensalEhValida(request.RendaMensal))
            {
                RendaMensal = request.RendaMensal;
            }
            else
            {
                erros.Add("Renda Mensal não válida");
            }
            
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public string CPF { get; private set; }
        public Endereco EnderecoPessoal { get; private set; }
        public double RendaMensal { get; private set; }

        public bool OferecerPlanoVip()
        {
            if(RendaMensal >= 6000)
            {
                return true;
            }
            return false;
        }
        public bool OferecerPlanoVip(ClienteRequest request)
        {
            if(request.RendaMensal >= 6000)
            {
                return true;
            }
            return false;
        }

        public bool NomeCompletoEhValido(string nomeCompleto) 
        {
            if (nomeCompleto.All(x => char.IsDigit(x))) 
            {
                return false;
            }
            return false;
        }

        public bool DataDeNascimentoEhValido(DateTime dataDeNascimento)
        {
            var dataMenos18anos = DateTime.Now.AddYears(-18);
            if(dataMenos18anos >= dataDeNascimento)
            {
                return true;
            }
            return false;
        }

        public bool CpfEhValido(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cpfTemporario;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            cpfTemporario = cpf.Substring(0, 9);
            soma = 0;

            for(int i = 0; i < 9; i++)
                soma += int.Parse(cpfTemporario[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 9;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            cpfTemporario = cpfTemporario + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpfTemporario[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }


        public bool EnderecoPessoalEhValido(Endereco endereco)
        {
            var resultado = endereco.CepEhValido(endereco);

            return resultado;
        }

        public bool RendaMensalEhValida(double rendaMensal)
        {
            if(rendaMensal <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
