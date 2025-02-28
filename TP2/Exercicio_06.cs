using System;

namespace TP2
{
    public class Exercicio_06
    {
        /// <summary>
        /// Cálculo de IMC
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Cálculo de IMC ############\n");

            Console.WriteLine("Digite o peso: ");
            double peso = 0;
            if (!double.TryParse(Console.ReadLine(), out peso))
                Console.WriteLine("Peso inválido! Você deve informar um número com ou sem casas decimais.");


            Console.WriteLine("Digite sua altura: ");
            double altura = 0;
            if (!double.TryParse(Console.ReadLine(), out altura))
                Console.WriteLine("Altura inválida! Você deve informar um número com ou sem casas decimais.");

            double imc = peso / (altura * altura);

            string faixaIMC = CalculoIMC(imc);
            Console.WriteLine(faixaIMC);

            Console.ReadKey();
        }


        private static string CalculoIMC(double imc)
        {
            string resultado = string.Empty;

            switch (imc)
            {
                case double n when n < 18.5:
                    resultado = "Abaixo do peso";
                    break;
                case double n when n < 24.9:
                    resultado = "Peso normal";
                    break;
                case double n when n < 29.9:
                    resultado = "Com Sobrepeso";
                    break;
                case double n when n < 34.9:
                    resultado = "Com Obesidade";
                    break;
                default:
                    resultado = "Com Obesidade Mórbida";
                    break;
            }

            return resultado;
        }
    }
}
