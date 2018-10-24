using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
    public class Comercial : Avion
    {

        #region Atributos

        protected int _capacidadPasajeros;

        #endregion

        #region Constructores

        public Comercial(double precio , double  velocidad , int pasajeros): base(precio,velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }

        #endregion
    }
}
