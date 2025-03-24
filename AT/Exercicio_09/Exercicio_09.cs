using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exe_09
{
    public class Exercicio_09
    {
        /// <summary>
        /// Controle de Estoque via Linha de Comando
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            var produto = new Produto();
            var produtos = new List<Produto>();

            // Caminho do arquivo de banco de dados de produtos
            string dataBasePath = @"C:/_AT_CSharp/listaProdutos.txt";
            Diretorios.CheckAndCreateFile(dataBasePath);

            // Menu de opções
            while (true)
            {
                Console.WriteLine(@"Selecione uma das opções abaixo:
1 - Inserir Produto
2 - Listar Produtos
3 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (produto.ContarLinhas(dataBasePath) >= 5)
                        {
                            Console.Write("Limite de produtos atingido!");
                        }
                        else
                        {
                            Console.WriteLine("Informe o nome do produto:");
                            string nome = Console.ReadLine();

                            produto.Quantidade = produto.SolicitarQuantidade();
                            produto.Preco = produto.SolicitarPreco();

                            produto.InserirProduto(dataBasePath, produto);
                        }
                        break;
                    case "2":
                        produto.ListarProdutos(dataBasePath);
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
