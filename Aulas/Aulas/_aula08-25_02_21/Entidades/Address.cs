using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas._25_02_14.Entidades
{
    public class Address_01
    {
        public string Logradouro { get; set; } = string.Empty;
        public string Complemento{ get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        
        // Propriedade somente leitura
        public string Pais{ get; } = "Brasil";

        public int Numero { get; set; }        
        public bool SemNumero
        {
            get {
                return this.Numero <=0; 
            }
        }

    }
}
