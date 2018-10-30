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

        }

        public DniInvalidoException(string message , Exception e) : base(message,e)
        {

        }

        //public DniInvalidoException(Exception e)
        //{

        //}
        
    }
}
