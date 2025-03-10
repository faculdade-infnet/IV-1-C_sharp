namespace Aulas.aula10_25_02_28
{
    public static partial class Utils
    {
        static readonly int accountDigitsSize;

        // É chamado apenas uma vez, quando a class é utilizada pela primeira vez
        static Utils() => accountDigitsSize = 4;


        /// <summary>
        /// Cria o número da conta de 0001 a 9999
        /// </summary>
        public static int CreateAccountNumber()
        {
            // Gera um número máximo de 4 digitos (9999)
            int maxNumber = int.Parse(new string('9', accountDigitsSize));
            Random random = new();
            // Gera um núemor aleatório entre 0001 e 9999
            int accountNumber = random.Next(0001, maxNumber);

            return accountNumber;
        }


        /// <summary>
        /// Cria o dígito da conta de 1 a 9
        /// </summary>
        public static byte CreateAccountDigit()
        {
            Random random = new();
            // Gera um dígito aleatório entre 1 e 9
            byte accountDigit = (byte)random.Next(1, 9);

            return accountDigit;
        }


        /// <summary>
        /// Verifica se o número da conta é válido, tem 4 dígitos        
        /// </summary>
        public static bool IsValidAccount(this int account)
        {
            /// Extension method
            // Converte para String e preenche com 0 à esquerda até ter 4 dígitos.
            string snitized = account.ToString().PadLeft(4, '0');
            return snitized.Length == 4;
        }

        /// <summary>
        /// Verifica se o número da conta é válido, tem 4 dígitos        
        /// </summary>
        public static bool IsValidAccount(this int account, int v)
        {
            /// Extension method
            // Converte para String e preenche com 0 à esquerda até ter 4 dígitos.
            string snitized = account.ToString().PadLeft(4, '0');
            return snitized.Length == 4;
        }
    }
}
