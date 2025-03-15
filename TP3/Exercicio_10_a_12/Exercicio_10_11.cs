using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Exercicio_10_11
    {
        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: 'Definindo Classes de Formas Geométricas' e 'Criando Métodos de Cálculo' ##########\n");
        }
    }


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
