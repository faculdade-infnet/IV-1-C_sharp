namespace DadosPessoais.Financeiro
{
    // Aula 11 - 07/03/2025
    public class ContaBase : Auditing
    {
        public ContaBase() { }

        public ContaBase(double saldo) => this.Saldo = saldo;


        public double Saldo { get; private set; }
        public DateTime DataOperacao { get; private set; }
        public int Conta { get; set; }
        public byte Digito { get; set; }

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


        public override void RegisterEntry(string entry)
        {
            //throw new NotImplementedException();
        }
    }
}
