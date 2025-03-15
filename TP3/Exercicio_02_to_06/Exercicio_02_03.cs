using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /// <summary>
    /// Imagine que você é responsável pela venda de ingressos para um grande evento musical. É preciso cadastrar ingressos com nome do show, preço e quantidade disponível, bem como atualizar essas informações sempre que algo mudar. Ao final, você deve exibir as informações do ingresso para ter um registro atualizado do sistema.
    /// <list type="bullet">    
    ///     <item>2 - Criando a Classe "Ingresso</item>
    ///     <item>3 - Métodos Básicos da Classe "Ingresso"</item>
    ///     <item>4 - Testando a Classe "Ingresso"</item>
    ///     <item>5 - Criando Métodos de Propriedade (Getters e Setters)</item>
    ///     <item>6 - Adicionando Construtores à Classe "Ingresso"</item>
    /// </list>
    /// </summary>
    public class Exercicio_02_03
    {
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: 'Criando a Classe \"Ingresso\"' e 'Métodos Básicos da Classe \"Ingresso\"' ##########\n");
        }
    }


    /// <summary>
    /// Cada atributo 
    /// </summary>
    public class Ingresso
    {
        public Ingresso() { }

        public Ingresso(string nomedoShow, double preco, int quantidadeDisponivel)
        {
            this.NomeDoShow = nomedoShow;
            this.Preco = preco;
            this.QuantidadeDisponivel = quantidadeDisponivel;
        }

        // Cada atributo é importante para podermos gerar/armazenar as informações de cada ingresso vendido corretamente
        public string NomeDoShow { get; set; }
        public double Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }


        internal void AlterarPreco(double novoPreco) => Preco = novoPreco;
        public void AtualizarQuantidade(int novaQuantidade) => QuantidadeDisponivel = novaQuantidade;


        public void ExibirInformacoes()
        {
            Console.Write("Informações do Ingresso:\n");
            Console.WriteLine($"Nome do Show: {NomeDoShow}");
            Console.WriteLine($"Preço do Ingresso: {Preco:C}");
            Console.WriteLine($"Ingressos Disponíveis: {QuantidadeDisponivel} unidades");
        }


        public string GetNomedoShow() => NomeDoShow;        
        public double GetPreco() => Preco;        
        public int GetQuantidadeDisponivel() => QuantidadeDisponivel;


        public string SetNomedoShow(string novoNome) => NomeDoShow = novoNome;
        public double SetPreco(double novoPreco) => Preco = novoPreco;
        public int SetQuantidadeDisponivel(int novaQtd) => QuantidadeDisponivel = novaQtd;
    }
}
