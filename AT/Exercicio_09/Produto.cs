using System;
using System.Collections.Generic;

namespace Exe_09
{
    public class Produto : Diretorios
    {
        public Produto() { }
        public Produto(string nome, int quantidade, double preco)
        {
            this.Nome = nome;
            this.Quantidade = quantidade;
            this.Preco = preco;
        }

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public void InserirProduto(string dataBasePath)
        {
            Console.WriteLine("Informe o nome do produto:");
            string nome = Console.ReadLine();

            int? tempQuantidade = SolicitarQuantidade();
            double? tempPreco = SolicitarPreco();

            if (string.IsNullOrEmpty(nome) || tempQuantidade == null || tempPreco == null)
                Console.WriteLine("Produto não inserido! Informações inválidas.\n");
            else
            {
                string texto = $"{nome},{tempQuantidade},{tempPreco}";
                EscreverArquivo(dataBasePath, texto);
                Console.WriteLine("Produto Cadastrado com sucesso!\n");
            }
        }

        public void ListarProdutos(string dataBasePath)
        {
            List<Produto> produtos = LerArquivo(dataBasePath);
            foreach (var item in produtos)
            {
                Console.WriteLine($"Produto: {item.Nome} | Quantidade: {item.Quantidade} | Preço: {item.Preco:C2}");
            }

            Console.WriteLine();
        }


        /// <summary>
        /// Solicita um número ao usuário e valida se o número é válido
        /// </summary>
        private int? SolicitarQuantidade()
        {
            int? n1 = null;

            while (!n1.HasValue)
            {
                Console.WriteLine("Digite a Quantidade: ");

                // Tenta converter a entrada para um número valido
                if (!int.TryParse(Console.ReadLine(), out int tempN1))
                    Console.WriteLine("Número Inválido! Você deve informar um número inteiro.\n");
                else
                    n1 = tempN1;
            }

            return n1;
        }

        /// <summary>
        /// Solicita um número ao usuário e valida se o número é válido
        /// </summary>
        private double? SolicitarPreco()
        {
            double? n1 = null;

            while (!n1.HasValue)
            {
                Console.WriteLine("Digite o Preço: ");

                // Tenta converter a entrada para um número valido
                if (!double.TryParse(Console.ReadLine(), out double tempN1))
                    Console.WriteLine("Número Inválido! Você deve informar um número inteiro ou decimal.\n");
                else
                    n1 = tempN1;
            }

            return n1;
        }
    }
}
