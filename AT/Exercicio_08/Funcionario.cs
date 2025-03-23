using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
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

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }

        public void ExibirSalario()
        {
            Console.WriteLine($"{Nome} ({Cargo}) - Salário: {CalcularSalario():C}");
        }
    }
}

