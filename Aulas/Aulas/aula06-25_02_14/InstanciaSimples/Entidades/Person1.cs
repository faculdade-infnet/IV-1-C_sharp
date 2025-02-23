namespace Aula_06.Entidades
{
    /// <summary>
    /// Exemplo de Class Person com campos, propriedades e métodos
    /// </summary>
    public class Person1
    {
        // Field
        public string Nome = string.Empty;
        // Property
        public DateTime Nascimento { get; set; } = DateTime.MinValue;        
        
        private string _endereco = string.Empty;
        public string Endereco
        {
            get
            { 
                return _endereco; 
            }
            set
            {
                _endereco = value; 
            }
        }
    }    
}
