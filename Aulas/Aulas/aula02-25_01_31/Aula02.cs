namespace Aula_02
{
    public class Aula02
    {
        /// <summary>
        /// Declaração de variáveis explicitamente tipadas
        /// </summary>
        public void DeclaracaoVariaveisExplicitamente()
        {
            Console.WriteLine("########### Método - DeclaracaoVariaveisExplicitamente ###########");

            string phrase = "Hello World!";
            int version = 1;

            Console.WriteLine(phrase + " versão " + version + "\n");
        }


        /// <summary>
        /// Declaração de variáveis implicitamente tipadas
        /// </summary>
        public void DeclaracaoVariaveisImplicitamente()
        {
            Console.WriteLine("########### Método - DeclaracaoVariaveisImplicitamente ###########");

            var phrase = "Hello World!";
            var version = 1;

            Console.WriteLine(phrase + " versão " + version + "\n");
        }


        // Escopo de classe
        static int limit = 10;

        /// <summary>
        /// Escopo de variáveis
        /// </summary>
        public void DeclaracaoDeVariaveis_Escopo()
        {
            Console.WriteLine("########### Método - DeclaracaoDeVariaveis_Escopo ###########");

            // Escopo local
            string sentence = "Hello World! ";
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(sentence + i + " de " + limit);
            }

            Console.WriteLine();
        }


        /// <summary>
        /// Concatenação de strings
        /// </summary>
        public void StringsConcatenacao()
        {
            Console.WriteLine("########### Método - StringsConcatenacao ###########");

            string text = "Ops!" + "faltou um espaço";
            string withNull = "Concatenando com nulo" + null;

            Console.WriteLine(text);
            Console.WriteLine(withNull);
            Console.WriteLine();
        }


        // Escopo de classe
        static int limit1 = 10;
        /// <summary>
        /// Interpolação de strings
        /// </summary>
        public void StringInterpolacao()
        {
            Console.WriteLine("########### Método - StringInterpolacao ###########");

            // Escopo local
            string sentence = "Hello World!";
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine($"Interação {i} de {limit}");
            }

            Console.WriteLine();
        }


        /// <summary>
        /// Operadores aritméticos
        /// </summary>
        public void OperadoresAritmeticos()
        {
            Console.WriteLine("########### Método - OperadoresAritmeticos ###########");

            int mutipliewr = 3;
            double firstNum = 12.5;

            // Somar
            double sum = firstNum + mutipliewr;
            // Subtrair
            double sub = firstNum - mutipliewr;
            // Multiplicar
            double mul = firstNum * mutipliewr;
            // Dividir
            double div = firstNum / mutipliewr;
            // Resto
            double rest = firstNum % mutipliewr;

            Console.WriteLine($"Soma: {sum}");
            Console.WriteLine($"Subtração: {sub}");
            Console.WriteLine($"Multiplicação: {mul}");
            Console.WriteLine($"Divisão: {div}");
            Console.WriteLine($"Resto: {rest}");            
        }
    }
}