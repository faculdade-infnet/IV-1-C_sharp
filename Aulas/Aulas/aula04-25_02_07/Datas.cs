using System.Globalization;

namespace Aula_04
{
    public class Datas
    {
        /// <summary>
        /// Método para trabalhar com datas:
        /// <list type="bullet">
        ///   <item>MinValue</item>
        ///   <item>Now</item>
        ///   <item>UTC</item>
        ///   <item>Constructor</item>
        ///   <item>ConstructorNew</item>
        /// </list>
        /// </summary>
        internal void Inicializacao()
        {
            Console.WriteLine("\n########### Método - Trabalhando com Datas - Estrutura ###########");

            DateTime defaultDate = DateTime.MinValue;
            DateTime currentDate = DateTime.Now;
            DateTime currentDateUtc = DateTime.UtcNow;
            DateTime dateConstructor = new DateTime(2025, 02, 18);
            DateTime dateConstructorNew = new(2025, 02, 10, 14, 34, 55);

            string dateSample = $@"Default: {defaultDate}
                                Corrent: {currentDate}
                                UTC: {currentDateUtc}
                                Constructor: {dateConstructor}
                                ConstructorNew: {dateConstructorNew}";

            Console.WriteLine(dateSample.Trim());
        }


        /// <summary>
        /// Método para trabalhar com formatação de datas:        
        /// <list type="bullet">
        ///   <item>Data Abreviada</item>
        ///   <item>Data Long</item>
        ///   <item>Hora</item>
        ///   <item>Dia</item>
        ///   <item>Mês</item>
        /// </list>
        /// </summary>
        internal void FormatacaoDatas()
        {
            Console.WriteLine("\n########### Método - Trabalhando com Datas - Formatação ###########");

            DateTime currentDate = DateTime.Now;

            string dateSample = $@"Abrevida: {currentDate.ToString("dd/MM/yyyy")}
                                Data Longa: {currentDate.ToString("D")}
                                Hora: {currentDate.ToString("T")}
                                Dia: {currentDate.ToString("dddd")}
                                Mes: {currentDate:MM}";

            Console.WriteLine(dateSample.Trim());
        }


        /// <summary>
        /// Método para manipular as proprieades e métodos de datas:
        /// <list type="bullet">
        ///   <item>Data de Amanhâ</item>
        ///   <item>Data de Ontem</item>
        ///   <item>Dias até um outro dia</item>
        /// </list>
        /// </summary>
        internal void ManipulacaoPropriedades()
        {
            Console.WriteLine("\n########### Método - Trabalhando com Datas - Manipulação de Propriedades ###########");

            DateTime start = new(2025, 02, 01);
            DateTime currentDate = DateTime.Now;
            DateTime tommorow = currentDate.AddDays(1);
            DateTime yesterday = currentDate.AddDays(-1);
            int days = currentDate.Subtract(start).Days;

            string dateSample = $@"Hoje: {currentDate:dd//MM/yyyy}                                
                                Amanhã: {tommorow:dd//MM/yyyy}
                                Ontem: {yesterday:dd//MM/yyyy}
                                Dias até: {days}";

            Console.WriteLine(dateSample.Trim());
        }


        /// <summary>
        /// Método para validar a conversão de um string em DateTime:
        /// <list type="bullet">
        ///   <item>Parse</item>
        ///   <item>PaseExact</item>
        ///   <item>TryParse</item>
        ///   <item>TryParseExact</item>
        /// </list>
        /// </summary>
        internal void Parse_TryParse()
        {
            Console.WriteLine("\n########### Método - Trabalhando com Datas - Try, TryParse ###########");

            CultureInfo culture = new("en-US");
            DateTime dateTime1 = Convert.ToDateTime("10/22/2015 12:10:15 PM", culture);

            try
            {
                // O formato da data não é compatível com a cultura pt-BR
                DateTime dateTime2 = Convert.ToDateTime("10/22/2015 12:10:15 PM", culture);
                Console.WriteLine($"Parse: {dateTime2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro de Parse: {ex.Message}");
            }

            // O parsing checa o formato exato da data, conforme a cultura
            DateTime dateTime3 = DateTime.ParseExact("10-22-2015", "MM-dd-yyyy", culture);
            Console.WriteLine($"ParseExact: {dateTime3}");

            // O formato da data nao é compativel com a cultura pt-BR
            bool isSuccess = DateTime.TryParse("10-22-2015", out DateTime dateTime4);
            Console.WriteLine($"TryParse resultou em: {isSuccess} para: {dateTime4}");

            // Aqui o formato da data é compativel com a cultura pt - BR
            bool isSuccessNew = DateTime.TryParse("22-10-2015", out DateTime dateTime5);
            Console.WriteLine($"TryParse resultou em: {isSuccessNew} para: {dateTime5}");

            CultureInfo provider = CultureInfo.InvariantCulture;
            bool isSuccessAgain = DateTime.TryParseExact("10-22-2015", "MM-dd-yyyy", provider, DateTimeStyles.None, out DateTime dateTime6);
            Console.WriteLine($"TryParse resultou em: {isSuccessAgain} para: {dateTime6}");
        }
    }
}
