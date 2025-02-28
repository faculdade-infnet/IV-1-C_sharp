using System;

namespace TP2
{
    public class Exercicio_08
    {
        /// <summary>
        /// Classificação Escolar de acordo com a nota (Insuficiente | Regular | Bom | Excelente)
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Classificação Escolar de acordo com a nota (Insuficiente | Regular | Bom | Excelente) ##########\n");

            bool erro = false;
            Console.WriteLine("Informe a nota do aluno: ");
            double nota = 0;

            if (!double.TryParse(Console.ReadLine(), out nota))
            {
                Console.WriteLine("Nota inválida! Você deve informar um número com ou sem casas decimais.");
                erro = true;
            }
            else if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida! Você deve informar um número de 0 a 10 ou sem casas decimais.");
                erro = true;
            }

            if (!erro)
            {
                string resultadoNota = ClassificarNota(nota);
                Console.WriteLine($"Pela avalaicação sua nota é {resultadoNota}!");
            }

            Console.ReadKey();
        }


        private string ClassificarNota(double nota)
        {
            string retorno = string.Empty;

            switch (nota)
            {
                case 10:
                    retorno = "Excelente";
                    break;
                case double n when n >= 8:
                    retorno = "Bom";
                    break;
                case double n when n >= 6:
                    retorno = "Regular";
                    break;
                default:
                    retorno = "Insuficiente";
                    break;
            }

            return retorno;
        }
    }
}
