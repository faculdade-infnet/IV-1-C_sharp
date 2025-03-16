using System;

namespace TP3
{
    public class Circulo
    {
        /// <summary>
        /// O Raio é imprescindível pois ele é necessário para calcular a área e o perímetro do Círculo.
        /// </summary>
        public double Raio { get; set; }

        /// <summary>
        /// Calcula a Área de um Círculo.
        /// </summary>
        /// <returns>double</returns>
        public double CalcularArea() => Math.PI * (Raio * Raio);
    }
}
