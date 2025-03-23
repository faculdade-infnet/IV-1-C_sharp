using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoais
{
    public struct Documentacao
    {
        public Documentacao()
        {
            this.CPF = string.Empty;
            this.RG = string.Empty;
        }

        public Documentacao(string cpf, string rg)
        {
            this.CPF = cpf;
            this.RG = rg;
        }

        public string CPF { get; set; }
        public string  RG { get; set; }

        override public string ToString()
        {
            return $"{this.RG} - {this.CPF}";
        }
    }
}
