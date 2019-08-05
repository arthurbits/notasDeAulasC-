using System;

namespace Orientado_a_Objetos.Exceptions.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
