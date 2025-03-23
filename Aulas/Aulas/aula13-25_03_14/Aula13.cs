using Aulas.aula10_25_02_28;
using DadosPessoais.Financeiro;
using DadosPessoais.Interfaces;
using Exceptions;

namespace Aula_13
{
    public class Aula13
    {
        public void Start()
        {
            ContaBancaria conta = new("CEF", 700)
            {
                Agencia = "18",
                Conta = Utils.CreateAccountNumber(),
                Digito = Utils.CreateAccountDigit(),
                Instituicao = "CEF"
            };

            ContaBancaria contaAdicioanl = new("CEF", 2300)
            {
                Agencia = "18",
                Conta = Utils.CreateAccountNumber(),
                Digito = Utils.CreateAccountDigit(),
                Instituicao = "CEF"
            };

            ContaBancaria contaExtra = new("CEF", 200)
            {
                Agencia = "18",
                Conta = Utils.CreateAccountNumber(),
                Digito = Utils.CreateAccountDigit(),
                Instituicao = "CEF"
            };

            //IContaBase baseAccount = conta;
            //IInvestimento invAccount = conta;

            //invAccount.Aplicar(1000);

            List<ContaBancaria> contas = new();
            contas.Add(conta);
            contas.Add(contaAdicioanl);
            contas.Add(contaExtra);
            contas.Sort();

            foreach (var item in contas)
            {
                Console.WriteLine($"Conta: {item.Conta}-{item.Digito} | Saldo: {item.Saldo}");
            }

            Console.ReadKey();
        }
    }
}
