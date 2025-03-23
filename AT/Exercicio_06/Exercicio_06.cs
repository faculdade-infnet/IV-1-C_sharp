using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace AT
{
    public class Exercicio_06
    {
        /// <summary>
        /// Cadastro de Aluno
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"########## {this.GetType().Name} ##########\n");            

            var aluno = new Alunos();
            aluno.Nome = "Samuel Hermany";
            aluno.Matricula = "123456";
            aluno.Curso = "Engenharia de Software";
            aluno.MediaNotas = 8.5;

            string situacao = VerificarAprovacao(aluno.MediaNotas);
            ExibirDados(aluno, situacao);
            Console.ReadKey();
        }

        private string VerificarAprovacao(double media) => media >= 7 ? "Aprovado" : "Reprovado";


        public void ExibirDados(Alunos aluno, string situacao)
        {
            string dateSample = $@"Dados do Aluno Cadastrado:
            Nome: {aluno.Nome}
            Matricula: {aluno.Matricula}
            Curso: {aluno.Curso}
            Nota: {aluno.MediaNotas}
            Situação: {situacao}";

            Console.WriteLine(dateSample);
        }
    }
}
