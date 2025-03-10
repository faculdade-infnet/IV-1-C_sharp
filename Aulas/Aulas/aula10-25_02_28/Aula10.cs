using Aulas.aula10_25_02_28;
using DadosPessoais.Financeiro;

namespace Aula_10
{
    public sealed class Aula10
    {
        /// <summary>
        /// (00:10) Utilziando static class
        /// </summary>
        public void StaticClass()
        {
            double value = Math.Round(100.53288, 2);
            Console.WriteLine(value);
        }


        /// <summary>
        /// (00:35) Utilizando métodos extenison methods
        /// </summary>
        public void UsoExtensionMethods()
        {
            ContaBancaria conta = new()
            {
                Agencia = "18",
                Conta = Utils.CreateAccountNumber(),
                Digito = Utils.CreateAccountDigit(),
                Instituicao = "CEF"
            };

            Console.WriteLine($"Banco: {conta.Instituicao}");
            Console.WriteLine($"Agencia: {conta.Agencia}");
            Console.WriteLine($"Conta: {conta.Conta:D4} | Válida: {conta.Conta.IsValidAccount()}");
            Console.WriteLine($"Digito: {conta.Digito}");
            Console.WriteLine($"Saldo: {conta.Saldo}");
            Console.WriteLine($"CPF é valido: {Utils.IsValidCpf("00260518778")}");



            Console.ReadKey();
        }
    }
}
