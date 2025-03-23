﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        /// <summary>
        /// Operação para depositar um valor na conta
        /// </summary>
        /// <param name="valor"></param>
        public void Depositar(decimal valor)
        {
            if (valor < 0)
                Console.WriteLine("O valor do depósito deve ser positivo!");
            else
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso!");
            }
        }

        /// <summary>
        /// Operação para sacar um valor da conta
        /// </summary>
        /// <param name="valor"></param>
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine($"Tentativa de saque: {valor:C}");
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
            else
            {
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso!");
                Saldo -= valor;
            }
        }

        /// <summary>
        /// Operação para exibir o saldo atual da conta
        /// </summary>
        public void ExbirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo:C}");
        }
    }
}
