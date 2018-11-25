using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
  public  class MiException : Exception
    {
      public MiException(string mensaje,Exception inner ): base(mensaje,inner)
        {

        }
        public MiException(string mensaje) : base(mensaje)
        {

        }

        public MiException()
        {

        }

    }
}
