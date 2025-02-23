namespace Aula_05
{
    public class NullableTypes
    {
        /// <summary>
        /// Exemplo de uso de tipos anuláveis <br/>
        /// Nullable possui propriedades read only para verificar se o valor é nulo, e obter seu valor caso não seja.
        /// </summary>
        internal void TiposAnulaveis()
        {
            Console.WriteLine("\n########### Método - Tipos Anuláveis ###########");

            int? idade = 25;

            if (idade.HasValue)
            {
                Console.WriteLine($"A idade informada é: {idade.Value} anos");
            }
            else
            {
                Console.WriteLine($"A idade nao foi informada");
            }
        }


        /// <summary>
        /// Exemplo de uso de tipos anuláveis <br/>
        /// Um tipo anulável pode ser criado usando-se também o caractere ?, porém, na declaração da variável.Ou como Nullable<T>.
        /// </summary>
        internal void TiposAnulaveis_T()
        {
            Console.WriteLine("\n########### Método - Tipos Anuláveis <T>###########");

            // Pode ser um inteiro ou null
            int? idade = null;
            Console.WriteLine($"Idade foi informada? {idade is not null}");

            idade = 25;
            Console.WriteLine($"Idade foi informada? {idade is not null}");

            Nullable<double> salarioProfessor = 100d;
            // Se o valor for double, armazena o valor em valorSalario
            // Semelhante ao TryParse
            if (salarioProfessor is double valorSalario)
            {
                // Formata como moeda
                Console.WriteLine($"O salário do professor é: {valorSalario:C}");
            }
            else
            {
                Console.WriteLine($"O salário do professor não foi informado");
            }
        }
    }
}
