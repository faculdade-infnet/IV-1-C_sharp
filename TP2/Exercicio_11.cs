using System;

namespace TP2
{
    public class Exercicio_11
    {
        /// <summary>
        /// Tabuada Interativa de um número X de 1 a 10
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Tabuada Interativa de um número X de 1 a 10\n");

            bool erro = false;
            Console.WriteLine("Informe um número: ");
            int numeroTabuada = 0;

            if (!int.TryParse(Console.ReadLine(), out numeroTabuada))
            {
                Console.WriteLine("Número inválido!, Você deve informar um número inteiro");
                erro = true;
            }
            else if (numeroTabuada < 1 && numeroTabuada > 10)
            {
                Console.WriteLine("Número inválido!, Você deve informar um número de 1 a 10 ");
                erro = true;
            }


            if (!erro)
            {
                int contador = 0;

                Console.WriteLine($"A tabuada do número {numeroTabuada}:");
                while (contador <= 10)
                {
                    Console.WriteLine($"{contador} x {numeroTabuada} = {contador * numeroTabuada}");
                    contador++;
                }
            }

            Console.ReadKey();
        }
    }
}
