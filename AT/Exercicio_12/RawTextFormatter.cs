using Exe_11;
using System;
using System.Collections.Generic;

namespace Exe_12
{ 
    public class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            foreach (var item in contatos)
            {
                Console.WriteLine($"Nome: {item.Nome} | Telefone: {item.Telefone} | Email: {item.Email}");
            }

            Console.WriteLine();
        }
    }
}
