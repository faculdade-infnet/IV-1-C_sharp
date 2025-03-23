using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    [Serializable]
    internal class InvalidDebitException : Exception
    {
        public InvalidDebitException() { }

        public InvalidDebitException(string? message) : base(message)
        {

        }

        public InvalidDebitException(string? message, Exception? innerException) : base(message, innerException)
        {

        }

        public InvalidDebitException(string? message, double? value) : base(message)
        {
            InvalidValue = value;
        }

        public double? InvalidValue { get; private set; }
    }
}
