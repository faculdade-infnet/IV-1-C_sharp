using System;

namespace TP2
{
    public class Exercicio_09
    {
        /// <summary>
        /// Calculadora de Salário Líquido
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Calculadora de Salário Líquido\n");

            Console.WriteLine("Informe o seu Salário Bruto: ");
            double salarioBruto = 0;

            if (!double.TryParse(Console.ReadLine(), out salarioBruto))
            {
                Console.WriteLine("Salário inválido! Você deve informar um número com ou sem casas decimais.");
            }

            double percentualDesconto = CalculoDescontoSalarioImposto(salarioBruto);
            double salarioLiquido = Math.Round(salarioBruto + (salarioBruto * percentualDesconto), 2);

            Console.WriteLine($"Seu salário líquido após os descontos é de {salarioLiquido:C}");

            Console.ReadKey();
        }


        private double CalculoDescontoSalarioImposto(double salarioBruto)
        {
            double desconto = 0;

            switch (salarioBruto)
            {
                case double n when n > 4664.68:
                    desconto = 0.275;
                    break;
                case double n when n <= 4664.68 && n >= 3751.06:
                    desconto = 0.225;
                    break;
                case double n when n < 3751.06 && n >= 2826.66:
                    desconto = 0.15;
                    break;
                case double n when n < 2826.66 && n >= 2259.21:
                    desconto = 0.075;
                    break;
                default:
                    break;
            }

            return desconto;
        }
    }
}
