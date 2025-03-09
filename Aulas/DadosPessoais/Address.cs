namespace DadosPessoais
{
    /// <summary>
    /// Exemplo de Class Address
    /// </summary>
    public class Address
    {
        public string Logradouro { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        // Aula09
        public string Estado { get; set; } = string.Empty;
        public string Pais { get; } = "Brasil";

        public int Numero { get; set; }
        public bool SemNumero
        {
            get
            {
                return this.Numero <= 0;
            }
        }
    }
}
