
using Exceptions;
using System;

namespace DadosPessoais.Financeiro
{
    /// <summary>
    /// Class sealed indica que não pode ser herdada
    /// </summary>
    public sealed class ContaBancaria : ContaBase
    {
        public ContaBancaria() { }

        /// <summary>
        /// Contutor Alternativo
        /// </summary>
        /// <param name="instituicao"></param>
        /// <param name="saldoInicial"></param>
        public ContaBancaria(string instituicao, double saldoInicial) : base(saldoInicial)
        {
            this.Instituicao = instituicao;
            this.Saldo = saldoInicial;
        }

        public string Instituicao { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;
        public int Conta { get; set; }
        public int Digito { get; set; }
        public bool Poupanca { get; set; }

        // Aula 11 - 07/03/2025
        public void CheckAndDebit(double saldo, DateTime dataOperacao)
        {
            if (saldo > 0)
            {
                throw new InvalidDebitException("Valor informado para débito é inválido", saldo);
            }
        }


        public override string ToString()
        {
            string resume = $"Banco: {this.Instituicao} | Conta: {this.Conta}-{this.Digito} | Saldo: {base.Saldo}";
            return resume;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj is not ContaBancaria)
            {
                return false;
            }

            bool result = (this.Conta == ((ContaBancaria)obj).Conta
                            && this.Digito == ((ContaBancaria)obj).Digito);
            return result;
        }

        override public int GetHashCode()
        {
            return HashCode.Combine(this.Conta, this.Digito);
        }
    }
}
