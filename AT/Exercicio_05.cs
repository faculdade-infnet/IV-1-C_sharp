using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;

namespace AT
{
    public class Exercicio_05
    {
        /// <summary>
        /// Tempo Restante para Conclusão do Curso - Diferença Entre Datas
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            Console.WriteLine("Informe a Data atual. Exemplo: 23/03/2025: ");
            string data = Console.ReadLine();

            // formatura < que 6 meses
            //DateTime dataFormatura = new DateTime(2025, 08, 29);
            // formatura > que 6 meses
            //DateTime dataFormatura = new DateTime(2025, 12, 15);
            // formatura > que 6 meses
            DateTime dataFormatura = new DateTime(2024, 01, 01);

            bool isSuccess1 = DateTime.TryParse(data, out DateTime dataAtual);

            if (!isSuccess1)
            {
                Console.WriteLine("A data informada deve ser um data válida no formato (dd/mm/yyyy)!\n");
            }
            else
            {
                if (dataAtual > DateTime.Now)
                    Console.WriteLine("A Data informada não pode ser no futuro!");
                else if (dataAtual > dataFormatura)
                    Console.WriteLine("Parbéns! Você já deveria estar formado!");
                else
                {
                    var (anos, meses, dias) = RetornarDiferencaEntreDatas(dataAtual, dataFormatura);
                    int totalDays = (anos * 365 + meses * 30 + dias);
                    // menor que 6 meses
                    // maior que 6 meses

                    // Se dias para formatura menor que 6 meses
                    if (totalDays < (6 * 30))
                    {
                        Console.WriteLine($"Faltam {meses} meses e {dias} dias para sua formatura!");
                        Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
                    }
                    else
                    {
                        // Se dias para formatura maior que 6 meses
                        if (anos == 0)
                            Console.WriteLine($"Faltam {meses} meses e {dias} dias para sua formatura!");
                        else
                            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");
                    }
                }
            }
        }


        // Retorna a diferença entre duas datas
        public (int Years, int Months, int Days) RetornarDiferencaEntreDatas(DateTime menorData, DateTime maiorData)
        {
            TimeSpan diferenca = maiorData - menorData;

            int totalDays = diferenca.Days;
            int years = totalDays / 365;
            int diasRestantes = totalDays % 365;

            int months = diasRestantes / 30;
            int days = diasRestantes % 30;

            return (years, months, days);
        }

    }
}
