using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
    class Persona
    {
        #region Atributos

        private string apellido;
        private string nombre;

        #endregion

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        #endregion

        #region Constructores

        public Persona(string nombre , string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

        #region Metodos

        public string Mostrar()
        {
            return string.Format("{0} {1}", this.Nombre, this.Apellido);
        }

        #endregion
    }

    public delegate void DelegadoString(string msg);
}
