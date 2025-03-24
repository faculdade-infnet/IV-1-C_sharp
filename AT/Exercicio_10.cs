using System;

namespace AT
{
    public class Exercicio_10
    {
        /// <summary>
        /// Jogo de Adivinhação
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");

            Console.WriteLine("Tente adivinhar o número. Você têm 5 tentativas ");

            Random random = new Random();
            int numeroAleatorio = random.Next(0, 51);
            int numTentativas = 5;

            while (numTentativas != 0)
            {
                if (VerificaResposta(numeroAleatorio))
                    break;
                else
                {
                    if (numTentativas - 1 != 0)
                        Console.WriteLine($"Você ainda tem {numTentativas - 1} tetnativas!\n");

                    numTentativas--;
                }
            }

            Console.WriteLine("Suas tentativas acabaram.\nFim");
        }


        /// <summary>
        /// Verifica se o usuário acertou o número
        /// </summary>
        private bool VerificaResposta(int numeroAleatorio)
        {
            bool acertou = false;

            Console.WriteLine("Informe um número de 1 a 50 para começarmos:");
            int numero = 0;
            bool erro = false;

            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número inválido! Você deve informar um número inteiro.");
                erro = true;
            }
            else if (numero < 1 || numero > 50)
            {
                Console.WriteLine("Número inválido! Você deve informar um número de 1 a 50 ");
                erro = true;
            }

            if (!erro)
            {
                if (numero == numeroAleatorio)
                {
                    Console.WriteLine($"Parabéns, Você acertou!!!\nO Número era {numeroAleatorio}");
                    acertou = true;
                }
            }

            return acertou;
        }
    }
}
