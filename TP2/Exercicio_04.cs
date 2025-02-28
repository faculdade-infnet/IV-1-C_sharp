using System;
using System.Linq;

namespace TP2
{
    public class Exercicio_04
    {
        /// <summary>
        /// Solicita NOME, IDADE, TELEFONE E E-MAIL do usuário e exiba os dados cadastrados de forma organizada. 
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Solicita NOME, IDADE, TELEFONE E E-MAIL do usuário e exiba os dados cadastrados de forma organizada ##########\n");

            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o seu idade: ");
            string idadeInput = Console.ReadLine();
            int idade = 0;

            if (!int.TryParse(idadeInput, out idade) && idade <= 150)
                Console.WriteLine("Idade inválida! Você deve informar um número inteiro!");

            Console.WriteLine("Informe o seu telefone: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Informe o seu e-mail: ");
            string email = Console.ReadLine();
            if (!email.Contains('@'))
            {
                Console.WriteLine("Informe o um e-mail válido!");
                return;
            }

            Console.WriteLine();
            string dateSample = $@"Dados Cadastrados:
            Nome: {nome}
            Idade: {idade} anos
            Telefone: {telefone}
            E-mail: {email}";

            Console.WriteLine(dateSample);

            Console.ReadKey();
        }
    }
}
