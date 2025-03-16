using System;

namespace TP3
{
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
