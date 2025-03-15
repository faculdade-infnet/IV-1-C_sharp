using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /// <summary>
    /// Testando a Classe "Ingresso"
    /// </summary>
    public class Exercicio_04
    {
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Testando a Classe \"Ingresso\" ##########\n");

            var ingresso = new Ingresso();
            ingresso.NomeDoShow = "Show do Metallica";
            ingresso.Preco = 300.00;
            ingresso.QuantidadeDisponivel = 100;

            ingresso.AlterarPreco(250.00);
            ingresso.AtualizarQuantidade(50);
            ingresso.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}
