using Aula_06.Entidades;

namespace Aula_06
{
    public class InstanciaDeClassSimples
    {
        /// <summary>
        /// Metodo para instanciar uma class simples
        /// </summary>
        internal void InstanciaSimples()
        {
            Console.WriteLine("\n########### Instancia de Class Simples ###########");

            Person1 pessoa1 = new Person1();
            pessoa1.Nome = "Roberval Firmino";
            pessoa1.Endereco = "Rua de Cima, n° 1";
            pessoa1.Nascimento = new DateTime(1965, 04, 04);

            Console.WriteLine($"Nome: {pessoa1.Nome}");
            Console.WriteLine($"Endereco: {pessoa1.Endereco}");
            Console.WriteLine($"Nascimento: {pessoa1.Nascimento:d}");
            Console.WriteLine();

            Person1 pessoa2 = new()
            {

                Nome = "Clarisbela de Jesus",
                Endereco = "Rua de Baixo, n° 2",
                Nascimento = new DateTime(1970, 02, 28)
            };

            Console.WriteLine($"Nome: {pessoa2.Nome}");
            Console.WriteLine($"Endereco: {pessoa2.Endereco}");
            Console.WriteLine($"Nascimento: {pessoa2.Nascimento:d}");
        }
    }
}
