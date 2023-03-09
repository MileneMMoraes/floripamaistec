using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecoes
{
    internal class IngressoException : Exception
    {
        public IngressoException(string message) : base(message)
        {

        }

        public IngressoException(string message, Exception causaException) : base(message, causaException)
        {

        }

        public IngressoException()
        {

        }




    }
}
