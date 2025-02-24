using System;


namespace TP2
{
    public class Exercicio_01
    {
        /// <summary>
        /// Calcula a idade completa de uma pessoa em anos, meses e dias
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Informe sua Data de nascimento (10/10/1989): ");

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
                    Console.WriteLine($"A data informada não pode ser superior a data atual!");
                }
                else
                {
                    var (Years, Months, Days) = RetornarIdadeCompleta(nascimento);
                    Console.WriteLine($"Você tem {Years} anos, {Months} meses e {Days} dias de vida.");
                }
            }

            Console.ReadKey();
        }


        /// <summary>
        /// Retorna a idade completa de uma pessoa em anos, meses e dias
        /// </summary>
        public (double Years, double Months, double Days) RetornarIdadeCompleta(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Now.Date;

            // Calcular anos completos, verificando se ainda não fez aniversário
            int anos = hoje.Year - dataNascimento.Year;
            if (hoje < dataNascimento.AddYears(anos))
                anos--;

            // Calcular meses completos, verificando se ainda não fez aniversário
            int meses = hoje.Month - dataNascimento.Month;
            if (hoje.Day < dataNascimento.Day)
                meses--;

            if (meses < 0)
                meses += 12; // Se o mês ficou negativo, corrige

            // Calcular quantos dias tem o mes que a pessoa nasceu
            // Obtgem o dia do nascimento
            // Calcula a diferença entre 
            int diasMesNascimento = DateTime.DaysInMonth(dataNascimento.Year, dataNascimento.Month);
            int diaNascimento = dataNascimento.Day;
            int dias = DateTime.Now.Day + (diasMesNascimento - diaNascimento) + 1;


            return (anos, meses, dias);
        }

    }
}