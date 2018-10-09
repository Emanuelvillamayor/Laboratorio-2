using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Mayor : Comensal
    {
        #region Atributos

        private eBebidas _bebida;

        #endregion

        #region Propieades

        public eBebidas Bebida
        {
            get
            {
                return this._bebida;
            }
        }

        #endregion

        #region Constructores

        public Mayor(string nombre, string apellido,eBebidas bebida) :base(nombre , apellido)
        {
            this._bebida = bebida;
        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Mayor m1 , Mayor m2)
        {
            bool retorno = false;

            if(m1.Nombre==m2.Nombre && m1.Apellido==m2.Apellido)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Mayor m1, Mayor m2)
        {

            return !(m1 == m2);

        }

        public static explicit operator string(Mayor m)
        {
            return string.Format("{0} {1}", m.Mostrar(), m.Bebida);
        }

        #endregion

        #region Sobreescritura
        public override string ToString()
        {
            return (string)this;
        }


        //Falta el Equals
        #endregion

        #region Enumerado

        public enum eBebidas
        {
            Agua,
            Cerveza,
            Vino,
            Gaseosa
        }

        #endregion
    }
}
