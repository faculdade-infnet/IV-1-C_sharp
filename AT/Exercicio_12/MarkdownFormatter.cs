using Exe_11;
using System;
using System.Collections.Generic;

namespace Exe_12
{
    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.Write("## Lista de Contatos");

            foreach (var item in contatos)
            {
                Console.WriteLine($"**Nome:** {item.Nome}");
                Console.WriteLine($"\U0001F4DE Telefone: {item.Telefone}");
                Console.WriteLine($"\U0001F4E7 Email: {item.Email}");
            }

            Console.WriteLine();
        }
    }
}
