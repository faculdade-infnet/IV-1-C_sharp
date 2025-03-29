using System;
using System.Collections.Generic;
using System.Linq;

namespace AT
{
    public class Exercicio_02
    {
        /// <summary>
        /// Manipulação de Strings - Cifrador de Nome
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");

            string nomeCompleto = "Samuel Hermany";
            string nomeSifrado = nomeCompleto;
            // saida = "Ectnqu Ukngxc"


            /* Verificar se tem espaço
             * Verificr se é maisucula ou minuscula
             * replace by index
             * printar a letra e a letra cifrada
             * printar o nome cifrado
             */
            List<char> alfabeto = new List<char>
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            string acentuados = "áéíóúãõàèìòùâêîôû";
            
            for (int i = 0; i < nomeCompleto.Length; i++)
            {
                char charAtual = nomeCompleto[i];
                bool isUpperCase = char.IsUpper(nomeCompleto[i]);
                bool temAcento = acentuados.Contains(nomeCompleto[i]);

                // Igonora os espaços em branco e os acentos
                if (!char.IsWhiteSpace(charAtual) && !temAcento)
                {
                    int index = -1;
                    // Encontra o index da letra no alfabeto que está sendo lido e soma 2
                    if (isUpperCase)
                        index = alfabeto.IndexOf(char.ToLower(nomeCompleto[i]));
                    else
                        index = alfabeto.IndexOf(nomeCompleto[i]);

                    int newIndex = index + 2;
                    if (newIndex > 25)
                    {
                        newIndex = newIndex - 26;
                    }

                    if (isUpperCase)
                    {
                        char letra = char.ToUpper(alfabeto[newIndex]);
                        nomeSifrado = nomeSifrado.Replace(nomeCompleto[i], letra);
                        //Console.WriteLine($"{nomeCompleto[i]} -> {letra}");
                    }
                    else
                    {
                        nomeSifrado = nomeSifrado.Replace(nomeCompleto[i], alfabeto[newIndex]);
                        //Console.WriteLine($"{nomeCompleto[i]} -> {alfabeto[newIndex]}");
                    }
                }
            }

            Console.WriteLine($"Nome:         {nomeCompleto}");
            Console.WriteLine($"Nome Cifrado: {nomeSifrado}");            
        }
    }
}
