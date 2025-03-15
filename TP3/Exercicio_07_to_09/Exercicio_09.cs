using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Exercicio_09
    {
        /// <summary>
        /// Testando a Classe de Matrícula
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: Testando a Classe de Matrícula ##########\n");

            var matricula = new Matricula
            {
                NomedoAluno = "João da Silva",
                Curso = "Ciência da Computação",
                NumeroMatricula = 123456,
                Situacao = "Concluída",
                DataInicial = "001/02/2025"
            };

            matricula.ExibirInformacoes();

            Console.Write("\n########## Chamada método Trancar Matrícula ##########\n");
            matricula.TrancarMatricula();
            matricula.ExibirInformacoes();

            Console.Write("\n########## Chamada método Reativar Matrícula ##########\n");
            matricula.ReativarMatricula();
            matricula.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}
