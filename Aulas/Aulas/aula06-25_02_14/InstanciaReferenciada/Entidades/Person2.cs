namespace Aula_06.Entidades
{
    /// <summary>
    /// Exemplo de Class Person com Adress referenciado em outa class
    /// </summary>
    public class Person2
    {
        // Field
        public string Nome { get; set; } = string.Empty;
        // Property-
        public DateTime Nascimento { get; set; }

        public Address Endereco { get; set; }
    }
}
