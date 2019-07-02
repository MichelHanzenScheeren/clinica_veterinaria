using System;

namespace Modelo.Excessoes
{
    public class NaoPreenchidoException : ApplicationException
    {
        public NaoPreenchidoException(string mensagem) : base(mensagem)
        { }
    }
}
