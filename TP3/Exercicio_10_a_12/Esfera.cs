using System;

namespace TP3
{
    public class Esfera
    {
        /// <summary>
        /// O Raio é imprescindível pois ele é necessário para calcular o volume da Esfera.
        /// </summary>
        public double Raio { get; set; }

        /// <summary>
        /// Calcula o Volume de uma Esfera.
        /// </summary>
        /// <returns>double</returns>
        public double CalcularVolume() => ((4.0 / 3.0) * Math.PI * (Raio * Raio * Raio));
    }
}
