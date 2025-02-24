using System;

namespace TP1
{
    internal class HelloWorld
    {
        internal void Start()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}!");

            Console.ReadKey();
        }
    }
}
