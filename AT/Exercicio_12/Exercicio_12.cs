using Exe_09;
using Exe_11;
using System;

namespace Exe_12
{
    public class Exercicio_12
    {
        /// <summary>
        /// Manipulação de Arquivos com Herança e Polimorfismo - Formatos de Exibição
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");


            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Caminho do arquivo de banco de dados de produtos
            string dataBasePath = @"C:/_AT_CSharp/contatos.txt";
            Diretorios.CheckAndCreateFile(dataBasePath);

            Contato contato = new Contato();

            // Menu de opções
            while (true)
            {
                Console.WriteLine(@"Selecione uma das opções abaixo:
1 - Adicionar Contato
2 - Listar Contatos cadastrados
3 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Informe o seu nome: ");
                        contato.Nome = Console.ReadLine();

                        Console.Write("Informe o seu telefone: ");
                        contato.Telefone = Console.ReadLine();

                        Console.Write("Informe o seu e-mail: ");
                        contato.Email = Console.ReadLine();

                        contato.AdicionarContato(dataBasePath, contato);
                        break;
                    case "2":
                        SubMenu(contato, dataBasePath);
                        break;
                    case "3":
                        Console.WriteLine("Encerrando programa...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }


        /// <summary>
        /// Submenu com opções de formatação
        /// </summary>
        private void SubMenu(Contato contato, string dataBasePath)
        {
            var lista  = contato.ListarContatosCadastrados(dataBasePath);

            // Menu de opções
            while (true)
            {
                Console.WriteLine(@"Selecione uma das opções abaixo:
1 - Markdown (formato estruturado para exibição em Markdown)
2 - Tabela (formatado como uma tabela no terminal)
3 - Texto Puro (exibição simples em texto)
4 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        var style1= new MarkdownFormatter();
                        style1.ExibirContatos(lista);
                        return;
                    case "2":
                        var style2 = new TabelaFormatterRaw();
                        style2.ExibirContatos(lista);
                        return;
                    case "3":
                        var style3= new RawTextFormatter();
                        style3.ExibirContatos(lista);
                        return;
                    case "4":
                        Console.WriteLine("Encerrando programa...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
