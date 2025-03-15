using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /// <summary>
    /// Criando Métodos de Propriedade (Getters e Setters)
    /// </summary>
    public class Exercicio_05
    {
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Criando Métodos de Propriedade (Getters e Setters) ##########\n");

            // Exercício 5
            var ingresso = new Ingresso();            
            ingresso.SetNomedoShow("Show do Nirvana");
            ingresso.SetPreco(350.00);
            ingresso.SetQuantidadeDisponivel(80);

            ingresso.GetNomedoShow();
            ingresso.GetPreco();
            ingresso.GetQuantidadeDisponivel();
            ingresso.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}
