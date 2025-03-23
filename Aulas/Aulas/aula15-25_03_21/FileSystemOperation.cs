using DadosPessoais;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    public class FileSystemOperation
    {
        public List<string> ListFolders(string rootFolder)
        {
            List<string> pastas = new();

            try
            {
                string fullPath = Path.GetFullPath(rootFolder);
                List<string> dirs = Directory.GetDirectories(fullPath, "*", SearchOption.AllDirectories).ToList();

                foreach (var dir in dirs)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dir);
                    pastas.Add($"{dirInfo.Name} / {dirInfo.CreationTime}");
                }

                return pastas;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<string> ListFiles(string rootFolder, string pattern)
        {
            List<string> arquivos = new();

            try
            {
                string fullPath = Path.GetFullPath(rootFolder);
                List<string> files = Directory.GetFiles(fullPath, pattern, SearchOption.AllDirectories).ToList();

                foreach (var file in files)
                {
                    FileInfo fileInfo = new(file);
                    arquivos.Add($"{fileInfo.Name} / {fileInfo.CreationTime}");
                }

                return arquivos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CopyFile(string origem, string destino)
        {
            bool result = false;
            if (File.Exists(origem))
            {
                File.Copy(origem, destino);
                result = true;
            }

            return result;
        }

        public bool DeleteFile(string origem)
        {
            bool result = false;
            if (File.Exists(origem))
            {
                File.Delete(origem);
                result = true;
            }

            return result;
        }


        /// <summary>
        /// Compactando arquivos
        /// </summary>
        public void CompactacaoArquivos()
        {
            Console.WriteLine("Informe o diretório de compactação:");
            string path = Path.GetFullPath(Console.ReadLine()) ?? "";
            Console.WriteLine("Informe o caminho completo do arquivo compactado:");
            string zipPath = Path.GetFullPath(Console.ReadLine()) ?? "";

            ZipFile.CreateFromDirectory(path, zipPath);
            Console.WriteLine("Compactação realizada com sucesso!");
        }

        /// <summary>
        /// Descompactando arquivos
        /// </summary>
        public void DescompactacaoArquivos()
        {
            Console.WriteLine("Informe o caminho completo do arquivo para descompactação:");
            string path = Path.GetFullPath(Console.ReadLine()) ?? "";
            Console.WriteLine("Informe o diretório para os arquivos extraidos:");
            string extractPath = Path.GetFullPath(Console.ReadLine()) ?? "";

            ZipFile.ExtractToDirectory(path, extractPath);
            Console.WriteLine("Descompactação realizada com sucesso!");
        }


        /// <summary>
        /// Compactando arquivos um a um
        /// </summary>
        public void CompactacaoArquivoUmPorVez()
        {
            Console.WriteLine("Informe o caminho completo para a verificação");
            string path = Path.GetFullPath(Console.ReadLine()) ?? "";

            using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Read))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    Console.WriteLine("Nome " + entry.Name);
                    Console.WriteLine("Tamanho " + entry.CompressedLength.ToSizeString());
                    entry.ExtractToFile(path + entry.Name);
                }
            }
        }


        /// <summary>
        /// Compactando arquivos especificos
        /// </summary>
        public void CompactacaoArquivosEspecificos()
        {
            Console.WriteLine("Informe o caminho completo do diretório de origem:");
            string sourcePath = Path.GetFullPath(Console.ReadLine()) ?? "";
            Console.WriteLine("Informe o caminho completo do diretório de destino:");
            string zipPath = Path.GetFullPath(Console.ReadLine()) ?? "";
            Console.WriteLine("Informe o padrão dos arquivos para compactação:");
            string pattern = Path.GetFullPath(Console.ReadLine()) ?? "";

            if (!Directory.Exists(sourcePath))
            {
                List<string> files = Directory.GetFiles(sourcePath, pattern).ToList();

                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
                {
                    foreach (string file in files)
                    {
                        string fullPath = Path.Combine(sourcePath, file);
                        archive.CreateEntryFromFile(fullPath, file);
                    }
                }
            }
        }
    }
}
