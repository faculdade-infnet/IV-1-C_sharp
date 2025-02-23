namespace Aula_05
{
    public class Nulos
    {
        /// <summary>
        /// Checa se a variável é nula usna Is (after C# 7.0)
        /// </summary>
        internal void IsNullo()
        {
            Console.WriteLine("\n########### Método - Trabalhando com Nulos - IS ###########");

            string semConteudo = null;

            Console.WriteLine($"ToString: {semConteudo}");
            Console.WriteLine($"variavel é nula?: {string.IsNullOrWhiteSpace(semConteudo)}");
            Console.WriteLine($"variavel é nula?: {semConteudo is null}");
            Console.WriteLine($"variavel é nula?: {semConteudo is not null}");
            if (semConteudo is null)
            {
                Console.WriteLine("Variavel 'semConteudo' é nula");
            }
            else
            {
                Console.WriteLine("Variavel 'semConteudo' nao é nula");
            }
        }


        /// <summary>
        /// Operador de coalescência <br/>
        /// O operador ?? avalia o valor, e retorna o dado da esquerda, caso o valor não seja nulo:
        /// </summary>
        internal void OperadorDeCoalescencia()
        {
            Console.WriteLine("\n########### Método - Trabalhando com Nulos - Operador de Coalescência ###########");        

            string semConteudo = null;
            // Se tem conteúdo exibe o valor a esquerda, senão exibe o valor a direita
            Console.WriteLine($"Valor de semConteudo: {semConteudo ?? """Indefinido"""}");
            Console.WriteLine($@"Valor de semConteudo: {semConteudo ?? "Indefinido"}");

            semConteudo = "Eu existo!";
            Console.WriteLine($"Valor semConteudo: {semConteudo ?? """Indefinido"""}");
        }


        /// <summary>
        /// Operador de condicional null <br/>
        /// O operador ?. Permite acessar os membros do valor, caso o valor não seja nulo.
        /// </summary>
        internal void OperadorCondicionalNull()
        {
            Console.WriteLine("\n########### Método - Trabalhando com Nulos - Operador Condicional Null ###########");

            string semConteudo = null;

            // Se tem conteúdo exibe o valor a esquerda, senão exibe o valor a direita            
            Console.WriteLine($"Valor de semConteudo: {semConteudo ?? """Indefinido"""}");
            Console.WriteLine($@"Valor de semConteudo: {semConteudo ?? "Indefinido"}");

            semConteudo = "Eu existo";
            Console.WriteLine($"Valor sem conteudo: {semConteudo ?? "Indefinido"}");
            Console.WriteLine($"Caracteres: {semConteudo?.Length}");
            Console.WriteLine($"Maiúsculas: {semConteudo?.ToUpper()}");
            Console.WriteLine($"Trim: {semConteudo?.TrimEnd('!')}");
        }
    }
}
