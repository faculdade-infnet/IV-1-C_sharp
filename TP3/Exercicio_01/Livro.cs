using System;

namespace TP3
{
    // Declaração da classe Livro
    public class Livro
    {
        // Campos (ou atributos) da classe
        public string Titulo { get; set; }          // Armazena o título do livro
        public string Autor { get; set; }           // Armazena o nome do autor        
        private int numeroPaginas;                  // Armazena o número de páginas
        public bool foiLido { get; private set; }   // Indica se o livro já foi lido

        // Construtor da classe
        public Livro(string titulo, string autor, int numeroPaginas)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.numeroPaginas = numeroPaginas;
            this.foiLido = false;  // Por padrão, um novo livro não foi lido
        }

        // Método que marca o livro como lido
        public void MarcarComoLido()
        {
            this.foiLido = true;
            Console.WriteLine($"O livro '{Titulo}' foi marcado como lido!");
        }

        // Método que retorna a informação resumida sobre o livro
        public string ObterInformacoes()
        {
            string statusLeitura = foiLido ? "já foi lido" : "ainda não foi lido";
            return $"Livro: {Titulo}, Autor: {Autor}, Páginas: {numeroPaginas}, Status: {statusLeitura}";
        }
    }
}
