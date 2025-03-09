namespace Aulas.aula10_25_02_28
{
    public static partial class Utils
    {
        public static bool IsValidCpf(string cpf)
        {
            // Remove formataçã oe verifica o comprimento
            cpf = cpf.Replace(".", "").Replace("-", "");

            //if (cpf.Length != 11 || !cpf.All(char.IsDigit()))
            //    return false;

            // Verifica se todos os digitos são iguais
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calcula o primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }

            int primeiroDigitoVerificador = (soma * 10) % 11;
            if (primeiroDigitoVerificador == 10)
            {

            }


            return true;
        }

    }
}
