using System;

namespace Exe_08
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salarioBase) : base(nome, "Gerente", salarioBase)
        {
        }

        // 20% de bônus
        public override double CalcularSalario() => SalarioBase * 1.2;
    }
}
