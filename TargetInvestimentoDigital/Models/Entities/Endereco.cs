using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetInvestimentoDigital.Models.Contracts
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
