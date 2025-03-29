using System;

namespace Exe_06
{
    public class Alunos
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public double MediaNotas { get; set; }


        /// <summary>
        /// Verifica se o aluno foi aprovado ou reprovado
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        internal string VerificarAprovacao() => MediaNotas >= 7 ? "Aprovado" : "Reprovado";


        /// <summary>
        /// Exibe os dados do aluno
        /// </summary>
        /// <param name="aluno"></param>
        /// <param name="situacao"></param>
        internal void ExibirDados(string situacao)
        {
            string dateSample = $@"Dados do Aluno Cadastrado:
            Nome: {Nome}
            Matricula: {Matricula}
            Curso: {Curso}
            Nota: {MediaNotas}
            Situação: {situacao}";

            Console.WriteLine(dateSample);
        }
    }
}
