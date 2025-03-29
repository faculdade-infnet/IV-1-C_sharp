using System;

namespace Exe_08
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario(string nome, string cargo, double salarioBase)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        public virtual double CalcularSalario() => SalarioBase;


        public void ExibirSalario() => Console.WriteLine($"{Nome} ({Cargo}) - Salário: {CalcularSalario():C2}");
    }
}