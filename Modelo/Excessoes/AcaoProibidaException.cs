using System;

namespace Modelo.Excessoes
{
    public class AcaoProibidaException : ApplicationException
    {
        public AcaoProibidaException(string mensagem) : base(mensagem)
        { }
    }
}
