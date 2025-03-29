using System;

namespace AT
{
    public class Exercicio_03
    {
        /// <summary>
        /// Calculadora de Operações Matemáticas
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");

            double? n1 = null, n2 = null;
            int? nOperacao = null;

            // Verifica se n1 não é nullo
            n1 = SolicitaNumero(n1, 1);

            // Verifica se n2 não é nullo
            n2 = SolicitaNumero(n2, 2);


            while (!nOperacao.HasValue)
            {
                Console.WriteLine(@"Informe o número da operação:
1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão");

                // Tenta converter a entrada para um número valido
                if (!int.TryParse(Console.ReadLine(), out int tempOperacao))
                    Console.WriteLine("Número da operação Inválido! Você deve informar um número inteiro de 1 a 4.\n");
                else if (tempOperacao >= 1 && tempOperacao <= 4)
                    nOperacao = tempOperacao;
                else
                    Console.WriteLine("Número da operação Inválido! Você deve informar um número inteiro de 1 a 4.\n");
            }

            // Verifica a operação escolhida e chama o método correspondente
            switch (nOperacao)
            {
                case 1:
                    var result = Soma(n1.Value, n2.Value);
                    EscreverResultado(n1.Value, n2.Value, result.resultadoOperacao, result.tipoOperacao, result.operador);
                    break;
                case 2:
                    result = Subtracao(n1.Value, n2.Value);
                    EscreverResultado(n1.Value, n2.Value, result.resultadoOperacao, result.tipoOperacao, result.operador);
                    break;
                case 3:
                    result = Multiplicacao(n1.Value, n2.Value);
                    EscreverResultado(n1.Value, n2.Value, result.resultadoOperacao, result.tipoOperacao, result.operador);
                    break;
                case 4:
                    var divResult = Divisao(n1.Value, n2.Value);
                    
                    // Divisão por zero
                    if (divResult == null) 
                        Console.WriteLine("Operação cancelada! Não é possível dividir por zero.");
                    else
                        EscreverResultado(n1.Value, n2.Value, divResult.Value.resultadoOperacao, divResult.Value.tipoOperacao, divResult.Value.operador);                    
                    break;
            }
        }

        /// <summary>
        /// Solicita um número ao usuário e valida se o número é válido
        /// </summary>
        private static double? SolicitaNumero(double? n1, int numero)
        {
            while (!n1.HasValue)
            {
                Console.WriteLine($"Digite o {numero}° número: ");

                // Tenta converter a entrada para um número valido
                if (!double.TryParse(Console.ReadLine(), out double tempN1))
                    Console.WriteLine("Número Inválido! Você deve informar um número inteiro ou decimal.\n");
                else
                    n1 = tempN1;
            }

            return n1;
        }

        /// <summary>
        ///  Exibe o resultado da operação em Tela
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="resultadoOperacao"></param>
        /// <param name="tipoOperacao"></param>
        /// <param name="operador"></param>
        private void EscreverResultado(double n1, double n2, double resultadoOperacao, string tipoOperacao, char operador)
        {
            Console.WriteLine($"Resultado da operação de {tipoOperacao} entre {n1} {operador} {n2} = {resultadoOperacao}");
        }

        /// <summary>
        /// Realiza a operação de Soma entre dois números, armazena o tipo de operação e o operador
        /// </summary>
        public (double resultadoOperacao, string tipoOperacao, char operador) Soma(double n1, double n2)
        {
            return (n1 + n2 , "Soma", '+');
        }

        /// <summary>
        /// Realiza a operação de Subtraçãoi entre dois números, armazena o tipo de operação e o operador
        /// </summary>
        public (double resultadoOperacao, string tipoOperacao, char operador) Subtracao(double n1, double n2)
        {            
            return (n1 - n2, "Subtração", '-');
        }

        /// <summary>
        /// Realiza a operação de Multiplicação entre dois números, armazena o tipo de operação e o operador
        /// </summary>
        public (double resultadoOperacao, string tipoOperacao, char operador) Multiplicacao(double n1, double n2)
        {            
            return (n1 * n2, "Multiplicação", '*');
        }

        /// <summary>
        /// Realiza a operação de Divisão entre dois números, armazena o tipo de operação e o operador
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public (double resultadoOperacao, string tipoOperacao, char operador)? Divisao(double n1, double n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine($"Não é possivel fazer a divisão por {n2}");
                return null;
            }

            return (n1 / n2, "Divisão", '/');
        }
    }
}
