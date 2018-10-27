using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades47
{
   public abstract class Equipo
    {
        #region Atributos

        protected string _nombre;
        protected DateTime _fechaCreacion;

        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }


        #endregion

        #region Constructor

        public Equipo(string nombre , DateTime fecha)
        {
            this._nombre = nombre;
            this._fechaCreacion = fecha;
        }


        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Equipo e1,Equipo e2)
        {
            bool retorno = false;

            if(e1._nombre==e2._nombre && e1._fechaCreacion==e2._fechaCreacion)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public virtual string Ficha()
        {
            return string.Format("{0} fundado el {1}", this._nombre, this._fechaCreacion);
        }
        #endregion
    }
}
