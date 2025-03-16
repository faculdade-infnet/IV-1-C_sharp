using System;

namespace TP3
{
    /// <summary>
    /// Agora, mude de cenário: você vai criar um sistema simples de matrícula para uma faculdade. A ideia é cadastrar informações básicas do aluno e efetuar operações relacionadas à sua matrícula.
    ///     <list type="bullet">    
    ///         <item>7 - Modelando uma Matrícula</item>
    ///         <item>8 - Criando Métodos na Classe de Matrícula</item>
    ///         <item>9 - Testando a Classe de Matrícula</item>
    ///     </list>
    /// </summary>
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

            Console.WriteLine("\n########## Chamada método Trancar Matrícula ##########");
            matricula.TrancarMatricula();
            matricula.ExibirInformacoes();

            Console.WriteLine("\n########## Chamada método Reativar Matrícula ##########");
            matricula.ReativarMatricula();
            matricula.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}
