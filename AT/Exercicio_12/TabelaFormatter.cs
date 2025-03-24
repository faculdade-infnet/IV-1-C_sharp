using Exe_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_12
{
    public class TabelaFormatterRaw : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("| Nome | Telefone | Email |");
            Console.WriteLine("----------------------------------------");

            foreach (var item in contatos)
            {
                Console.WriteLine($"| {item.Nome} | {item.Telefone} | {item.Email} |");
            }

            Console.WriteLine();
        }
    }    
}
