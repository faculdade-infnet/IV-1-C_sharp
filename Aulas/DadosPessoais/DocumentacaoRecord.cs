using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoais
{
    public record DocumentacaoRecord
    {
        public DocumentacaoRecord(string RG, string CPF)
        {
            this.RG = RG;
            this.CPF = CPF;
        }


        public string CPF { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
    }

    // Parcialmente Imutavel
    public record DocumentacaoRecord1(string RG)
    {
        public string CPF { get; set; } = string.Empty;
    }
}
