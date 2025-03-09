using DadosPessoais;

namespace Aula_09
{
    public class Aula09
    {
        /// <summary>
        /// (00:09) Utilziando métodos das Colections
        /// </summary>
        public void ListMethodAdd_AddRange()
        {
            string? selecao1 = null;
            int? selecao = null;
            string[] nomeEstados = { "Rio de Janeiro", "Minas Gerais", "Santa Catarina", "São Paulo", "Paraná", "Bahia" };
            List<string> estados = new();
            estados.AddRange(nomeEstados);
            estados.Add("Rio Grande do Sul");

            DadosPessoais.Address endereco = new();
            endereco.Logradouro = "Rua Blah";
            endereco.Complemento = "Bloco 1";

            //do
            //{
            //    Console.WriteLine("Informe o nome do Estado: ");
            //    selecao1 = Console.ReadLine();                
            //} while (string.IsNullOrWhiteSpace(selecao1));

            //endereco.Estado = selecao1;
            //endereco.Estado = estados.Find(n => n == selecao1);
            //endereco.Estado = estados.FirstOrDefault(e => e.Contains(selecao1, StringComparison.OrdinalIgnoreCase));

            do
            {
                Console.WriteLine("Informe a posiçã odo Estado: ");
                selecao = Convert.ToInt32(Console.ReadLine());
            } while (selecao is null);

            //endereco.Estado = estados.ElementAt(selecao.Value);
            endereco.Estado = estados[selecao.Value];

            Person pessoa = new();
            pessoa.Nome = "Roberval Firmino";
            pessoa.Endereco = endereco;
            pessoa.Nascimento = new DateTime(1965, 04, 04);

            Console.WriteLine($"Endereço: {endereco.Logradouro}");
            Console.WriteLine($"Logradouro: {endereco.Logradouro} | Complemento: {endereco.Complemento}");
            Console.WriteLine($"Bairro: {endereco.Bairro} | Possui número: {(endereco.SemNumero ? "Não" : endereco.Numero)}");
            Console.WriteLine($"Estado: {endereco.Estado}");
            Console.WriteLine($"País: {endereco.Pais}");

            estados.Remove("Minas Gerais");
            estados.RemoveAt(1);
            estados.RemoveRange(2, 3); // Remove a partir do índice 2, + 3 elementos. (Santa Catarina, São Paulo e Paraná)

            Console.ReadKey();
        }

        /// <summary>
        /// (00:54) Trabalhando com o Iteração de listas (ForEach)
        /// </summary>
        public void IteracaoForEach()
        {
            string? selecao = null;
            string[] nomeEstados = { "Rio de Janeiro", "Minas Gerais", "Santa Catarina", "São Paulo", "Paraná", "Bahia" };
            List<string> estados = new();
            estados.AddRange(nomeEstados);
            estados.Add("Rio Grande do Sul");

            foreach (string item in estados)
            {
                Console.WriteLine($"{estados.IndexOf(item)} - {item}");
            }

            Console.WriteLine($"O banco esta nos seguintes {estados.Count} estados.");
            do
            {
                Console.WriteLine("Informe o nome do Estado: ");
                selecao = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(selecao));
        }


        /// <summary>
        /// (01:07) Trabalhando com o funcioamneto do Capacity (armazenamento e uso de memória)
        /// </summary>
        public void CapacityExplicacao()
        {
            string? selecao = null;
            string[] nomeEstados = { "Rio de Janeiro", "Minas Gerais", "Santa Catarina", "São Paulo", "Paraná", "Bahia" };
            List<string> estados = new(10);
            estados.AddRange(nomeEstados);
            estados.Add("Rio Grande do Sul");

            Console.WriteLine($"Capacidade inicial: {estados.Capacity}");
            Console.WriteLine($"Carga inicial: {estados.Count}");
            estados.AddRange(new string[] { "Amazonas", "Pará", "Acre", "Roraima" });
            Console.WriteLine($"Capacidade final: {estados.Capacity}");
            Console.WriteLine($"Carga final: {estados.Count}");
            Console.WriteLine();

        }
    }
}
