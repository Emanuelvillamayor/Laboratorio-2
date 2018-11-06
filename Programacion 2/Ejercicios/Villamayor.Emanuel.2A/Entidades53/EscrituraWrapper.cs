using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades53
{
  public  class EscrituraWrapper
    {
        #region Atributos

        public ConsoleColor color;
        public string texto;

        #endregion

        #region Metodos

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }

        #endregion
    }
}
