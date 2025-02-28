using System;

namespace TP2
{
    public class Exercicio_12
    {
        /// <summary>
        /// Jogo de Adivinhação, Número aleatório de 1 a 100 com palpites
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Jogo de Adivinhação, Número aleatório de 1 a 100 com palpites\n");

            Console.WriteLine("Tente adivinhar o número.");
            bool acertou = false;

            Random random = new Random();
            int numeroAleatorio = random.Next(0, 101);

            while (!acertou)
            {
                acertou = VerificaResposta(numeroAleatorio, acertou);
            }


            Console.ReadKey();
        }

        /// <summary>
        /// Verifica se o usuário acertou o número
        /// </summary>
        private bool VerificaResposta(int numeroAleatorio, bool acertou)
        {
            Console.WriteLine("Informe um número de 1 a 100 para começarmos:");
            int numero = 0;
            bool erro = false;

            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número inválido! Você deve informar um número inteiro.");
                erro = true;
            }
            else if (numero <= 1 || numero >= 100)
            {
                Console.WriteLine("Número inválido! Você deve informar um número de 1 e 100 ");
                erro = true;
            }

            if (!erro)
            {
                if (numero == numeroAleatorio)
                {
                    Console.WriteLine($"Parabéns, Você acertou!!!\nO Número era {numeroAleatorio}");
                    acertou = true;
                }
                else if (numeroAleatorio >= numero)
                    Console.WriteLine("\nDica: O número que está tentando adivinhar é maior");
                else if (numeroAleatorio < numero)
                    Console.WriteLine("\nDica: O número que está tentando adivinhar é menor");
            }

            return acertou;
        }
    }
}
