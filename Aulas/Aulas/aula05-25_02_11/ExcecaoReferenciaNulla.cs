namespace Aula_05
{
    public class ExcecaoReferenciaNulla
    {
        /// <summary>
        /// Exemplo de exceção NullReferenceException ao tentar manipular um nulo
        /// </summary>
        internal void ManipulacaoDeNulo()
        {
            Console.WriteLine("\n########### Método - Trabalhando com Nulos - IS ###########");

            string? nome = "Tião Veneno ";

            try
            {
                nome = null;
                string message =$"O nome possui {nome.Length} caracteres";
                Console.WriteLine(message);
            }
            catch (NullReferenceException nEx)
            {
                Console.WriteLine("Nome nao foi informado: " + nEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado");
            }
        }
    }
}
