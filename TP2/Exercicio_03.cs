using System;


namespace TP2
{
    public class Exercicio_03
    {
        public void Start()
        {
            Console.WriteLine("Informe a menor Data(10/10/1989): ");
            string primeiraData = Console.ReadLine();
            
            Console.WriteLine("Informe a maior Data(10/10/1989): ");
            string segundaData = Console.ReadLine();

            bool isSuccess1 = DateTime.TryParse(primeiraData, out DateTime menorData);
            bool isSuccess2 = DateTime.TryParse(segundaData, out DateTime maiorData);

            if (!isSuccess1 && !isSuccess2)
            {
                Console.WriteLine("A datas informadas devem ser um data válida no formato (dd/mm/yyyy)!\n");
            }
            else
            {
                if (menorData > maiorData)
                {
                    Console.WriteLine("A primeira data informada não pode ser superior a segunda data informada!");
                }
                else
                {
                    var (Years, Months, Days) = RetornarDiferencaEntreDatas(menorData, maiorData);
                    Console.WriteLine($"Adiferença entre as datas é de {Years} anos, {Months} meses e {Days} dias.");
                }
            }

            Console.ReadKey();
        }


        // Método que retorna a diferença entre duas datas
        public (double Years, double Months, double Days) RetornarDiferencaEntreDatas(DateTime menorData, DateTime maiorData)
        {
            TimeSpan diferenca = maiorData - menorData;
            
            int totalDays = diferenca.Days;
            int years = totalDays/ 365;
            int diasRestantes = totalDays % 365;

            int months = diasRestantes / 30;
            int days = diasRestantes % 30;

            return (years, months, days);
        }
    }
}
