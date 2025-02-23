namespace Aula_04
{
    public class EstruturasControleFluxo
    {
        /// <summary>
        /// Exemplo de estrutura condicional IF
        /// </summary>
        internal void CondicionalIf()
        {
            Console.WriteLine("\n########### Método - Condicional If ###########");
            
            DateTime primeiro = new(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime ultimo = primeiro.AddMonths(1).AddSeconds(-1);
            DateTime hoje = DateTime.Now;

            if (primeiro.DayOfWeek >= DayOfWeek.Sunday && primeiro .DayOfWeek != DayOfWeek.Saturday)
            {
                Console.WriteLine("O primeiro dia do mês é um dia útil");
            }
            else
            {
                Console.WriteLine("O primeiro dia do mês NÃO é um dia útil");
            }
        }


        /// <summary>
        /// Exemplo de estrutura condicional ElseIF
        /// </summary>
        internal void CondicionalIfElseIf()
        {
            Console.WriteLine("\n########### Método - Condicional ElseIf ###########");

            DateTime primeiro = new(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime ultimo = primeiro.AddMonths(1).AddSeconds(-1);
            DateTime hoje = DateTime.Now;

            if (hoje.Day == 1)
            {
                Console.WriteLine("Hoje é o primeiro dia do mês");
            }
            else if (hoje.Day == ultimo.Day)
            {
                Console.WriteLine("Hoje é o último dia do mês");
            }            
            else
            {
                Console.WriteLine("Hoje é um dia qualquer");
            }
        }


        /// <summary>
        /// Exemplo de estrutura condicional SWITCH
        /// </summary>
        internal void CondicionalSwitch()
        {
            Console.WriteLine("\n########### Método - Condicional SWITCH ###########");

            int cardNumber = 18;

            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1:
                    goto case 12;
                default:
                    Console.WriteLine("O card é : " + cardNumber);
                    break;
            }
        }


        /// <summary>
        /// Exemplo de Laço de repetição WHILE
        /// </summary>
        internal void EstrutruaLacoWhile()
        {
            Console.WriteLine("\n########### Método - Laço Repetição WHILE ###########");

            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }


        /// <summary>
        /// Exemplo de Laço de repetição DO WHILE
        /// </summary>
        internal void EstrutruaLacoDoWhile()
        {
            Console.WriteLine("\n########### Método - Laço Repetição DO WHILE ###########");
            
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }


        /// <summary>
        /// Exemplo de Laço de repetição FOR
        /// </summary>
        internal void EstrutruaLacoFor()
        {
            Console.WriteLine("\n########### Método - Laço Repetição FOR ###########");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("i: " + i);
            }
        }


        /// <summary>
        /// Exemplo de Laço de repetição FOREACH
        /// </summary>
        internal void EstrutruaLacoForeach()
        {
            Console.WriteLine("\n########### Método - Laço Repetição FOREACH ###########");
            
            string[] names = { "zezinho", "huguinho", "luizinho" };
            foreach (var name in names)
            {
                // Converte a letra inicial para Maiúscula
                Console.WriteLine(char.ToUpper(name[0]) + name.Substring(1));
            }
        }
    }
}
