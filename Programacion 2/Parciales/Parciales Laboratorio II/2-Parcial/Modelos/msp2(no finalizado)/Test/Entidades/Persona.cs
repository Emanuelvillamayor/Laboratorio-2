using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public abstract class Persona
    {
        #region Atributos

        protected string apellido;

        protected string nombre;

        #endregion

        #region Constructores

        public Persona(string nombre , string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        #endregion
    }
}
