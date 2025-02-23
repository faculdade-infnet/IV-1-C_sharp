using DadosPessoais.Financeiro;

namespace DadosPessoais
{
    /// <summary>
    /// Exemplo de Class Person com Adress referenciado em outa class
    /// </summary>
    public class Person
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime Nascimento { get; set; }
        public Address? Endereco { get; set; }
        public ContaBancaria ContaBancaria { get; set; }


        #region Operações        
        public int RetornarIdade()
        {
            if (this.Nascimento == DateTime.MinValue)
                return 0;

            int idade = DateTime.Now.Year - this.Nascimento.Year;

            // Anos bisextos
            if (this.Nascimento > DateTime.Now.AddYears(-idade))
                idade--;

            return idade;
        }


        public (double Years, double Months, double Days) RetornarIdadeCompleta()
        {
            if (this.Nascimento == DateTime.MinValue)
                return (0, 0, 0);

            double tempo = (DateTime.Now - this.Nascimento).TotalDays;
            double anos = Math.Truncate(tempo / 365);
            double meses = Math.Truncate((tempo % 365) / 30);
            double dias = Math.Truncate((tempo % 365) % 30);

            return (anos, meses, dias);
        }
        #endregion
    }
}