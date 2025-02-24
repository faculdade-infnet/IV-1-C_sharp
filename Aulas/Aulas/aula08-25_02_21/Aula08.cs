using DadosPessoais;
using DadosPessoais.Financeiro;

namespace Aula_08
{
    public class Aula08
    {
        /// <summary>        
        /// (00:40)  Trabalhando com Sobrecaraga de métodos, Instanciar uma class
        /// </summary>
        internal void Sobrecarga1()
        {
            Console.WriteLine("\n########### Sobrecarga 1 Aula 08 ###########");

            ContaBancaria contaBancaria = new()
            {
                Agencia = "18",
                Conta = 1212,
                Digito = 1,
                Instituicao = "CEF"
            };

            Console.WriteLine("Informe o valor a ser debitado: ");
            string? valor = Console.ReadLine();
            bool valido = double.TryParse(valor, out double valorValido);
            if (valido)
            {
                contaBancaria.Debit(valorValido);
            }

            Console.WriteLine($"Banco: {contaBancaria.Instituicao}");
            Console.WriteLine($"Agencia: {contaBancaria.Agencia}");
            Console.WriteLine($"Conta: {contaBancaria.Conta}");
            Console.WriteLine($"Digito: {contaBancaria.Digito}");
            Console.WriteLine($"Saldo: {contaBancaria.Saldo}");

            Console.ReadKey();
        }


        /// <summary>
        /// (00:51) Trabalhando com Sobrecaraga de métodos, Instanciar uma class
        /// </summary>
        internal void Sobrecarga2()
        {
            Console.WriteLine("\n########### Sobrecarga 2 Aula 08 ###########");

            ContaBancaria contaBancaria = new()
            {
                Agencia = "18",
                Conta = 1212,
                Digito = 1,
                Instituicao = "CEF"
            };

            Console.WriteLine("Informe o valor a ser debitado: ");
            string? valor = Console.ReadLine();
            bool valido = double.TryParse(valor, out double valorValido);
            if (valido)
            {
                contaBancaria.Debit(valorValido, DateTime.Now);
            }

            Console.WriteLine($"Banco: {contaBancaria.Instituicao}");
            Console.WriteLine($"Agencia: {contaBancaria.Agencia}");
            Console.WriteLine($"Conta: {contaBancaria.Conta}");
            Console.WriteLine($"Digito: {contaBancaria.Digito}");
            Console.WriteLine($"Saldo: {contaBancaria.Saldo:C}");
            Console.WriteLine($"Movimentação: {contaBancaria.DataOperacao:f}");

            Console.ReadKey();
        }


        /// <summary>
        /// (00:51) Trabalhando com Construtores, Instanciar uma class
        /// </summary>
        internal void Construtores()
        {
            Console.WriteLine("\n########### Construtores Aula 08 ###########");

            ContaBancaria contaBancaria = new("Itau", 2000)
            {
                Agencia = "18",
                Conta = 1212,
                Digito = 1
            };

            Console.WriteLine("Informe o valor a ser debitado: ");
            string? valor = Console.ReadLine();
            bool valido = double.TryParse(valor, out double valorValido);
            if (valido)
            {
                contaBancaria.Debit(valorValido, DateTime.Now);
            }

            Console.WriteLine($"Banco: {contaBancaria.Instituicao}");
            Console.WriteLine($"Agencia: {contaBancaria.Agencia}");
            Console.WriteLine($"Conta: {contaBancaria.Conta}");
            Console.WriteLine($"Digito: {contaBancaria.Digito}");
            Console.WriteLine($"Saldo: {contaBancaria.Saldo:C}"); // C = Currency(estilo moeda R$120,20)
            Console.WriteLine($"Movimentação: {contaBancaria.DataOperacao:f}"); // f = full date (data longa sem segundos)

            Console.ReadKey();
        }
    }
}