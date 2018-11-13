using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades50
{
   public class Pasajero
    {
        #region Atributos

        private eTipoPasajero _TipoDePasajero;

        #endregion

        #region Prpiedades

        public eTipoPasajero TipoDePasajero
        {
            get
            {
                return this._TipoDePasajero;
            }
            set
            {
                this._TipoDePasajero = value;
            }
        }

        #endregion

        #region Constructores
        public Pasajero()
        {

        }

        public Pasajero(eTipoPasajero tipo)
        {
            this._TipoDePasajero = tipo;
        }

        #endregion
    }
}
