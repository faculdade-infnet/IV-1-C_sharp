namespace DadosPessoais.Financeiro
{
    public class ContaBancaria
    {
        public ContaBancaria()
        {

        }

        /// <summary>
        /// Construtor Alternativo
        /// </summary>
        /// <param name="instituicao"></param>
        /// <param name="saldoInicial"></param>
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

        // Aula 08 - 18/02/2025
        public void Debit(double value)
        {
            this.Saldo -= value;
        }

        // Aula 08 - 18/02/2025
        public void Debit(int value)
        {
            this.Saldo -= value;
        }

        // Aula 07 - 18/02/2025
        public void Debit(double value, DateTime dataOperacao)
        {
            this.Saldo -= value;
            this.DataOperacao = dataOperacao;
        }

        // Aula 08 - 21/02/2025
        public void Debit(int value, DateTime dataOperacao)
        {
            this.Saldo -= value;
            this.DataOperacao = dataOperacao;
        }
    }
}
