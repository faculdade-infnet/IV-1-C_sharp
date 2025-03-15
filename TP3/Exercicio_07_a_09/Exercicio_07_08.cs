using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Exercicio_07_08
    {
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name}: 'Modelando uma Matrícula' e 'Criando Métodos na Classe de Matrícula' ##########\n");            
        }
    }

    public class Matricula
    {
        public string NomedoAluno { get; set; }
        public string Curso { get; set; }
        public int NumeroMatricula { get; set; }
        /// <summary>
        /// Ativa | Trancada | Concluída
        /// </summary>
        public string Situacao { get; set; }
        public string DataInicial { get; set; }


        public void TrancarMatricula() => Situacao = "Trancada";

        public void ReativarMatricula() => Situacao = "Ativa";

        public void ExibirInformacoes()
        {            
            string informacoes = $@"Informações da matrícula:
            Nome do Aluno: {NomedoAluno}
            Curso: {Curso}
            Situação atual: {Situacao}
            Data inicial da matrícula: {DataInicial}";

            Console.WriteLine(informacoes.Trim());

        }
    }
}
