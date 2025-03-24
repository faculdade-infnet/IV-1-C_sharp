using Exe_09;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_11
{
    public class Contato : Diretorios
    {
        public Contato() { }
        public Contato(string nome, string telefone, string email)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }


        /// <summary>
        /// Realiza a inserção de um contato no arquivo de banco de dados
        /// </summary>
        /// <param name="dataBasePath"></param>
        /// <param name="contato"></param>
        public void AdicionarContato(string dataBasePath, Contato contato)
        {            
            string texto = $"{contato.Nome},{contato.Telefone},{contato.Email}";
            EscreverArquivo(dataBasePath, texto);
            Console.WriteLine("Contato cadastrado com sucesso!\n");
        }


        /// <summary>
        /// Lista todos os contatos cadastrados no arquivo de banco de dados
        /// </summary>
        /// <param name="dataBasePath"></param>
        public void ListarContatosCadastrados(string dataBasePath)
        {
            List<Contato> produtos = LerArquivo(dataBasePath);

            foreach (var item in produtos)
            {
                Console.WriteLine($"Nome: {item.Nome} | Telefone: {item.Telefone} | Email: {item.Email}");
            }

            Console.WriteLine();
        }


        /// <summary>
        /// Faz aleitura do arquivo Texto e retorna uma lista de contatos
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<Contato> LerArquivo(string path)
        {
            var lista = new List<Contato>();

            using (var reader = new StreamReader(path, true))
            {
                // Verifica se o arquivo esta vazio
                if (reader.Peek() == -1)
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                }
                else
                {
                    string linha;
                    string[] elementos;

                    // Le todas as linahs até o final do arquivo
                    while ((linha = reader.ReadLine()) != null)
                    {
                        elementos = linha.Trim().Split(',');
                        lista.Add(new Contato(elementos[0], elementos[1], elementos[2]));
                    }
                }
            }

            return lista; ;
        }
    }
}
