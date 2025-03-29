using System;
using System.Globalization;

namespace Exe_07
{
    public class Exercicio_07
    {
        /// <summary>
        /// Banco Digital (Encapsulamento)
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");
            
            
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            var conta = new ContaBancaria();
            conta.Titular = "João Silva";

            Console.WriteLine($"Titular {conta.Titular}");
            conta.Depositar(500);

            conta.ExibirSaldo();

            conta.Sacar(700);
            conta.Sacar(200);

            conta.ExibirSaldo();
        }
    }
}
