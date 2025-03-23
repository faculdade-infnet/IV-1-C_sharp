using Aulas.aula10_25_02_28;
using DadosPessoais;
using DadosPessoais.Financeiro;
using System.Security.Cryptography;

namespace Aula_14
{
    public class Aula14
    {
        public void Start()
        {
            UsandoStruct();
            UsandoRecords();

            Console.ReadKey();
        }


        private static void UsandoStruct()
        {
            Documentacao contaId = new() { RG = "212", CPF = "009" };
            contaId.CPF = "009";
            Documentacao contaDoc = contaId with { RG = "353" };

            ContaBancaria conta = new("CEF", 700)
            {
                Agencia = "18",
                Conta = Utils.CreateAccountNumber(),
                Digito = Utils.CreateAccountDigit(),
                Documentacao = contaId,
            };

            Console.WriteLine($"Cliente: {conta.Documentacao.RG}-{conta.Documentacao.CPF}");
            Console.WriteLine($"Documentação: {contaDoc.ToString()}");
        }



        private void UsandoRecords()
        {
            DocumentacaoRecord contaId = new("212", "009");
            DocumentacaoRecord contaDoc = contaId with { RG = "353" };

            ContaBancaria conta = new("CEF", 700)
            {
                Agencia = "18",
                Conta = Utils.CreateAccountNumber(),
                Digito = Utils.CreateAccountDigit(),
                DocumentacaoRecord = contaId,
            };

            Console.WriteLine($"Cliente: {conta.DocumentacaoRecord.RG}-{conta.DocumentacaoRecord.CPF}");
            Console.WriteLine($"Documentação: {contaDoc.ToString()}");
        }
    }
}
