using System;

namespace Exe_06
{
    public class Exercicio_06
    {
        /// <summary>
        /// Cadastro de Alunos
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");            

            var aluno = new Alunos();
            aluno.Nome = "Samuel Hermany";
            aluno.Matricula = "123456";
            aluno.Curso = "Engenharia de Software";
            aluno.MediaNotas = 8.5;

            string situacao = aluno.VerificarAprovacao();
            aluno.ExibirDados(situacao);

            Console.ReadKey();
        }
    }
}
