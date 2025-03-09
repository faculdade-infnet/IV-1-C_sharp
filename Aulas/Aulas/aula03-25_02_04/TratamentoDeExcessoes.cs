namespace Aula_03
{
    public class TratamentoDeExcessoes
    {
        /// <summary>
        /// Metodo com exemplos de tratamento de exceções.
        /// </summary>
        public void Get()
        {
            Exemplo01();
            Exemplo02();
            FiltrandoExcessoes();
        }


        #region Métodos privados
        /// <summary>
        /// Exemplo da estrutura no tratamento de exceção.
        /// </summary>
        private void Exemplo01()
        {
            Console.WriteLine("\n########### Método - Tratamento de Excessões Exemplo 1 ###########");

            try
            {
                // Codigo Protegido entra aqui.
            }
            catch (DivideByZeroException Dex)
            {
                // Codigo do tratamento de excessoes entra aqui.
                // Procure caturar apenas exceções que vocÊ sabe como tratar.                
            }
            catch (Exception ex)
            {
                // Se for tratar diretamente a classe Exception, dispare-a  no final do catch.
                throw;
            }
        }


        /// <summary>
        /// Exemplo de tratamento de exceção.
        /// </summary>
        private void Exemplo02()
        {
            Console.WriteLine("\n########### Método - Tratamento de Excessões Exemplo 2 ###########");

            int number1 = 3000;
            int number2 = 0;

            try
            {
                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisão de {0} por zero.", number1);
            }

            Console.WriteLine();
        }


        /// <summary>
        /// Exemplo de filtro no tratamento de exceção.
        /// Introduzido no C# 6.0
        /// </summary>
        private void FiltrandoExcessoes()
        {
            Console.WriteLine("\n########### Método - Tratamento de Excessoes - Filtrando Excessões ###########");

            try
            {
                ConnectDatabase(true);
            }
            catch (CustomException ex) when (ex.Code == 42)
            {
                Console.WriteLine("Ocorreu um erro de conexão. Código 42.");
            }
        }

        private void ConnectDatabase(bool v)
        {
            Console.WriteLine("Banco de dados conectado com sucesso!");
        }
        #endregion
    }
}
