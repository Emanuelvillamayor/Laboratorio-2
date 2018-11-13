using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.Final
{
    class ExceptionPropia : Exception
    {
        public ExceptionPropia(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
        public ExceptionPropia(string mensaje) : base(mensaje)
        {

        }

        public ExceptionPropia()
        {

        }
    }
}
