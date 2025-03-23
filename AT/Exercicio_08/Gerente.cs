using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salarioBase) : base(nome, "Gerente", salarioBase)
        {
        }

        public override double CalcularSalario()
        {
            return SalarioBase * 1.2; // 20% de bônus
        }

        public void ExibirSalario()
        {
            Console.WriteLine($"{Nome} ({Cargo}) - Salário: {CalcularSalario():C}");
        }
    }
}
