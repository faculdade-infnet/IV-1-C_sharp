namespace DadosPessoais.Financeiro
{
    /// <summary>
    /// Class sealed indica que não pode ser herdada
    /// </summary>
    public sealed class ContaBancaria : ContaBase
    {
        public ContaBancaria() { }

        public ContaBancaria(string instituicao, double saldoInicial) : base(saldoInicial)
        {
            this.Instituicao = instituicao;
            //this.Saldo = saldoInicial;
        }

        public string Instituicao { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;

        public bool Poupanca { get; set; }

        // Aula 11 - 07/03/2025
        public void CheckAndDebit(double value, DateTime dataOperacao)
        {
            if (value > 0)
            {
                // Chama o método da classe base
                base.Debit(value, dataOperacao);
            }
        }

        #region Movido para arquivo ContaBase        
        //public DateTime DataOperacao { get; private set; }
        //public double Saldo { get; private set; }

        //// Aula 08 - 18/02/2025
        //public void Debit(double value)
        //{
        //    this.Saldo -= value;
        //}

        //// Aula 08 - 18/02/2025
        //public void Debit(int value)
        //{
        //    this.Saldo -= value;
        //}

        //// Aula 07 - 18/02/2025
        //public void Debit(double value, DateTime dataOperacao)
        //{
        //    this.Saldo -= value;
        //    this.DataOperacao = dataOperacao;
        //}

        //// Aula 08 - 21/02/2025
        //public void Debit(int value, DateTime dataOperacao)
        //{
        //    this.Saldo -= value;
        //    this.DataOperacao = dataOperacao;
        //}
        #endregion
    }
}
