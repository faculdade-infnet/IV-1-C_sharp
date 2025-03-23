using Aulas.aula10_25_02_28;
using DadosPessoais.Financeiro;
using Exceptions;

namespace Aula_12
{
    public class Aula12
    {
        public void Start()
        {
            ContaBancaria conta = new("CEF", 0)
            {
                Agencia = "18",
                Conta = 2170, //Utils.CreateAccountNumber(),
                Digito = 1,//Utils.CreateAccountDigit(),
                Instituicao = "CEF"
            };

            ContaBancaria contaAdicioanl = new()
            {
                Agencia = "18",
                Conta = Utils.CreateAccountNumber(),
                Digito = Utils.CreateAccountDigit(),
                Instituicao = "CEF"
            };

            try
            {
                conta.CheckAndDebit(-10, DateTime.Now);
            }
            catch (InvalidDebitException inv)
            {
                Console.WriteLine($"{inv.Message} | Valor: {inv.InvalidValue}");
            }
            catch (Exception)
            {
                throw;
            }

            Console.WriteLine(conta.ToString());

            bool areSame = conta.Equals(contaAdicioanl);
            HashSet<ContaBancaria> contasValidas = new();
            contasValidas.Add(conta);
            contasValidas.Add(contaAdicioanl);

            Console.WriteLine($"Conta: {conta.GetHashCode()}");
            Console.WriteLine($"Conta Adicional: {contaAdicioanl.GetHashCode()}");

            Console.WriteLine($"Contas iguais? {areSame}");


            Console.ReadKey();
        }
    }
}
