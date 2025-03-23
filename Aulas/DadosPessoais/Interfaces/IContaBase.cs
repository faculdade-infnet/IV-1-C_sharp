using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoais.Interfaces
{
    public interface IContaBase
    {
        public void Debit(double value);
        public void Debit(int value);
        public void Debit(double value, DateTime dataOperacao);
        public void Credit(double value, DateTime dataOperacao) { value = Math.Abs(value); }

        public bool Transfer(double value, int contaDestino, byte digitosDestino);
    }
}
