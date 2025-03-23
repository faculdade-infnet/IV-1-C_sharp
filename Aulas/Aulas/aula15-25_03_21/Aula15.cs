using Aulas;
namespace Aula_15
{
    public class Aula15
    {
        public void Start()
        {
            // C:\Users\User\Desktop\Testes
            Console.WriteLine("Informe o diretório inicial para busca:");
            string path = Console.ReadLine() ?? "";
            FileSystemOperation acesso = new();

            Console.WriteLine("\nDiretóerios\n");
            foreach (var item in acesso.ListFolders(path))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nArquivos\n");
            string pattern = "*.pdf";
            foreach (var item in acesso.ListFiles(path, pattern))
            {
                Console.WriteLine(item);
            }

            CopiarEApagarArquivo(acesso);

            // C:\Users\User\Desktop\Testes\certificados
            // C:\Users\User\Desktop\Testes\teste.zip
            acesso.CompactacaoArquivos();
            acesso.DescompactacaoArquivos();

            acesso.CompactacaoArquivosEspecificos();
            Console.WriteLine("\nArquivos compactados com sucesso!\n");

            Console.Read();
        }

        private static void CopiarEApagarArquivo(FileSystemOperation acesso)
        {
            string origem = @"C:\Users\User\Desktop\Testes\Empresa TXT\series.txt";
            string destino = @"C:\Users\User\Desktop\Testes\series2.txt";
            acesso.CopyFile(origem, destino);
            Console.WriteLine("Arquivo copiado com sucesso!");

            acesso.DeleteFile(destino);
            Console.WriteLine("Arquivo apagado com sucesso!");
        }


    }
}
