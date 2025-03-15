using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Exercicio_12
    {
        /// <summary>
        /// Testando as Classes de Figuras
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Testando as Classes de Figuras ##########\n");

            var circulo = new Circulo();
            var esfera = new Esfera();

            circulo.Raio = 3;
            esfera.Raio = 5;

            double areaCirculo = circulo.CalcularArea();
            double areaEsfera = esfera.CalcularVolume();

            Console.WriteLine($"Área do Círculo para raio({circulo.Raio}): {areaCirculo:F2}");
            Console.WriteLine($"Volume da Esfera para raio({esfera.Raio}): {areaEsfera:F2}");
        }
    }
}
