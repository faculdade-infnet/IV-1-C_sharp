namespace Aula_03
{
    public class FuncoesSubrotinas
    {
        /// <summary>
        /// Metodo com subrotinas, sem retorno(void)
        /// </summary>
        public void Subrotinas() => ProcessTime();

        
        /// <summary>
        /// Metodo com funções, com retorno único e múltiplo
        /// </summary>
        public void Funcoes()
        {
            Console.WriteLine("\n########### Método - Função com apenas um retorno ###########");

            AddNumbers(10, 5);

            Console.WriteLine("\n########### Método - Função com múltiplos retornos 1 ###########");
            var (sum, product) = CalculateSumAndProduct(5, 10);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");

            Console.WriteLine("\n########### Método - Função com múltiplos retornos 2 ###########");
            var result = CalculateSumAndProduct(5, 10);
            int sum1 = result.Sum;
            int product1 = result.Product;

            Console.WriteLine($"Sum: {sum1}");
            Console.WriteLine($"Product: {product1}");
        }


        #region Métodos Privados        
        /// <summary>
        /// Subrotinas, apenas executam o código e não retornam valores
        /// </summary>
        private void ProcessTime()
        {
            Console.WriteLine("\n########### Método - Subrotina (void) ###########");

            DateTime current = DateTime.Now;
            Console.WriteLine($"Estamos em {current}");
        }


        /// <summary>
        /// Função com um retorno apenas
        /// </summary>
        private int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
            return result;
        }


        /// <summary>
        /// Função com múltiplos retornos
        /// </summary>
        private (int Sum, int Product) CalculateSumAndProduct(int a, int b)
        {
            int sum = a + b;
            int product = a + b;

            return (sum, product);
        }
        #endregion
    }
}
