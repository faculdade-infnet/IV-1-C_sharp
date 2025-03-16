using System;

namespace TP3
{
    /// <summary>
    /// Você está desenvolvendo um sistema para calcular áreas (em figuras 2D) e volumes (em figuras 3D), agora utilizando C#. Não serão utilizados conceitos avançados, como herança: cada classe será independente.
    ///     <list type="bullet">    
    ///         <item>10 - Definindo Classes de Formas Geométricas;</item>
    ///         <item>11 - Criando Métodos de Cálculo;</item>
    ///         <item>12 - Testando as Classes de Figuras.</item>
    ///     </list>
    /// </summary>
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
