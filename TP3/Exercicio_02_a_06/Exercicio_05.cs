using System;

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

            Console.WriteLine($"Nome do Show: {ingresso.GetNomedoShow()}");
            Console.WriteLine($"Preço do Ingresso: {ingresso.GetPreco():C}");
            Console.WriteLine($"Ingressos Disponíveis: {ingresso.GetQuantidadeDisponivel()} unidades");

            Console.ReadKey();
        }
    }
}
