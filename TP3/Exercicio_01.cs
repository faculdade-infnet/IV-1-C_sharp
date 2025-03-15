using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Exercicio_01
    {
        /// <summary>
        /// Explique o Conceitos de Classe, Objeto, Campos e Métodos (C#) com exemplos do dia a dia
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: ##########\n");

            Console.WriteLine(@"Conceitos Básicos
Classe: É um modelo que define o tipo de um objeto, contendo características e comportamentos que os objetos desse tipo terão.
Objeto: É uma instância concreta de uma classe, Representa algo do mundo real que possui estado e comportamento definidos pela classe.
Campos (ou Atributos): São as variáveis declaradas dentro de uma classe que armazenam os dados/estados dos objetos. Representam as características ou propriedades que os objetos daquela classe possuem.
Métodos: São funções definidas dentro de uma classe que determinam o comportamento dos objetos. Eles podem manipular os campos e realizar operações.");


            // Exemplo de utilização dos conceitos de Classe, Objeto, Campos e Métodos
            // Criando objetos (instâncias) da classe Livro
            Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis", 256);
            Livro livro2 = new Livro("1984", "George Orwell", 328);

            // Usando os métodos para interagir com os objetos
            Console.WriteLine("\n" + livro1.ObterInformacoes());

            // Modificando o estado do objeto através de um método
            livro1.MarcarComoLido();

            // Verificando a mudança de estado
            Console.WriteLine(livro1.ObterInformacoes());
            Console.WriteLine(livro2.ObterInformacoes());
            Console.ReadKey();
        }
    }

    // Declaração da classe Livro
    public class Livro
    {
        // Campos (ou atributos) da classe
        public string Titulo;      // Armazena o título do livro
        public string Autor;       // Armazena o nome do autor
        private int numeroPaginas; // Armazena o número de páginas
        private bool foiLido;      // Indica se o livro já foi lido

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