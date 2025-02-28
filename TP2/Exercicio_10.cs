using System;

namespace TP2
{
    public class Exercicio_10
    {
        /// <summary>
        /// Contagem Regressiva de X ate 0.
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Contagem Regressiva de X ate 0\n");

            bool erro = false;
            Console.WriteLine("Informe um número: ");
            int numero = 0;

            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número inválido!, Você deve informar um número inteiro");
                erro = true;
            }


            if (!erro)
            {
                Console.WriteLine($"Contagem regressiva do número {numero}:");
                int contador = numero;

                while (contador >= 0)
                {
                    Console.WriteLine($"Número {contador}.");
                    contador--;
                }
            }

            Console.ReadKey();
        }
    }
}
