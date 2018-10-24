using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        #region Atributos

        private string _apellido;
        private string _nombre;

        #endregion

        #region Constructor

        public Autor(string nombre , string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator  ==(Autor a , Autor b)
        {
            bool retorno = false;

            if(a._apellido==b._apellido && a._nombre==b._nombre)
            {
                retorno = true;

            }

            return retorno;
        }

        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }

        public static implicit operator string(Autor a)
        {
            return string.Format("{0} - {1}", a._nombre, a._apellido);
        }

        #endregion



    }
}
