using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exe_09
{
    public abstract class Diretorios
    {
        /// <summary>
        /// Verifica se o arquivo existe, caso não exista, cria o arquivo
        /// </summary>
        /// <param name="path"></param>
        public static bool CheckAndCreateFile(string filePath)
        {
            string directoryPath = Path.GetDirectoryName(filePath);

            // Verifica se o diretório existe, se não, cria
            if (!string.IsNullOrEmpty(directoryPath) && !Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            // Verifica se o arquivo existe, se não, cria
            if (!File.Exists(filePath))
                using (File.Create(filePath)) { }

            if (File.Exists(filePath))
                return true;

            return false;
        }

        /// <summary>
        /// Escreve no arquivo Texto linha a linha
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool EscreverArquivo(string path, string text)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(text);
            }

            return true;
        }

        /// <summary>
        /// Faz aleitura do arquivo Texto e retorna uma lista de produtos
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual List<Produto> LerArquivo(string path)
        {
            var lista = new List<Produto>();

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
                        lista.Add(new Produto(elementos[0], Convert.ToInt32(elementos[1]), Convert.ToDouble(elementos[2])));
                    }
                }
            }

            return lista;
        }


        public int ContarLinhas(string filePath) => File.ReadLines(filePath).Count();
    }
}
