using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DniInvalidoException : Exception
    {
        #region Atributos

        private string mensajeBase;

        #endregion

        public DniInvalidoException(): base()
        {

        }

     public DniInvalidoException(string message) : base(message)
        {
            this.mensajeBase = message;
        }

        public DniInvalidoException(string message , Exception e) : base(message,e)
        {
            this.mensajeBase = message;
        }

        public DniInvalidoException(Exception e): base("El dni presenta un error de formato!",e)
        {

        }

    }
}
