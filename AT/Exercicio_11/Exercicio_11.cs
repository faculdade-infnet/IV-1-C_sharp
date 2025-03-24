using Exe_09;
using System;

namespace Exe_11
{
    public class Exercicio_11
    {
        /// <summary>
        /// Manipulação de Arquivos - Cadastro e Listagem de Contatos
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");

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
                        var items =  contato.ListarContatosCadastrados(dataBasePath);

                        foreach (var item in items)
                        {
                            Console.WriteLine($"Nome: {item.Nome} | Telefone: {item.Telefone} | Email: {item.Email}");
                        }

                        Console.WriteLine();
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
    }
}
