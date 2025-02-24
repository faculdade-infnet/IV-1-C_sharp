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
            Console.WriteLine("Informe a temperatura em Celsius: ");
            string input = Console.ReadLine();
            double temperatura = 0;

            if (!double.TryParse(input, out temperatura))
                Console.WriteLine("Temperatura inválida! Você deve informar um número!");

            double F = temperatura * 9 / 5 + 32;
            double K = temperatura + 273.15;

            Console.WriteLine($"{temperatura}°Celcius equivale a {Math.Round(F, 2)} Fahrenheit");
            Console.WriteLine($"{temperatura}°Celcius equivale a {Math.Round(K, 2)} KelvinKelvin");
        }
    }
}
