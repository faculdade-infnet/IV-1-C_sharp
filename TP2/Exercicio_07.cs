using System;

namespace TP2
{
    public class Exercicio_07
    {
        /// <summary>
        /// Verificar se um número é par ou ímpar
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Verificar se um número é par ou ímpar ##########\n");

            Console.Write("Digite um número inteiro: ");
            int inputNumero = 0;
            if (!int.TryParse(Console.ReadLine(), out inputNumero))
                Console.WriteLine("Número Inválido! Você deve informar um número inteiro.");

            string parImpar = inputNumero % 2 == 0 ? "PAR" : "ÍMPAR";
            Console.WriteLine($"O número {inputNumero} é {parImpar}.");

            Console.ReadKey();
        }
    }
}
