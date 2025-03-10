using Aulas.aula10_25_02_28;
using DadosPessoais;
using DadosPessoais.Financeiro;

namespace Aula_11
{
    public class Aula11
    {
        /// <summary>
        /// (00:05) Utilizando Herança
        /// </summary>
        public void UsoHeranca()
        {
            ContaBancaria conta = new("CEF", 200)
            {
                Agencia = "18",
                Conta = Utils.CreateAccountNumber(),
                Digito = Utils.CreateAccountDigit(),
                //Instituicao = "CEF"
            };

            conta.RegisterEntry("Auditoria realizada com sucesso!");

            Console.WriteLine($"Banco: {conta.Instituicao}");
            Console.WriteLine($"Agencia: {conta.Agencia}");
            Console.WriteLine($"Conta: {conta.Conta:D4} | Válida: {conta.Conta.IsValidAccount(55)}");
            Console.WriteLine($"Digito: {conta.Digito}");
            Console.WriteLine($"Saldo: {conta.Saldo}");
            Console.WriteLine($"CPF é valido: {Utils.IsValidCpf("00260518778")}");

            Console.ReadKey();
        }
    }
}
