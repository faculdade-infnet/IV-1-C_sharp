namespace Aula_06.Entidades
{
    /// <summary>
    /// Exemplo de Class Address
    /// </summary>
    public class Address
    {
        public string Logradouro { get; set; } = string.Empty;
        public string Complemento{ get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        
        // Propriedade somente leitura
        public string Pais{ get; } = "Brasil";

        public int Numero { get; set; }        
        public bool SemNumero
        {
            get {
                return this.Numero <=0; 
            }
        }
    }
}
