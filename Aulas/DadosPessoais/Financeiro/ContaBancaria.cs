using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoais.Financeiro
{
    public class ContaBancaria
    {
        public ContaBancaria()
        {

        }

        public ContaBancaria(string instituicao, double saldoInicial)
        {
            this.Instituicao = instituicao;
            this.Saldo = saldoInicial;
        }

        public string Instituicao { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;
        public int Conta { get; set; }
        public byte Digito { get; set; }
        public bool Poupanca { get; set; }
        public DateTime DataOperacao { get; private set; }
        public double Saldo { get; private set; }
        
        public void Debit(double value)
        {
            this.Saldo -= value;
        }

        public void Debit(int value)
        {
            this.Saldo -= value;
        }

        public void Debit(double value, DateTime dataOperacao)
        {
            this.Saldo -= value;
            this.DataOperacao = dataOperacao;
        }
    }
}
