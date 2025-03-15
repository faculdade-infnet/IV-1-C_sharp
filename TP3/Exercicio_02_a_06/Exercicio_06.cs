using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /// <summary>
    ///  Adicionando Construtores à Classe "Ingresso"
    /// </summary>
    public class Exercicio_06
    {
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}:  Adicionando Construtores à Classe \"Ingresso\" ##########\n");


            var ingresso = new Ingresso("Show do Eminem", 420.00, 310);
            ingresso.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}
