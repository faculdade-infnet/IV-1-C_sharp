namespace Aulas
{
    public class FormatacoesDataMoeda
    {
        public void Exemplos()
        {
            // Data e Hora
            DateTime data = new DateTime(2024, 2, 21, 14, 30, 15);
            Console.WriteLine($"Data curta: {data:d}");
            Console.WriteLine($"Data longa: {data:D}");
            Console.WriteLine($"Hora curta: {data:t}");
            Console.WriteLine($"Hora longa: {data:T}");
            Console.WriteLine($"Data e hora curta: {data:g}");
            Console.WriteLine($"Data e hora longa: {data:G}");
            Console.WriteLine($"Mês/Dia: {data:M}");
            Console.WriteLine($"Ano/Mês: {data:Y}");
            Console.WriteLine($"Formato ISO 8601: {data:O}");

            // Moeda e Números
            decimal saldo = 1500.5m;
            Console.WriteLine($"Moeda: {saldo:C}");
            Console.WriteLine($"Número padrão: {saldo:N}");
            Console.WriteLine($"Número sem casas decimais: {saldo:N0}");
            Console.WriteLine($"Número com 2 casas decimais: {saldo:F2}");
            Console.WriteLine($"Porcentagem: {saldo:P}");
            Console.WriteLine($"Exponencial: {saldo:E}");
            Console.WriteLine($"Hexadecimal: {(int)saldo:X}");
        }
    }
}
