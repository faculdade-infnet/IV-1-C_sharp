using System;
using System.Globalization;

namespace Exe_08
{
    public class Exercicio_08
    {
        /// <summary>
        /// Cadastro de Funcionários (Herança)
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            Funcionario funcionario = new Funcionario("Carlos Silva", "Analista", 3000);
            Gerente gerente = new Gerente("Mariana Souza", 6000);

            funcionario.ExibirSalario();
            gerente.ExibirSalario();

            Console.ReadKey();
        }


    }
}
