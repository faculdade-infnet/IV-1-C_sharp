using System;

namespace AT
{
    public class Exercicio_08
    {
        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");

            Funcionario funcionario = new Funcionario("Carlos Silva", "Analista", 3000);
            Gerente gerente = new Gerente("Mariana Souza", 6000);

            funcionario.ExibirSalario();
            gerente.ExibirSalario();

            Console.ReadKey();
        }


    }
}
