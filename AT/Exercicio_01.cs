using System;

namespace AT
{
    public class Exercicio_01
    {
        /// <summary>
        /// Criando e Executando seu Primeiro Programa
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");
            
            string nome = "Samuel Hermany";
            DateTime dataNascimento = new DateTime(1989, 10, 10);

            Console.WriteLine($"Olá, meu nome é {nome}!");
            Console.WriteLine($"Nasci em {dataNascimento.ToString("d")} e estou aprendendo C#!");
        }
    }
}