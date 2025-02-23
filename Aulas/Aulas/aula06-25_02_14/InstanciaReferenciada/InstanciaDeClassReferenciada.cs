using Aula_06.Entidades;

namespace Aula_06
{
    public class InstanciaDeClassReferenciada
    {
        /// <summary>
        /// Metodo para instanciar uma class que tem outra class referenciada
        /// </summary>
        internal void InstanciaDeOutraInstancia()
        {
            Console.WriteLine("\n########### Instancia de Class Referenciada em outra Class ###########");

            Address endereco = new Address();

            endereco.Logradouro = "Rua Blah";
            endereco.Complemento = "Bloco 1";
            endereco.Bairro = "Centro";
            
            Person2 pessoa = new Person2();
            pessoa.Nome = "Roberval Firmino";
            pessoa.Endereco = endereco;
            pessoa.Nascimento = new DateTime(1965, 04, 04);
            
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Logradouro: {pessoa.Endereco.Logradouro} | Bairro: {pessoa.Endereco.Bairro}");
            Console.WriteLine($"Nascimento: {pessoa.Nascimento:dd/MM/yyyy}");
            Console.WriteLine();
        }
    }
}
