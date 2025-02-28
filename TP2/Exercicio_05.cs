using System;


namespace TP2
{
    public class Exercicio_05
    {
        /// <summary>
        /// Conversor de Temperatura, Celcius para Fahrenheit e Kelvin
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Conversor de Temperatura, Celcius para Fahrenheit e Kelvin ##########\n");

            Console.WriteLine("Informe o valor da temperatura em Celsius: ");
            string input = Console.ReadLine();
            double temperatura = 0;

            if (!double.TryParse(input, out temperatura))
                Console.WriteLine("Temperatura inválida! Você deve informar um número!");


            double F = CelciusToFahrenheit(temperatura);
            double K = CelciusToFahrenheit(temperatura);

            Console.WriteLine($"{temperatura}° Celcius é igual a {Math.Round(F, 2)}° Fahrenheit");
            Console.WriteLine($"{temperatura}° Celcius é igual a {Math.Round(K, 2)}° Kelvin");

            Console.ReadKey();
        }

        public double CelciusToFahrenheit(double temperatura) => temperatura * 9 / 5 + 32;

        public double CelciusToKelvin(double temperatura) => temperatura + 273.15;
    }
}
