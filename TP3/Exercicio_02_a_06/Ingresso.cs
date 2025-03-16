using System;

namespace TP3
{
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
            Console.WriteLine("Informações do Ingresso:");
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
