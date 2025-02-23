using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas._25_02_14.Entidades
{
    public class Person_01
    {
        // Field
        public string Nome = string.Empty;
        // Property
        public DateTime Nascimento { get; set; } = DateTime.MinValue;        
        

        private string _endereco;
        public string Endereço
        {
            get
            { 
                return _endereco; 
            }
            set
            {
                _endereco = value; 
            }
        }

    }    
}
