using System;
using System.Globalization;
using System.Threading;

namespace AT
{
    public class Exercicio_04
    {
        /// <summary>
        /// Manipulação de Datas - Dias até o Próximo Aniversário
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Calcula quantos dias faltam para o próximo aniversário ##########\n");

            Console.WriteLine("Informe sua Data de nascimento \nExemplo: 10/10/1989: ");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            string dataNascimento = Console.ReadLine();
            bool isSuccess = DateTime.TryParse(dataNascimento, out DateTime nascimento);

            if (!isSuccess)
            {
                Console.WriteLine("A idade informada deve ser um data válida no formato (dd/mm/yyyy)!\n");
            }
            else
            {
                if (nascimento > DateTime.Today)
                {
                    Console.WriteLine("A data informada não pode ser superior a data atual!");
                }
                else
                {
                    int days = RetornarIdadeDiasAteAniversario(nascimento);
                    Console.WriteLine($"Faltam {days} dias para o seu aniversário.");
                }
            }
        }


        /// <summary>
        /// Calcula a data do próximo aniversário e faz a diferença entre a data atual e a data do aniversário
        /// </summary>
        private int RetornarIdadeDiasAteAniversario(DateTime nascimento)
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTime hoje = DateTime.Now.Date;
            bool isSuccess = false;
            string proximoAniversario = string.Empty;
            DateTime proximoAniversarioDateTime = DateTime.MinValue;

            while (!isSuccess)
            {
                proximoAniversario = $"{nascimento.Day}-{nascimento.Month}-{hoje.Year}";
                isSuccess = DateTime.TryParse(proximoAniversario, out proximoAniversarioDateTime);
                nascimento = nascimento.AddDays(1);
            }

            TimeSpan diferenca = proximoAniversarioDateTime - hoje;
            int days = diferenca.Days;

            return days;
        }
    }
}
